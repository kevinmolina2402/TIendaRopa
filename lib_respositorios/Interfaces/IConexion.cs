using lib_dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace lib_repositorio.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<Clientes>? Clientes { get; set; }
        DbSet<Puestos>? Puestos { get; set; }
        DbSet<Proveedores>? Proveedores { get; set; }
        DbSet<Marcas>? Marcas { get; set; }
        DbSet<Categorias>? Categorias { get; set; }
        DbSet<Colores>? Colores { get; set; }
        DbSet<Tallas>? Tallas { get; set; }
        DbSet<Promociones>? Promociones { get; set; }
        DbSet<Empleados>? Empleados { get; set; }
        DbSet<Productos>? Productos { get; set; }
        DbSet<Inventario>? Inventario { get; set; }
        DbSet<Compras>? Compras { get; set; }
        DbSet<DetalleCompras>? DetalleCompras { get; set; }
        DbSet<Ventas>? Ventas { get; set; }
        DbSet<DetalleVentas>? DetalleVentas { get; set; }
        DbSet<Devoluciones>? Devoluciones { get; set; }


        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}