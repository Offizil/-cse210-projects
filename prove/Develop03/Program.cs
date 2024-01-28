using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Welcome to the Scripture memorizer app");
        Console.WriteLine();
        //i have now made it possible for user memorise just a single verse or multiple verse.
        //For exceeding requirement.
        Console.Write("Do you wish to memorise just a single verse? ");
        string usersChoice = Console.ReadLine();
        if (usersChoice == "yes")
        {
            Console.Write("What Bible book would you like to memorise? ");
            string inputBook = Console.ReadLine();
            Console.Write("What Chapter would you like to memorise? ");
            string inputChapter = Console.ReadLine();
            int inputChapterNum = int.Parse(inputChapter);
            Console.Write("What verse would you like to memorise? ");
            string inputVerse = Console.ReadLine();
            int inputVerseNum = int.Parse(inputVerse);
            Console.Write("Kindly type the whole passage you want to memorise ");
            string inputText = Console.ReadLine();
            Reference reference = new Reference(inputBook, inputChapterNum, inputVerseNum);
            Scripture scripture = new Scripture(reference, inputText);
            Random random = new Random();
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayTextt());
            string userInput;
            bool complete;
            complete = scripture.IsCompletelyHidden();
            while (complete == false)
            {
                complete = scripture.IsCompletelyHidden();
                Console.Write("Press Enter key to continue or type quit to exit ");
                userInput = Console.ReadLine();
                Console.Clear();
                if (userInput == "quit")
                {
                    Console.WriteLine("Thank you for your time!!");
                    break;
                }
                else if (complete == true)
                {
                    Console.WriteLine("Thank you for your time\nHope you were able to memorize the scripture!!");
                    break;
                }
                else
                {
                    int numberToHide = random.Next(scripture.Getters().Count);
                    scripture.HideRandomWords(numberToHide);
                    string generatedString = scripture.GetDisplayTextt();
                    Console.WriteLine(generatedString);
                }
            }
        }
        else
        {
            Console.Write("What Bible book would you like to memorise? ");
            string inputBook = Console.ReadLine();
            
            Console.Write("What Chapter would you like to memorise? ");
            string inputChapter = Console.ReadLine();
            
            int inputChapterNum = int.Parse(inputChapter);
            Console.Write("What is the first verse of the Chapter you would like to memorise? ");
            
            string inputFirstVerse = Console.ReadLine();
            int inputFirstVerseNum = int.Parse(inputFirstVerse);
            Console.Write("What is the last verse of the Chapter you would like to memorise? ");
            
            string inputLastVerse = Console.ReadLine();
            int inputLastVerseNum = int.Parse(inputLastVerse);
            Console.Write("Kindly type the whole text you want to memorise ");
            
            string inputText = Console.ReadLine();
            Reference reference = new Reference(inputBook, inputChapterNum, inputFirstVerseNum, inputLastVerseNum);
            Scripture scripture = new Scripture(reference, inputText);
            Random random = new Random();
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayTextt());
            Console.Write("Press Enter key to continue or type quit to exit ");
            string userInput;
            bool complete;
            complete = scripture.IsCompletelyHidden();
            while (complete == false)
            {
                complete = scripture.IsCompletelyHidden();
                Console.Write("Press Enter key to continue or type quit to exit ");
                userInput = Console.ReadLine();
                if (userInput == "quit")
                {
                    Console.WriteLine("Gododbye, thank you for your time!!");
                    break;
                }
                else if (complete == true)
                {
                    Console.WriteLine("Thank you for your time\nHope you were successful at memorizing the scripture passage!!");
                    break;
                }
                else
                {
                    int numberToHide = random.Next(scripture.Getters().Count);
                    scripture.HideRandomWords(numberToHide);
                    string generatedString = scripture.GetDisplayTextt();
                    Console.WriteLine(generatedString);
                }
            }
            
        }

    }
}