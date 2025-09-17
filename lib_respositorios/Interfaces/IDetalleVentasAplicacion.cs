using lib_dominio.Entidades;

namespace lib_repositorio.Interfaces
{
    public interface IDetalleVentasAplicacion
    {
        void Configurar(string StringConexion);
        List<DetalleVentas> Listar();
        DetalleVentas? Guardar(DetalleVentas? entidad);
        DetalleVentas? Modificar(DetalleVentas? entidad);
        DetalleVentas? Borrar(DetalleVentas? entidad);
    }
}