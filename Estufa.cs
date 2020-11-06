using System;
using System.Threading;
namespace ElectromesticosG4
{
    class Estufa : IApagar,IEncender
    {
        public Estufa()
        {
            Console.WriteLine("Bienvenido, vamos a cocinar");
        }

        public void Apagar()
        {
            Console.WriteLine("Disminuyendo flujo gas");
            Thread.Sleep(2000);
            Console.WriteLine("Piloto y quemador apagado");
        }

        void IEncender.Encender()
        {
            Console.WriteLine("Aumentando flujo de gas");
            Thread.Sleep(2000);
            Console.WriteLine("Piloto y Quemador Encendido");
        }
    }
}
