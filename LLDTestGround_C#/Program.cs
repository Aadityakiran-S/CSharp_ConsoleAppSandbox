class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        Program myProgram = new Program();
        myProgram.PrintAllElementsInArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
    }

    public void PrintAllElementsInArray(int[] input)
    {
        foreach(var element in input)
        {
            Console.WriteLine(element);
        }
    }
}