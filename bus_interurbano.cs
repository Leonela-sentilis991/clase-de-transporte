using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte
{

    public class Businterurbano : transporte
    {
        public string destino { get; set; }
        public string compañia { get; set; }


        public void imprimir()
        {
            Console.WriteLine("El destino es: " + destino);
            Console.WriteLine();
            Console.WriteLine("La compañia es: " + compañia);
            Console.WriteLine();
            Console.WriteLine("El costo es: " + costo);
            Console.WriteLine();


        }
    }
}

