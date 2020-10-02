using System;
using System.Collections.Generic;

namespace TP1
{
	/// <summary>
	/// Description of NodoGeneral.
	/// </summary>
	public class NodoGeneral<T>
	{
		private T dato;
		private List<NodoGeneral<T>> hijos;
		
		public NodoGeneral(T dato){		
			this.dato = dato;
			this.hijos = new List<NodoGeneral<T>>();
		}
	
		public T getDato(){		
			return this.dato; 
		}
		
		public List<NodoGeneral<T>> getHijos(){		
			return this.hijos;
		}

		public void setDato(T dato){		
			this.dato = dato;
		}
		
		public void setHijos(List<NodoGeneral<T>> hijos){		
			this.hijos = hijos;
		}
	
	}
}
