using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Lab4;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }
    //Problem 1
    public void Start()
    {
        Console.WriteLine("The car is starting");
    }
    //Problem 2
    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles");
    }
    //Probelm 3
    public string GetDescription(string model, string color, int year)
    {
        string descrip = $"{year} {color} {model}";
        return descrip;

    }
    //Problem 4

    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine($"The car has been repainted to {color}");
    
    }
    
}


 class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        string model = myCar.model = "Civic";
        string color = myCar.color = "Black";
        int year = myCar.year = 2020;

        myCar.Display(); // Calling the Display method
        myCar.Start();
        myCar.Drive(50);
        Console.WriteLine(myCar.GetDescription(year: year, model: model, color: color));
        myCar.Repaint("red");
    }
}
