using System.ComponentModel.DataAnnotations.Schema;
using lib_dominio.Entidades;

namespace lib_dominio.Entidades
{


    public class Empleados
    {      
      public int Id { get; set; }
        public string? Cedula { get; set; }

        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }

        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public int Puesto { get; set; }

        [ForeignKey("Puesto")] public Puestos? _Puesto { get; set; }
        public DateTime Fecha_Contratacion { get; set; }
    }
}








