using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Net;
using System.IO;
using Newtonsoft.Json;


namespace NitradoUnlimited
{
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
        }

        private void web_Load(object sender, EventArgs e)
        {
            webbro.Navigate(new Uri("https://oauth.nitrado.net/oauth/v2/auth?client_id=<CLIENTID>&scope=service%20user_info%20service_order&redirect_uri=https://marcsrv.de/nitrado/auth.php&&response_type=code"));
            webbro.DocumentCompleted +=
        new WebBrowserDocumentCompletedEventHandler(webloaded);
        }

        private void webloaded(object sender,
            
    WebBrowserDocumentCompletedEventArgs e)
        {
            txturl.Text = Convert.ToString(webbro.Url);
            int find = txturl.Text.IndexOf("https://");
            if (find == 0)
            {
                txturl.BackColor = Color.Green;

            }else
            {
                txturl.BackColor = Color.White;
            }
            string webinhalt = webbro.Document.Body.InnerText;
            int webindex =  webinhalt.IndexOf("token:");
            if (webindex >= 0)
            {
               string authtoken = webinhalt.Replace("token:", "");
               makeaccessrequest(authtoken);
                Properties.Settings.Default.Save();
                this.Close();
                
            }
           
        }

       

    //fordert accesstoken an
        public static string makeaccessrequest(string authtoken)
        {
            string UrlRequest = "https://oauth.nitrado.net/oauth/v2/token?grant_type=authorization_code&code=" +
                                 authtoken +
                                 "&redirect_uri=https://marcsrv.de/nitrado/auth.php&%20client_id=<clientID>&%20client_secret=<CLIENTSecret>";

            var request = WebRequest.Create(UrlRequest);
            request.ContentType = "application/json; charset=utf-8";
            string jsonesponse;
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                jsonesponse = sr.ReadToEnd();
            }
            

            dynamic waffelresponse = JsonConvert.DeserializeObject(jsonesponse);

            string accesstoken = waffelresponse.access_token;
            Properties.Settings.Default.accesstoken = accesstoken;
            return null;
            

        }

        
    }
    
}
