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
     

        public static List<AusgaengeModel> LoadAusgang()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AusgaengeModel>("select * from Ausgaenge", new DynamicParameters());
                return output.ToList();
            }

        }


        public static List<EingaengeModel> LoadEingang()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<EingaengeModel>("select * from Eingaenge", new DynamicParameters());
                return output.ToList();
            }

        }





      


        public static void SaveAusgang(AusgaengeModel ausgaenge)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Ausgaenge (Heizband_ALM, Pumpe_Solar,Pumpe_Zirku,Ventil_Solar1, Ventil_Solar2, Ventil_WW, Pumpe_Hzkr,Ventil_Sole1,Ventil_Sole2,Wp_Anf, Pumpe_Sole, Mischer_Auf,Mischer_Zu, date) values (@Heizband_ALM, @Pumpe_Solar,@Pumpe_Zirku,@Ventil_Solar1, @Ventil_Solar2, @Ventil_WW, @Pumpe_Hzkr,@Ventil_Sole1,@Ventil_Sole2,@Wp_Anf, @Pumpe_Sole, @Mischer_Auf,@Mischer_Zu, @date)", ausgaenge);
            }
        }

        public static void SaveEingang(EingaengeModel eingaenge)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Eingaenge (aussen_temperatur, alm_aussen_temperatur, fbh_vl, fbh_vr,ps_oben, ps_unten,PS_WW,PS_Heiz, PS_WW_Zulauf,SolarRLTemp, Kollektor, Pumpe_Zirku, Wp_innen, Sole_vl,Sole_rl,Zist_unten, Zist_oben, date) values (@aussen_temperatur, @alm_aussen_temperatur, @fbh_vl, @fbh_vr,@ps_oben, @ps_unten,@PS_WW,@PS_Heiz, @PS_WW_Zulauf,@SolarRLTemp, @Kollektor, @Pumpe_Zirku, @Wp_innen,@Sole_vl,@Sole_rl,@Zist_unten, @Zist_oben, @date)", eingaenge);
            }
        }


        private static string LoadConnectionString (string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
