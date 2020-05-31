using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3BuildPlanner
{
    class Updater
    {
        public Updater()
        {

        }
        public void update() { 
            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/4SDWV9m4").Contains("1.0"))
            {
                if (MessageBox.Show("Update available", "DS3BuildPlanner Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/Asiern/DS3BuildPlanner/releases");
                }
                else
                {

                }
            }
        }

        public string getVersion()
        {
            WebClient webClient = new WebClient();
            return webClient.DownloadString("https://pastebin.com/raw/4SDWV9m4");
        }
    }
}
