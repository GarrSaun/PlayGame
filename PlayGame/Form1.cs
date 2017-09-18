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

namespace PlayGame
{
    public partial class background : Form
    {
        public background()
        {
            InitializeComponent();
        }

        SoundPlayer ding = new SoundPlayer(Properties.Resources.up);

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = false;
            start3.ForeColor = Color.White;
            ding.Play();
            this.Refresh();
            Thread.Sleep(1000);

            start3.Text = "Game Starts In: 2";
            ding.Play();
            this.Refresh();
            Thread.Sleep(1000);

            start3.Text = "Game Starts In: 1";
            ding.Play();
            this.Refresh();
            Thread.Sleep(1000);

            //Graphics Stuff
            start3.Visible = false;
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.LimeGreen);
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            //Red Ellipse
            formGraphics.DrawEllipse(drawPen, 159, 87, 200, 200);
            formGraphics.FillEllipse(drawBrush, 159, 87, 200, 200);

            //C
            drawBrush.Color = Color.White;
            Font cFont = new Font("Copperplate Gothic", 120, FontStyle.Bold);
            formGraphics.DrawString("C", cFont, drawBrush, 150, 100);

            //Rams
            Font ramFont = new Font("Segoe UI", 25, FontStyle.Bold);
            formGraphics.DrawString("Rams", ramFont, drawBrush, 240, 163);

            //Rotated Text
            Font turnFont = new Font("Sugoe UI", 10, FontStyle.Bold);
            formGraphics.TranslateTransform(375, 260);
            formGraphics.RotateTransform(270);
            formGraphics.DrawString("Central Rams Arcade", turnFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();
        }
    }
}
