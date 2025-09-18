//using lib_dominio.Entidades;
//using lib_repositorio.Interfaces;
//using Microsoft.EntityFrameworkCore;

//namespace lib_repositorio.Implementaciones
//{
//    public class InventarioAplicacion : IInventarioAplicacion
//    {
//        private IConexion? IConexion = null;
        
//        public InventarioAplicacion(IConexion iConexion)
//        {
//            this.IConexion = iConexion;
//        }

//        public void Configurar(string StringConexion)
//        {
//            this.IConexion!.StringConexion = StringConexion;
//        }

//        public Inventario? Borrar(Inventario? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            this.IConexion!.Inventario!.Remove(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public Inventario? Guardar(Inventario? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad.Id != 0)
//                throw new Exception("lbYaSeGuardo");
//            // Operaciones
//            this.IConexion!.Inventario!.Add(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public List<Inventario> Listar()
//        {
//            return this.IConexion!.Inventario!.Take(20).ToList();
//        }

//        public Inventario? Modificar(Inventario? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            var entry = this.IConexion!.Entry<Inventario>(entidad);
//            entry.State = EntityState.Modified;
//            this.IConexion.SaveChanges();
//            return entidad;
//        }
//    }
//}