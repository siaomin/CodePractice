namespace Library.Entity
{
    public class TreeNode
    {
        public TreeNode(int value)
        {
            this.Value = value;
        }

        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Value { get; set; }
    }
}