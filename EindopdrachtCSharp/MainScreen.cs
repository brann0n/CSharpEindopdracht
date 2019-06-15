using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EindopdrachtCSharp
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
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
    }
}
