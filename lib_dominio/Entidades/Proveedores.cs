namespace lib_dominio.Entidades
{
    public class Proveedores
    {
        public int Id { get; set; }
        public string? RUT { get; set; }

        public string? Nombre_Empresa { get; set; }
        public string? Nombre_Contacto { get; set; }
        public int Telefono { get; set; }

        public string? Direccion { get; set; }
        public string? Email { get; set; }
    }
}