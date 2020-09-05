using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class PartitionLabels
    {
        public List<int> GetPartitionLabels(String S)
        {
            var ans = new List<int>();
            if (S.Length == 0)
            {
                return ans;
            }
            var arr = S.ToCharArray();
            var seen = new HashSet<char>();

            var freq = new int[26];

            foreach (char c in arr)
                freq[c - 'a']++;

            int count = 0;
            foreach (char c in arr)
            {
                count++;
                seen.Add(c);
                var currentFreq = --freq[c - 'a'];
                if (currentFreq == 0)
                {
                    seen.Remove(c);
                    if (seen.Count == 0)
                    {
                        ans.Add(count);
                        count = 0;
                    }
                }
            }
            return ans;
        }


        public List<int> GetPartitionEndIndex(String S)
        {
            var ans = new List<int>();
            var len = S.Length;

            if (S.Length == 0)
            {
                return ans;
            }
            var arr = S.ToCharArray();

            var endIndexMap = new int[26];

            for (int i = 0; i < len; i++)
            {
                endIndexMap[arr[i] - 'a'] = i;
            }

            var lastMaxIndex = -1;

            foreach (char elem in arr)
            {
                var currentIndex = endIndexMap[elem - 'a'];

                if (currentIndex > lastMaxIndex)
                    lastMaxIndex = currentIndex;

                else if (lastMaxIndex == currentIndex)
                {
                    var lastAns = ans.Count > 0 ? ans[ans.Count - 1] : 0;
                    var currentLastAns = (lastMaxIndex + 1) - lastAns;

                    if (lastAns != currentLastAns)
                        ans.Add(currentLastAns);
                }
            }
            return ans;
        }
    }
}
