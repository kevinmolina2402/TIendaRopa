using lib_dominio.Entidades;

namespace lib_repositorio.Interfaces
{
    public interface IColoresAplicacion
    {
        void Configurar(string StringConexion);
        List<Colores> Listar();
        Colores? Guardar(Colores? entidad);
        Colores? Modificar(Colores? entidad);
        Colores? Borrar(Colores? entidad);
    }
}