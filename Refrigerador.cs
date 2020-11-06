using System;
using System.Threading;
namespace ElectromesticosG4
{
    class Refrigerador : IApagar,IEncender
    {

        public Refrigerador()
        {
            Console.WriteLine("Hola, buen día");
        }

        public void Encender()
        {
            Console.WriteLine("Termostato encendido");
            Thread.Sleep(2000);
            Console.WriteLine("Compresor encendido");
        }

        void IApagar.Apagar()
        {
            Console.WriteLine("Suspendiendo compresor");
            Thread.Sleep(2000);
            Console.WriteLine("Hasta luego....");
        }
    }
}
