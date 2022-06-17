using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SqliteDataAccess
    {
        public static List<SolarRLModel> LoadSolarPanel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SolarRLModel>("select * from SolarRL", new DynamicParameters());
                return output.ToList();
            }

        }


        public static List<AussenluftModel> LoadAussenLuftTemp()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AussenluftModel>("select * from Aussenluft", new DynamicParameters());
                return output.ToList();
            }

        }

        public static void SaveSolarPanel(SolarRLModel solarRl)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into SolarRL (Temperatur) values (@Temperatur)", solarRl);
            }
        }

        public static void SaveAußenluft(AussenluftModel aussen)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Aussenluft (alm_aussen_temperatur, aussen_temperatur) values (@alm_aussen_temperatur, @aussen_temperatur)", aussen);
            }
        }

        private static string LoadConnectionString (string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
