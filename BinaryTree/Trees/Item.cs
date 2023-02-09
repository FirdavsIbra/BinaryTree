namespace BinaryTree.Trees
{
    public sealed class Item
    {
        /// <summary>
        /// Gets or sets id of node.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of node.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets parent id of node.
        /// </summary>
        public int? ParentId { get; set; }
    }
}
