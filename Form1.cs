using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace StundenTimerNeu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lbl_Clock.Text = DateTime.Now.ToString("hh:mm:ss");
            if (DateTime.Now.ToString("HH:mm:ss") == "07:40:00")
            {
                Play_Stunde();
                lbl_Next.Text = "Um 8:25 Uhr klingelt" + Environment.NewLine + " es zur Pause";

            }
            if (DateTime.Now.ToString("HH:mm:ss") == "08:25:00")
            {
                Play_Pause();
                lbl_Next.Text = "Um 8:35 Uhr klingelt" + Environment.NewLine + " es zur Stunde";
            }
            if (DateTime.Now.ToString("HH:mm:ss") == "08:35:00")
            {
                Play_Stunde();
                lbl_Next.Text = "Um 9:20 Uhr klingelt" + Environment.NewLine + " es zur Pause";
            }
            if (DateTime.Now.ToString("HH:mm:ss") == "09:20:00")
            {
                Play_Pause();
                lbl_Next.Text = "Um 9:40 Uhr klingelt" + Environment.NewLine + " es zur Stunde";
            }
            if (DateTime.Now.ToString("HH:mm:ss") == "09:40:00")
            {
                Play_Stunde();
                lbl_Next.Text = "Um 11:10 Uhr klingelt" + Environment.NewLine + " es zur Pause";
            }
            if (DateTime.Now.ToString("HH:mm:ss") == "11:10:00")
            {
                Play_Pause();
                lbl_Next.Text = "Um 11:20 Uhr klingelt" + Environment.NewLine + " es zur Stunde";
            }
            if (DateTime.Now.ToString("HH:mm:ss") == "11:20:00")
            {
                Play_Stunde();
                lbl_Next.Text = "Um 12:05 Uhr klingelt" + Environment.NewLine + " es zur Pause";
            }
            if (DateTime.Now.ToString("HH:mm:ss") == "12:05:00")
            {
                Play_Pause();
                lbl_Next.Text = "Um 12:35 Uhr klingelt" + Environment.NewLine + " es zur Stunde";
            }
            if (DateTime.Now.ToString("HH:mm:ss") == "12:35:00")
            {
                Play_Stunde();
                lbl_Next.Text = "Um 13:20 Uhr ist die " + Environment.NewLine + " Schule vorbei";
            }
            if (DateTime.Now.ToString("HH:mm:ss") == "13:20:00")
            {
                Play_Pause();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Clock.Text = DateTime.Now.ToString("HH:mm:ss");
            Clock.Start();
        }
        private static void Play_Pause()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.Pause);
            audio.Play();
        }
        private static void Play_Stunde()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.Stunde);
            audio.Play();
        }
    }
}