using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Productos
    {
        public int Id { get; set; }
        public int Marca { get; set; }
        public int Categoria { get; set; }


        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Venta { get; set; }

        [ForeignKey("Marca")] public Marcas? _Marca { get; set; }
        [ForeignKey("Categoria")] public Categorias? _Categoria { get; set; }


    }
}