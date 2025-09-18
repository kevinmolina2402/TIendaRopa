using lib_dominio.Entidades;
using lib_repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lib_repositorio.Implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<Puestos>? Puestos { get; set; }
        public DbSet<Proveedores>? Proveedores { get; set; }
        public DbSet<Categorias>? Categorias { get; set; }
        public DbSet<Marcas>? Marcas { get; set; }
        public DbSet<Colores>? Colores { get; set; }
        public DbSet<Tallas>? Tallas { get; set; }
        public DbSet<Promociones>? Promociones { get; set; }
       public DbSet<Empleados>? Empleados { get; set; }
        public DbSet<Productos>? Productos { get; set; }
        public DbSet<Inventario>? Inventario { get; set; }
        public DbSet<Compras>? Compras { get; set; }
        public DbSet<DetalleCompras>? DetalleCompras { get; set; }
        public DbSet<Ventas>? Ventas { get; set; }
        public DbSet<DetalleVentas>? DetalleVentas { get; set; }
        public DbSet<Devoluciones>? Devoluciones { get; set; }

    }
}