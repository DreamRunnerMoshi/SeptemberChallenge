using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class IsContainsNearbyAlmostDuplicate
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int index, int value)
        {
            if(nums.Length == 0) return true;
            var sortedList = new SortedList<int, int>();
            var startIndex = 0;

            sortedList.Add(nums[0], 1);

            for (int i = 1; i < nums.Length; i++)
            {
                var num = nums[i];

                if (Math.Abs(sortedList.Keys[0] - num) <= value) return true;

                if (!sortedList.ContainsKey(num))
                {
                    sortedList.Add(num, 0);
                }
                sortedList[num]++;

                if ((i - startIndex) == index + 1)
                {
                    var startValue = nums[startIndex];
                    if (sortedList[startValue] > 1) sortedList[startValue]--;
                    else sortedList.Remove(startValue);
                    startIndex++;
                }
            }

            return false;
        }

        //public bool GetCheck(int[] nums, int index, int value)
        //{
        //    if (nums == null || nums.length < 2 || k < 0 || t < 0)
        //        return false;

        //    TreeSet<Long> set = new TreeSet<Long>();
        //    for (int i = 0; i < nums.length; i++)
        //    {
        //        long curr = (long)nums[i];

        //        long leftBoundary = (long)curr - t;
        //        long rightBoundary = (long)curr + t + 1; //right boundary is exclusive, so +1
        //        SortedSet<Long> sub = set.subSet(leftBoundary, rightBoundary);
        //        if (sub.size() > 0)
        //            return true;

        //        set.add(curr);

        //        if (i >= k)
        //        { // or if(set.size()>=k+1)
        //            set.remove((long)nums[i - k]);
        //        }
        //    }

        //    return false;
        //}
    }
}
