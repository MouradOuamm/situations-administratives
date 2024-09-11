using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Situations_Administratives.Forms
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Prénom")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.LightGray;
            }
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "")
            {
                txtPrenom.Text = "Prénom";
                txtPrenom.ForeColor = Color.Silver;
            }
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.LightGray;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtAdresseEmail_Enter(object sender, EventArgs e)
        {
            if (txtAdresseEmail.Text == "Adresse e-mail")
            {
                txtAdresseEmail.Text = "";
                txtAdresseEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtAdresseEmail_Leave(object sender, EventArgs e)
        {
            if (txtAdresseEmail.Text == "")
            {
                txtAdresseEmail.Text = "Adresse e-mail";
                txtAdresseEmail.ForeColor = Color.Silver;
            }
        }

        private void txtMotDePasse_Enter(object sender, EventArgs e)
        {
            if (txtMotDePasse.Text == "Mot de passe")
            {
                txtMotDePasse.Text = "";
                txtMotDePasse.ForeColor = Color.LightGray;
                txtMotDePasse.UseSystemPasswordChar = true;
            }   
        }

        private void txtMotDePasse_Leave(object sender, EventArgs e)
        {
             if (txtMotDePasse.Text == "")
            {
                txtMotDePasse.Text = "Mot de passe";
                txtMotDePasse.ForeColor = Color.Silver;
                txtMotDePasse.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmerMotDePasse_Enter(object sender, EventArgs e)
        {
            if (txtConfirmerMotDePasse.Text == "Confirmer le mot de passe")
            {
                txtConfirmerMotDePasse.Text = "";
                txtConfirmerMotDePasse.ForeColor = Color.LightGray;
                txtConfirmerMotDePasse.UseSystemPasswordChar = true;

            }

        }

        private void txtConfirmerMotDePasse_Leave(object sender, EventArgs e)
        {
            if (txtConfirmerMotDePasse.Text == "")
            {
                txtConfirmerMotDePasse.Text = "Confirmer le mot de passe";
                txtConfirmerMotDePasse.ForeColor = Color.Silver;
                txtConfirmerMotDePasse.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Si la case est cochée, afficher le mot de passe en clair dans la première TextBox
            txtMotDePasse.UseSystemPasswordChar = !checkBox1.Checked;

            // Pour la deuxième TextBox (confirmation), ne changer l'affichage que si elle contient du texte
            if (!string.IsNullOrEmpty(txtConfirmerMotDePasse.Text))
            {
                txtConfirmerMotDePasse.UseSystemPasswordChar = !checkBox1.Checked;
            }
            else
            {
                // Si le champ de confirmation est vide, s'assurer qu'il reste vide

                txtConfirmerMotDePasse.UseSystemPasswordChar = true; // Masquer avec des astérisques
            }
        }
        public static void ShowCustomMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string prenom = txtPrenom.Text;
            string nom = txtNom.Text;
            string email = txtAdresseEmail.Text;
            string password = txtMotDePasse.Text;
            string confirmPassword = txtConfirmerMotDePasse.Text;
            string genre = cmbGenre.SelectedItem?.ToString();

            // Vérifier si les champs obligatoires sont vides
            if (string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(nom) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(genre))
            {
                ShowCustomMessage("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxIcon.Warning);
                return;
            }

            // Vérifier si le mot de passe et sa confirmation correspondent
            if (password != confirmPassword)
            {
                ShowCustomMessage("Le mot de passe et la confirmation ne correspondent pas.", "Erreur de mot de passe", MessageBoxIcon.Warning);
                return;
            }

            // Créer une instance de la classe Functions
            Functions dbFunctions = new Functions();

            // Requête SQL pour vérifier si l'utilisateur existe déjà
            string checkQuery = $"SELECT COUNT(1) FROM Utilisateurs WHERE Prenom = '{prenom}' AND Nom = '{nom}' AND AdresseEmail = '{email}'";

            DataTable dt = dbFunctions.GetData(checkQuery);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                ShowCustomMessage("Cet e-mail existe déjà.\nVeuillez entrer une autre adresse e-mail.", "Adresse e-mail en double", MessageBoxIcon.Warning);
                return;
            }

            // Requête SQL pour insérer un nouvel utilisateur
            string insertQuery = $"INSERT INTO Utilisateurs (Prenom, Nom, AdresseEmail, MotDePasse, Genre) " +
                                 $"VALUES ('{prenom}', '{nom}', '{email}', '{password}', '{genre}')";

            try
            {
                int result = dbFunctions.SetData(insertQuery);

                // Vérifier si l'enregistrement a réussi
                if (result > 0)
                {
                    ShowCustomMessage("Utilisateur enregistré avec succès !", "Succès", MessageBoxIcon.Information);

                    // Réinitialiser les champs de texte après enregistrement
                    txtPrenom.Clear();
                    txtNom.Clear();
                    txtAdresseEmail.Clear();
                    txtMotDePasse.Clear();
                    txtConfirmerMotDePasse.Clear();
                    cmbGenre.SelectedIndex = -1; // Réinitialiser la sélection du genre
                    this.Hide();  // Masquer le formulaire actuel
                    login loginForm = new login(); // Créer une instance du formulaire de connexion
                    loginForm.Show(); // Afficher le formulaire de connexion
                }
                else
                {
                    ShowCustomMessage("Échec de l'enregistrement de l'utilisateur.", "Erreur", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ShowCustomMessage("Une erreur s'est produite lors de l'enregistrement.\nDétails : " + ex.Message, "Erreur d'enregistrement", MessageBoxIcon.Error);
            }
        }
    }
}
