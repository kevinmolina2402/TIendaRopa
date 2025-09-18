//using lib_dominio.Entidades;
//using lib_repositorio.Interfaces;
//using lib_repositorio.Implementaciones;
//using Microsoft.EntityFrameworkCore;
//using ut_presentacion.Nucleo;

//namespace ut_presentacion.Repositorios
//{
//    [TestClass]
//    public class DevolucionesPrueba
//    {
//        private readonly IConexion? iConexion;
//        private List<Devoluciones>? lista;
//        private Devoluciones? entidad;

//        public DevolucionesPrueba()
//        {
//            iConexion = new Conexion();
//            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
//        }

//        [TestMethod]
//        public void Ejecutar()
//        {
//            Assert.AreEqual(true, Guardar());
//            Assert.AreEqual(true, Modificar());
//            Assert.AreEqual(true, Listar());
//            Assert.AreEqual(true, Borrar());
//        }

//        public bool Listar()
//        {
//            this.lista = this.iConexion!.Devoluciones!.ToList();
//            return lista.Count > 0;
//        }

//        public bool Guardar()
//        {
//            this.entidad = EntidadesNucleo.Devoluciones()!;

//            this.iConexion!.Devoluciones!.Add(this.entidad);
//            this.iConexion!.SaveChanges();

//            return true;
//        }

//        public bool Modificar()
//        {
//            this.entidad!.Cantidad = 2;

//            var entry = this.iConexion!.Entry<Devoluciones>(this.entidad);
//            entry.State = EntityState.Modified;
//            this.iConexion!.SaveChanges();

//            return true;
//        }

//        public bool Borrar()
//        {
//            this.iConexion!.Devoluciones!.Remove(this.entidad!);
//            this.iConexion!.SaveChanges();
//            return true;
//        }
//    }
//}