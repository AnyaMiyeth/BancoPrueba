
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPrueba
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuenta cuenta = new Cuenta();
            Console.WriteLine(cuenta.Retirar(100));
            Console.WriteLine(cuenta.Consignar(100));
            Console.WriteLine(cuenta.Retirar(50));
            Console.WriteLine(cuenta.Consignar(100));
            Console.WriteLine(cuenta.Retirar(50));
            Console.WriteLine(cuenta.ConsultarSaldo());
            Console.WriteLine(cuenta.Consultarextracto());
            Console.ReadKey();
        }
    }
}
