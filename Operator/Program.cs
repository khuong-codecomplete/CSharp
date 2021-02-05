using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {

            double Volume = 0.0;

            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();

            Box1.setLenght(7.0);
            Box1.setWidth(8.0);
            Box1.setHeight(5.0);

            Box2.setLenght(4.0);
            Box2.setWidth(6.0);
            Box2.setHeight(9.0);

            Volume = Box1.VolumeColculation();
            Console.WriteLine("Volume of box 1: {0}", Volume);

            Volume = Box2.VolumeColculation();
            Console.WriteLine("Volume of box 2: {0}", Volume);

            Box3 = Box1 + Box2;

            Volume = Box3.VolumeColculation();
            Console.WriteLine("Volume of box 3: {0}", Volume);
        }
    }
}
