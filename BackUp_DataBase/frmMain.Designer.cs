namespace BackUp_DataBase
{
    partial class frmBackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackUp));
            this.btnStartBackUp = new System.Windows.Forms.Button();
            this.btnSaveDialog = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblTitreBackUp = new System.Windows.Forms.Label();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.picLogoBackup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartBackUp
            // 
            this.btnStartBackUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartBackUp.BackColor = System.Drawing.Color.Transparent;
            this.btnStartBackUp.Enabled = false;
            this.btnStartBackUp.FlatAppearance.BorderSize = 0;
            this.btnStartBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartBackUp.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 24F);
            this.btnStartBackUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartBackUp.Location = new System.Drawing.Point(12, 398);
            this.btnStartBackUp.Name = "btnStartBackUp";
            this.btnStartBackUp.Size = new System.Drawing.Size(201, 56);
            this.btnStartBackUp.TabIndex = 9;
            this.btnStartBackUp.Text = "DEBUTER";
            this.btnStartBackUp.UseVisualStyleBackColor = false;
            this.btnStartBackUp.Click += new System.EventHandler(this.btnStartBackUp_Click);
            // 
            // btnSaveDialog
            // 
            this.btnSaveDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDialog.FlatAppearance.BorderSize = 0;
            this.btnSaveDialog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveDialog.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDialog.Location = new System.Drawing.Point(12, 294);
            this.btnSaveDialog.Name = "btnSaveDialog";
            this.btnSaveDialog.Size = new System.Drawing.Size(201, 28);
            this.btnSaveDialog.TabIndex = 8;
            this.btnSaveDialog.Text = "Choisir un emplacement d\'enregistrement";
            this.btnSaveDialog.UseVisualStyleBackColor = true;
            this.btnSaveDialog.Click += new System.EventHandler(this.btnSaveDialog_Click);
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPath.Location = new System.Drawing.Point(12, 336);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(201, 48);
            this.lblPath.TabIndex = 7;
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreBackUp
            // 
            this.lblTitreBackUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitreBackUp.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreBackUp.Location = new System.Drawing.Point(12, 21);
            this.lblTitreBackUp.Name = "lblTitreBackUp";
            this.lblTitreBackUp.Size = new System.Drawing.Size(243, 30);
            this.lblTitreBackUp.TabIndex = 6;
            this.lblTitreBackUp.Text = "Backup MySql BD";
            // 
            // picSettings
            // 
            this.picSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSettings.Image = global::BackUp_DataBase.Properties.Resources.iconfinder_settings_4341324_120534;
            this.picSettings.Location = new System.Drawing.Point(220, 71);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(35, 31);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSettings.TabIndex = 11;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // picLogoBackup
            // 
            this.picLogoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogoBackup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoBackup.Image = global::BackUp_DataBase.Properties.Resources.database_cache_128;
            this.picLogoBackup.Location = new System.Drawing.Point(12, 71);
            this.picLogoBackup.Name = "picLogoBackup";
            this.picLogoBackup.Size = new System.Drawing.Size(201, 215);
            this.picLogoBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoBackup.TabIndex = 5;
            this.picLogoBackup.TabStop = false;
            // 
            // frmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(264, 488);
            this.Controls.Add(this.picSettings);
            this.Controls.Add(this.btnStartBackUp);
            this.Controls.Add(this.btnSaveDialog);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblTitreBackUp);
            this.Controls.Add(this.picLogoBackup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 527);
            this.Name = "frmBackUp";
            this.Text = "backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackUp_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartBackUp;
        private System.Windows.Forms.Button btnSaveDialog;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblTitreBackUp;
        private System.Windows.Forms.PictureBox picLogoBackup;
        private System.Windows.Forms.PictureBox picSettings;
    }
}

