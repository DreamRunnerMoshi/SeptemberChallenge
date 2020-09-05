using SeptemberChallenge;
using SeptemberChallenge.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SeptemberChalllenge.Tests
{
    public class AllElementsTwoBSTTests
    {
        private readonly AllElementsTwoBST allElementsTwoBST;
        public AllElementsTwoBSTTests()
        {
            allElementsTwoBST = new AllElementsTwoBST();
        }

        [Fact]
        public void Positive1()
        {
            var tree1 = new TreeConstruction().GetFromLevelOrderTraverse(new int[] { 2, 1, 4 });
            var tree2 = new TreeConstruction().GetFromLevelOrderTraverse(new int[] { 1, 0, 3 });
            var actual = allElementsTwoBST.GetAllElements(tree1, tree2);
            Assert.Equal(new int[] { 0, 1, 1, 2, 3, 4 }, actual);
        }

        [Fact]
        public void PositiveIntuitive1()
        {
            var tree1 = new TreeConstruction().GetFromLevelOrderTraverse(new int[] { 2, 1, 4 });
            var tree2 = new TreeConstruction().GetFromLevelOrderTraverse(new int[] { 1, 0, 3 });
            var actual = allElementsTwoBST.GetAllElementsIntuitive(tree1, tree2);
            Assert.Equal(new int[] { 0, 1, 1, 2, 3, 4 }, actual);
        }
    }
}
