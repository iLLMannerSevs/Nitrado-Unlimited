using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitradoUnlimited
{
    public partial class serverview : Form
    {
        public serverview()
        {
            InitializeComponent();
        }

        private void serverview_Load(object sender, EventArgs e)
        {
            string serviceid = main.Variables.serviceid;

            btnreload.PerformClick();

        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            
                string servicevar = main.Variables.serviceid;
try
            {
                string UrlRequesting5 = "https://api.nitrado.net/services/" + servicevar + "/gameservers?access_token=" + Properties.Settings.Default.accesstoken;
                var requestservice = WebRequest.Create(UrlRequesting5);
                requestservice.ContentType = "application/json; charset=utf-8";
                string jsonesponseservice;

                var responseservice = (HttpWebResponse)requestservice.GetResponse();

                using (var sr = new StreamReader(responseservice.GetResponseStream()))
                {
                    jsonesponseservice = sr.ReadToEnd();
                }
                dynamic dresponse = JsonConvert.DeserializeObject(jsonesponseservice);

                if (Convert.ToString(dresponse.status) == "error")
                {
                    MessageBox.Show(Convert.ToString(dresponse.message));
                }

                labelgame.Text = dresponse.data.gameserver.game_human;
                labelgameservertype.Text = dresponse.data.gameserver.type + " " + dresponse.data.gameserver.slots + " Slots";
                labelip.Text = dresponse.data.gameserver.ip + ":" + dresponse.data.gameserver.port;
                string status = dresponse.data.gameserver.status;
                switch (status)
                {
                    case "started":
                        labelstatus.Text = "Online";
                        labelstatus.BackColor = Color.Green;
                        break;
                    case "stopped":
                        labelstatus.Text = "Offline";
                        labelstatus.BackColor = Color.Red;
                        break;
                    case "stopping":
                        labelstatus.Text = "Wird gestoppt";
                        labelstatus.BackColor = Color.Orange;
                        break;
                    case "restarting":
                        labelstatus.Text = "Neustarten";
                        labelstatus.BackColor = Color.Orange;
                        break;
                    case "suspended":
                        labelstatus.Text = "Deaktiviert";
                        labelstatus.BackColor = Color.Blue;
                        break;
                    case "guardian_locked":
                        labelstatus.Text = "Elternschutz aktiviert";
                        labelstatus.BackColor = Color.Orange;
                        break;
                    case "gs_installation":
                        labelstatus.Text = "Gameswitching";
                        labelstatus.BackColor = Color.Blue;
                        break;
                    case "backup_restore":
                        labelstatus.Text = "Backup wird wiederhergestellt";
                        labelstatus.BackColor = Color.Blue;
                        break;
                    case "backup_creation":
                        labelstatus.Text = "Backup wird erstellt";
                        labelstatus.BackColor = Color.Blue;
                        break;
                    default:
                        labelstatus.Text = "Unknow";
                        labelstatus.BackColor = Color.White;
                        break;
                    }
                string piccode;
                if (dresponse.data.gameserver.game == "mcr")
                {
                    piccode = "minecraft";
                }
                else
                {
                    piccode = dresponse.data.gameserver.game;
                }
                serverimage.ImageLocation = "https://static.nitrado.net/cdn/gameicons/120/" + piccode + ".jpg";
                this.Text = labelgameservertype.Text + " - " + labelgame.Text + " - " + labelip.Text;
                labelservice.Text = "ID: " + servicevar;
                groupBox1.Text = "Einstellungen - " + labelgame.Text;
                
}catch 
            {

                

                MessageBox.Show("Für diesen Service steht keine Daten zur verfügung");
                this.Close();

            }

            //Service nochmal laden
            

            }

        private void button1_Click(object sender, EventArgs e)
        {
            string servicevar = main.Variables.serviceid;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.nitrado.net/services/" + servicevar + "/gameservers/restart?access_token=" + Properties.Settings.Default.accesstoken);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic dresponse = JsonConvert.DeserializeObject(result);
                MessageBox.Show(Convert.ToString(dresponse.message));
            }





            btnreload.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string servicevar = main.Variables.serviceid;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.nitrado.net/services/" + servicevar + "/gameservers/stop?access_token=" + Properties.Settings.Default.accesstoken);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic dresponse = JsonConvert.DeserializeObject(result);
                MessageBox.Show(Convert.ToString(dresponse.message));
            }
            btnreload.PerformClick();
        }
    }
}
