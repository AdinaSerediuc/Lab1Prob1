using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex1
Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui
• Google: volumul paralelipipedului dreptunghic
            */

            int Lungime = int.Parse(Console.ReadLine());
            int latime = int.Parse(Console.ReadLine());
            int inaltime = int.Parse(Console.ReadLine());
            int Volum = Lungime * latime * inaltime;

            Console.WriteLine("Volumul paralelipipedului dreptunghic este =" + Volum);
        }
    }
}
