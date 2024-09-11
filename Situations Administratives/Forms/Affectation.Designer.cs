namespace Situations_Administratives.Forms
{
    partial class Affectation
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
            this.btnExport = new System.Windows.Forms.Button();
            this.DGVAffe = new System.Windows.Forms.DataGridView();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.BtnVider = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.TxtCombo = new System.Windows.Forms.ComboBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtEcole = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TxtApartir = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAffe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(867, 187);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(133, 43);
            this.btnExport.TabIndex = 148;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // DGVAffe
            // 
            this.DGVAffe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVAffe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAffe.BackgroundColor = System.Drawing.Color.White;
            this.DGVAffe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVAffe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVAffe.ColumnHeadersHeight = 32;
            this.DGVAffe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGVAffe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVAffe.Location = new System.Drawing.Point(7, 330);
            this.DGVAffe.Name = "DGVAffe";
            this.DGVAffe.ReadOnly = true;
            this.DGVAffe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGVAffe.RowHeadersVisible = false;
            this.DGVAffe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAffe.Size = new System.Drawing.Size(997, 247);
            this.DGVAffe.TabIndex = 147;
            this.DGVAffe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAffe_CellContentClick);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecherche.FlatAppearance.BorderSize = 0;
            this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecherche.Location = new System.Drawing.Point(299, 268);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(174, 36);
            this.btnRecherche.TabIndex = 146;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnImp
            // 
            this.btnImp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImp.FlatAppearance.BorderSize = 0;
            this.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImp.Location = new System.Drawing.Point(708, 187);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(133, 43);
            this.btnImp.TabIndex = 145;
            this.btnImp.Text = "Imprimer";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupp.FlatAppearance.BorderSize = 0;
            this.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupp.Location = new System.Drawing.Point(545, 187);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(133, 43);
            this.btnSupp.TabIndex = 144;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // BtnVider
            // 
            this.BtnVider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVider.FlatAppearance.BorderSize = 0;
            this.BtnVider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVider.Location = new System.Drawing.Point(363, 187);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.Size = new System.Drawing.Size(133, 43);
            this.BtnVider.TabIndex = 143;
            this.BtnVider.Text = "Vider";
            this.BtnVider.UseVisualStyleBackColor = true;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Location = new System.Drawing.Point(183, 187);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(133, 43);
            this.btnModifier.TabIndex = 142;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Location = new System.Drawing.Point(8, 187);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(133, 43);
            this.btnAjouter.TabIndex = 141;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 140;
            this.label4.Text = "ابتداء من";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(760, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 139;
            this.label5.Text = "المؤسسة ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 138;
            this.label6.Text = "رقم التأجير";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 137;
            this.label3.Text = "الفترة الزمنية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 136;
            this.label2.Text = "الاطار";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(777, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 135;
            this.label1.Text = "الاسم";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(708, 38);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(182, 31);
            this.TxtName.TabIndex = 149;
            // 
            // TxtN
            // 
            this.TxtN.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN.Location = new System.Drawing.Point(386, 38);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(182, 31);
            this.TxtN.TabIndex = 150;
            // 
            // TxtCombo
            // 
            this.TxtCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TxtCombo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCombo.ForeColor = System.Drawing.Color.White;
            this.TxtCombo.FormattingEnabled = true;
            this.TxtCombo.ItemHeight = 24;
            this.TxtCombo.Items.AddRange(new object[] {
            "أ. ت. الثانوي",
            "أ. ت. ثا. الإعدادي",
            "أ. ت. ثا. التأهيلي",
            "اس ت ابتدائي",
            "أستاذ  مبرز للتعليم  الثانوي التأهيلي",
            "أستاذ التعليم الابتدائي",
            "أستاذ(ة) مبرز(ة)",
            "أستاذة التعليم الابتدائي",
            "أستاذة التعليم الثانوي الاعدادي",
            "تقني  من درجة 2",
            "متصرف",
            "متصرف  تربوي"});
            this.TxtCombo.Location = new System.Drawing.Point(82, 31);
            this.TxtCombo.Name = "TxtCombo";
            this.TxtCombo.Size = new System.Drawing.Size(200, 32);
            this.TxtCombo.TabIndex = 151;
            // 
            // TxtDate
            // 
            this.TxtDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(387, 130);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(182, 31);
            this.TxtDate.TabIndex = 153;
            // 
            // TxtEcole
            // 
            this.TxtEcole.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEcole.Location = new System.Drawing.Point(709, 130);
            this.TxtEcole.Name = "TxtEcole";
            this.TxtEcole.Size = new System.Drawing.Size(182, 31);
            this.TxtEcole.TabIndex = 152;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(496, 270);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(182, 31);
            this.TxtSearch.TabIndex = 154;
            // 
            // TxtApartir
            // 
            this.TxtApartir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApartir.Location = new System.Drawing.Point(83, 130);
            this.TxtApartir.Name = "TxtApartir";
            this.TxtApartir.Size = new System.Drawing.Size(199, 31);
            this.TxtApartir.TabIndex = 155;
            // 
            // Affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 580);
            this.Controls.Add(this.TxtApartir);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtEcole);
            this.Controls.Add(this.TxtCombo);
            this.Controls.Add(this.TxtN);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.DGVAffe);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnImp);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.BtnVider);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Affectation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الالحاق";
            this.Load += new System.EventHandler(this.Affectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAffe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView DGVAffe;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button BtnVider;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.ComboBox TxtCombo;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.TextBox TxtEcole;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox TxtApartir;
    }
}