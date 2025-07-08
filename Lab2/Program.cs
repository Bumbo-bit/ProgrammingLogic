namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Step 1
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine((a > b) + "\n" +
        (a < c) + "\n" +
        (a > b && a > c) + "\n" +
        (a > b || a > c));
        //Step 2
        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining == true && haveUmbrella == false)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }
        //Step 3
        string userAge = Console.ReadLine();
        int age = Convert.ToInt32(userAge);
        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else if (age >= 65)
        {
            Console.WriteLine("Senior ticket: $6");
        }
        //Step 4
        string userDayInput = Console.ReadLine();
        int day = Convert.ToInt32(userDayInput);
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("It's Wednesday My Dudes!");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;   
        }
    }
}
