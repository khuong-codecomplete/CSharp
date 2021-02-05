using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal BlackCat = new Cat();
            Animal WhiteDog = new Dog();

            BlackCat.Speak();
            WhiteDog.Speak();
        }
    }
}
