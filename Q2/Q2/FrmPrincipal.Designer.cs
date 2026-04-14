namespace Q2
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsvIngredients = new ListView();
            clhNom = new ColumnHeader();
            clhType = new ColumnHeader();
            cboSectionsMenu = new ComboBox();
            lstPlats = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtNbIngredientImporte = new TextBox();
            txtNbIngredientLocal = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lsvIngredients
            // 
            lsvIngredients.Columns.AddRange(new ColumnHeader[] { clhNom, clhType });
            lsvIngredients.Font = new Font("Segoe UI", 12F);
            lsvIngredients.FullRowSelect = true;
            lsvIngredients.Location = new Point(455, 115);
            lsvIngredients.MultiSelect = false;
            lsvIngredients.Name = "lsvIngredients";
            lsvIngredients.Size = new Size(364, 178);
            lsvIngredients.TabIndex = 1;
            lsvIngredients.UseCompatibleStateImageBehavior = false;
            lsvIngredients.View = View.Details;
            // 
            // clhNom
            // 
            clhNom.Text = "Nom";
            clhNom.Width = 275;
            // 
            // clhType
            // 
            clhType.Text = "Type";
            // 
            // cboSectionsMenu
            // 
            cboSectionsMenu.Font = new Font("Segoe UI", 12F);
            cboSectionsMenu.FormattingEnabled = true;
            cboSectionsMenu.Items.AddRange(new object[] { "Déjeuner", "Souper", "Végétarien" });
            cboSectionsMenu.Location = new Point(36, 39);
            cboSectionsMenu.Name = "cboSectionsMenu";
            cboSectionsMenu.Size = new Size(373, 29);
            cboSectionsMenu.TabIndex = 2;
            cboSectionsMenu.SelectedIndexChanged += cboSectionsMenu_SelectedIndexChanged;
            // 
            // lstPlats
            // 
            lstPlats.Font = new Font("Segoe UI", 12F);
            lstPlats.FormattingEnabled = true;
            lstPlats.ItemHeight = 21;
            lstPlats.Location = new Point(36, 115);
            lstPlats.Name = "lstPlats";
            lstPlats.Size = new Size(373, 172);
            lstPlats.TabIndex = 3;
            lstPlats.SelectedIndexChanged += lstPlats_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 4;
            label1.Text = "Section de menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 91);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 5;
            label2.Text = "Plats";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(455, 91);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 6;
            label3.Text = "Ingrédients";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 27);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 8;
            label5.Text = "Local";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 25);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 9;
            label6.Text = "Importé";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNbIngredientImporte);
            groupBox1.Controls.Add(txtNbIngredientLocal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(455, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 56);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total d'ingrédients";
            // 
            // txtNbIngredientImporte
            // 
            txtNbIngredientImporte.Location = new Point(267, 22);
            txtNbIngredientImporte.Name = "txtNbIngredientImporte";
            txtNbIngredientImporte.ReadOnly = true;
            txtNbIngredientImporte.Size = new Size(59, 29);
            txtNbIngredientImporte.TabIndex = 11;
            txtNbIngredientImporte.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNbIngredientLocal
            // 
            txtNbIngredientLocal.Location = new Point(93, 22);
            txtNbIngredientLocal.Name = "txtNbIngredientLocal";
            txtNbIngredientLocal.ReadOnly = true;
            txtNbIngredientLocal.Size = new Size(59, 29);
            txtNbIngredientLocal.TabIndex = 10;
            txtNbIngredientLocal.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 318);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstPlats);
            Controls.Add(cboSectionsMenu);
            Controls.Add(lsvIngredients);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Restaurant";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lsvIngredients;
        private ComboBox cboSectionsMenu;
        private ListBox lstPlats;
        private Label label1;
        private Label label2;
        private Label label3;
        private ColumnHeader clhNom;
        private ColumnHeader clhType;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txtNbIngredientImporte;
        private TextBox txtNbIngredientLocal;
    }
}
