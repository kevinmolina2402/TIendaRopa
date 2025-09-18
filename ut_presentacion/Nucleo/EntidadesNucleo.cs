using lib_dominio.Entidades;
namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Tallas? Tallas()
        {
            var entidad = new Tallas();
            entidad.Descripcion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            return entidad;
        }
        public static Puestos? Puestos()
        {
            var entidad = new Puestos();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            return entidad;
        }
        public static Categorias? Categorias()
        {
            var entidad = new Categorias();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            return entidad;
        }
        public static Marcas? Marcas()
        {
            var entidad = new Marcas();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Pais_Origen = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");

            return entidad;
        }
        public static Colores? Colores()
        {
            var entidad = new Colores();
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Codigo_Hexa = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");

            return entidad;
        }
        public static Clientes? Clientes()
        {
            var entidad = new Clientes();
            entidad.Cedula = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); 
            entidad.Telefono = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); 
            entidad.Direccion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Email = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");

            return entidad;
        }
        public static Proveedores? Proveedores()
        {
            var entidad = new Proveedores();
            entidad.RUT = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre_Empresa = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre_Contacto = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); 
            entidad.Telefono = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); 
            entidad.Direccion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Email = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");

            return entidad;
        }
        public static Promociones? Promociones()
        {
            var entidad = new Promociones();
            entidad.Codigo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Descripcion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Porcentaje = 0.1m;
            entidad.Valor_Descuento = 0.0m;
            entidad.Fecha_inicio = DateTime.Now;
            entidad.Fecha_Fin = DateTime.Now;

            return entidad;
        }
        public static Empleados? Empleados()
        {
            var entidad = new Empleados();
            entidad.Cedula = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); 
            entidad.Telefono = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); 
            entidad.Direccion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Email = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Puesto = 1;
            entidad.Fecha_Contratacion = DateTime.Now;  
            return entidad;
        }
        public static Productos? Productos()
        {
            var entidad = new Productos();
            entidad.Marca = 1;
            entidad.Categoria = 1;

            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); 
            entidad.Descripcion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); 
            entidad.Precio_Compra = 10.0m;
            entidad.Precio_Venta = 15.0m;

            return entidad;
        }
        public static Inventario? Inventario()
        {
            var entidad = new Inventario();
            entidad.Producto = 1;
            entidad.Talla = 1;
            entidad.Color = 1;

            entidad.Cantidad = 1;

            return entidad;
        }
        public static Compras? Compras()
        {
            var entidad = new Compras();
            entidad.Proveedor = 1;
            entidad.Empleado = 1;
            
            entidad.Fecha_Compra = DateTime.Now;
            entidad.Total = 100.0m;
            entidad.Impuestos = 10.0m;

            return entidad;
        }
        public static DetalleCompras? DetalleCompras()
        {
            var entidad = new DetalleCompras();
            entidad.Compra = 1;
            entidad.Producto = 1;
            entidad.Talla = 1;
            entidad.Color = 1;

            entidad.Cantidad = 1;
            entidad.Precio_Unitario = 15.0m;
            return entidad;
        }
        public static Ventas? Ventas()
        {
            var entidad = new Ventas();
            entidad.Cliente = 1;
            entidad.Empleado = 1;

            entidad.Fecha_Venta = DateTime.Now;
            entidad.Total = 100.0m;
            entidad.Impuestos = 10.0m;

            return entidad;
        }
        public static DetalleVentas? DetalleVentas()
        {
            var entidad = new DetalleVentas();
            entidad.Venta = 1;
            entidad.Producto = 1;
            entidad.Talla = 1;
            entidad.Color = 1;
            entidad.Promocion = 1;

            entidad.Cantidad = 1;
            entidad.Precio_Unitario = 15.0m;
            return entidad;
        }
        public static Devoluciones? Devoluciones()
        {
            var entidad = new Devoluciones();
            entidad.Venta = 1;
            entidad.Producto = 1;
            entidad.Talla = 1;
            entidad.Color = 1;

            entidad.Cantidad = 1;
            entidad.Motivo = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Fecha_Devolucion = DateTime.Now;
            return entidad;
        }

    }
}