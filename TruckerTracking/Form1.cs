using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Globalization;
using System.Data;
using System.IO;
using System.Xml;

namespace TruckerTracking
{
    public partial class DFDS : Form
    {
     
        public DFDS()
        {
            InitializeComponent();
         
        }

        private void getAdress_btn_Click(object sender, EventArgs e)
        {
            //Client GET
            var client = new RestSharp.RestClient("https://eu1.locationiq.com");
            var req = new RestSharp.RestRequest("v1/reverse.php", RestSharp.Method.GET);

            //Input 
            req.AddParameter("key", LocationKey.Key);
            req.AddParameter("lat", lat_txt.Text);
            req.AddParameter("lon", long_txt.Text);
            req.AddParameter("format", "json");


            //Execute and Convert to Json
            var res = client.Execute(req);
            getAddress_txt.Text = res.Content;
            var content = JsonConvert.DeserializeObject<Location>(res.Content);

            //Displaying fully infomation about where the truckdriver is
            getAddress_txt.Text = "Adress";
            getAddress_txt.Text = $"{content.Display_Name}";

        }
      
        private void Beregn_btn_Click(object sender, EventArgs e)
        {
           
           
            //Getting lib from GeoCoordinations
            GeoCoordinate distanceFrom = new GeoCoordinate();
            GeoCoordinate distanceTo = new GeoCoordinate();
         
            //Converting to double and Culture it from dot to comma,
            distanceFrom.Latitude = double.Parse(BeregnFra_Lat.Text, CultureInfo.InvariantCulture);
            distanceFrom.Longitude = double.Parse(BeregnFra_long.Text, CultureInfo.InvariantCulture);


            distanceTo.Latitude = double.Parse(BeregnTil_Lat.Text, CultureInfo.InvariantCulture);
            distanceTo.Longitude = double.Parse(BeregnTil_long.Text, CultureInfo.InvariantCulture);

            //Calulate the distance between both from / to lat,long
            double distance = distanceFrom.GetDistanceTo(distanceTo);

            //Calulate and divide the meters to get km 
            double resultat = distance / 1000;

            //Making it look simple and clean
            resultat = Math.Round(resultat, 2);

            //Display the result to label
            beregn_resultat.Text = resultat.ToString() + " km";
        }


        private void calulator_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void CityFinder_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void DFDS_Load(object sender, EventArgs e)
        {

        }
    }
 
    
}
