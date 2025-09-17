using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Ventas
    {
        public int Id { get; set; }
        public int Cliente { get; set; }
        public int Empleado { get; set; }

        public DateTime Fecha_Venta { get; set; }
        public decimal Total { get; set; }
        public decimal Impuestos { get; set; }

        [ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
        [ForeignKey("Empleado")] public Empleados? _Empleado { get; set; }

    }
}