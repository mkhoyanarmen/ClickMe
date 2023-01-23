using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int points,ticks,firstTick;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblBtnSize.Text = trcButtonSize.Value.ToString();
            btnClickMe.Location = new Point(100, 150);
            txtPlayerName.Text = "Player";
            points = 0;
            ticks = int.Parse(txtSeconds.Text);
            firstTick = int.Parse(txtSeconds.Text);
            readFromFile();
        }

        private void trcButtonSize_Scroll(object sender, EventArgs e)
        {
            lblBtnSize.Text = trcButtonSize.Value.ToString();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            timer.Start();
            points++;
            lblPoints.Text = points.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            lblBtnSize.Text = trcButtonSize.Value.ToString();
            switch (trcButtonSize.Value)
            {
                case 1:
                    btnClickMe.Width = 60;
                    btnClickMe.Height = 25;
                    btnClickMe.Location = new Point(100, 150);
                    break;
                case 2:
                    btnClickMe.Width = 80;
                    btnClickMe.Height = 45;
                    btnClickMe.Location = new Point(90, 140);
                    break;
                case 3:
                    btnClickMe.Width = 100;
                    btnClickMe.Height = 65;
                    btnClickMe.Location = new Point(80, 130);
                    break;
                case 4:
                    btnClickMe.Width = 120;
                    btnClickMe.Height = 85;
                    btnClickMe.Location = new Point(70, 120);
                    break;
                case 5:
                    btnClickMe.Width = 140;
                    btnClickMe.Height = 105;
                    btnClickMe.Location = new Point(60, 110);
                    break;
                case 6:
                    btnClickMe.Width = 160;
                    btnClickMe.Height = 125;
                    btnClickMe.Location = new Point(50, 100);
                    break;
                case 7:
                    btnClickMe.Width = 180;
                    btnClickMe.Height = 145;
                    btnClickMe.Location = new Point(40, 90);
                    break;
                case 8:
                    btnClickMe.Width = 200;
                    btnClickMe.Height = 165;
                    btnClickMe.Location = new Point(30, 80);
                    break;
                case 9:
                    btnClickMe.Width = 220;
                    btnClickMe.Height = 185;
                    btnClickMe.Location = new Point(20, 70);
                    break;
                default:
                    break;
            }

            lblProgSec.Text = txtSeconds.Text;
            ticks = int.Parse(txtSeconds.Text);
            firstTick = int.Parse(txtSeconds.Text);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtPlayerName.Text = "Player";
            lblBtnSize.Text = "1";
            trcButtonSize.Value = 1;
            lblProgSec.Text = txtSeconds.Text = "10";
            btnClickMe.Width = 60;
            btnClickMe.Height = 25;
            btnClickMe.Location = new Point(100, 150);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ticks == 0)
            {
                timer.Stop();
                btnClickMe.Enabled = false;
                gbSettings.Enabled = true;
                btnResults.Enabled = true;
                if (lstPlayers.Items.Count > 19)
                {
                    lstPlayers.Items.RemoveAt(lstPlayers.Items.Count-1);
                    lstPoints.Items.RemoveAt(lstPoints.Items.Count-1);
                }
                addToLeaderBoard(int.Parse(lblPoints.Text));
                addToFile();
            }
            lblProgSec.Text = ticks.ToString();
            ticks--;
            progressBar1.Value++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("Please, enter your name!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlayerName.Focus();
                return;
            }
            if (txtSeconds.Text == "")
            {
                MessageBox.Show("Please, enter the quantity of seconds!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSeconds.Focus();
                return;
            }
            gbGameArena.Enabled = true;
            btnClickMe.Enabled = true;
            gbSettings.Enabled = false;
            ticks = int.Parse(txtSeconds.Text);
            lblProgSec.Text = txtSeconds.Text;
            points = 0;
            progressBar1.Maximum = ticks+1;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            btnResults.Enabled = false;
        }
        private void addToLeaderBoard(int score)
        {
            int insertIndex = 0;
            for (insertIndex = 0; insertIndex < lstPoints.Items.Count; insertIndex++)
            {
                int cScore = Convert.ToInt32(lstPoints.Items[insertIndex]);
                if (score > cScore) break;
            }
            
            lstPlayers.Items.Insert(insertIndex,"Name: " + txtPlayerName.Text);
            lstPoints.Items.Insert(insertIndex, score);
        }
        private void addToFile()
        {
            File.Delete("results.txt");
            for (int i = 0; i < lstPlayers.Items.Count; i++)
            {
                File.AppendAllText("results.txt",lstPlayers.Items[i] + "\n");
                File.AppendAllText("results.txt", "Score: " + lstPoints.Items[i] + "\n\n");
            }
        }
        private void readFromFile()
        {
            string [] text = File.ReadAllLines("results.txt");
            for (int i = 0; i < text.Length; i+=3)
            {
                lstPlayers.Items.Add(text[i]);
                lstPoints.Items.Add(text[i+1].Substring(7));
            }
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            Process.Start("results.txt");
        }
    }
}
