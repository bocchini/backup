namespace backup
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnToTray = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPathToBackup = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.folderBrowserAddMoreFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.ltvFolder = new System.Windows.Forms.ListView();
            this.columnFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastBackup = new System.Windows.Forms.Label();
            this.txtTimeToNextBackup = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeToNextBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessage});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            resources.ApplyResources(this.lblMessage, "lblMessage");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToTray});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btnToTray
            // 
            this.btnToTray.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnToTray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btnToTray, "btnToTray");
            this.btnToTray.Name = "btnToTray";
            this.btnToTray.Click += new System.EventHandler(this.BtnToTray_Click);
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // btnBackup
            // 
            resources.ApplyResources(this.btnBackup, "btnBackup");
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblPathToBackup
            // 
            resources.ApplyResources(this.lblPathToBackup, "lblPathToBackup");
            this.lblPathToBackup.Name = "lblPathToBackup";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAdicionar
            // 
            resources.ApplyResources(this.btnAdicionar, "btnAdicionar");
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ltvFolder
            // 
            this.ltvFolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFolder});
            this.ltvFolder.FullRowSelect = true;
            this.ltvFolder.GridLines = true;
            this.ltvFolder.HideSelection = false;
            resources.ApplyResources(this.ltvFolder, "ltvFolder");
            this.ltvFolder.MultiSelect = false;
            this.ltvFolder.Name = "ltvFolder";
            this.ltvFolder.UseCompatibleStateImageBehavior = false;
            this.ltvFolder.View = System.Windows.Forms.View.Details;
            // 
            // columnFolder
            // 
            resources.ApplyResources(this.columnFolder, "columnFolder");
            // 
            // btnRemoveFolder
            // 
            resources.ApplyResources(this.btnRemoveFolder, "btnRemoveFolder");
            this.btnRemoveFolder.Name = "btnRemoveFolder";
            this.btnRemoveFolder.UseVisualStyleBackColor = true;
            this.btnRemoveFolder.Click += new System.EventHandler(this.BtnRemoveFolder_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblLastBackup
            // 
            resources.ApplyResources(this.lblLastBackup, "lblLastBackup");
            this.lblLastBackup.Name = "lblLastBackup";
            // 
            // txtTimeToNextBackup
            // 
            resources.ApplyResources(this.txtTimeToNextBackup, "txtTimeToNextBackup");
            this.txtTimeToNextBackup.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtTimeToNextBackup.Name = "txtTimeToNextBackup";
            this.txtTimeToNextBackup.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimeToNextBackup);
            this.Controls.Add(this.lblLastBackup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveFolder);
            this.Controls.Add(this.ltvFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPathToBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeToNextBackup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnToTray;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPathToBackup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserAddMoreFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ltvFolder;
        private System.Windows.Forms.ColumnHeader columnFolder;
        private System.Windows.Forms.Button btnRemoveFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastBackup;
        private System.Windows.Forms.NumericUpDown txtTimeToNextBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

