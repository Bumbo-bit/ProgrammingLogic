namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Problem 1
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(i);
        }
        //Problem 2
        for (int i = 1; i < 21; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }

        }
        //Problem 3
        int countdown = 5;
        while (countdown > 0)
        {
            Console.WriteLine(countdown);
            countdown--;
        }
        //Problem 4
        int multiples = 10;
        while (multiples <= 1000)
        {
            if (multiples % 10 == 0)
            {
                Console.WriteLine(multiples);
            }
            multiples++;
        }
        //Problem 5
        string[] seasons = new string[4]
         { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
        //Problem 6
        Console.WriteLine("Choose a number 1-7");
        string[] days = new string[7]
        { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        string userInput = Console.ReadLine() ?? "";
        int chosenDay = 0;
        if (int.TryParse(userInput, out int result))
        {
            chosenDay = result;
        }
        else
        {
            Console.WriteLine("Input a number silly");
        }



        if (chosenDay == 1 || chosenDay == 2 || chosenDay == 3 || chosenDay == 4 || chosenDay == 5 || chosenDay == 6 || chosenDay == 7)
        {
            for (int i = 1; i < 8; i++)
            {
                if (i == chosenDay)
                {
                    Console.WriteLine(days[i - 1]);
                }
            }
        }
        else
        {
            Console.WriteLine("Thats not a number 1-7");
        }
        //Problem 7
        string[] bookTitles = new string[3] { "Lightning Thief", "The Art of War", "Artemis Fowl" };
        string[] authors = new string[3] { "Rick Riordan", "Sun Tzu", "Eoin Colfer" };
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(bookTitles[i] + " by " + authors[i]);
        }
        //Problem 8
        int[] tempValues = new int[5] { 76, 54, 89, 43, 87 };
        Array.Sort(tempValues);
        foreach (int temp in tempValues)
        {
            Console.WriteLine(temp);
        }
        //Problem 9
        int[] numbers = new int[] { 5, 4, 3, 2, 1 };
        Array.Reverse(numbers);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
