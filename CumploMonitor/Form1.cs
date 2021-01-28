using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CumploMonitor
{
    public partial class MonitorForm : Form
    {
        Thread t1;

        public MonitorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1 = new Thread(() => Monitor.MonitorProcess());
            t1.Start();
        }

        private void monitorButton_Click(object sender, EventArgs e)
        {
            msgLabel.Visible = false;
        }
    }

    /// <summary>
    /// Clase Monitor.
    /// </summary>
    public class Monitor
    {
        private const string cumploUrl = "https://secure.cumplo.mx/";
        //Create the reference for the Chrome browser
        private static IWebDriver driver = new ChromeDriver();
        private static System.Media.SoundPlayer player;
        

        /// <summary>
        /// Activar sonido de alerta de nueva oportunidad.
        /// </summary>
        private static void SoundPlay()
        {
            player = new System.Media.SoundPlayer(@"C:\Windows\Media\Alarm10.wav");
            player.PlayLooping();
        }

        /// <summary>
        /// Parar alarma de oportunidad.
        /// </summary>
        private static void SoundStop()
        {
            if (player != null)
            {
                player.Stop();
            }
        }

        /// <summary>
        /// Proceso de monitoreo.
        /// </summary>
        public static void MonitorProcess()
        {
            int opportunities = 0;
            do
            {
                SoundStop();
                Navigate(cumploUrl);
                opportunities = ChromeNavigation();
            }
            while (opportunities == 0);
            SoundPlay();
        }

        /// <summary>
        /// Navegación usando Chrome.
        /// </summary>
        /// <returns></returns>
        private static int ChromeNavigation()
        {
            IEnumerable<IWebElement> elements = driver.FindElements(By.ClassName("funding-request-see"));

            return elements.Count();
        }

        /// <summary>
        /// Navegación a uri.
        /// </summary>
        /// <param name="uri"></param>
        private static void Navigate(string uri)
        {
            //Navigate to the Jucaba's URL page
            driver.Navigate().GoToUrl(uri);

            //wait
            Thread.Sleep(3000);
        }
    }
}
