using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleTCP;
using System.Net;

namespace TcpIpProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Text += e.MessageString;
            e.ReplyLine(string.Format("You said: {0}", e.MessageString));
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            txtStatus.Text = "server starting";
            IPAddress ip = new IPAddress(long.Parse(txtHost.Text));
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }
    }
}

