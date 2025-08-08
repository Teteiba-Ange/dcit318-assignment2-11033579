// code for inheritance
using System;



static void Main(String[] args)
{
    Animal m = new Animal();
}
class Animal { 

    public void  makeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

 class Dog :Animal
{
     public  void makeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat:Animal
{
    public void makeSound()
    {
        Console.WriteLine("Meow");
}




