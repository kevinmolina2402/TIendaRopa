using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IInventarioAplicacion
    {
        void Configurar(string StringConexion);
        List<Inventario> Listar();
        Inventario? Guardar(Inventario? entidad);
        Inventario? Modificar(Inventario? entidad);
        Inventario? Borrar(Inventario? entidad);
    }
}