using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeptemberChallenge
{
    public class VersionComparison
    {
        public int CompareVersion(string version1, string version2)
        {

            var v1Parts = version1.Split('.').ToList();
            var v2Parts = version2.Split('.').ToList();

            var maxPart = Math.Max(v1Parts.Count(), v2Parts.Count());

            for (int i = 0; i < maxPart; i++)
            {
                var v1 = (i >= v1Parts.Count) ? 0 : Convert.ToInt32(v1Parts[i]);
                var v2 = (i >= v2Parts.Count) ? 0 : Convert.ToInt32(v2Parts[i]);
                if (v1 > v2) return 1;
                if (v1 < v2) return -1;
            }

            return 0;
        }
    }
}
