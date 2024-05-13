namespace BackUp_DataBase
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStartBackUp = new System.Windows.Forms.Button();
            this.btnSaveDialog = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblTitreBackUp = new System.Windows.Forms.Label();
            this.picLogoBackup = new System.Windows.Forms.PictureBox();
            this.contextMenuStripCTRL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBackup)).BeginInit();
            this.contextMenuStripCTRL.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartBackUp
            // 
            this.btnStartBackUp.BackColor = System.Drawing.Color.Transparent;
            this.btnStartBackUp.Enabled = false;
            this.btnStartBackUp.FlatAppearance.BorderSize = 0;
            this.btnStartBackUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBackUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartBackUp.Location = new System.Drawing.Point(13, 338);
            this.btnStartBackUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartBackUp.Name = "btnStartBackUp";
            this.btnStartBackUp.Size = new System.Drawing.Size(213, 34);
            this.btnStartBackUp.TabIndex = 9;
            this.btnStartBackUp.Text = "Débuter";
            this.btnStartBackUp.UseVisualStyleBackColor = false;
            this.btnStartBackUp.Click += new System.EventHandler(this.btnStartBackUp_Click);
            // 
            // btnSaveDialog
            // 
            this.btnSaveDialog.FlatAppearance.BorderSize = 0;
            this.btnSaveDialog.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnSaveDialog.Location = new System.Drawing.Point(14, 237);
            this.btnSaveDialog.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveDialog.Name = "btnSaveDialog";
            this.btnSaveDialog.Size = new System.Drawing.Size(212, 34);
            this.btnSaveDialog.TabIndex = 8;
            this.btnSaveDialog.Text = "Choisir un emplacement d\'enregistrement";
            this.btnSaveDialog.UseVisualStyleBackColor = true;
            this.btnSaveDialog.Click += new System.EventHandler(this.btnSaveDialog_Click);
            // 
            // lblPath
            // 
            this.lblPath.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPath.Location = new System.Drawing.Point(14, 275);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(212, 59);
            this.lblPath.TabIndex = 7;
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreBackUp
            // 
            this.lblTitreBackUp.AutoSize = true;
            this.lblTitreBackUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreBackUp.Location = new System.Drawing.Point(14, 26);
            this.lblTitreBackUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreBackUp.Name = "lblTitreBackUp";
            this.lblTitreBackUp.Size = new System.Drawing.Size(143, 19);
            this.lblTitreBackUp.TabIndex = 6;
            this.lblTitreBackUp.Text = "Backup MySql BD";
            // 
            // picLogoBackup
            // 
            this.picLogoBackup.Image = global::BackUp_DataBase.Properties.Resources.database_cache_128;
            this.picLogoBackup.Location = new System.Drawing.Point(13, 49);
            this.picLogoBackup.Margin = new System.Windows.Forms.Padding(4);
            this.picLogoBackup.Name = "picLogoBackup";
            this.picLogoBackup.Size = new System.Drawing.Size(213, 180);
            this.picLogoBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoBackup.TabIndex = 5;
            this.picLogoBackup.TabStop = false;
            // 
            // contextMenuStripCTRL
            // 
            this.contextMenuStripCTRL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem});
            this.contextMenuStripCTRL.Name = "contextMenuStripCTRL";
            this.contextMenuStripCTRL.Size = new System.Drawing.Size(134, 26);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(239, 452);
            this.Controls.Add(this.btnStartBackUp);
            this.Controls.Add(this.btnSaveDialog);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblTitreBackUp);
            this.Controls.Add(this.picLogoBackup);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 640);
            this.Name = "frmMain";
            this.Text = "backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackUp_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBackup)).EndInit();
            this.contextMenuStripCTRL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartBackUp;
        private System.Windows.Forms.Button btnSaveDialog;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblTitreBackUp;
        private System.Windows.Forms.PictureBox picLogoBackup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCTRL;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
    }
}

