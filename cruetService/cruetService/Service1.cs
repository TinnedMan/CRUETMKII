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

namespace cruetService
{
    
    
    public partial class Service1 : ServiceBase
    {
        //public Cookie(string name, string value, string domain, string path, DateTime? expiry);
        //temp class members
        string CName, CValue, Cdomain, CPath;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
           Cookie MySessionCookie = new Cookie("test","test");

            Console.WriteLine(MySessionCookie.Name);
        }

        protected override void OnStop()
        {

        }

        private void flowLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
