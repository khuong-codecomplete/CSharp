using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat is speaking meow meow");
        }
    }
}
