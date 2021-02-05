using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        protected double Weight;
        protected double Height;
        protected static int Legs;

        public void Info()
        {
            Console.WriteLine("Weight: {0}, Height: {1}, Legs: {2}", Weight, Height, Legs);
        }

        public Animal()
        {

        }

        public Animal(double w, double h, int l)
        {
            Weight = w;
            Height = h;
            Legs = l;
        }
    }
}
