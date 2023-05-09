using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writeAssign = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writeAssign.GetSummary());
        Console.WriteLine(writeAssign.GetWritingInformation());



    }
}