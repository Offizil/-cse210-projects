using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Edem", "LeForte fractures");
        string details = assignment.GetSummary();
        Console.WriteLine(details);

        MathAssignment mathAssignment = new MathAssignment("Section 7", "Problems 77", "Fred Offiong", "Complications of maxillectomy");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Jhetem Ayang", "Abi History", "The Root Cause of Century Long Feud Along Abi Borders");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
}

}