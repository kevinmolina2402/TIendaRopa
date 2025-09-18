﻿//using lib_dominio.Entidades;
//using lib_repositorio.Interfaces;
//using Microsoft.EntityFrameworkCore;

//namespace lib_repositorio.Implementaciones
//{
//    public class ProductosAplicacion : IProductosAplicacion
//    {
//        private IConexion? IConexion = null;
        
//        public ProductosAplicacion(IConexion iConexion)
//        {
//            this.IConexion = iConexion;
//        }

//        public void Configurar(string StringConexion)
//        {
//            this.IConexion!.StringConexion = StringConexion;
//        }

//        public Productos? Borrar(Productos? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            this.IConexion!.Productos!.Remove(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public Productos? Guardar(Productos? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad.Id != 0)
//                throw new Exception("lbYaSeGuardo");
//            // Operaciones
//            this.IConexion!.Productos!.Add(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public List<Productos> Listar()
//        {
//            return this.IConexion!.Productos!.Take(20).ToList();
//        }

//        public Productos? Modificar(Productos? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            var entry = this.IConexion!.Entry<Productos>(entidad);
//            entry.State = EntityState.Modified;
//            this.IConexion.SaveChanges();
//            return entidad;
//        }
//    }
//}