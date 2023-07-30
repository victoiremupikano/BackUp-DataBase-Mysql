using BackUp_DataBase.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BackUp_DataBase
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmParametres_Load(object sender, EventArgs e)
        {
            // instaciation des valeurs par defaut
            txtIp.Text = Settings.Default.host;
            txtdatabase.Text = Settings.Default.database;
            txtusername.Text = Settings.Default.user;
            txtpassword.Text = Settings.Default.password;
            txtport.Text = Settings.Default.port;
        }

        private void btnTester_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();

                string connection_string = "server=" + txtIp.Text + "; port=" + txtport.Text + "; user=" + txtusername.Text + "; password=" + txtpassword.Text + "; database=" + txtdatabase.Text + "";

                conn = new MySqlConnection(connection_string);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    MessageBox.Show("Connexion établie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Connexion échouer", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Connexion échouer " + Ex.Message, "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdatabase.Text) || string.IsNullOrEmpty(txtIp.Text) || string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtport.Text) || string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Les champs sont vides, remplisser puis ressayer", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // instaciation des valeurs par defaut
                Settings.Default.host = txtIp.Text;
                Settings.Default.database = txtdatabase.Text;
                Settings.Default.user = txtusername.Text;
                Settings.Default.password = txtpassword.Text;
                Settings.Default.port = txtport.Text;

                Settings.Default.Save();

                MessageBox.Show("Effectuer", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }
    }
}
