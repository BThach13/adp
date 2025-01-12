namespace ADP_Implementations.Algorithms;

/*
    - [V]  Node find(T value)
    - [V]  findMin()
    - [V]  findMax()
    - [V]  insert(T value)
    - [V]  remove(T value)
*/

public class AVL<T> where T : IComparable<T>
{
    public class Node : IComparable<Node>
    {
        public T Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Height { get; set; }

        public Node(T value)
        {
            Value = value;
            Height = 0;
        }

        public int CompareTo(Node other)
        {
            return Value.CompareTo(other.Value);
        }
    }
    
    private Node _root;
    
    public void Insert(T value)
    {
       _root = Insert(_root, value); 
    }
    
    public void Remove(T value)
    {
        _root = Remove(_root, value);
    }

    public T? FindMin()
    {
        var node = FindMin(_root);
        
        if (node == null)
            return default;
        else
            return node.Value;
    }
    
    public T? FindMax()
    {
        var node = FindMax(_root);
        
        if (node == null)
            return default;
        else
            return node.Value;
    }
    
    public T? Find(T value)
    {
        var node = Find(_root, value);
        
        if (node == null)
            return default;
        else
            return node.Value;
    }

    private Node Insert(Node node, T value)
    {
        if (node == null)
            return new Node(value);

        if (value.CompareTo(node.Value) < 0)
            node.Left = Insert(node.Left, value);
        else if (value.CompareTo(node.Value) > 0)
            node.Right = Insert(node.Right, value);
        else
            return node;

        node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;

        var balance = GetBalance(node);

        if (balance > 1 && value.CompareTo(node.Left.Value) < 0)
            return RightRotate(node);

        if (balance < -1 && value.CompareTo(node.Right.Value) > 0)
            return LeftRotate(node);

        if (balance > 1 && value.CompareTo(node.Left.Value) > 0)
        {
            node.Left = LeftRotate(node.Left);
            return RightRotate(node);
        }

        if (balance < -1 && value.CompareTo(node.Right.Value) < 0)
        {
            node.Right = RightRotate(node.Right);
            return LeftRotate(node);
        }

        return node;
    }
    
    private Node Remove(Node node, T value)
    {
        if (node == null)
            return node;

        if (value.CompareTo(node.Value) < 0)
            node.Left = Remove(node.Left, value);
        else if (value.CompareTo(node.Value) > 0)
            node.Right = Remove(node.Right, value);
        else
        {
            if (node.Left == null || node.Right == null)
            {
                if (node.Left != null)
                    node = node.Left;
                else
                    node = node.Right;
            }
            else
            {
                var temp = FindMin(node.Right);
                node.Value = temp.Value;
                node.Right = Remove(node.Right, temp.Value);
            }
        }

        if (node == null)
            return node;

        node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;

        var balance = GetBalance(node);

        if (balance > 1 && GetBalance(node.Left) >= 0)
            return RightRotate(node);

        if (balance > 1 && GetBalance(node.Left) < 0)
        {
            node.Left = LeftRotate(node.Left);
            return RightRotate(node);
        }

        if (balance < -1 && GetBalance(node.Right) <= 0)
            return LeftRotate(node);

        if (balance < -1 && GetBalance(node.Right) > 0)
        {
            node.Right = RightRotate(node.Right);
            return LeftRotate(node);
        }

        return node;
    }
    
    private Node Find(Node node, T value)
    {
        if (node == null)
            return null;

        if (value.CompareTo(node.Value) < 0)
            return Find(node.Left, value);

        if (value.CompareTo(node.Value) > 0)
            return Find(node.Right, value);

        return node;
    }

    private Node FindMax(Node node)
    {
        if (node.Right == null)
            return node;
        else
            return FindMax(node.Right);
    }

    private Node FindMin(Node node)
    {
        if (node.Left == null)
            return node;
        else
            return FindMin(node.Left);
    }
    
    private int GetBalance(Node node)
    {
        if (node == null)
            return 0;
        else
            return Height(node.Left) - Height(node.Right);
    }
    
    private int Height(Node node)
    {
        if (node == null)
            return -1;
        else
            return node.Height;
    }
    
    private Node RightRotate(Node node)
    {
        var left = node.Left;
        var right = left.Right;

        left.Right = node;
        node.Left = right;

        node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;
        left.Height = Math.Max(Height(left.Left), Height(left.Right)) + 1;

        return left;
    }
    
    private Node LeftRotate(Node node)
    {
        var right = node.Right;
        var left = right.Left;

        right.Left = node;
        node.Right = left;

        node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;
        right.Height = Math.Max(Height(right.Left), Height(right.Right)) + 1;

        return right;
    }
}