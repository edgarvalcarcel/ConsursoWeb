using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinSerRankingCierre
{
    public partial class ServiceRankingCierre : ServiceBase
    {
        public ServiceRankingCierre()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("RankingCierre"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "RankingCierre", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Inicio Servicio RankingCierre");
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = double.Parse(ConfigurationManager.AppSettings["IntervalosEjecucion"].ToString()); // 60000; // 60 seconds  
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Se detuvo el servicio RankingCierre"); 
        }
        protected override void OnContinue()
        {
            eventLog1.WriteEntry("In OnContinue.");
        }
        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.  
            

        }
    }
}
