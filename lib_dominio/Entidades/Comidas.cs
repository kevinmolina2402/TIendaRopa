namespace lib_dominio.Entidades
{
    public class Comidas
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime Tiempo { get; set; }
        public string? Calorias { get; set; }
        public string? Pais { get; set; }
        public decimal Precio { get; set; }
    }
}