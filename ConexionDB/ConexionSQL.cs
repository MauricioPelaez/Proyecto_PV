namespace Proyecto_PV.ConexionDB
{
    internal class ConexionSQL
    {
        Ruta Rut = new Ruta();
        string URL = "";
        string USER = "";
        string PASS = "";
        string DB = "";
        string PORT = "";
        /// <summary>
        /// configuracion archivo config.ini
        /// </summary>

        public void Configurate()
        {

            INIFile inif = new INIFile(Rut.pac_local0() + "config.ini");
            URL = inif.Read("Database", "URL");
            USER = inif.Read("Database", "USER");
            PASS = inif.Read("Database", "PASS");
            DB = inif.Read("Database", "DB");
            PORT = inif.Read("Database", "PORT");

        }


        public string Conectar()
        {   
            Configurate();   
            string conex = "server=" + URL + ";user=" + USER + ";password=" + PASS + ";Port=" + PORT + ";" + "database=" + DB;  
            return conex;
        }
    }
}
