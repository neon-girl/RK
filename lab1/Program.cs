using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Баркалова Ирина Владимировна, ИУ5-33Б");

            double A =0, B=0, C=0;
            double d1, d2, x1, x2;
            HashSet<double> roots = new HashSet<double>();
            bool fl = false;

            if (args.Length > 0)
            {
                try
                {
                    A = Convert.ToDouble(args[0]);
                    B = Convert.ToDouble(args[1]);
                    C = Convert.ToDouble(args[2]);
                }
                catch
                {
                    Console.WriteLine(" Коэффициенты введены не кореектно. Повторите ввод!");

                }

            }
            else
            {
                while (fl != true)
                {
                    try
                    {
                        Console.Write("A= ");
                        A = Convert.ToDouble(Console.ReadLine());
                        Console.Write("B= ");
                        B = Convert.ToDouble(Console.ReadLine());
                        Console.Write("C= ");
                        C = Convert.ToDouble(Console.ReadLine());
                        fl = true;
                    }
                    catch
                    {
                        Console.WriteLine(" Коэффициенты введены не кореектно. Повторите ввод!");

                    }

                }
            }
            if((A==0)&& (B == 0) && (C == 0))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Уравнение имеет бесконечное множество решений.");
                Console.ResetColor();

                Environment.Exit(0);
            }
            double D = B * B - 4 * A * C;
            if (D < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Корней нет!");
                Console.ResetColor();

                Environment.Exit(0);
            }
            else if (D > 0)
            {
                if ((A != 0) && (B != 0))
                {
                    d1 = (-B + Math.Sqrt(D)) / (2 * A);
                    d2 = (-B - Math.Sqrt(D)) / (2 * A);
                    if ((d1 < 0) || (d2 < 0)||((d1 < 0) && (d2 < 0)))
                    {
                        if ((d1 < 0) && (d2 < 0))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Корней нет!");
                            Console.ResetColor();

                            Environment.Exit(0);
                        }
                        else if (d1 < 0)
                        {
                            if (d2 != 0)
                            {
                                x2 = Math.Sqrt(d2);
                               
                                roots.Add(x2);
                                roots.Add(-x2);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("x1 = " + Math.Round(x2, 2) + " ; x2= " + Math.Round(-x2, 2));
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("x = 0");
                                Console.ResetColor();

                            }
                        }
                        else 
                        {
                            if (d1 != 0)
                            {
                                x1 = Math.Sqrt(d1);
                                
                                roots.Add(x1);
                                roots.Add(-x1);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("x1 = " + Math.Round(x1, 2) + " ; x2= " + Math.Round(-x1, 2));
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("x = 0");
                                Console.ResetColor();

                            }

                        }
                        
                    }
                    else
                    {
                        x1 = Math.Sqrt(d1);
                        
                        x2 = Math.Sqrt(d2);
                        
                        roots.Add(x1);
                        roots.Add(-x1);
                        roots.Add(x2);
                        roots.Add(-x2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = " + Math.Round(x1, 2) + "       x2 = " + Math.Round(-x1, 2) + "     x3 = " + Math.Round(x2, 2) + "     x4 = " + Math.Round(-x2, 2));
                    }
                }
                else 
                {
                    if (A == 0)
                    {
                        if(C>0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Корней нет!");
                            Console.ResetColor();

                            Environment.Exit(0);
                        }
                        else
                        {
                           
                            if (C != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("x1 = " + Math.Round(Math.Sqrt(-C/B), 2) + " ; x2= " + Math.Round(-Math.Sqrt(-C/B), 2));
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("x = 0");
                                Console.ResetColor();

                            }

                        }
                    }
                    else
                    {
                        if (C > 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Корней нет!");
                            Console.ResetColor();

                            Environment.Exit(0);
                        }
                        else
                        {

                            if (C != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("x1 = " + Math.Round(Math.Pow(-C/A,0.25), 2) + " ; x2= " + Math.Round(-Math.Pow(-C/A, 0.25), 2));
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("x = 0");
                                Console.ResetColor();

                            }

                        }
                    }
                }
               
            }
           
            else if (D==0)
            {
                d1 = -B / 2 * A;
                if ((d1 < 0) || (A == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Корней нет!");
                    Console.ResetColor();

                    Environment.Exit(0);
                }
                else
                {
                    x1 = Math.Sqrt(d1);
                    if (x1 != 0)
                    {

                        roots.Add(x1);
                        roots.Add(-x1);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = " + Math.Round(x1, 2) + " ; x2= " + Math.Round(-x1, 2));
                        Console.ResetColor();
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x = 0" );
                        Console.ResetColor();
                    }

                }


            }

        }
    }
}
 