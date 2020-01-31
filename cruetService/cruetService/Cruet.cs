using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Data.SQLite;

namespace cruetService
{
    
    
    public partial class Cruet : ServiceBase
    {
        //public Cookie(string name, string value, string domain, string path, DateTime? expiry);

       


        public Cruet()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //instantiate the database
            
           
            //
        }

        protected override void OnStop()
        {

        }

        private void flowLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
