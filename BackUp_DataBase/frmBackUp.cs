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
    public partial class frmBackUp : Form
    {
        bool EtatBool;
        connect cn = new connect();
        
        string ExportFolder;

        public frmBackUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            //connection  automatique à la base de données lors de l'ouverture de l'interface
            //
            try
            {
                if (cn.conn.State == ConnectionState.Closed)//si la connection est fermé on l'ouvre sinon on la ferme
                {
                    cn.conn.Open();
                    EtatBool = true;
                }
                else
                {
                    cn.conn.Close();
                    EtatBool = false;
                    MessageBox.Show("Désolée on a pas pu se connectez à la base de données; renseigner les paramètres de connection avant de lancer le backup", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception Ex)
            {
                //s'il y a une erreur de connection à la base de données on ne fait rien mais on. Mais l'Etat devient fals
                EtatBool = false;
                MessageBox.Show("Désolée on a pas pu se connectez à la base de données; renseigner les paramètres de connection avant de lancer le backup " + Ex.Message, "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnSaveDialog_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog folder = new SaveFileDialog())
            {
                folder.Filter = "sql(*.sql)|*.sql";

                if (folder.ShowDialog() == DialogResult.OK)
                {
                    ExportFolder = folder.FileName;
                    lblPath.Text = ExportFolder;

                    if (cn.conn.State == ConnectionState.Open)
                    {
                        btnStartBackUp.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Désolée on a pas pu se connectez à la base de données; renseigner les paramètres de connection avant de lancer le backup", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnStartBackUp_Click(object sender, EventArgs e)
        {
            if (EtatBool)
            {
                try
                {
                    btnStartBackUp.Text = "débuter backup";
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup ab = new MySqlBackup(cmd))
                        {
                            cmd.Connection = cn.conn;
                            ab.ExportToFile(ExportFolder);
                        }
                    }
                    MessageBox.Show("BackUp éffectuer avec succès à l'emplacement " + lblPath.Text, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnStartBackUp.Text = "DEBUTER";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erreur " + Ex.Message, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Désolée on a pas pu se connectez à la base de données; renseigner les paramètres de connection avant de lancer le backup ", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }

        private void frmBackUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cn.conn.State == ConnectionState.Closed)
            {
                cn.conn.Close();
            }
            else
            {
                cn.conn.Close();
            }
        }
    }
}
