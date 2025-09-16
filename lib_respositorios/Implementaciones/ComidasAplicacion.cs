﻿using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorios.Implementaciones
{
    public class ComidasAplicacion : IComidasAplicacion
    {
        private IConexion? IConexion = null;
        
        public ComidasAplicacion(IConexion iConexion)
        {
            this.IConexion = iConexion;
        }

        public void Configurar(string StringConexion)
        {
            this.IConexion!.StringConexion = StringConexion;
        }

        public Comidas? Borrar(Comidas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");
            // Operaciones
            this.IConexion!.Comidas!.Remove(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public Comidas? Guardar(Comidas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");
            // Operaciones
            this.IConexion!.Comidas!.Add(entidad);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<Comidas> Listar()
        {
            return this.IConexion!.Comidas!.Take(20).ToList();
        }

        public Comidas? Modificar(Comidas? entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");
            if (entidad!.Id == 0)
                throw new Exception("lbNoSeGuardo");
            // Operaciones
            var entry = this.IConexion!.Entry<Comidas>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion.SaveChanges();
            return entidad;
        }
    }
}