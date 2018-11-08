using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricDrawerWithFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricDrawerMenu();
        }
        static void GeometricDrawerMenu()
        {
            int Opt;
            bool Ext = false;
            do
            {
                Console.WriteLine("Choose one of the four options :");
                Console.Write("1- Rectangle.\n2- Right Triangle Upside-Down.\n3- Numbers Cube.\n4- Exit.\n");
                Opt = int.Parse(Console.ReadLine());
                if (Opt == 1)
                {
                    Rectangle();

                }
                else if (Opt == 2)
                {
                    RightTriangleUpside_Down();
                }
                else if (Opt == 3)
                {
                    NumbersCube();
                }
                else if (Opt == 4)
                {
                    Ext = true;
                }

            } while (!Ext);
        }
        static void Rectangle()
        {
            Console.WriteLine("Enter the hight of the rectangle...");
            int Hight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle...");
            int Width = int.Parse(Console.ReadLine());
            for (int i = 0; i < Hight; i++)
            {
                if (i == 0 || i == (Hight - 1))
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("*");
                    for (int z = 1; z < Width - 1; z++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }
            Console.WriteLine("Press enter to back to menu page...");
            Console.ReadLine();
            Console.Clear();
        }
        static void RightTriangleUpside_Down()
        {
            Console.WriteLine("Enter the width of the triangle base...");
            int Base = int.Parse(Console.ReadLine());
            for (int i = 0; i < Base; i++)
            {
                for (int z = 0; z < i; z++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < Base; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press enter to back to menu page...");
            Console.ReadLine();
            Console.Clear();
        }
        static void NumbersCube()
        {
            Console.WriteLine("Enter a natural number...");
            int Num = int.Parse(Console.ReadLine());
            for (int i = 0; i < Num; i++)
            {
                for (int j = i; j <= Num; j++)
                {
                    Console.Write(j);
                }
                for (int z = 0; z < i; z++)
                {
                    Console.Write(z);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press enter to back to menu page...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
