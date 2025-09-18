//using lib_dominio.Entidades;
//using lib_repositorio.Interfaces;
//using lib_repositorio.Implementaciones;
//using Microsoft.EntityFrameworkCore;
//using ut_presentacion.Nucleo;

//namespace ut_presentacion.Repositorios
//{
//    [TestClass]
//    public class TallasPrueba
//    {
//        private readonly IConexion? iConexion;
//        private List<Tallas>? lista;
//        private Tallas? entidad;

//        public TallasPrueba()
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
//            this.lista = this.iConexion!.Tallas!.ToList();
//            return lista.Count > 0;
//        }

//        public bool Guardar()
//        {
//            this.entidad = EntidadesNucleo.Tallas()!;

//            this.iConexion!.Tallas!.Add(this.entidad);
//            this.iConexion!.SaveChanges();

//            return true;
//        }

//        public bool Modificar()
//        {
//            this.entidad!.Descripcion = "Test";

//            var entry = this.iConexion!.Entry<Tallas>(this.entidad);
//            entry.State = EntityState.Modified;
//            this.iConexion!.SaveChanges();

//            return true;
//        }

//        public bool Borrar()
//        {
//            this.iConexion!.Tallas!.Remove(this.entidad!);
//            this.iConexion!.SaveChanges();
//            return true;
//        }
//    }
//}