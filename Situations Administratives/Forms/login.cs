using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Situations_Administratives.Forms
{
    public partial class login : Form
    {
        Functions con;
        public login()
        {
            InitializeComponent();
            con = new Functions();
        }
        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si l'utilisateur clique sur Oui, l'application se ferme
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Utilisateur")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Utilisateur";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Mot de passe")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Mot de passe";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des TextBox
            string email = txtuser.Text;
            string password = txtpass.Text;

            // Vérifier si les champs sont vides
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez entrer l'adresse e-mail et le mot de passe.", "Erreur");
                return;
            }

            // Créer une instance de la classe Functions
            Functions dbFunctions = new Functions();

            // Requête SQL pour vérifier les informations d'identification
            string query = $"SELECT COUNT(1) FROM Utilisateurs WHERE AdresseEmail = '{email}' AND MotDePasse = '{password}'";

            try
            {
                // Exécuter la requête et obtenir le résultat
                DataTable dt = dbFunctions.GetData(query);
                if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    // Connexion réussie
                    MessageBox.Show("Connexion réussie !");

                    // Ouvrir le formulaire principal
                    Menu menuPrincipal = new Menu();
                    menuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    // Échec de la connexion
                    MessageBox.Show("Adresse e-mail ou mot de passe incorrect.");
                    txtuser.Text = "";
                    txtpass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentification authentification = new Authentification();
            authentification.ShowDialog();
        }
    }
}
