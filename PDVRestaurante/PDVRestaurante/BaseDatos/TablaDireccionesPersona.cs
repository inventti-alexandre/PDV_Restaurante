﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.BaseDatos
{
    public static class TablaDireccionesPersona
    {
        private static string Tabla()
        {
            return "DireccionesPersona";
        }

        private static string Columnas()
        {
            return "Cedula|Tipo|IdDistrito|IdCanton|IdProvincia|Detalle";
        }

        private static string LlavePrincipal()
        {
            return "Cedula|Tipo";
        }
    }
}
