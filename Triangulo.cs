using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3
{
    class Triangulo : Figura
    {
        public Triangulo()
        {
            Console.WriteLine("Ingresa el valor de la base");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la altura");
            z = Convert.ToDouble(Console.ReadLine());

        }

        public void CalcularArea()
        {
            Area = (y * z) / 2;
            Console.WriteLine("El area es = " + Area);

        }
    }
}