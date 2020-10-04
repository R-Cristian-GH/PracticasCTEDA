using System;

namespace tp3
{

	public class ArbolBinarioBusqueda : IComparable
	{
		
		private IComparable dato;
		private IComparable raiz;
		private ArbolBinarioBusqueda hijoIzquierdo;
		private ArbolBinarioBusqueda hijoDerecho;
        

        public ArbolBinarioBusqueda(IComparable dato){
			this.dato = dato;
			//this.raiz = this.dato;
		}
		
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public ArbolBinarioBusqueda getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public ArbolBinarioBusqueda getHijoDerecho(){
			return this.hijoDerecho;
		}
		
		public void agregarHijoIzquierdo(ArbolBinarioBusqueda hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(ArbolBinarioBusqueda hijo){
			this.hijoDerecho=hijo;
		}
		
		public void eliminarHijoIzquierdo(){
			this.hijoIzquierdo=null;
		}
		
		public void eliminarHijoDerecho(){
			this.hijoDerecho=null;
		}

		public bool esVacio()
		{
			return this.raiz == null;
		}

		public bool esHoja()
		{
			return this.raiz != null && this.getHijoIzquierdo()==null && this.getHijoDerecho()==null;
		}

		public void agregar(IComparable elem)
		{
            switch (elem.CompareTo(this.getDatoRaiz()))//comparo el elemto a agregar(elemto B) con el elemento raiz(elemento A)
            {                                          //el CompareTo me devuelve mayor a cero en caso de que el elemento B sea mayor
				                                       //menor a cero en caso de que sea menor, cero en caso de que sea igual a el elemento A
				case 1:       //en caso de que el elemto a agregar sea mayor a la raiz
                    if (hijoDerecho==null)
					{
						agregarHijoDerecho(new ArbolBinarioBusqueda(elem));
						Console.WriteLine("padre: " + this.getDatoRaiz().ToString() + " ; hijo derecho: " + getHijoDerecho().getDatoRaiz().ToString());
					}
                    else
                    {
						hijoDerecho.agregar(elem);
                    }
					
					break;
				case -1:      //en caso de que el elemento a agregar sea menor a la raiz
					if (hijoIzquierdo == null)
					{
						agregarHijoIzquierdo(new ArbolBinarioBusqueda(elem));
						Console.WriteLine("padre: " + this.getDatoRaiz().ToString() + " ; hijo izquierdo: " + getHijoIzquierdo().getDatoRaiz().ToString());
					}
					else
					{
						hijoIzquierdo.agregar(elem);
					}
					break;
				default:
						break;
			}
		}
		
		public bool incluye(IComparable elem)
		{
			bool resul = false;
			switch (elem.CompareTo(this.getDatoRaiz()))//comparo el elemto a agregar(elemto B) con el elemento raiz(elemento A)
			{                                          //el CompareTo me devuelve mayor a cero en caso de que el elemento B sea mayor
													   //menor a cero en caso de que sea menor, cero en caso de que sea igual a el elemento A
				case 1:
					{
						hijoDerecho.incluye(elem);
						break;
					}
				case -1:
                    {
						hijoIzquierdo.incluye(elem);
						break;
                    }
				case 0:       //en caso de que el elemto a agregar ya este en el arbol
					{
						Console.WriteLine("el elemento: "+ elem + ", elemento ya se encuentra en el arbol");
						Console.WriteLine("por favor ingrese otro elemento");
						resul = true;
						break;
					}

				default:    
					break;
			}
			return resul;
		}


		public void preorden() 
		{
            if (this!=null)
            {
				Console.WriteLine(this.getDatoRaiz().ToString());
				if(this.getHijoIzquierdo()!=null)
					this.getHijoIzquierdo().preorden();
				if(this.getHijoDerecho()!=null)
					this.getHijoDerecho().preorden();
            }
		}
		
		public void inorden() 
		{
			if (this != null)
			{
				if (this.getHijoIzquierdo() != null) 
				{ 
					this.getHijoIzquierdo().preorden();
					
				}
				Console.WriteLine(this.getDatoRaiz().ToString());
				if (this.getHijoDerecho() != null)
                {
					this.getHijoDerecho().preorden();
                }
					
			}
		}
		
		public void postorden() {
			//llamada recursiva en hijo izquierdo
			if (!this.getHijoIzquierdo().esVacio())
				this.getHijoIzquierdo().postorden();
			{

			}
			//llamada recursiva en hijo derecho
			if (!this.getHijoDerecho().esVacio())
			{
				this.getHijoDerecho().postorden();
			}
			//por ultimo procesamos la raiz
			Console.WriteLine(this.getDatoRaiz());
		}

        public int CompareTo(object obj)
        {
            return raiz.CompareTo(obj);
        }
    }
}