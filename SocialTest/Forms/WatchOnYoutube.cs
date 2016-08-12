using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;
using System.Text.RegularExpressions;


namespace Social_Network.Forms
{
    public partial class WatchOnYoutube : Form
    {
        Home p = null;
        string name = "";
        public WatchOnYoutube()
        {
            InitializeComponent();
        }

        public WatchOnYoutube(string youtubeSong, Home previous)
        {
            this.p = previous;
            this.name = youtubeSong;
            InitializeComponent();
        }

        private void WatchOnYoutube_Load(object sender, EventArgs e)
        {

            name = Regex.Replace(name, @"[^\w\.@\ \!~$%()-_=:]", "", RegexOptions.Compiled);

            Uri websiteName = new Uri("https://www.youtube.com");
            Uri CombinedString = new Uri(websiteName, "/results?search_query=" + name);

            webBrowser1.Url = CombinedString;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            p.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            IHTMLElement2 doc = (webBrowser1.Document.DomDocument as IHTMLDocument3).documentElement as IHTMLElement2;
            doc.scrollLeft = 15;
        }
    }
}
