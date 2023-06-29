using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Data;
using System;

namespace Proyecto
{
    public class ListaDoblementeEnlazada<T>
    {
        private Nodo<T> cabeza;
        private Nodo<T> cola;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public ListaDoblementeEnlazada()
        {
            cabeza = null;
            cola = null;
            count = 0;
        }

        public void AddLast(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                cola.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = cola;
                cola = nuevoNodo;
            }

            count++;
        }

        public IEnumerable<T> GetEnumerator()
        {
            Nodo<T> nodoActual = cabeza;

            while (nodoActual != null)
            {
                yield return nodoActual.Valor;
                nodoActual = nodoActual.Siguiente;
            }
        }
    }
}