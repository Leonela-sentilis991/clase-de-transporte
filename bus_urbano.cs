using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporte
{
    public class Bus_urbano : transporte
    {
        public string corredor { get; set; }
        public void Operar()
        {
            string Corredor = "A";

            if (corredor == "a" || corredor == "b" || corredor == "c" || corredor == "A" || corredor == "B" || corredor == "C")
            {
                Console.WriteLine("35");
            }
            else
            {
                Console.WriteLine("no se ha encontrado un corredor con ese nombre");
            }
        }
    }
}
