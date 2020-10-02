using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TP2
{
	class PruebaAB
	{
		public static void Main(string[] args)
		{
			ArbolBinario<int> arbolBinarioA = new ArbolBinario<int>(1);

			ArbolBinario<int> hijoIzquierdo=new ArbolBinario<int>(2);
			hijoIzquierdo.agregarHijoIzquierdo(new ArbolBinario<int>(3));
			hijoIzquierdo.agregarHijoDerecho(new ArbolBinario<int>(4));
			
			ArbolBinario<int> hijoDerecho=new ArbolBinario<int>(5);
			hijoDerecho.agregarHijoIzquierdo(new ArbolBinario<int>(6));
			hijoDerecho.agregarHijoDerecho(new ArbolBinario<int>(7));
			
			arbolBinarioA.agregarHijoIzquierdo(hijoIzquierdo);
            arbolBinarioA.agregarHijoDerecho(hijoDerecho);

			//arbolBinarioA.preorden();
			//arbolBinarioA.inorden();
			//arbolBinarioA.postorden();
			//arbolBinarioA.recorridoPorNiveles();
			arbolBinarioA.recorridoEntreNiveles(1,2);
			Console.Write("Presione una tecla para concluir la ejecucion . . . ");
			Console.ReadKey(true);
		}
	}
}