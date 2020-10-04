using System;

namespace TP2
{
	public class ArbolBinario<T>
	{
		
		private NodoBinario<T> raiz;

		public ArbolBinario(T dato) {
			this.raiz = new NodoBinario<T>(dato);
		}
	
		private ArbolBinario(NodoBinario<T> nodo) {
			this.raiz = nodo;
		}
	
		private NodoBinario<T> getRaiz() {
			return raiz;
		}
	
		public T getDatoRaiz() {
			return this.getRaiz().getDato();
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return new ArbolBinario<T>(this.raiz.getHijoIzquierdo());
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return new ArbolBinario<T>(this.raiz.getHijoDerecho());
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.raiz.setHijoIzquierdo(hijo.getRaiz());
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.raiz.setHijoDerecho(hijo.getRaiz());
		}
	
		public void eliminarHijoIzquierdo() {
			this.raiz.setHijoIzquierdo(null);
		}
	
		public void eliminarHijoDerecho() {
			this.raiz.setHijoDerecho(null);
		}
	
		public bool esVacio() {
			return this.raiz == null;
		}
	
		public bool esHoja() {
			return this.raiz != null && this.getHijoIzquierdo().esVacio() && this.getHijoDerecho().esVacio();
		}
		
		public void inorden() {

            //llamada recursiva en hijo izquierdo
            if (!this.getHijoIzquierdo().esVacio())
            {
                this.getHijoIzquierdo().inorden();
            }
            //primero procesamos la raiz
            Console.WriteLine(this.getDatoRaiz());

            //llamada recursiva en hijo derecho
            if (!this.getHijoDerecho().esVacio())
            {
                this.getHijoDerecho().inorden();
            }
        }
		
		public void preorden() {
            if (!this.esVacio())
            {
                //primero procesamos la raiz
                Console.WriteLine(this.getDatoRaiz());
                //llamada recursiva en hijo izquierdo
                if (!this.getHijoIzquierdo().esVacio()) 
                { 
                    this.getHijoIzquierdo().preorden();
                }
                //llamada recursiva en hijo derecho
                if (!this.getHijoDerecho().esVacio())
                {
                    this.getHijoDerecho().preorden();
                }
            }
		}
		
		public void postorden() {

            //llamada recursiva en hijo izquierdo
            if (!this.getHijoIzquierdo().esVacio())
            {
                this.getHijoIzquierdo().postorden();
            }
            //llamada recursiva en hijo derecho
            if (!this.getHijoDerecho().esVacio())
            {
                this.getHijoDerecho().postorden();
            } 
            //por ultimo procesamos la raiz
            Console.WriteLine(this.getDatoRaiz());
        }
		
		public void recorridoPorNiveles() {
            Cola<ArbolBinario<T>> c= new Cola<ArbolBinario<T>>();
            ArbolBinario<T> arbolAux;
            c.encolar(this);
            while (!c.esVacia())
            {
                arbolAux = c.desencolar();
                Console.WriteLine(arbolAux.getDatoRaiz());
                if (!arbolAux.getHijoIzquierdo().esVacio())
                    c.encolar(arbolAux.getHijoIzquierdo());
                if (!arbolAux.getHijoDerecho().esVacio())
                    c.encolar(arbolAux.getHijoDerecho());
            }
		}
	
		public int contarHojas() {
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
            Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
            ArbolBinario<T> arbolAux;
            int contNivel = 0;

            c.encolar(this);
            c.encolar(null);

            while (!c.esVacia())
            {
                arbolAux = c.desencolar();
                if (arbolAux!=null)
                {
                    if (contNivel>=n && contNivel<=m)
                        Console.WriteLine(arbolAux.getDatoRaiz());                    
                    if (!arbolAux.getHijoIzquierdo().esVacio())
                        c.encolar(arbolAux.getHijoIzquierdo());
                    if (!arbolAux.getHijoDerecho().esVacio())
                        c.encolar(arbolAux.getHijoDerecho());
                }

                else
                {
                    contNivel++;
                    if(!c.esVacia())
                        c.encolar(null);
                }
            }
        }
	}
}
