using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cat : Animal
    {
        public Cat()
        {

            Weight = 100;
            Height = 15;
            Legs = 4;
        }
        public Cat(double w, double h, int l) : base(w, h, l)
        {

        }
        public new void Info()
        {

            Console.WriteLine("Info of Cat: ");
            base.Info();
        }
    }
}
