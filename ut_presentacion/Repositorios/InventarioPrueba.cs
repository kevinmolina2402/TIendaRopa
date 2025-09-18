using lib_dominio.Entidades;
using lib_repositorio.Interfaces;
using lib_repositorio.Implementaciones;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class InventarioPrueba
    {
        private readonly IConexion? iConexion;
        private List<Inventario>? lista;
        private Inventario? entidad;

        public InventarioPrueba()
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
            this.lista = this.iConexion!.Inventario!
                .Include(x => x._Producto)
                .Include(x => x._Talla)
                .Include(x => x._Color)

                .ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Inventario()!;

            this.iConexion!.Inventario!.Add(this.entidad);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Cantidad = 2;

            var entry = this.iConexion!.Entry<Inventario>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.Inventario!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}