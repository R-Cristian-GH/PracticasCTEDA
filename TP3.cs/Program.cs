using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp3;

namespace TP3.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda(25);

            arbol.agregar(13);          
            arbol.agregar(27);
        
            arbol.agregar(11);    
            arbol.agregar(15);
            arbol.agregar(36);
            arbol.agregar(85);
            arbol.agregar(5);
            arbol.agregar(1);
            arbol.agregar(45);
            
            arbol.agregar(20);

            //arbol.incluye(13);

            //arbol.preorden();
            arbol.inorden();

            Console.ReadLine();
        
        }
    }
}
