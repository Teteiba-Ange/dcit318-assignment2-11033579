// code for inheritance
using System;


class Program
{
    static void Main(String[] args)
    {
        Animal m = new Animal();
        m.makeSound();

        Animal ADog = new Dog();
        ADog.makeSound();

        Animal ACat = new Cat();
        ACat.makeSound();
    }
}
class Animal { 

    public  virtual void  makeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

 class Dog :Animal
{
     public   override void makeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override  void makeSound()
    {
        Console.WriteLine("Meow");
    }
}
//Abstract classes

public abstract class Shape
{
    public virtual void GetArea()
    {
    }
}
public abstract class Circle : Shape {

    public override void GetArea()
    {
        Console.WriteLine("Please enter the radius of a circle");
        String userInput = Console.ReadLine();

        
        base.GetArea();
    }
}




