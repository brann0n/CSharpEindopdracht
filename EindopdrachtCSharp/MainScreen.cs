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
using System.Windows.Forms.DataVisualization.Charting;

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
			if (thisControl.SelectedIndex == 1)
			{
				drawGraph();
			}
		}

		private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
				//TaskbarIcon.ShowBalloonTip(1000, "NHL Stenden Weerstation", "Programma is nu verborgen dubbel klik om weer te geven", ToolTipIcon.None);
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
			string locale = txt_cityname.Text;
			EindopdrachtEntities db = new EindopdrachtEntities();
			DateTime beginDate = DateTime.Today.AddDays(-5);
			DateTime endDate = DateTime.Today;
			WeatherInfo[] histData = db.WeatherInfoes.Where(record => record.Timestamp >= beginDate && record.Timestamp <= endDate).ToArray();
			return histData.Where(data => data.Locale == ((string.IsNullOrEmpty(locale) ? locale : "Emmen"))).ToList();
		}

		private void VerversenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RefreshTimer_Tick(null, null); //just call the timers tick funtion
		}

		private void OverToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AboutWeatherStation().Show();
		}

		private void drawGraph()
		{
			EindopdrachtEntities db = new EindopdrachtEntities();
			List<DateTime> dates = get5DayWeather().Select(n => n.Timestamp.Value.Date).Distinct().ToList();
			List<double> temps = new List<double>();
			if (radio_celsius.Checked)
			{
				foreach (var date in dates)
				{
					temps.Add(get5DayWeather().Where(all => all.Timestamp.Value.Date == date).Average(avg => double.Parse(avg.Temperature)));
				}
			}
			else
			{
				foreach (var date in dates)
				{
					double temp = get5DayWeather().Where(all => all.Timestamp.Value.Date == date).Average(avg => double.Parse(avg.Temperature));
					temps.Add(((9.0 / 5.0) * temp + 32));
				}
			}

			chart1.Series.Clear();
			//Create a new Chart and add data
			var series = new Series("Gemiddelde temperatuur");
			series.ChartType = SeriesChartType.Line;
			series.Points.DataBindXY(dates.ToArray(), temps.ToArray());
			//Kies het correcte label voor de Y Axis
			if (radio_celsius.Checked)
			{
				chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{#,##} \u00B0" + "C";
			}
			else
			{
				chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{#,##} \u00B0" + "F";
			}


			chart1.Series.Add(series);
			chart1.Series[0].IsVisibleInLegend = false;

			chart1.ChartAreas[0].RecalculateAxesScale();

			//kijkt of er een stad is ingevoert
			if (txt_cityname.Text != "")
			{
				lbl_graphCityName.Text = txt_cityname.Text;

			}
			else if (txt_cityname.Text == "")
			{
				lbl_graphCityName.Text = "Emmen";
			}
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show();
		}
	}
}
