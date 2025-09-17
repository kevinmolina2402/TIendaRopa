using lib_dominio.Entidades;

namespace lib_repositorio.Interfaces
{
    public interface IDevolucionesAplicacion
    {
        void Configurar(string StringConexion);
        List<Devoluciones> Listar();
        Devoluciones? Guardar(Devoluciones? entidad);
        Devoluciones? Modificar(Devoluciones? entidad);
        Devoluciones? Borrar(Devoluciones? entidad);
    }
}