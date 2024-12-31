namespace General_tree;

public class TreeNode<T>
{
    public T Value { get; set; }
    public List<TreeNode<T>> Children { get; set; }
    public TreeNode(T value)
    {
        Value = value;
        Children = new();
    }
    public void AddChild(TreeNode<T> child)
    {
        Children.Add(child);
    }
    public TreeNode<T>? Find(T value)
    {
        if(EqualityComparer<T>.Default.Equals(value, value))
            return this;
        foreach(var child in Children)
        {
            var found = child.Find(value);
            if(found != null)
                return found;
        }
        return null;
    }
}

public class Tree<T>
{
    public TreeNode<T>? Root { get; set; }
    public Tree(TreeNode<T> root)
    {
        Root = root;
    }
    public void Print()
    {
        Print(Root);
    }
    public void Print(TreeNode<T>? node, string space = "")
    {
        if(node == null)
            return;
        Console.WriteLine(space + node.Value);
        foreach (var child in node.Children)
        {
            if(child.Value != null)
            Print(child, space + "   ");
        }
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        Tree<string> tree = new(new TreeNode<string>("CEO"));
        var node1 = new TreeNode<string>("CFO");
        var node2 = new TreeNode<string>("Accountant");
        var node3 = new TreeNode<string>("CTO");
        var node4 = new TreeNode<string>("Developer");
        var node5 = new TreeNode<string>("UX Designer");
        var node6 = new TreeNode<string>("CMO");
        var node7 = new TreeNode<string>("Social Media Manager");

        tree.Root.AddChild(node1);
        tree.Root.AddChild(node3);
        tree.Root.AddChild(node6);
        node1.AddChild(node2);
        node3.AddChild(node4);
        node3.AddChild(node5);
        node6.AddChild(node7);

        tree.Print();
    }
}
