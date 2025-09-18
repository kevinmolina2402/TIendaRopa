//using lib_dominio.Entidades;
//using lib_repositorio.Interfaces;
//using lib_repositorio.Implementaciones;
//using Microsoft.EntityFrameworkCore;
//using ut_presentacion.Nucleo;

//namespace ut_presentacion.Repositorios
//{
//    [TestClass]
//    public class ComprasPrueba
//    {
//        private readonly IConexion? iConexion;
//        private List<Compras>? lista;
//        private Compras? entidad;

//        public ComprasPrueba()
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
//            this.lista = this.iConexion!.Compras!.ToList();
//            return lista.Count > 0;
//        }

//        public bool Guardar()
//        {
//            this.entidad = EntidadesNucleo.Compras()!;

//            this.iConexion!.Compras!.Add(this.entidad);
//            this.iConexion!.SaveChanges();

//            return true;
//        }

//        public bool Modificar()
//        {
//            this.entidad!.Total = 1.5m;

//            var entry = this.iConexion!.Entry<Compras>(this.entidad);
//            entry.State = EntityState.Modified;
//            this.iConexion!.SaveChanges();

//            return true;
//        }

//        public bool Borrar()
//        {
//            this.iConexion!.Compras!.Remove(this.entidad!);
//            this.iConexion!.SaveChanges();
//            return true;
//        }
//    }
//}