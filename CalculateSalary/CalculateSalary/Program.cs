using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSalary
{
    internal class Program
    {
        static readonly Random _random = new Random();
        static void Main(string[] args)
        {
            Felhantering(false, _random.Next(15000, 50000), _random.Next(0, 200));
            Console.WriteLine("------");
            Felhantering(false, _random.Next(15000, 50000), _random.Next(0, 200));
            Console.WriteLine("------");
            Felhantering(false, _random.Next(15000, 50000), _random.Next(0, 200));
        }


        static void Felhantering(bool inmatat, int inkomst, int timmar)
        {
            while (!inmatat)
            {
                try
                {
                    Console.Write("Insert your monthly salary: ");
                    Console.Write(inkomst);
                    if (inkomst > 40000 || inkomst < 16000)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        inmatat = true;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("The highest salary in this company is 40000kr and the lowest is 16000 kr. Try again!");
                    Console.ResetColor();
                    inkomst = _random.Next(15000, 50000);
                }
                Console.WriteLine();
            }

            inmatat = false;
            while (!inmatat)
            {
                try
                {
                    Console.Write("Insert the amount of hours you work per month: ");
                    Console.Write(timmar);
                    if (timmar > 160 || timmar < 35)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        inmatat = true;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Any employer must work a minimum of 35 and a maximum of 160 hrs per month. Try again!");
                    Console.ResetColor();
                    timmar = _random.Next(0, 200);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your salary per hour: {Math.Round((double)inkomst / timmar, 2)} kr/h");
            Console.ResetColor();
            Console.ReadKey();
        }     
    }
}
