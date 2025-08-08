// code for inheritance
using System;
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


