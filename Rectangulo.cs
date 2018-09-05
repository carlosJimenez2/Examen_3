using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3
{
    class Rectangulo : Figura
    {
        public Rectangulo()

        {

            Console.WriteLine("Ingresa el valor de la Base");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de la Altura");
            z = Convert.ToDouble(Console.ReadLine());


        }

        public void CalcularArea()
        {
            Area = y * z;
            Console.WriteLine("El area es = " + Area);


        }
    }
}