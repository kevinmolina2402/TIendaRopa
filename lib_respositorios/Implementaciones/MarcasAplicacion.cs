﻿//using lib_dominio.Entidades;
//using lib_repositorio.Interfaces;
//using Microsoft.EntityFrameworkCore;

//namespace lib_repositorio.Implementaciones
//{
//    public class MarcasAplicacion : IMarcasAplicacion
//    {
//        private IConexion? IConexion = null;
        
//        public MarcasAplicacion(IConexion iConexion)
//        {
//            this.IConexion = iConexion;
//        }

//        public void Configurar(string StringConexion)
//        {
//            this.IConexion!.StringConexion = StringConexion;
//        }

//        public Marcas? Borrar(Marcas? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            this.IConexion!.Marcas!.Remove(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public Marcas? Guardar(Marcas? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad.Id != 0)
//                throw new Exception("lbYaSeGuardo");
//            // Operaciones
//            this.IConexion!.Marcas!.Add(entidad);
//            this.IConexion.SaveChanges();
//            return entidad;
//        }

//        public List<Marcas> Listar()
//        {
//            return this.IConexion!.Marcas!.Take(20).ToList();
//        }

//        public Marcas? Modificar(Marcas? entidad)
//        {
//            if (entidad == null)
//                throw new Exception("lbFaltaInformacion");
//            if (entidad!.Id == 0)
//                throw new Exception("lbNoSeGuardo");
//            // Operaciones
//            var entry = this.IConexion!.Entry<Marcas>(entidad);
//            entry.State = EntityState.Modified;
//            this.IConexion.SaveChanges();
//            return entidad;
//        }
//    }
//}