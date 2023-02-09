using BinaryTree.Trees;
using BinaryTree.TreeServices;

internal class Program
{
    private static void Main(string[] args)
    {
        TreeService tree = new TreeService();
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Item item = new Item()
            {
                Id = i,
                Name = Guid.NewGuid().ToString(),
                ParentId = random.Next(0, i),
            };
            tree.AddNode(item);
            
        }
        tree.PrintTree();


        Console.ReadLine();

    }
}