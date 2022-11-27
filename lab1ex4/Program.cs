using System;

namespace lab1ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercitii
             Ex 4
             Scrieti un program care va afisa semnul unui numar citit de la tastatura
             • Daca numarul este pozitiv, va afisa “+”
             • Daca numarul este negativ, va afisa “-”
             • Daca numarul este 0, va afisa “0”
             */

            int number;
            Console.WriteLine("Introduceti un numar: ");
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Semnul numarului este: -");
            }
            else if(number==0)
            {
                Console.WriteLine("Rezultat: 0");
            }
            else {
                Console.WriteLine("Semnul numarului este: +");
            }
         
        }
    }
}
