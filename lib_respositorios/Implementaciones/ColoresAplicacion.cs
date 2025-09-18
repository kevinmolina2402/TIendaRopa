//using lib_dominio.Entidades;
//using lib_repositorio.Interfaces;
//using Microsoft.EntityFrameworkCore;

//namespace lib_repositorio.Implementaciones
//{
//    public class ColoresAplicacion : IColoresAplicacion
//    {
//        private IConexion? IConexion = null;
        
//        public ColoresAplicacion(IConexion iConexion)
//        {
//            this.IConexion = iConexion;
//        }

//        public void Configurar(string StringConexion)
//        {
//            this.IConexion!.StringConexion = StringConexion;
//        }

//        public Colores? Borrar(Colores? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            this.IConexion!.Colores!.Remove(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public Colores? Guardar(Colores? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad.Id != 0)
//                throw new Exception("lbYaSeGuardo");
//            // Operaciones
//            this.IConexion!.Colores!.Add(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public List<Colores> Listar()
//        {
//            return this.IConexion!.Colores!.Take(20).ToList();
//        }

//        public Colores? Modificar(Colores? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            var entry = this.IConexion!.Entry<Colores>(entidad);
//            entry.State = EntityState.Modified;
//            this.IConexion.SaveChanges();
//            return entidad;
//        }
//    }
//}