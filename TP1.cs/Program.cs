using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral<int> arbol = new ArbolGeneral<int>(10);
            ArbolGeneral<int> hijo1 = new ArbolGeneral<int>(20);
            ArbolGeneral<int> hijo2 = new ArbolGeneral<int>(30);
            ArbolGeneral<int> hijo3 = new ArbolGeneral<int>(40);
            ArbolGeneral<int> hijo4 = new ArbolGeneral<int>(50);
            ArbolGeneral<int> hijo5 = new ArbolGeneral<int>(60);

            //arbol.agregarHijo(hijo3);
            //arbol.agregarHijo(hijo4);
            //arbol.agregarHijo(hijo5);

            hijo3.agregarHijo(hijo4);
            //hijo1.agregarHijo(hijo3);
            hijo1.agregarHijo(hijo3);
            arbol.agregarHijo(hijo1);
            arbol.agregarHijo(hijo2);

            Console.WriteLine(arbol.altura());
            //Console.WriteLine(arbol.nivel(40));
            //Console.WriteLine(arbol.ancho());
            //arbol.porNiveles();
            Console.WriteLine("press enter");
            Console.ReadLine();
        }
    }
}
