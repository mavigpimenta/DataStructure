namespace Stack.Classes;

public class StackClass
{
    private static StackClass? _currentStack = null;
    public Stack<int> Stack { get; set; } = [];

    public static StackClass GetCurrentStack()
    {
        _currentStack ??= new StackClass();
        return _currentStack;
    }

    public void Push(int number)
    {
        Stack.Push(number);
    }

    public int Pop()
    {
        return Stack.Pop();
    }

    public bool Find(int number)
    {
        return Stack.Contains(number);
    }
}