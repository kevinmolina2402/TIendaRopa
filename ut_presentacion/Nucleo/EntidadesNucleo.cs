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
            entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Telefono = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Direccion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Email = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");

            return entidad;
        }
        public static Proveedores? Proveedores()
        {
            var entidad = new Proveedores();
            entidad.RUT = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre_Empresa = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre_Contacto = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Telefono = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
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
            entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Telefono = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Direccion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Email = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Puesto = 1;
            entidad.Fecha_Contratacion = DateTime.Now;  
            return entidad;
        }
        public static Productos? Productos()
        {
            var entidad = new Productos();
            entidad.Id_Marca = 
            entidad.Id_Categoria = 

            entidad.Nombre = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Descripcion = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss"); entidad.Apellido = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Precio_Compra = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Precio_Venta = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");

            return entidad;
        }

    }
}