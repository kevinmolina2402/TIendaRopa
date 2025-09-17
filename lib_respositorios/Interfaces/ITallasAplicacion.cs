using lib_dominio.Entidades;

namespace lib_repositorio.Interfaces
{
    public interface ITallasAplicacion
    {
        void Configurar(string StringConexion);
        List<Tallas> Listar();
        Tallas? Guardar(Tallas? entidad);
        Tallas? Modificar(Tallas? entidad);
        Tallas? Borrar(Tallas? entidad);
    }
}