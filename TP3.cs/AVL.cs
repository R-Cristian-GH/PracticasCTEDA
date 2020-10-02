using System;

namespace tp3
{

	public class AVL{
		
		private IComparable dato;
		private AVL hijoIzquierdo;
		private AVL hijoDerecho;
		private int altura;
		
		public AVL(IComparable dato){
			this.dato = dato;
		}
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public AVL getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public AVL getHijoDerecho(){
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(AVL hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(AVL hijo){
			this.hijoDerecho=hijo;
		}
		
		public void eliminarHijoIzquierdo(){
			this.hijoIzquierdo=null;
		}
		
		public void eliminarHijoDerecho(){
			this.hijoDerecho=null;
		}
		
		public void agregar(IComparable elem) {
		}
		

		public void rotacionSimpleDerecha() {
			
		}
		
		public void rotacionSimpleIzquierda() {
		
		}
		
		public void rotacionDobleDerecha() {
		
		}
		
				
		public void rotacionDobleIzquierda() {
		
		}
		
		
	}
}