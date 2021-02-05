using System;

namespace CSharpBasic
{
    class SwichCase
    {
        static void Main(string[] args)
        {

            int Year;
            string Can = "";
            string Chi = "";

            Console.Write("Hay nhap mot nam bat ki: ");
            Year = Convert.ToInt32(Console.ReadLine());

            switch (Year % 10)
            {

                case 0:
                    Can = "Canh";
                    break;
                case 1:
                    Can = "Tan";
                    break;
                case 2:
                    Can = "Nham";
                    break;
                case 3:
                    Can = "Quy";
                    break;
                case 4:
                    Can = "Giap";
                    break;
                case 5:
                    Can = "At";
                    break;
                case 6:
                    Can = "Binh";
                    break;
                case 7:
                    Can = "Đinh";
                    break;
                case 8:
                    Can = "Mau";
                    break;
                case 9:
                    Can = "Ky";
                    break;

            }

            switch (Year % 12)
            {

                case 0:
                    Chi = "Than";
                    break;
                case 1:
                    Chi = "Dau";
                    break;
                case 2:
                    Chi = "Tuat";
                    break;
                case 3:
                    Chi = "Hoi";
                    break;
                case 4:
                    Chi = "Ti";
                    break;
                case 5:
                    Chi = "Suu";
                    break;
                case 6:
                    Chi = "Dan";
                    break;
                case 7:
                    Chi = "Meo";
                    break;
                case 8:
                    Chi = "Thin";
                    break;
                case 9:
                    Chi = "Ti";
                    break;
                case 10:
                    Chi = "Ngo";
                    break;
                case 11:
                    Chi = "Mui";
                    break;

            }

            Console.WriteLine("Năm {0} là năm: {1} {2}", Year, Can, Chi);
            Console.ReadKey();

        }
    }
}
