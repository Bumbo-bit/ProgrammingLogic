namespace Lab1;
/* Name : Hagen White Title: [IT-1050-Lab1] */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Step 2
        string name = "Hagen White";
        string title = "IT-1050-Lab1";
        Console.WriteLine(name + " " + title);
        //Step 3
        int favNum = 100;
        string favCodingLang = "SQL";
        double numOfPrograms = 30;
        bool codingExp = true;
        Console.WriteLine("My favorite number is " + favNum
         + " and my favorite programing language is " + favCodingLang
          + ".The number of programs i've written is " + numOfPrograms
           + " and it is " + codingExp
            + " that I have programming experience.");
        //Step 4
        const string school = "Tri-C";
        Console.WriteLine("I'm going to " + school);
        //Step 5
        double doubleToCast = 9.78;
        int intValue = (int)doubleToCast;
        int integerToCast = 100;
        bool boolToCast = true;
        Console.WriteLine("double: " + doubleToCast +
         "\n" + "int: " + intValue
         + "\n" + "String of Int: " + Convert.ToString(integerToCast)
         + "\n" + "Boolean to String: " + Convert.ToString(boolToCast));
        //Step 6
        Console.WriteLine("Type your name, stranger");
        string strangerName = Console.ReadLine();
        Console.WriteLine("Now gimme your age, stranger");
        string strangerAge = Console.ReadLine();
        Console.WriteLine("Why hello there " + strangerName
         + " who is also " + Convert.ToInt32(strangerAge));
        //Step 7 
        int num1 = 100;
        int num2 = 200;
        Console.WriteLine(num1 += 10);
        Console.WriteLine(num2 -= 2);
        Console.WriteLine(num1 *= 3);
        Console.WriteLine(num2 /= 2);
        Console.WriteLine(num1 %= 2);
        //Step 8
        float floatNum = 1.123456789F;
        double doubleNum = 1.123456789D;
        Console.WriteLine("Float: " + floatNum
         + "\n vs. \n" + "Double: " + doubleNum);
        //Step 9
        int incrementNum = 10;
        incrementNum++;
        Console.WriteLine(incrementNum);
        incrementNum--;
        Console.WriteLine(incrementNum);
        
    }
}
