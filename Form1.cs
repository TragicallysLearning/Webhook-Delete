using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Webhook_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/9QVeTZasTN");
        }

        private void hookDel_Click(object sender, EventArgs e)
        {
            if (hook.Text == "Webhook URL")
            {
                MessageBox.Show("Enter A Webhook URL.");
            }

            else if (hook.Text == "")
            {
                MessageBox.Show("Enter A Webhook URL.");
            }

            else if (hook.Text.Contains("https://discordapp.com/api/webhooks/"))
            {
                WebRequest request = WebRequest.Create($"{hook.Text}");
                request.Method = "DELETE";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                MessageBox.Show("Deleted Webhook.");
            }

            else if (hook.Text.Contains("https://discordapp.com/api/webhooks/") == false)
            {
                MessageBox.Show("Invalid Webhook.");
            }
        }
    }
}
