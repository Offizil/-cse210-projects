class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int intMagicNumber = int.Parse(magicNumber);

        int guess; // Declare guess outside the loop
        // Create an instance of Random
        Random random = new Random();

        // Generate a random integer between 1 and 100 (inclusive)
        int randomNumber = random.Next(1, 101);

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Higher");
            }

        } while (guess != randomNumber);

        Console.WriteLine("Congratulations! You guessed the magic number.");
    }
}
