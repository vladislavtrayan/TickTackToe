namespace tick_tack_toe
{
    class Tree
    {
        private readonly TreeNode _root;

        public Tree()
        {
            _root = null;
        }

        public bool IsEmpty()
        {
            return _root == null;
        }


    }
}
