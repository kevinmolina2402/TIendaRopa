using lib_dominio.Entidades;

namespace lib_repositorio.Interfaces
{
    public interface IPuestosAplicacion
    {
        void Configurar(string StringConexion);
        List<Puestos> Listar();
        Puestos? Guardar(Puestos? entidad);
        Puestos? Modificar(Puestos? entidad);
        Puestos? Borrar(Puestos? entidad);
    }
}