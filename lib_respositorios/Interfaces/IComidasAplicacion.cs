using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IComidasAplicacion
    {
        void Configurar(string StringConexion);
        List<Comidas> Listar();
        Comidas? Guardar(Comidas? entidad);
        Comidas? Modificar(Comidas? entidad);
        Comidas? Borrar(Comidas? entidad);
    }
}