using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace StartGame_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click (object sender, EventArgs e)
        {
            StartButton.Visible = false;
            StartLabel.ForeColor = Color.White;
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alertSound);
            alertPlayer.Play();
            
            Refresh();
            Thread.Sleep(1000);

            StartLabel.Text = "Game Will Start In 2...";
           
            Refresh();
            Thread.Sleep(1000);

            StartLabel.Text = "Game Will Start In 1...";
            Refresh();

            Thread.Sleep(1000);
            alertPlayer.Stop();
            SoundPlayer alertSound2 = new SoundPlayer(Properties.Resources.alertSound2);
            alertSound2.Play();
            StartLabel.Text = "GOOO!!";
            StartLabel.BackColor = Color.Green;
            this.BackColor = Color.Green;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
