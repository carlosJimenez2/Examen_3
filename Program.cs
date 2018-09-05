using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            Figura F1 = new Figura();
            Figura F2 = new Figura();
            double Resultado;

                Console.WriteLine("Elije una figura \n1) Rectangulo \n2) Triangulo\n3) Circulo ");
                menu = 0;

            if (menu == 0)
            {
                menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {

                    case 1:
                        Console.WriteLine("Seleccionaste el rectangulo. ingresa su base y altura");
                        Rectangulo cuadrado = new Rectangulo();
                        F2 = cuadrado;
                        cuadrado.CalcularArea();
                        break;
                    case 2:
                        Console.WriteLine("Seleccionaste el triangulo. ingresa su base y altura");
                        Triangulo triangulo = new Triangulo();
                        F2 = triangulo;
                        triangulo.CalcularArea();
                        break;
                    case 3:
                        Console.WriteLine("Seleccionaste el circulo. ingresa su radio");
                        Circulo circulo = new Circulo();
                        circulo.CalcularArea();
                        F2 = circulo;
                        break;


                }


                Console.WriteLine("Elije una figura \n1) Rectangulo \n2) Triangulo\n3) Circulo ");
            }

            else;
                {
                    menu = 0;
               
                
                    menu = Convert.ToInt16(Console.ReadLine());
                    switch (menu)
                    {

                        case 1:
                            Console.WriteLine("Seleccionaste el rectangulo. ingresa su base y altura");
                            Rectangulo cuadrado = new Rectangulo();
                            cuadrado.CalcularArea();
                            F1 = cuadrado;
                            break;
                        case 2:
                            Console.WriteLine("Seleccionaste el triangulo. ingresa su base y altura");
                            Triangulo triangulo = new Triangulo();
                            triangulo.CalcularArea();
                            F1 = triangulo;
                            break;
                        case 3:
                            Console.WriteLine("Seleccionaste el circulo. ingresa su radio");
                            Circulo circulo = new Circulo();
                            F1 = circulo;
                            circulo.CalcularArea();
                            break;


                    }

                } 

                Resultado = F1 + F2; 
                Console.WriteLine("La Suma de las áreas es " + Resultado); 
                Console.ReadKey();
            
        }
    }
}