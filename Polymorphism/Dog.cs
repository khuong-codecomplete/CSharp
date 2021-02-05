using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog is speaking gauw gauw");
        }
    }
}
