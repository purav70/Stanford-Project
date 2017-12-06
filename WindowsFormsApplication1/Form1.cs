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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //notifyIcon1.ShowBalloonTip(1000, "Harmful Posuture Detected", "Please arch your back more", ToolTipIcon.Info);
            showBalloon("Harmful Posture Detected!", "Please arch your back more (it's for your own good!). Click for more information!", SystemIcons.Warning);
        }
        private void showBalloon(string title, string body, Icon icon)
        {
            Thread.Sleep(2000);
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;

            if (title != null)
            {
                notifyIcon.BalloonTipTitle = title;
            }

            if (body != null)
            {
                notifyIcon.BalloonTipText = body;
            }
            notifyIcon.Icon = icon;

            notifyIcon.ShowBalloonTip(30000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //notifyIcon1.ShowBalloonTip(1000, "Harmful Posuture Detected", "Please arch your back more", ToolTipIcon.Info);
            showBalloon("Harmful Posture Detected!", "Rest your neck against the rest. Click for more information!", SystemIcons.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showBalloon("Break Time!", "You've been sitting too long, perhaps it is time for a break? Go walk to the nearest coffee machine", SystemIcons.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showBalloon("Health Summary", "Before logging off, why not click to see your health accomplishments for the day?", SystemIcons.Application);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showBalloon("Checkup", "Did you take the stairs today after lunch?", SystemIcons.Application);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            showBalloon("___ Battery Life Low", "Don't forget to put your seat to charge before you leave work", SystemIcons.Warning);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showBalloon("Break Time!", "You're still sitting down, a walk to the nearest coffee machine will help alleviate the dangers of sitting too long such as heart disease", SystemIcons.Exclamation);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //showBalloon("Checkup!", "Did you walk to a coffee machine?", SystemIcons.Exclamation);
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Checkup!";
            notifyIcon1.BalloonTipText = "Did you walk to a coffee machine?";
            notifyIcon1.Icon = SystemIcons.Exclamation;

            notifyIcon1.ShowBalloonTip(30000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
