using System;
using System.Windows.Forms;

namespace Music_Player_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Developped by Blasius Fosso Difo".ToUpper());
        }
        string[] Datein, folder;
        private void BtnDatein_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            //Oeffne das Datei
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Datein = ofd.SafeFileNames; //speichere der MusicsName in meinem Array
                folder = ofd.FileNames; // speichere den der Music in meindém Array
                for (int i = 0; i < Datein.Length; i++)
                {
                    PlayList.Items.Add(Datein[i]); // einzelne oder Mehreren Dateien einfügen
                }
            }
        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////// zu verarbeiten, weil ich wahlProbleme habe/////

            WindowsPlayerInterface.URL = folder[PlayList.SelectedIndex]; // weise jetzt die Gewälte Music in meinem Windows Media Player zu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHidePlaylist_Click(object sender, EventArgs e)
        {
            if (BtnHidePlaylist.Text == ">")
            {
                pnlregroupPlaylist.Hide();
                BtnHidePlaylist.Text = "<";
                WindowsPlayerInterface.Width = 827 - 37;                
            }
            else if (BtnHidePlaylist.Text == "<")
            {
                
                pnlregroupPlaylist.Show();
                BtnHidePlaylist.Text = ">";
                WindowsPlayerInterface.Width = 566;
            }
        }
    }
}