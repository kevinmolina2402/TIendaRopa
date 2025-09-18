using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class DetalleVentas
    {
        public int Id { get; set; }
        public int Venta { get; set; }
        public int Producto { get; set; }
        public int Talla { get; set; }
        public int Color { get; set; }
        public int Promocion { get; set; }



        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }


        [ForeignKey("Venta")] public Ventas? _Venta { get; set; }
        [ForeignKey("Producto")] public Productos? _Producto { get; set; }
        [ForeignKey("Talla")] public Tallas? _Talla { get; set; }
        [ForeignKey("Color")] public Colores? _Color { get; set; }
        [ForeignKey("Promocion")] public Promociones? _Promocion { get; set; }


    }
}