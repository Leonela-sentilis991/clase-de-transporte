using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte
{
    public class metro : transporte
    {
        public string compañia { get; set; }
        public string linea { get; set; }

        public void imprimir()
        {

            Console.WriteLine("La compañia es: " + compañia);
            Console.WriteLine();
            Console.WriteLine("La linea es: " + linea);
            Console.WriteLine();
            Console.WriteLine("El costo es: " + costo);
            Console.WriteLine();


        }
    }
}
