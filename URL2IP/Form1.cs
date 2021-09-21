using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace URL2IP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ChangeUrl_Click(object sender, EventArgs e)
        {
            string url;            
            url = txt_Url.Text;

            IPHostEntry urlInfo;

            urlInfo = Dns.GetHostEntry(url);

            if (urlInfo.AddressList.Length > 0)
            {
                foreach (IPAddress ip in urlInfo.AddressList)
                {
                    lb_IP.Items.Add(url +" : "+ "IP is: "+ip.ToString());
                }
            } 

            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
