namespace Queue.Classes;

public class QueueClass
{
    private static QueueClass? _currentQueue = null;
    public Queue<int> Queue { get; set; } = [];

    public static QueueClass GetCurrentQueue()
    {
        _currentQueue ??= new QueueClass();
        return _currentQueue;
    }

    public void Enqueue(int number)
    {
        Queue.Enqueue(number);
    }

    public int Dequeue()
    {
        return Queue.Dequeue();
    }

    public bool Find(int number)
    {
        return Queue.Contains(number);
    }
}