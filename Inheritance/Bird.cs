using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird()
        {

            Weight = 20;
            Height = 10;
            Legs = 2;
        }
        public Bird( double w, double h, int l) : base( w, h, l)
        {

        }
        public new void Info()
        {

            Console.WriteLine("Info of Bird: ");
            base.Info();
        }
    }
}
