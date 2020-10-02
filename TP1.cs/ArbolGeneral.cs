using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TP1
{
	public class ArbolGeneral<T>
	{
		
		private NodoGeneral<T> raiz;

		public ArbolGeneral(T dato) {
			this.raiz = new NodoGeneral<T>(dato);
		}
	
		private ArbolGeneral(NodoGeneral<T> nodo) {
			this.raiz = nodo;
		}
	
		private NodoGeneral<T> getRaiz() {
			return raiz;
		}
	
		public T getDatoRaiz() {
			return this.getRaiz().getDato();
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			List<ArbolGeneral<T>> temp= new List<ArbolGeneral<T>>();
			foreach (var element in this.raiz.getHijos()) {
				temp.Add(new ArbolGeneral<T>(element));
			}
			return temp;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Add(hijo.getRaiz());
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.raiz.getHijos().Remove(hijo.getRaiz());
		}
	
		public bool esVacio() {
			return this.raiz == null;
		}
	
		public bool esHoja() {
			return this.raiz != null && this.getHijos().Count == 0;
		}

		public void preorden()
        {
			Console.WriteLine(this.getDatoRaiz());
            foreach (ArbolGeneral<T> hijo in this.getHijos())
            {

            }
        }

		public void inOrden()
        {

        }

		public void postOrden()
        {

        }

		public void porNiveles()
        {
			Cola<ArbolGeneral<T>> cola = new Cola<ArbolGeneral<T>>(); //
			ArbolGeneral<T> arbolA;

			cola.encolar(this);

            while (!cola.esVacia())
            {
				arbolA = cola.desencolar();
				Console.WriteLine(arbolA.getDatoRaiz());
                if (!arbolA.esHoja())
                {
					cola.encolar(arbolA);
                }
            }
        }
//EJERCICIO 4A	
		public int altura() {
			int contA=-1;//contador de altura

			/* PRUEBA
			int dato =1;
			if (this.getDatoRaiz().Equals(dato))
            {
				Console.WriteLine(dato);
            }*/
			if (this.esHoja()==true)
			{
				return contA + 1;           }
			else
			{
				foreach(var element in this.getHijos())
				{
					if (element.altura()>contA)
					{
						contA = element.altura();
					}
					element.altura();
					
				}
				contA++;             
			}
			return contA++;
		}
	
//EJERCICIO 4B		
		public int nivel(T dato) {
			int contA = -1;
			if (this.raiz.getDato().Equals(dato))
			{
				return contA+1;
			}
			else
			{
				foreach (var element in this.getHijos())
				{
					if (element.nivel(dato) > contA)
						contA = element.nivel(dato);
					element.nivel(dato);
				}
				contA++;
			}
			return contA;
		}

//EJERCICIO 4C
		
		public int ancho()
		{
            //Cola<ArbolGeneral<T>> c = new Cola<ArbolGeneral<T>>(); //instanciamos cola

            if (this.esHoja())
            {
				return 1; // si es hoja, ancho = 1
            }

			Queue<ArbolGeneral<T>> cola = new Queue<ArbolGeneral<T>>();
			cola.Enqueue(this); //encolamos arbol
			int maxCantidadNivel = 0;
            while (cola.Count != 0) //mientras la cola no este vacia
            {
				int cantidadNiveles = cola.Count;
				if(cantidadNiveles > maxCantidadNivel)
                {
					maxCantidadNivel = cantidadNiveles;
                }
                while (cantidadNiveles-- >0)
                {
					ArbolGeneral<T> arbol = cola.Dequeue();
                    foreach (ArbolGeneral<T> hijo in arbol.getHijos())
                    {
						cola.Enqueue(hijo);
                    }
                }
			}
			
			return maxCantidadNivel;
		}
	}
}
