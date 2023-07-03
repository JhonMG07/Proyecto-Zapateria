using System.Data;

namespace Proyecto
{
    public class Nodo
    {
        public int id_zapato;
        public Nodo siguiente;
        public Nodo anterior;

        public Nodo(int id_zapato)
        {
            this.id_zapato = id_zapato;
            this.siguiente = null;
            this.anterior = null;
        }
    }
}