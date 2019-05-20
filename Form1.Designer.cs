namespace Music_Player_APP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WindowsPlayerInterface = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnDatein = new System.Windows.Forms.Button();
            this.BtnHidePlaylist = new System.Windows.Forms.Button();
            this.pnlregroupPlaylist = new System.Windows.Forms.Panel();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsPlayerInterface)).BeginInit();
            this.pnlregroupPlaylist.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowsPlayerInterface
            // 
            resources.ApplyResources(this.WindowsPlayerInterface, "WindowsPlayerInterface");
            this.WindowsPlayerInterface.Name = "WindowsPlayerInterface";
            this.WindowsPlayerInterface.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsPlayerInterface.OcxState")));
            // 
            // BtnDatein
            // 
            resources.ApplyResources(this.BtnDatein, "BtnDatein");
            this.BtnDatein.Name = "BtnDatein";
            this.BtnDatein.UseVisualStyleBackColor = true;
            this.BtnDatein.Click += new System.EventHandler(this.BtnDatein_Click);
            // 
            // BtnHidePlaylist
            // 
            resources.ApplyResources(this.BtnHidePlaylist, "BtnHidePlaylist");
            this.BtnHidePlaylist.Name = "BtnHidePlaylist";
            this.BtnHidePlaylist.UseVisualStyleBackColor = true;
            this.BtnHidePlaylist.Click += new System.EventHandler(this.BtnHidePlaylist_Click);
            // 
            // pnlregroupPlaylist
            // 
            resources.ApplyResources(this.pnlregroupPlaylist, "pnlregroupPlaylist");
            this.pnlregroupPlaylist.Controls.Add(this.BtnDatein);
            this.pnlregroupPlaylist.Controls.Add(this.PlayList);
            this.pnlregroupPlaylist.Name = "pnlregroupPlaylist";
            // 
            // PlayList
            // 
            resources.ApplyResources(this.PlayList, "PlayList");
            this.PlayList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayList.ForeColor = System.Drawing.Color.Black;
            this.PlayList.FormattingEnabled = true;
            this.PlayList.Name = "PlayList";
            this.PlayList.SelectedIndexChanged += new System.EventHandler(this.PlayList_SelectedIndexChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnHidePlaylist);
            this.panel1.Name = "panel1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlregroupPlaylist);
            this.Controls.Add(this.WindowsPlayerInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WindowsPlayerInterface)).EndInit();
            this.pnlregroupPlaylist.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WindowsPlayerInterface;
        private System.Windows.Forms.Button BtnDatein;
        private System.Windows.Forms.Panel pnlregroupPlaylist;
        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.Button BtnHidePlaylist;
        private System.Windows.Forms.Panel panel1;
    }
}

