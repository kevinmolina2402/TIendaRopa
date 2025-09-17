using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Devoluciones
    {
        public int Id { get; set; }
        public int Venta { get; set; }
        public int Producto { get; set; }
        public int Talla { get; set; }
        public int Color { get; set; }


        public int Cantidad { get; set; }
        public string? Motivo { get; set; }

        public DateTime Fecha_Devolucion { get; set; }



        [ForeignKey("Venta")] public Ventas? _Venta { get; set; }
        [ForeignKey("Producto")] public Productos? _Producto { get; set; }
        [ForeignKey("Talla")] public Tallas? _Talla { get; set; }
        [ForeignKey("Color")] public Colores? _Color { get; set; }


    }    
}