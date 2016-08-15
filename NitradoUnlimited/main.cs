using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitradoUnlimited
{
    
    public partial class main : Form
    {
        string accesstokenacc = Properties.Settings.Default.accesstoken;
        public main()
        {
            InitializeComponent();


        }

        public class Variables
        {
            public static string name;
            public static string userid;
            public static string username;
            public static string email;
            public static double credit;
            public static DateTime registered;
            public static string lang;
            public static string avtarurl = "https://server.nitrado.net/img.nitrado/unknown-user.jpg";
            public static string currency;
            public static Boolean employee;
            public static string serviceid;
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            string appversion = Application.ProductVersion.ToString();
            this.Text += " - Version: " + appversion;
            if (Properties.Settings.Default.accesstoken == "")
            {
                web webbrowser = new web();
                webbrowser.ShowDialog();
                accesstokenacc = Properties.Settings.Default.accesstoken;
                if (accesstokenacc == "")
                {
                    MessageBox.Show("Error, Kein Account Zugriff");
                }

            }

            btnupdate.PerformClick();

            

        }
        
        

        public static void login()
        {
            main mainform = new NitradoUnlimited.main();
            web webbrowser = new web();
            webbrowser.ShowDialog();
            mainform.accesstokenacc = Properties.Settings.Default.accesstoken;
            if (mainform.accesstokenacc == "")
            {
                MessageBox.Show("Error, Kein Account Zugriff");
            }
        }

        
        public static string getuserdata(string accesstoken)
        {
            string UrlRequest = "https://api.nitrado.net/user?access_token=" + accesstoken;
            var request = WebRequest.Create(UrlRequest);
            request.ContentType = "application/json; charset=utf-8";
            
            string jsonesponse;
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                jsonesponse = sr.ReadToEnd();
            }
            dynamic dataresponse = JsonConvert.DeserializeObject(jsonesponse);

            Variables.userid = dataresponse.data.user.user_id;
            Variables.username = dataresponse.data.user.username;
            Variables.email = dataresponse.data.user.email;
            double creditit = Convert.ToDouble(dataresponse.data.user.credit);
            Variables.credit = creditit / 100;
            Variables.registered = dataresponse.data.user.registred;
            Variables.lang = dataresponse.data.user.language;
            Variables.avtarurl = dataresponse.data.user.avatar;
            Variables.name = dataresponse.data.user.profile.name;
            Variables.currency = dataresponse.data.user.currency;

            return null;
            
            
        }

        public static string gettokendata(string accesstoken)
        {
            string UrlRequest = "https://api.nitrado.net/token?access_token=" + accesstoken;
            var request = WebRequest.Create(UrlRequest);
            request.ContentType = "application/json; charset=utf-8";
            string jsonesponse;
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                jsonesponse = sr.ReadToEnd();
            }
            dynamic dataresponse = JsonConvert.DeserializeObject(jsonesponse);

            Variables.employee = dataresponse.data.token.employee;
            

            return null;


        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.accesstoken = "";
            Properties.Settings.Default.Save();
            login();
            btnupdate.PerformClick();
            


        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.ShowDialog();
            btnupdate.PerformClick();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            listservices.Clear();
            

            getuserdata(Properties.Settings.Default.accesstoken);

            

            avatarpic.ImageLocation = Variables.avtarurl;
            labelusername.Text = Variables.username;
            if(Properties.Settings.Default.showrealname == true)
            {
            labelname.Text = Variables.name;
            }else
            {
                labelname.Text = "--Hidden--";
            }

            
            labelregistered.Text = "Mitglied seit: " + Variables.registered.ToString("dd.MM.yyyy H:mm:ss");

            if(Properties.Settings.Default.showcredit == true)
            {
                labelcredit.Text = "Guthaben: " + Variables.credit + " €";
            }else
            {
                labelcredit.Text = "--Hidden--";
            }
            

            


            string UrlRequesting = "https://api.nitrado.net/services?access_token=" + Properties.Settings.Default.accesstoken;
            var requestservice = WebRequest.Create(UrlRequesting);
            requestservice.ContentType = "application/json; charset=utf-8";
            string jsonesponseservice;
            var responseservice = (HttpWebResponse)requestservice.GetResponse();

            using (var sr = new StreamReader(responseservice.GetResponseStream()))
            {
                jsonesponseservice = sr.ReadToEnd();
            }
            dynamic dresponse = JsonConvert.DeserializeObject(jsonesponseservice);

            
            listservices.LargeImageList = imagelist;

            foreach (var service in dresponse.data.services)
            {
                string type = Convert.ToString(service.type);
                string imgindex = "0";
                string servicegroup = "55";
                Boolean showgame = false;
                switch (type)
                {
                    case "gameserver":
                        imgindex = "0";
                        servicegroup = "gameserver";
                        showgame = true;
                        break;
                    case "voiceserver":
                        imgindex = "1";
                        servicegroup = "voiceserver";
                        break;
                    case "webspace":
                        imgindex = "2";
                        servicegroup = "webspace";
                        break;
                    case "domain":
                        imgindex = "3";
                        servicegroup = "domain";
                        break;
                    case "clanpage":
                        imgindex = "4";
                        servicegroup = "clanpage";
                        break;
                    case "bouncer":
                        imgindex = "5";
                        servicegroup = "bouncer";
                        break;


                }
                string inklammertext = Convert.ToString(service.id);
                if (showgame == true)
                {
                    inklammertext = Convert.ToString(service.details.game);
                }
                
                int imgintindex = Convert.ToInt32(imgindex);

                var thegroup = listservices.Groups[servicegroup];
                var item = new ListViewItem { Text = Convert.ToString(service.type_human) + " (" + (inklammertext) + ")", Group = thegroup, ImageIndex = imgintindex, Tag = Convert.ToString(service.id) };
                listservices.Items.Add(item);

                /* Bilder der Services
                 * 0 Gameserver
                 * 1 Voiceserver
                 * 2 Webspace
                 * 3 Domain
                 * 4 CMS
                 * 5 Bouncer
                 */
                
            }
            
            }

        private void listservices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            Variables.serviceid = Convert.ToString(listservices.SelectedItems[0].Tag);
            Form serverview = new serverview();
            serverview.Show();

        }
    }
}
