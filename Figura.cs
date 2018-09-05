using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3
{
    class Figura
    {
        protected double x;
        protected double z;
        protected double y;
        protected double area;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        public double Area { get => area; set => area = value; }

        public static double operator +(Figura F1,  Figura F2)
        {
            return F1.area + F2.area;
        }
        public static double operator -(Figura F1, Figura F2)
        {
            return F1.area + F2.area;
        }
    }
}