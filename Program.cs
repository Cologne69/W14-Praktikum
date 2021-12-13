using System;

namespace W14_Praktikum
{
    class Program
    {
        static void Prime(int input)
        {
            if (input < 2)
            {
                Console.WriteLine("Input minimal 2");
            }
            int repeat = 2;
            while (input % repeat != 0)
            {
                repeat = repeat + 1;
            }
            if (input == repeat)
            {
                int Prime = 2;
                for (int vertical = 0; vertical < input; vertical++)
                {
                    for (int horizontal = 0; horizontal < input; horizontal++)
                    {
                        Console.Write(Prime);
                        Prime = Prime + 1;
                        int counter = 2;
                        while (Prime % counter != 0)
                        {
                            counter++;
                        }
                        while (Prime != counter)
                        {
                            Prime = Prime + 1;
                            counter = 2;
                            while (Prime % counter != 0)
                            {
                                counter++;
                            }
                        }
                        Console.Write("".PadLeft(5));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                int NonPrime = 1;
                for (int vertical = 0; vertical < input; vertical++)
                {
                    for (int horizontal = 0; horizontal < input; horizontal++)
                    {
                        Console.Write(NonPrime);
                        NonPrime = NonPrime + 1;
                        int counter = 2;
                        while (NonPrime % counter != 0)
                        {
                            counter++;
                        }
                        while (NonPrime == counter)
                        {
                            NonPrime = NonPrime + 1;
                            counter = 2;
                            while (NonPrime % counter != 0)
                            {
                                counter++;
                            }
                        }
                        Console.WriteLine("".PadLeft(5));
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan input : ");
            Prime(int.Parse(Console.ReadLine()));
        }
    }
}
