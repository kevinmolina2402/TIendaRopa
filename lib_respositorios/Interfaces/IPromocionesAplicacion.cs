using lib_dominio.Entidades;

namespace lib_repositorio.Interfaces
{
    public interface IPromocionesAplicacion
    {
        void Configurar(string StringConexion);
        List<Promociones> Listar();
        Promociones? Guardar(Promociones? entidad);
        Promociones? Modificar(Promociones? entidad);
        Promociones? Borrar(Promociones? entidad);
    }
}