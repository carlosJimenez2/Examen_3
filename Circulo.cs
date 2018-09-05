using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3
{
    class Circulo : Figura
    {
        public Circulo()
        {
            Console.WriteLine("Ingresa el valor del radio");
            x = Convert.ToDouble(Console.ReadLine());
        }

        public void CalcularArea()
        {
            Area = 3.1416 * (x * x);
            Console.WriteLine("El area es = " + Area);
        }
    }
}