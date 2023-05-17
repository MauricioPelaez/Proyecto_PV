using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PV.Datos_Staticos
{
    internal static class Global
    {
        internal static bool pestaña = false;
        internal static string usuarioLog { get; set; }
        internal static string tipoUsuarioLog { get; set; }
        internal static string id_bodega{ get; set; }
        internal static string id_proveedor { get; set; }
        internal static string id_producto { get; set; }
        internal static int camara { get; set; }


        internal static bool pest_prov = false;
        internal static bool pest_reg_inv = false;
    }
}
