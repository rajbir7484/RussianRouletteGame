using RRGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRGame
{
    public partial class Home : Form
    {

        Timer tm;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            tm = new Timer();
            tm.Interval = 2500;
            tm.Start();
            tm.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender,EventArgs e)
        {
            tm.Stop();
            PlayGame ps = new PlayGame();
            ps.Show();
            this.Hide();
        }
    }
}
