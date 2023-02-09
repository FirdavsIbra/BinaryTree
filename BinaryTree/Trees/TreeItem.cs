namespace BinaryTree.Trees
{
    public sealed class TreeItem
    {
        /// <summary>
        /// Gets or sets id of tree node.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of tree node.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets childrens of tree node.
        /// </summary>
        public List<TreeItem> Children { get; set; }
        public TreeItem(int id, string name)
        {
            Id = id;
            Name = name;
            Children = new List<TreeItem>();
        }
    }
}
