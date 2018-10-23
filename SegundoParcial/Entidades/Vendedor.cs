using System;
using System.ComponentModel.DataAnnotations;

namespace SegundoParcial.Entidades
{
    public class Vendedor
    {
        [Key]
        public int IDVendedor { get; set; }
        public string Nombre { get; set; }
        public float Sueldo { get; set; }
        public float Retecion {get; set;}
        public float Total { get; set; }
        public DateTime Fecha { get; set; }
        public float Retencion { get; internal set; }

        public Vendedor()
        {
            IDVendedor = 0;
            Nombre = string.Empty;
            Sueldo = 0;
            Retecion = 0;
            Total = 0;
            Fecha = DateTime.Now;
        }

    }
}
