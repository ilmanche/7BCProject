using ClassLibrary.Models.Ausgänge;
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

        public static List<WPModel> LoadWPModel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<WPModel>("select * from Waermepumpe", new DynamicParameters());
                return output.ToList();
            }

        }

        public static List<PSModel> LoadPS()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PSModel>("select * from SolarRL", new DynamicParameters());
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

        public static List<FBHModel> LoadFBH()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<FBHModel>("select * from FBH", new DynamicParameters());
                return output.ToList();
            }

        }

        public static List<ZisterneModel> LoadZist()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ZisterneModel>("select * from Zisterne", new DynamicParameters());
                return output.ToList();
            }

        }

        public static List<AusgaengeModel> LoadAusgang()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AusgaengeModel>("select * from Ausgaenge", new DynamicParameters());
                return output.ToList();
            }

        }



        public static void SaveSolarPanel(SolarRLModel solarRl)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into SolarRL (Temperatur, Kollektor, date) values (@Temperatur, @Kollektor, @date)", solarRl);
            }
        }


        public static void SaveZisterne(ZisterneModel zisterne)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Zisterne (Zist_unten, Zist_oben, date) values (@Zist_unten,@Zist_oben, @date)", zisterne);
            }
        }

        public static void SaveWPModel(WPModel WPModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into SolarRL (Temperatur, date) values (@Temperatur, @date)", WPModel);
            }
        }

        public static void SaveAußenluft(AussenluftModel aussen)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Aussenluft (alm_aussen_temperatur, aussen_temperatur, date) values (@alm_aussen_temperatur, @aussen_temperatur, @date)", aussen);
            }
        }

        public static void SaveFBH(FBHModel fbh)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into FBH (fbh_vl, fbh_vr, date) values (@FBH_VL, @FBH_VR, @date)", fbh);
            }
        }

        public static void SavePS(PSModel ps)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Pufferspeicher (ps_oben, ps_unten,PS_WW,PS_Heiz, PS_WW_Zulauf, date) values (@ps_oben, @ps_unten,@PS_WW, @PS_Heiz, @PS_WW_Zulauf, @date)", ps);
            }
        }


        public static void SaveAusgang(AusgaengeModel ausgaenge)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Ausgaenge (Heizband_ALM, Pumpe_Solar,Pumpe_Zirku,Ventil_Solar1, Ventil_Solar2, Ventil_WW, Pumpe_Hzkr,Ventil_Sole1,Ventil_Sole2,Wp_Anf, Pumpe_Sole, Mischer_Auf,Mischer_Zu, date    ) values (@Heizband_ALM, @Pumpe_Solar,@Pumpe_Zirku,@Ventil_Solar1, @Ventil_Solar2, @Ventil_WW, @Pumpe_Hzkr,@Ventil_Sole1,@Ventil_Sole2,@Wp_Anf, @Pumpe_Sole, @Mischer_Auf,@Mischer_Zu, date)", ausgaenge);
            }
        }



        private static string LoadConnectionString (string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
