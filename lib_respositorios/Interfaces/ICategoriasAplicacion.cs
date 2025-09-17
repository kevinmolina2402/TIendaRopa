using lib_dominio.Entidades;

namespace lib_repositorio.Interfaces
{
    public interface ICategoriasAplicacion
    {
        void Configurar(string StringConexion);
        List<Categorias> Listar();
        Categorias? Guardar(Categorias? entidad);
        Categorias? Modificar(Categorias? entidad);
        Categorias? Borrar(Categorias? entidad);
    }
}