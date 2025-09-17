﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ut_presentacion.Nucleo
{
    class Configuracion
    {
        private static Dictionary<string, string>? datos = null;

        public static string ObtenerValor(string clave)
        {
            string respuesta = "";
            if (datos == null)
                Cargar();
            respuesta = datos![clave].ToString();
            return respuesta;
        }

        public static void Cargar()
        {
            if (!File.Exists(DatosGenerales.ruta_json))
                return;
            StreamReader jsonStream = File.OpenText(DatosGenerales.ruta_json);
            var json = jsonStream.ReadToEnd();
            datos = JsonConversor.ConvertirAObjeto<Dictionary<string, string>>(json)!;
        }
    }
}
