namespace Stack.Exercises;

using Stack.Interfaces;

public class Ex1 : IExercise
{
    public void Resolve()
    {
        Stack<string> documentStack = new();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nDocument Management System:");
            Console.WriteLine("1 - Add a new document");
            Console.WriteLine("2 - Remove last document sent");
            Console.WriteLine("3 - Show next document to review");
            Console.WriteLine("4 - List all pending documents");
            Console.WriteLine("5 - Show total number of pending documents");
            Console.WriteLine("6 - Exit");
            Console.Write("Choose an option: ");

            string? input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter the document name: ");
                    string? docName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(docName))
                    {
                        documentStack.Push(docName);
                        Console.WriteLine($"Document \"{docName}\" added.");
                    }
                    else
                        Console.WriteLine("Invalid document name.");
                    break;

                case "2":
                    if (documentStack.Count > 0)
                    {
                        string removed = documentStack.Pop();
                        Console.WriteLine($"Document \"{removed}\" has been reviewed and removed.");
                    }
                    else
                        Console.WriteLine("No documents to remove.");
                    break;

                case "3":
                    if (documentStack.Count > 0)
                        Console.WriteLine($"Next document to review: {documentStack.Peek()}");
                    else
                        Console.WriteLine("No documents pending.");
                    break;

                case "4":
                    if (documentStack.Count > 0)
                    {
                        Console.WriteLine("Pending documents:");
                        foreach (var doc in documentStack)
                            Console.WriteLine($"- {doc}");
                    }
                    else
                        Console.WriteLine("No documents pending.");
                    break;

                case "5":
                    Console.WriteLine($"Total pending documents: {documentStack.Count}");
                    break;

                case "6":
                    Console.WriteLine("Exiting system...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
