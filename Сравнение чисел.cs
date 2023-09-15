using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text
{
 class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Ведите первое число: ")
        int number1 = int.Parse(Console.ReadLine())
        Console.WriteLine("Ведите второе число: ")
        int number2 = int.Parse(Console.ReadLine())
        if (number1 > number2)
        {
            Console.WriteLine("число 1 > числа 2")
        }
        else if (number1 < number2)
        {
            Console.WriteLine("число 1 < числа 2")
        }
        else Console.WriteLine("Числа одинаковы")

    }
}
}