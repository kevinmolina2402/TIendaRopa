using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Inventario
    {
        public int Id { get; set; }
        public int Producto { get; set; }
        public int Talla { get; set; }
        public int Color { get; set; }
        public int Cantidad { get; set; }

        [ForeignKey("Producto")] public Productos? _Producto { get; set; }
        [ForeignKey("Talla")] public Tallas? _Talla { get; set; }
        [ForeignKey("Color")] public Colores? _Color { get; set; }





    }
}