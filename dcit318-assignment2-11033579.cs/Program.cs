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

        Shape circle = new Circle();
        circle.GetArea();

        Shape rectangle = new Rectangle();
        rectangle.GetArea();

        IMovable car = new Car();
        car.Move();

        IMovable bicycle = new Bicycle();
        bicycle.Move();
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
public  class Circle : Shape {

    public override void GetArea()
    {
        Console.WriteLine("Please enter the radius of a circle");
        String userInput = Console.ReadLine();
        if (double.TryParse(userInput ,out  double radius)) { 
          
            double Pi = 3.14;
            double Area = Pi * (radius * radius);
            Console.WriteLine($"The area of the circle is {Area}");
        }else
        {
            Console.WriteLine("Invalid Input!Please enter a number");
        }

        
        
    }
}
public class Rectangle:Shape { 
    public override void GetArea()
    {
        Console.WriteLine("Please enter the length of the rectangle");
        String userInput1 = Console.ReadLine();

        Console.WriteLine("Please enter the breadth of the rectangle");
        String userInput2 = Console.ReadLine();
        if(int.TryParse(userInput1,out int length))
        {
            Console.WriteLine("This is  the length");
        }
        if (int.TryParse(userInput2, out int breadth))
        {
            Console.WriteLine("This is  the breadth");
        }
        int AreaRec = length * breadth;
        Console.WriteLine($"The Area of your rectangle is {AreaRec}");

    }
}

public interface IMovable {
    void Move();
}

 public class Car : IMovable
{
    public void Move() {
        Console.WriteLine("Car is moving");
    }

}
public class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle  is moving");
    }

}




