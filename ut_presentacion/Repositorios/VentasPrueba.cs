using lib_dominio.Entidades;
using lib_repositorio.Interfaces;
using lib_repositorio.Implementaciones;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class VentasPrueba
    {
        private readonly IConexion? iConexion;
        private List<Ventas>? lista;
        private Ventas? entidad;

        public VentasPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.AreEqual(true, Guardar());
            Assert.AreEqual(true, Modificar());
            Assert.AreEqual(true, Listar());
            Assert.AreEqual(true, Borrar());
        }

        public bool Listar()
        {
            this.lista = this.iConexion!.Ventas!
                .Include(x => x._Cliente)
                .Include(x => x._Empleado)
                .ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Ventas()!;

            this.iConexion!.Ventas!.Add(this.entidad);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Total = 15.0m;

            var entry = this.iConexion!.Entry<Ventas>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Ventas!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}