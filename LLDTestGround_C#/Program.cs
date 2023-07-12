class Program
{
    string personName;
    static void Main(string[] args)
    {
        Program myProgram = new("John");
        myProgram.PrintMessage($"Hello {myProgram.personName}!");
    }

    public Program(string name)
    {
        personName = name;
    }

    private void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}