namespace SeptemberChallenge.Library
{
    public class TreeConstruction
    {
        public TreeNode GetFromLevelOrderTraverse(int[] array)
        {
            int len = array.Length;
            if (len == 0) return null;

            var root = new TreeNode(array[0]);
            Construct(root, 0, array);

            return root;
        }

        private void Construct(TreeNode node, int index, int[] array)
        {
            if(index>=array.Length) return;

            int leftIndex = 2*index + 1;
            int rightIndex = 2*index + 2;

            if(leftIndex < array.Length )
            {
                var leftChild = new TreeNode(array[leftIndex]);
                node.left = leftChild;
                Construct(leftChild, leftIndex,array);
            }

            if (rightIndex < array.Length)
            {
                var rightChild = new TreeNode(array[rightIndex]);
                node.right = rightChild;
                Construct(rightChild, leftIndex, array);
            }
        }
    }
}
