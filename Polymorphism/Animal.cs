using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking...");
        }
    }
}
