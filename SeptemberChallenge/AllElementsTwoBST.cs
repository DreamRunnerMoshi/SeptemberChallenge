using SeptemberChallenge.Library;
using System.Collections.Generic;

namespace SeptemberChallenge
{
    public class AllElementsTwoBST
    {
        public IList<int> GetAllElementsIntuitive(TreeNode root1, TreeNode root2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            InOrderTraverse(root1, list1);
            InOrderTraverse(root2, list2);

            var ans = new List<int>();

            int l1 = list1.Count;
            int l2 = list2.Count;
            int i = 0;
            int j = 0;

            while (i < l1 && j < l2)
            {
                while (i < l1 && j < l2 && list1[i] < list2[j])
                {
                    ans.Add(list1[i]);
                    i++;
                }

                while (i < l1 && j < l2 && list1[i] > list2[j])
                {
                    ans.Add(list2[j]);
                    j++;
                }

                while (i < l1 && j < l2 && list1[i] == list2[j])
                {
                    ans.Add(list1[i]);
                    ans.Add(list1[i]);
                    i++;
                    j++;
                }
            }

            while (i < l1)
            {
                ans.Add(list1[i]);
                i++;
            }


            while (j < l2)
            {
                ans.Add(list2[j]);
                j++;
            }

            return ans;

        }

        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            InOrderTraverse(root1, list1);
            InOrderTraverse(root2, list2);

            var ans = new List<int>();

            int l1 = list1.Count;
            int l2 = list2.Count;
            int i = 0;
            int j = 0;

            int minX = int.MaxValue;
            int minY = int.MaxValue;

            for (int k = 0; k < (l1 + l2); k++)
            {
                int x = minX;

                if (i < l1)
                {
                    x = list1[i];
                }
                int y = minY;

                if (j < l2)
                {
                    y = list2[j];
                }

                if (x < y)
                {
                    ans.Add(list1[i++]);
                }

                if (x > y)
                {
                    ans.Add(list2[j++]);
                }

                if (x != int.MinValue && x == y)
                {
                    ans.Add(list1[i++]);
                    ans.Add(list2[j++]);
                    k++;
                }
            }

            //         while(i<l1 && j<l2)
            //         {
            //             while(i<l1 && j<l2 && list1[i]<list2[j])
            //             {
            //                 ans.Add(list1[i]);
            //                 i++;
            //             }

            //             while(i<l1 && j<l2&& list1[i]>list2[j])
            //             {
            //                 ans.Add(list2[j]);
            //                 j++;
            //             }

            //             while(i<l1 && j<l2 && list1[i] == list2[j])
            //             {
            //                 ans.Add(list1[i]);                
            //                 ans.Add(list1[i]);
            //                 i++;
            //                 j++;
            //             }
            //         }

            //         while(i<l1){
            //             ans.Add(list1[i]);
            //             i++;
            //         }


            //         while(j<l2){
            //             ans.Add(list2[j]);
            //             j++;
            //         }

            return ans;

        }

        private void InOrderTraverse(TreeNode node, List<int> list)
        {
            if (node == null) return;
            InOrderTraverse(node.left, list);
            list.Add(node.val);
            InOrderTraverse(node.right, list);
        }
    }
}
