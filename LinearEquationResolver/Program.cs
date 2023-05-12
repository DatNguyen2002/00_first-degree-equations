using System;
namespace LinearEquationResolver
{
    class Progarm
    {
        static void Main(string [] args)
        {
            // double a = 2;
            // double b = 3;

            Console.WriteLine("Nhap Gia Tri a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Gia Tri b: ");
            double b = double.Parse(Console.ReadLine());



            // neu ma a =0 thi phuong trinh vo nghiem hoac vo so nghiem
            if(a == 0)
            {
                if (b ==0) Console.WriteLine("Phuong Trinh Vo so nghiem");

                else Console.WriteLine("Phuong trinh vo nghiem");
            }
            // voi a!=0 thi phuong trinh co nghiem x = -b/a
            else
            {
                double x = -b/a;
                Console.WriteLine("Phuong trinh co nghiem duy nhat: x = "+ x);
            }
        }
    }
}