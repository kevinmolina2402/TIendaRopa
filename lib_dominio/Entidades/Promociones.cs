namespace lib_dominio.Entidades
{
    public class Promociones
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }

        public string? Descripcion { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Valor_Descuento { get; set; }

        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
    }    
}