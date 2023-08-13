using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] paths, files;

        private void btnDosyaekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    lbOynatmaListesi.Items.Add(files[i]);
                }
            }
        }

        private void btnGenisekran_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnKucult_Click(object sender, EventArgs e)  //simge durumuna küçültme
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            btnPlay.Visible = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            btnPlay.Visible = true;
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (lbOynatmaListesi.SelectedIndex < lbOynatmaListesi.Items.Count - 1)
            {
                lbOynatmaListesi.SelectedIndex = lbOynatmaListesi.SelectedIndex + 1;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (lbOynatmaListesi.SelectedIndex > 0)
            {
                lbOynatmaListesi.SelectedIndex = lbOynatmaListesi.SelectedIndex - 1;
            }
        }

        private void tbarSes_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = tbarSes.Value;
            if (axWindowsMediaPlayer1.settings.volume==0)
            {
                btnSes.Visible = false;
            }
            else
            {
                btnSes.Visible = true;
            }
            
        }

        
        private void btnSes_Click(object sender, EventArgs e) // butonun ses açıkkenki görüntüsü
        {
            btnSes.Visible = false;
            axWindowsMediaPlayer1.settings.volume = 0;
            tbarSes.Value = 0;

        }

        private void btnSeskapat_Click(object sender, EventArgs e) // butonun ses kapalıykenki görüntüsü
        {
            axWindowsMediaPlayer1.settings.volume = tbarSes.Value;
            btnSes.Visible = true;
        }

        private void pBarMedya_progressChanged(object sender, EventArgs e)
        {
          //  axWindowsMediaPlayer1.settings.
          
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                pBarMedya.MaximumValue = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                pBarMedya.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblZaman1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;   // o anki bulundğu saniyeyi yazdırır
            lblZaman2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();   //medyanın toplam uzunluğunu yazdırır

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)    //oynayan biir medya varsa progressbar'da ilerlemesini gösterir
            {
                pBarMedya.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        

        private void btnOynatmaListesi_Click(object sender, EventArgs e)
        {
            if (lbOynatmaListesi.Visible == true)
            {
                lbOynatmaListesi.Visible = false;
            }
            else
                lbOynatmaListesi.Visible = true;
        }

        

        private void lbOynatmaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[lbOynatmaListesi.SelectedIndex]; // listeden  bir  medya seçtiğinde oynat
            btnPlay.Visible = false;
            label1.Text = lbOynatmaListesi.Text;
        }
    }
}
