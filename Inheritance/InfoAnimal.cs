using System;

namespace Inheritance
{
    class InfoAnimal
    {
        static void Main(string[] args)
        {

            Bird Dove = new Bird();
            Dove.Info();

            Cat BlackCat = new Cat();
            BlackCat.Info();

            Console.ReadKey();
        }
    }
}
