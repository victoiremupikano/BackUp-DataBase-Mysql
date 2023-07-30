namespace BackUp_DataBase
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tbServeur = new System.Windows.Forms.TabPage();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.lbldatabase = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.lblport = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnlBaodDroit = new System.Windows.Forms.Panel();
            this.pnlBordGauche = new System.Windows.Forms.Panel();
            this.btnTester = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.tbServeur.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbServeur
            // 
            this.tbServeur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbServeur.Controls.Add(this.txtIp);
            this.tbServeur.Controls.Add(this.lblIp);
            this.tbServeur.Controls.Add(this.txtdatabase);
            this.tbServeur.Controls.Add(this.lbldatabase);
            this.tbServeur.Controls.Add(this.txtpassword);
            this.tbServeur.Controls.Add(this.lblpassword);
            this.tbServeur.Controls.Add(this.txtusername);
            this.tbServeur.Controls.Add(this.lblUsername);
            this.tbServeur.Controls.Add(this.txtport);
            this.tbServeur.Controls.Add(this.lblport);
            this.tbServeur.Location = new System.Drawing.Point(4, 22);
            this.tbServeur.Name = "tbServeur";
            this.tbServeur.Padding = new System.Windows.Forms.Padding(3);
            this.tbServeur.Size = new System.Drawing.Size(233, 344);
            this.tbServeur.TabIndex = 0;
            this.tbServeur.Text = "Serveur";
            // 
            // txtIp
            // 
            this.txtIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIp.BackColor = System.Drawing.Color.White;
            this.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.Location = new System.Drawing.Point(6, 46);
            this.txtIp.MaxLength = 15;
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(217, 22);
            this.txtIp.TabIndex = 11;
            this.txtIp.UseSystemPasswordChar = true;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(6, 28);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(63, 13);
            this.lblIp.TabIndex = 10;
            this.lblIp.Text = "Adresse Ip :";
            // 
            // txtdatabase
            // 
            this.txtdatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdatabase.BackColor = System.Drawing.Color.White;
            this.txtdatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatabase.Location = new System.Drawing.Point(6, 150);
            this.txtdatabase.MaxLength = 15;
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(217, 22);
            this.txtdatabase.TabIndex = 9;
            this.txtdatabase.UseSystemPasswordChar = true;
            // 
            // lbldatabase
            // 
            this.lbldatabase.AutoSize = true;
            this.lbldatabase.Location = new System.Drawing.Point(6, 132);
            this.lbldatabase.Name = "lbldatabase";
            this.lbldatabase.Size = new System.Drawing.Size(92, 13);
            this.lbldatabase.TabIndex = 8;
            this.lbldatabase.Text = "Dase de donnée :";
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(6, 267);
            this.txtpassword.MaxLength = 30;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(217, 22);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(6, 250);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(77, 13);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "Mot de passe :";
            // 
            // txtusername
            // 
            this.txtusername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(6, 215);
            this.txtusername.MaxLength = 15;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(217, 22);
            this.txtusername.TabIndex = 5;
            this.txtusername.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 197);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Nom d\'utilisateur :";
            // 
            // txtport
            // 
            this.txtport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtport.BackColor = System.Drawing.Color.White;
            this.txtport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtport.Location = new System.Drawing.Point(6, 98);
            this.txtport.MaxLength = 5;
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(217, 22);
            this.txtport.TabIndex = 3;
            this.txtport.UseSystemPasswordChar = true;
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(6, 79);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(29, 13);
            this.lblport.TabIndex = 2;
            this.lblport.Text = "Port:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbServeur);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(241, 370);
            this.tabControl1.TabIndex = 87;
            // 
            // pnlBaodDroit
            // 
            this.pnlBaodDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlBaodDroit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBaodDroit.Location = new System.Drawing.Point(245, 0);
            this.pnlBaodDroit.Name = "pnlBaodDroit";
            this.pnlBaodDroit.Size = new System.Drawing.Size(3, 427);
            this.pnlBaodDroit.TabIndex = 86;
            // 
            // pnlBordGauche
            // 
            this.pnlBordGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlBordGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBordGauche.Location = new System.Drawing.Point(0, 0);
            this.pnlBordGauche.Name = "pnlBordGauche";
            this.pnlBordGauche.Size = new System.Drawing.Size(3, 427);
            this.pnlBordGauche.TabIndex = 85;
            // 
            // btnTester
            // 
            this.btnTester.FlatAppearance.BorderSize = 0;
            this.btnTester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTester.Image = global::BackUp_DataBase.Properties.Resources.Refresh_16x16;
            this.btnTester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTester.Location = new System.Drawing.Point(104, 380);
            this.btnTester.Name = "btnTester";
            this.btnTester.Size = new System.Drawing.Size(69, 25);
            this.btnTester.TabIndex = 91;
            this.btnTester.Text = "Tester";
            this.btnTester.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTester.UseVisualStyleBackColor = true;
            this.btnTester.Click += new System.EventHandler(this.btnTester_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.FlatAppearance.BorderSize = 0;
            this.btnSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSauvegarder.Image = global::BackUp_DataBase.Properties.Resources.Save_16x16;
            this.btnSauvegarder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSauvegarder.Location = new System.Drawing.Point(12, 380);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(86, 25);
            this.btnSauvegarder.TabIndex = 90;
            this.btnSauvegarder.Text = "Enregistrer";
            this.btnSauvegarder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // frmParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 427);
            this.Controls.Add(this.btnTester);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlBaodDroit);
            this.Controls.Add(this.pnlBordGauche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmParametres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.frmParametres_Load);
            this.tbServeur.ResumeLayout(false);
            this.tbServeur.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tbServeur;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Label lbldatabase;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel pnlBaodDroit;
        private System.Windows.Forms.Panel pnlBordGauche;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnTester;
    }
}