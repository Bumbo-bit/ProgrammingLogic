namespace Lab5;
//Step 1
class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
//Step 2
class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}
class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}
//Step 3
class Program()
{
    static void Main(string[] args)
    {
        Animal animalObj = new Animal();
        Animal catObj = new Cat();
        Animal dogObj = new Dog();
        animalObj.animalSound();
        catObj.animalSound();
        dogObj.animalSound();

    }
}
