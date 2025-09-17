using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Compras
    {
        public int Id { get; set; }
        public int Proveedor { get; set; }
        public int Empleado { get; set; }

        public DateTime Fecha_Compra { get; set; }
        public decimal Total { get; set; }
        public decimal Impuestos { get; set; }

        [ForeignKey("Proveedor")] public Proveedores? _Proveedor { get; set; }
        [ForeignKey("Empleado")] public Empleados? _Empleado { get; set; }

    }
}