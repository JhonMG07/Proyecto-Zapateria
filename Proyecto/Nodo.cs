﻿using System.Data;

namespace Proyecto
{
    class Nodo<T>
    {
        public T Valor { get; set; }
        public Nodo<T> Siguiente { get; set; }
        public Nodo<T> Anterior { get; set; }

        public Nodo(T valor)
        {
            Valor = valor;
            Siguiente = null;
            Anterior = null;
        }
    }
}