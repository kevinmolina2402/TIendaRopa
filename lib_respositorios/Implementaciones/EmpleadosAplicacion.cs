﻿//using lib_dominio.Entidades;
//using lib_repositorio.Interfaces;
//using Microsoft.EntityFrameworkCore;

//namespace lib_repositorio.Implementaciones
//{
//    public class EmpleadosAplicacion : IEmpleadosAplicacion
//    {
//        private IConexion? IConexion = null;
        
//        public EmpleadosAplicacion(IConexion iConexion)
//        {
//            this.IConexion = iConexion;
//        }

//        public void Configurar(string StringConexion)
//        {
//            this.IConexion!.StringConexion = StringConexion;
//        }

//        public Empleados? Borrar(Empleados? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            this.IConexion!.Empleados!.Remove(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public Empleados? Guardar(Empleados? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad.Id != 0)
//                throw new Exception("lbYaSeGuardo");
//            // Operaciones
//            this.IConexion!.Empleados!.Add(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public List<Empleados> Listar()
//        {
//            return this.IConexion!.Empleados!.Take(20).ToList();
//        }

//        public Empleados? Modificar(Empleados? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            var entry = this.IConexion!.Entry<Empleados>(entidad);
//            entry.State = EntityState.Modified;
//            this.IConexion.SaveChanges();
//            return entidad;
//        }
//    }
//}