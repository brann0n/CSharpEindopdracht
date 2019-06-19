using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EindopdrachtCSharp
{
    public partial class MainScreen : Form
    {
		private const string apiKey = "YEET";
		public DateTime lastRefresh = DateTime.Now;
        public MainScreen()
        {
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(2000);
            t.Abort();
            InitializeComponent();

            //to bring the form to the foreground
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;

			loadOptions(true);
			MainScreenTabControl.Selected += MainScreenTabControl_Selected;
        }

		private void MainScreenTabControl_Selected(object sender, TabControlEventArgs e)
		{
			TabControl thisControl = (TabControl)sender;
			if(thisControl.SelectedIndex == 1)
			{
				//draw the graph
			}
		}

		private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                TaskbarIcon.ShowBalloonTip(1000, "NHL Stenden Weerstation", "Programma is nu verborgen dubbel klik om weer te geven", ToolTipIcon.None);
            }
        }

        private void TaskbarIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void TaskbarIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
        }

        private void SluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void splash()
        {
            Application.Run(new SplashScreen());
        }

		private void Button1_Click(object sender, EventArgs e)
		{
			
		}

		private void OptiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show();
			MainScreenTabControl.SelectTab(2);
		}

		private void Btn_options_Click(object sender, EventArgs e)
		{
			loadOptions(true);
		}

		private void loadOptions(bool reloadWeather)
		{
			if (txt_cityname.Text != "" && reloadWeather)
			{
				WeatherAPIControl api = new WeatherAPIControl(apiKey, txt_cityname.Text);
				api.Save();
				api.UpdateScreen(this);
			}
			if (numericUpDown1.Text != "" && numericUpDown1.Text != "0")
			{
				refreshTimer.Interval = (1000 * (Int32.Parse(numericUpDown1.Text)));
			}
			if (checkBox1.Checked)
			{
				refreshTimer.Enabled = true;
			}
			else if (!checkBox1.Checked)
			{
				refreshTimer.Enabled = false;
			}
		}

		private void RefreshTimer_Tick(object sender, EventArgs e)
		{
			string locale = txt_cityname.Text;
			WeatherAPIControl api = new WeatherAPIControl(apiKey, ((string.IsNullOrEmpty(locale) ? locale : "Emmen")));
			api.Save();
			api.UpdateScreen(this);
		}

		private List<WeatherInfo> get5DayWeather()
		{
			DateTime oneTwentyDaysAgo = DateTime.Today.AddDays(-120);

			return null;
		}
	}
}
