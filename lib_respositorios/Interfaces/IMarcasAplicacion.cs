using lib_dominio.Entidades;

namespace lib_repositorio.Interfaces
{
    public interface IMarcasAplicacion
    {
        void Configurar(string StringConexion);
        List<Marcas> Listar();
        Marcas? Guardar(Marcas? entidad);
        Marcas? Modificar(Marcas? entidad);
        Marcas? Borrar(Marcas? entidad);
    }
}