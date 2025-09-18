//using lib_dominio.Entidades;
//using lib_repositorio.Interfaces;
//using lib_repositorio.Implementaciones;
//using Microsoft.EntityFrameworkCore;
//using ut_presentacion.Nucleo;

//namespace ut_presentacion.Repositorios
//{
//    [TestClass]
//    public class ColoresPrueba
//    {
//        private readonly IConexion? iConexion;
//        private List<Colores>? lista;
//        private Colores? entidad;

//        public ColoresPrueba()
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
//            this.lista = this.iConexion!.Colores!.ToList();
//            return lista.Count > 0;
//        }

//        public bool Guardar()
//        {
//            this.entidad = EntidadesNucleo.Colores()!;

//            this.iConexion!.Colores!.Add(this.entidad);
//            this.iConexion!.SaveChanges();

//            return true;
//        }

//        public bool Modificar()
//        {
//            this.entidad!.Nombre = "Test";

//            var entry = this.iConexion!.Entry<Colores>(this.entidad);
//            entry.State = EntityState.Modified;
//            this.iConexion!.SaveChanges();

//            return true;
//        }

//        public bool Borrar()
//        {
//            this.iConexion!.Colores!.Remove(this.entidad!);
//            this.iConexion!.SaveChanges();
//            return true;
//        }
//    }
//}