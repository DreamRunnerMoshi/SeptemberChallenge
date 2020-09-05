using System.Collections.Generic;
using Testing;
using Xunit;

namespace SeptemberChalllenge.Tests
{
    public class PartitionLabelsTests
    {
        private readonly PartitionLabels partitionLabels;
        public PartitionLabelsTests()
        {
            partitionLabels = new PartitionLabels();
        }

        [Fact]
        public void Test1()
        {
            var actual = partitionLabels.GetPartitionLabels("ababcbacadefegdehijhklij");
            Assert.Equal(new List<int>() { 9, 7, 8 }, actual);
        }

        [Fact]
        public void Test12()
        {
            var actual = partitionLabels.GetPartitionEndIndex("ababcbacadefegdehijhklij");
            Assert.Equal(new List<int>() { 9, 7, 8 }, actual);
        }
    }
}
