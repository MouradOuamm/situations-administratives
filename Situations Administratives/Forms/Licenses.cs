using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Situations_Administratives.Forms
{
    public partial class Licenses : Form
    {
        Functions con;
        public Licenses()
        {
            InitializeComponent();
            con = new Functions();
            ShowLic();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }
        private void ShowLic()
        {
            string Query = "select * from الرخص ";

            DGVLic.DataSource = con.GetData(Query);
        }
        int key =0;
        private void DGVLic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtName.Text = DGVLic.SelectedRows[0].Cells[1].Value.ToString();
            TxtN.Text = DGVLic.SelectedRows[0].Cells[2].Value.ToString();
            TxtCombo.Text = DGVLic.SelectedRows[0].Cells[3].Value.ToString();
            TxtApartir.Text = DGVLic.SelectedRows[0].Cells[4].Value.ToString();
            TxtDate.Text = DGVLic.SelectedRows[0].Cells[5].Value.ToString();
            TxtObser.Text = DGVLic.SelectedRows[0].Cells[6].Value.ToString();
            if (TxtName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVLic.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Licenses_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtN.Text == "" || TxtDate.Text == "" || TxtCombo.SelectedIndex == -1 || TxtApartir.Text == "" || TxtObser.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {

                try
                {
                    string TxtNam = TxtName.Text;
                    string TxtNumber = TxtN.Text;
                    string TxtComb = TxtCombo.SelectedItem.ToString();
                    string TxtDat = TxtDate.Text;
                    string TxtLic = TxtApartir.Text;
                    string TxtObs = TxtObser.Text;
                    string Query = "INSERT INTO [الرخص] ([الاسم], [رقم_التأجير], [الاطار], [الرخصة_طبيعة], [مدتها], [ملاحظات]) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')";
                    Query = string.Format(Query, TxtNam, TxtNumber, TxtComb, TxtDat, TxtLic, TxtObs);
                    con.SetData(Query);
                    MessageBox.Show("Données ajoutées avec succès !");
                    ShowLic();
                    BtnVider_Click(this, EventArgs.Empty);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtN.Text = "";
            TxtDate.Text = "";
            TxtApartir.Text = "";
            TxtCombo.SelectedIndex = -1;
            TxtSearch.Text = "";
            TxtObser.Text = "";
        }
        private void AjusterColonnesPourPage(DataGridView dgv, DGVPrinter printer)
        {
            // Ajuster la largeur des colonnes en fonction du contenu
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Calculer la largeur totale des colonnes
            int totalWidth = 0;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                totalWidth += column.Width;
            }

            // Obtenir la largeur de la page imprimée
            int pageWidth = printer.PageSettings.Bounds.Width - printer.PageSettings.Margins.Left - printer.PageSettings.Margins.Right;

            // Si la largeur totale des colonnes est inférieure à la largeur de la page, les ajuster proportionnellement
            if (totalWidth < pageWidth)
            {
                // Calculer l'écart à remplir
                int difference = pageWidth - totalWidth;

                // Répartir la différence sur chaque colonne
                int extraWidthPerColumn = difference / dgv.Columns.Count;

                // Augmenter la largeur de chaque colonne
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Width += extraWidthPerColumn;
                }
            }
        }
        private void btnImp_Click(object sender, EventArgs e)
        {
            // Chargement de l'image depuis les ressources
            Image img = Properties.Resources.logo_Imprimer;

            // Création de l'objet DGVPrinter
            DGVPrinter printer = new DGVPrinter();

            // Configuration du titre, ici ajouté plusieurs lignes vides pour espacer
            printer.Title = "\n\n\n\n\n\n\n\nالأكاديمية الجهوية للتربية والتكوين لجهة العيون الساقية الحمراء \n" +
              "المديرية الإقليمية العيون \n\n\n";
            printer.SubTitle = "\n\nالرخص\n\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true; // Ajustement proportionnel des colonnes
            printer.HeaderCellAlignment = StringAlignment.Near;

            // Configuration du pied de page
            printer.Footer = "________________________________________________________________________________________________________________________________\r\n\n\n" +
                   "الأكاديمية الجهوية للتربية والتكوين لجهة العيون الساقية الحمراء - المديرية الإقليمية العيون -\r\n" +
                   "مصلحة الموارد البشرية والشؤون الإدارية والمالية –    مكتب الوضعيات الإدارية للموظفين\r\n" +
                   "شارع الأمير مولاي عبد الله ، صندوق بريد 428، العيون – الهاتف : 0528894703 – 0528893704   الفاكس : 0528892764";
            printer.FooterSpacing = 15;

            // Configurer le DataGridView pour ajuster automatiquement la taille des lignes
            DGVLic.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Configurer l'impression en mode paysage
            printer.PageSettings.Landscape = true;

            // Ajout de l'image d'en-tête
            DGVPrinter.ImbeddedImage headerImage = new DGVPrinter.ImbeddedImage
            {
                theImage = img, // L'image depuis les ressources
                ImageAlignment = DGVPrinter.Alignment.Center, // Centrer l'image
                ImageLocation = DGVPrinter.Location.Header // Placer l'image dans l'en-tête
            };

            // Ajouter l'image à la liste des images imbriquées
            printer.ImbeddedImageList.Add(headerImage);

            // Ajuster les colonnes automatiquement pour qu'elles tiennent sur une seule page
            AjusterColonnesPourPage(DGVLic, printer);

            // Lancer l'impression du DataGridView
            printer.PrintDataGridView(DGVLic);
           }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (DGVLic.Rows.Count > 0)
            {
                Excel.Application xcelApp = new Excel.Application();
                Excel.Workbook workbook = xcelApp.Application.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                string tempLogoPath = null;

                try
                {
                    // Configurer la feuille de calcul entière en mode Right-to-Left
                    worksheet.DisplayRightToLeft = true;

                    // Chemin du logo dans le dossier Ressources
                    var logoImage = Situations_Administratives.Properties.Resources.logo_Imprimer;

                    // Sauvegarder l'image à un emplacement temporaire
                    tempLogoPath = Path.Combine(Path.GetTempPath(), "logo_temp.png");
                    logoImage.Save(tempLogoPath, System.Drawing.Imaging.ImageFormat.Png);

                    // Ajouter l'image à la feuille de calcul
                    Excel.Picture logoPicture = worksheet.Pictures().Insert(tempLogoPath);

                    // Positionner l'image (cellule A1 par exemple)
                    logoPicture.Left = worksheet.Cells[1, 1].Left;
                    logoPicture.Top = worksheet.Cells[1, 1].Top;

                    // Redimensionner l'image
                    logoPicture.Width = 650; // Largeur en points
                    logoPicture.Height = 90;  // Hauteur en points

                    // Ajouter de l'espace entre l'image et les données (laisser 3 lignes vides)
                    int startRow = 9; // Commencer les données à partir de la ligne 5

                    // Exporter les en-têtes de colonnes et appliquer des styles
                    for (int i = 1; i < DGVLic.Columns.Count + 1; i++)
                    {
                        Excel.Range headerCell = worksheet.Cells[startRow, i];
                        headerCell.Value2 = DGVLic.Columns[i - 1].HeaderText;

                        // Appliquer les styles
                        headerCell.Font.Bold = true;
                        headerCell.Font.Size = 14;
                        headerCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                        headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                    }

                    // Exporter les données des cellules
                    for (int i = 0; i < DGVLic.Rows.Count; i++)
                    {
                        for (int j = 0; j < DGVLic.Columns.Count; j++)
                        {
                            var cellValue = DGVLic.Rows[i].Cells[j].Value;
                            Excel.Range cell = worksheet.Cells[i + startRow + 1, j + 1];

                            cell.Value2 = cellValue != null ? cellValue.ToString() : string.Empty;
                            cell.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                            cell.ReadingOrder = -5004;
                        }
                    }

                    // Ajuster les colonnes pour remplir toute la largeur de la page
                    worksheet.Columns.AutoFit();

                    // Demander à l'utilisateur où enregistrer le fichier
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Enregistrer le fichier Excel";
                        saveFileDialog.FileName = "الرخص.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(saveFileDialog.FileName);
                            xcelApp.Visible = true;
                        }
                        else
                        {
                            xcelApp.Quit();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                }
                finally
                {
                    // Libération des objets COM
                    if (worksheet != null)
                    {
                        Marshal.ReleaseComObject(worksheet);
                        worksheet = null;
                    }
                    if (workbook != null)
                    {
                        Marshal.ReleaseComObject(workbook);
                        workbook = null;
                    }
                    if (xcelApp != null)
                    {
                        Marshal.ReleaseComObject(xcelApp);
                        xcelApp = null;
                    }

                    // Supprimer le fichier temporaire, si le chemin est défini
                    if (tempLogoPath != null && File.Exists(tempLogoPath))
                    {
                        File.Delete(tempLogoPath);
                    }
                }
            }
        }

      

        private void btnRecherche_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSearch.Text))
            {
                MessageBox.Show("Veuillez entrer un nom à rechercher.");
                return;
            }

            try
            {
                // Définir la requête SQL pour la table الرخص
                string query = "SELECT * FROM الرخص WHERE الاسم LIKE '%' + @nom + '%'";

                // Créer une instance de la classe Functions
                Functions functions = new Functions();

                // Ajouter les paramètres
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@nom", TxtSearch.Text.Trim())
                };

                // Récupérer les données en utilisant la méthode GetData avec la requête et les paramètres
                DataTable dataTable = functions.GetData(query, parameters);

                // Vérifier si des enregistrements ont été trouvés
                if (dataTable.Rows.Count > 0)
                {
                    DGVLic.DataSource = dataTable; // Afficher les résultats dans le DataGridView
                    TxtSearch.Text = ""; // Réinitialiser le champ de recherche
                }
                else
                {
                    MessageBox.Show("Aucun enregistrement trouvé pour ce nom.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtN.Text) ||
    string.IsNullOrEmpty(TxtDate.Text) || TxtCombo.SelectedIndex == -1 ||
    string.IsNullOrEmpty(TxtApartir.Text) || string.IsNullOrEmpty(TxtObser.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                try
                {
                    string TxtNam = TxtName.Text;
                    string TxtNumber = TxtN.Text;
                    string TxtComb = TxtCombo.SelectedItem.ToString();
                    string TxtDat = TxtDate.Text;
                    string TxtLic = TxtApartir.Text;
                    string TxtObs = TxtObser.Text;

                    // Requête SQL avec des paramètres pour la mise à jour
                    string Query = "UPDATE [الرخص] SET [رقم_التأجير] = @number, [الاطار] = @comb, " +
                                   "[الرخصة_طبيعة] = @dat, [مدتها] = @lic, [ملاحظات] = @obs " +
                                   "WHERE [الاسم] = @name";

                    // Créer les paramètres SQL
                    SqlParameter[] parameters = new SqlParameter[]
                    {
            new SqlParameter("@name", TxtNam),
            new SqlParameter("@number", TxtNumber),
            new SqlParameter("@comb", TxtComb),
            new SqlParameter("@dat", TxtDat),
            new SqlParameter("@lic", TxtLic),
            new SqlParameter("@obs", TxtObs)
                    };

                    // Exécuter la requête
                    con.SetData(Query, parameters);

                    MessageBox.Show("Données modifiées avec succès !");
                    ShowLic();  // Actualiser l'affichage après modification
                    BtnVider_Click(this, EventArgs.Empty);  // Vider les champs
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erreur : " + Ex.Message);
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtN.Text == "" || TxtDate.Text == "" || TxtCombo.SelectedIndex == -1 || TxtApartir.Text == "" || TxtObser.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                try
                {
                    string TxtNam = TxtName.Text;
                    string TxtNumber = TxtN.Text;
                    string TxtComb = TxtCombo.SelectedItem.ToString();
                    string TxtDat = TxtDate.Text;
                    string TxtLic = TxtApartir.Text;
                    string TxtObs = TxtObser.Text;

                    // Obtenir le prochain ID disponible
                    int newId = GetNextID();

                    // Requête SQL pour l'insertion avec le nouvel ID
                    string insertQuery = "INSERT INTO [الرخص] ([الرقم], [الاسم], [رقم_التأجير], [الاطار], [الرخصة_طبيعة], [مدتها], [ملاحظات]) VALUES (@ID, @Name, @Number, @Comb, @Dat, @Lic, @Obs)";

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@ID", newId),
                new SqlParameter("@Name", TxtNam),
                new SqlParameter("@Number", TxtNumber),
                new SqlParameter("@Comb", TxtComb),
                new SqlParameter("@Dat", TxtDat),
                new SqlParameter("@Lic", TxtLic),
                new SqlParameter("@Obs", TxtObs)
                    };

                    con.SetData(insertQuery, parameters);
                    MessageBox.Show("Données ajoutées avec succès !");
                    ShowLic();
                    BtnVider_Click(this, EventArgs.Empty);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private int GetNextID()
        {
            int nextID = 1;

            // Chaîne de connexion LocalDB
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\GestionDR.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Vérifier s'il y a des IDs supprimés
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 DeletedID FROM DeletedIDs ORDER BY DeletedID", conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    nextID = (int)result;

                    // Supprimer l'ID de la table des IDs supprimés
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM DeletedIDs WHERE DeletedID = @ID", conn);
                    deleteCmd.Parameters.AddWithValue("@ID", nextID);
                    deleteCmd.ExecuteNonQuery();
                }
                else
                {
                    // Obtenir le prochain ID auto-incrémenté
                    SqlCommand maxIDCmd = new SqlCommand("SELECT ISNULL(MAX([الرقم]), 0) + 1 FROM [الرخص]", conn);
                    nextID = (int)maxIDCmd.ExecuteScalar();
                }
            }

            return nextID;
        }


            private void btnSupp_Click(object sender, EventArgs e)
            {
                if (key == 0)
                {
                    MessageBox.Show("Veuillez sélectionner un enregistrement à supprimer !");
                }
                else
                {
                    try
                    {
                        // Requête SQL pour la suppression avec un paramètre
                        string Query = "DELETE FROM [الرخص] WHERE [الرقم] = @key";

                        // Créer le paramètre SQL
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                new SqlParameter("@key", key)
                        };

                        // Exécuter la requête
                        int rowsAffected = con.SetData(Query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Enregistrement supprimé avec succès !");
                            ShowLic();  // Actualiser l'affichage après suppression
                            BtnVider_Click(this, EventArgs.Empty);  // Vider les champs
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrement trouvé avec cet identifiant.");
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Erreur : " + Ex.Message);
                    }
                }

            }
    }

}
