namespace Situations_Administratives
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSituation = new System.Windows.Forms.Panel();
            this.DetachementSyndical = new System.Windows.Forms.Button();
            this.Affectation = new System.Windows.Forms.Button();
            this.MiseDisposition = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLicens = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSituation.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 4;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Situations_Administratives.Properties.Resources.logo_Imprimer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(498, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelSituation
            // 
            this.panelSituation.BackColor = System.Drawing.Color.DarkCyan;
            this.panelSituation.Controls.Add(this.DetachementSyndical);
            this.panelSituation.Controls.Add(this.Affectation);
            this.panelSituation.Controls.Add(this.MiseDisposition);
            this.panelSituation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSituation.Location = new System.Drawing.Point(0, 307);
            this.panelSituation.Name = "panelSituation";
            this.panelSituation.Size = new System.Drawing.Size(220, 107);
            this.panelSituation.TabIndex = 2;
            // 
            // DetachementSyndical
            // 
            this.DetachementSyndical.BackColor = System.Drawing.Color.DarkCyan;
            this.DetachementSyndical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetachementSyndical.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetachementSyndical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetachementSyndical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetachementSyndical.ForeColor = System.Drawing.Color.White;
            this.DetachementSyndical.Location = new System.Drawing.Point(0, 68);
            this.DetachementSyndical.Name = "DetachementSyndical";
            this.DetachementSyndical.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.DetachementSyndical.Size = new System.Drawing.Size(220, 34);
            this.DetachementSyndical.TabIndex = 5;
            this.DetachementSyndical.Text = " التفرغ النقابي";
            this.DetachementSyndical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DetachementSyndical.UseVisualStyleBackColor = false;
            this.DetachementSyndical.Click += new System.EventHandler(this.DetachementSyndical_Click);
            // 
            // Affectation
            // 
            this.Affectation.BackColor = System.Drawing.Color.DarkCyan;
            this.Affectation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Affectation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Affectation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Affectation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Affectation.ForeColor = System.Drawing.Color.White;
            this.Affectation.Location = new System.Drawing.Point(0, 34);
            this.Affectation.Name = "Affectation";
            this.Affectation.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.Affectation.Size = new System.Drawing.Size(220, 34);
            this.Affectation.TabIndex = 4;
            this.Affectation.Text = "وضع  الالحاق";
            this.Affectation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Affectation.UseVisualStyleBackColor = false;
            this.Affectation.Click += new System.EventHandler(this.Affectation_Click);
            // 
            // MiseDisposition
            // 
            this.MiseDisposition.BackColor = System.Drawing.Color.DarkCyan;
            this.MiseDisposition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiseDisposition.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiseDisposition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiseDisposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiseDisposition.ForeColor = System.Drawing.Color.White;
            this.MiseDisposition.Location = new System.Drawing.Point(0, 0);
            this.MiseDisposition.Name = "MiseDisposition";
            this.MiseDisposition.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.MiseDisposition.Size = new System.Drawing.Size(220, 34);
            this.MiseDisposition.TabIndex = 3;
            this.MiseDisposition.Text = "وضع رهن الإشارة";
            this.MiseDisposition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MiseDisposition.UseVisualStyleBackColor = false;
            this.MiseDisposition.Click += new System.EventHandler(this.MiseDisposition_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1005, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "O";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1033, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(976, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.button6);
            this.panelTitleBar.Controls.Add(this.button5);
            this.panelTitleBar.Controls.Add(this.button4);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1067, 80);
            this.panelTitleBar.TabIndex = 6;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::Situations_Administratives.Properties.Resources.icons8_x_24;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 2;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("BatangChe", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLbl.ForeColor = System.Drawing.Color.Teal;
            this.TimeLbl.Location = new System.Drawing.Point(313, 333);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(432, 96);
            this.TimeLbl.TabIndex = 5;
            this.TimeLbl.Text = "00:00:00";
            this.TimeLbl.Click += new System.EventHandler(this.TimeLbl_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.button7);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.panelSituation);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btnLicens);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Teal;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(70, 555);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 636);
            this.panelMenu.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkCyan;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 582);
            this.button7.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(220, 54);
            this.button7.TabIndex = 5;
            this.button7.Text = "   الخروج";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Situations_Administratives.Properties.Resources._4;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 251);
            this.button3.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(220, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "  الوضعيات الإدارية    ";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLicens
            // 
            this.btnLicens.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLicens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLicens.FlatAppearance.BorderSize = 0;
            this.btnLicens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicens.ForeColor = System.Drawing.Color.White;
            this.btnLicens.Image = global::Situations_Administratives.Properties.Resources._11;
            this.btnLicens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicens.Location = new System.Drawing.Point(0, 81);
            this.btnLicens.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.btnLicens.Name = "btnLicens";
            this.btnLicens.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLicens.Size = new System.Drawing.Size(220, 60);
            this.btnLicens.TabIndex = 1;
            this.btnLicens.Text = "  الرخص الطبية      ";
            this.btnLicens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLicens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLicens.UseVisualStyleBackColor = false;
            this.btnLicens.Click += new System.EventHandler(this.btnLicens_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Situations_Administratives.Properties.Resources._3;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 197);
            this.button2.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(220, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "  الاستيداع";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Situations_Administratives.Properties.Resources._2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "  الاعفاء ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.White;
            this.panelDesktopPane.Controls.Add(this.pictureBox2);
            this.panelDesktopPane.Controls.Add(this.TimeLbl);
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 81);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1067, 555);
            this.panelDesktopPane.TabIndex = 7;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Situations_Administratives.Properties.Resources.logo_Imprimer;
            this.pictureBox2.Location = new System.Drawing.Point(156, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 636);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktopPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSituation.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSituation;
        private System.Windows.Forms.Button DetachementSyndical;
        private System.Windows.Forms.Button Affectation;
        private System.Windows.Forms.Button MiseDisposition;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnLicens;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

