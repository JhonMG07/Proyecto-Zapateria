using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Zapato
    {
        [Key]
        public int Id_zapato { get; set; }

        public string Tipo { get; set; }

        public int Talla { get; set; }

        public float Precio { get; set; }
        public string Descripcion { get; set; }
        public string Genero { get; set; }

        public Zapato(int id, string tipo, int talla, float precio, string descripcion, string genero)
        {
            Id_zapato = id;
            Tipo = tipo;
            Talla = talla;
            Precio = precio;
            Descripcion = descripcion;
            Genero = genero;
        }
    }
  

        
    
}
