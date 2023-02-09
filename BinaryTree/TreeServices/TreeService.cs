using BinaryTree.Trees;
using System.Xml.Linq;
using System;

namespace BinaryTree.TreeServices
{
    public class TreeService
    {
        private Dictionary<int, TreeItem> _nodes;
        private Random _random;

        public TreeService()
        {
            _nodes = new Dictionary<int, TreeItem>();
            _random = new Random();
        }
        public void AddNode(Item item)
        {
            if (!_nodes.ContainsKey(item.Id))
            {
                _nodes[item.Id] = new TreeItem(item.Id, item.Name);
            }

            if (item.ParentId.HasValue)
            {
                if (!_nodes.ContainsKey(item.ParentId.Value))
                {
                    _nodes[item.ParentId.Value] = new TreeItem(item.ParentId.Value, "");
                }

                int index = _random.Next(_nodes[item.ParentId.Value].Children.Count + 1);
                _nodes[item.ParentId.Value].Children.Insert(index, _nodes[item.Id]);
            }
        }

        public void PrintTree()
        {
            foreach (var node in _nodes.Values)
            {
                Console.WriteLine("Id: " + node.Id);
                Console.WriteLine("Name: " + node.Name);
                Console.WriteLine("Children: ");
                foreach (var child in node.Children)
                {
                    Console.WriteLine(child.Id + " " + child.Name);
                }
                Console.WriteLine();
            }
        }

    }
}
