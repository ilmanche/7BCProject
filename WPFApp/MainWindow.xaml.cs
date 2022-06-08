using PLCLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }
           
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //Solaranlage
            var solardata = await SolarPanel.LoadSolarPanelData();

            SolarRLModel sol = new SolarRLModel();
            sol.solar_rl = solardata.val;

            //Aussenluftmodul
            var aussenluftdata1 = await Aussenluft.LoadAlmAussen();
            var aussenluftdata2 = await Aussenluft.LoadTempAussen();

            AussenluftModel alm = new AussenluftModel();
            alm.alm_aussen = aussenluftdata1.val;
            alm.temperature = aussenluftdata2.val;
            
            //Fussbodenheizung
            var fbhdata1 = await Fussbodenheizung.LoadFbhVL();
            var fbhdata2 = await Fussbodenheizung.LoadFbhRL();

            FusbodenheizungModel fbh = new FusbodenheizungModel();
            fbh.vl = fbhdata1.val;
            fbh.rl = fbhdata2.val;

            //Waermepumpe
            var wpdata1 = await Waermepumpe.LoadWPinnen();
            var wpdata2 = await Waermepumpe.LoadSoleVL();
            var wpdata3 = await Waermepumpe.LoadSoleRL();

            WaermepumpeModel wp = new WaermepumpeModel();
            wp.innen = wpdata1.val;
            wp.sole_vl = wpdata2.val;
            wp.sole_rl = wpdata3.val;

            //Zisterne
            var zisdata1 = await Zisterne.LoadZisUnten();
            var zisdata2 = await Zisterne.LoadZisOben();

            ZisterneModel zis = new ZisterneModel();
            zis.unten = zisdata1.val;
            zis.oben = zisdata2.val;

            //Prozessspeicher
            var psdata1 = await Prozessspeicher.LoadProzOben();
            var psdata2 = await Prozessspeicher.LoadProzUnten();

            ProzessspeicherModel ps = new ProzessspeicherModel();
            ps.oben = psdata1.val;
            ps.unten = psdata2.val;
            
            resultText.Text = $" Solar {sol.solar_rl} \n ALM {alm.alm_aussen} and {alm.temperature} \n FBH {fbh.vl} and {fbh.rl} \n WP {wp.innen} and {wp.sole_vl} and {wp.sole_rl} \n Zis {zis.unten} and {zis.oben} \n PS {ps.oben} and {ps.unten}";

        }
    } }
