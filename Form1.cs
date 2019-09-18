using backup.Controller;
using backup.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace backup
{
    public partial class Form1 : Form
    {

        private List<string> folders;
        private DateTime ? dateArchive;
       

        public Form1()
        {
            InitializeComponent();
            folders = new List<string>();
            dateArchive = null;

        }

        private void BtnToTray_Click(object sender, EventArgs e)
        {
            MinimizeToTray();

        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {

            MinimizeToTray();

        }

        private void MinimizeToTray()
        {
            Hide();
            notifyIcon.Visible = true;
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if (lblPathToBackup.Text != "" && ltvFolder.Items.Count > 0)
            {
                lblMessage.Text = "Backup sendo executado aguarde!";
                SaveConfig();
                StartBackup();

            }
            else if (lblPathToBackup.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione a pasta de destino do backup");
            }
            else
            {
                MessageBox.Show("Selecione a pasta de a ser  feito o backup");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblPathToBackup.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if(folderBrowserAddMoreFolder.ShowDialog() == DialogResult.OK)
            {
                folders.Add(folderBrowserAddMoreFolder.SelectedPath);
                ltvFolder.Items.Add(folderBrowserAddMoreFolder.SelectedPath);
                Configs config = new Configs();
                config.SaveFoldersToBackup(folders.ToArray());
            }
        }

        private void BtnRemoveFolder_Click(object sender, EventArgs e)
        {
            if (ltvFolder.SelectedItems.Count > 0)
            {
                folders.Remove(ltvFolder.SelectedItems[0].Text);
                ltvFolder.SelectedItems[0].Remove();
                Configs config = new Configs();
                config.SaveFoldersToBackup(folders.ToArray());
            }
        }


        private void LoadConfig()
        {
            txtNome.Text = Properties.Settings.Default.nameBackup;
            lblPathToBackup.Text = Properties.Settings.Default.nameFolder;
            txtTimeToNextBackup.Value = Properties.Settings.Default.timeToNextBackup;
            lblLastBackup.Text = Properties.Settings.Default.timeBackup;
            Configs configs = new Configs();
            folders.AddRange(configs.loadFolders());
            
            foreach(string folder in folders)
            {
                ltvFolder.Items.Add(folder);
            }
            
        }

        private void SaveConfig()
        {
            Properties.Settings.Default.nameBackup = txtNome.Text;
            Properties.Settings.Default.nameFolder =lblPathToBackup.Text;
            Properties.Settings.Default.timeToNextBackup = Convert.ToInt32(txtTimeToNextBackup.Value);
            Properties.Settings.Default.timeBackup = lblLastBackup.Text;
            Properties.Settings.Default.Save();
            
            Configs config = new Configs();
            config.SaveFoldersToBackup(folders.ToArray());

        }


        //Carrego a data do último backup
        private void SetBackupDate()
        {

            CompressController compress = new CompressController();
            lblLastBackup.Text = compress.CreationTime(lblPathToBackup.Text, txtNome.Text);
            if(lblLastBackup.Text == "")
            {
                lblLastBackup.Text = Properties.Settings.Default.timeBackup;
            }
        }

        private void AutoBackup()
        {
            if(txtTimeToNextBackup.Value > 0)
            {
                if (lblLastBackup.Text != "")
                {
                    dateArchive = (Convert.ToDateTime(lblLastBackup.Text)).AddDays(Convert.ToDouble(txtTimeToNextBackup.Value));
                  
                    if (dateArchive <= DateTime.Now)
                    {
                        StartBackup();

                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartNotify();
            LoadConfig();
            SetBackupDate();
            AutoBackup();
        }

        private void StartBackup()
        {
            if (lblPathToBackup.Text != "" && ltvFolder.Items.Count > 0)
            {
                SaveConfig();
                CompressController compress = new CompressController();
                notifyIcon.ShowBalloonTip(500);
                notifyIcon.BalloonTipText = "Backup sendo executado";
                if (compress.CompactMyDocuments(lblPathToBackup.Text, folders, txtNome.Text))
                {
                    lblMessage.Text = "Backup feito";
                    SetBackupDate();
                    notifyIcon.BalloonTipText = "Backup feito";
                }
                else
                {
                
                    notifyIcon.BalloonTipText = "Verifique se as pastas existem";
                    lblMessage.Text = "Verifique as pastas de destino ou de backup";
                }
            }
            
        }


        private void StartNotify()
        {
            notifyIcon.BalloonTipTitle = "Backup";
            notifyIcon.BalloonTipText = "Backup funcionando";
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }
    }
}
