using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine();

        Console.WriteLine("WELCOME TO THE ETERNAL QUEST PROGRAM");
        Console.WriteLine("Menu Options: \n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit ");
        Console.Write("Select a choice from the menu: ");
        string menu_choice  = Console.ReadLine();
        

        while (menu_choice != "6")
        {
            if (menu_choice == "1")
            {
                Console.WriteLine("Hey there, the available types of goals are \n1. Simple Goals \n2. Eternal Goals \n3. Checklist Goals");
                Console.Write("What type of goals would you like to create?");
                string intChoice = Console.ReadLine();

                if (intChoice == "1")
                {

                }

                else if (intChoice == "2")
                {

                }

                else  if (intChoice == "3")

            }
        }
    }
}