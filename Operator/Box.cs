using System;

namespace Operator
{
    class Box
    {

        private double Lenght;
        private double Width;
        private double Height;

        public double VolumeColculation()
        {

            return Lenght * Width * Height;
        }

        public void setLenght(double lenght)
        {
            Lenght = lenght;
        }

        public void setWidth(double width)
        {
            Width = width;
        }

        public void setHeight(double height)
        {
            Height = height;
        }

        public static Box operator +(Box a, Box b)
        {

            Box box = new Box();
            box.Lenght = a.Lenght + b.Lenght;
            box.Width = a.Width + b.Width;
            box.Height = a.Height + b.Height;
            return box;
        }

    }
}
