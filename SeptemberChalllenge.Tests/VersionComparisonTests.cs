using SeptemberChallenge;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SeptemberChalllenge.Tests
{
    public class VersionComparisonTests
    {
        private readonly VersionComparison versionComparison;
        public VersionComparisonTests()
        {
            versionComparison = new VersionComparison();
        }


        [Fact]
        public void Test1()
        {
            var actual = versionComparison.CompareVersion("0.9.9.9.9.9.9.9.9.9.9.9.9","1.0");
            Assert.Equal(-1,actual);
        }

        [Fact]
        public void Test2()
        {
            var actual = versionComparison.CompareVersion("0.9.9.9.9.9.9.9.9.9.9.9.9.9.9.9.9", "1.0");
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void Test3()
        {
            var actual = versionComparison.CompareVersion("1.0","1");
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Test4()
        {
            var actual = versionComparison.CompareVersion("1","0");
            Assert.Equal(1, actual);
        }
    }
}
