using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        MyProgram myProgram = new("John");
        myProgram.PrintMessage("Hello World!");
    }

    public class MyProgram {
        public string Name { get; private set;}
        public MyProgram(string name) {  Name = name; }
        public void PrintMessage(string message) { Console.WriteLine($"{Name} says: {message}"); }
    }
}