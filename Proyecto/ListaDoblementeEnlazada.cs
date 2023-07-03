using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Data;
using System;

namespace Proyecto
{
    public class ListaDoblementeEnlazada
    {
        public Nodo primero;
        public Nodo ultimo;

        public ListaDoblementeEnlazada()
        {
            this.primero = null;
            this.ultimo = null;
        }
        //Agregar el último nodo a la lista
        public void agregarUltimoDato(int id_zapato)
        {
            Nodo nuevoNodo = new Nodo(id_zapato);
            if (primero == null)
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo;
            }
            else
            {
                ultimo.siguiente = nuevoNodo;
                nuevoNodo.anterior = ultimo;
                ultimo = nuevoNodo;
            }
        }
        public Nodo obtenerNodoPorId(int id_zapato)
        {
            Nodo nodoActual = primero;
            while (nodoActual != null)
            {
                if (nodoActual.id_zapato == id_zapato)
                {
                    return nodoActual;
                }
                nodoActual = nodoActual.siguiente;
            }
            return null;
        }
    }
}