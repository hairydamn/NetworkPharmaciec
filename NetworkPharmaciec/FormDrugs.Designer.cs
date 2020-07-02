namespace NetworkPharmaciec
{
    partial class FormDrugs
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewDrugs = new System.Windows.Forms.ListView();
            this.IDDrugs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitleDrug = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Maker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShelfLife = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxMaker = new System.Windows.Forms.TextBox();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.textBoxTitleDrug = new System.Windows.Forms.TextBox();
            this.labelMaker = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.labelFormRelease = new System.Windows.Forms.Label();
            this.labelTitleDrug = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxShelfLife = new System.Windows.Forms.TextBox();
            this.labelShelfLife = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FormRelease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(1016, 610);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(192, 73);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            // 
            // buttonRes
            // 
            this.buttonRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonRes.FlatAppearance.BorderSize = 0;
            this.buttonRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRes.Location = new System.Drawing.Point(797, 610);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(192, 73);
            this.buttonRes.TabIndex = 24;
            this.buttonRes.Text = "Обновить";
            this.buttonRes.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(580, 610);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(192, 73);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // listViewDrugs
            // 
            this.listViewDrugs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDDrugs,
            this.TitleDrug,
            this.FormRelease,
            this.Dosage,
            this.Maker,
            this.ShelfLife});
            this.listViewDrugs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewDrugs.FullRowSelect = true;
            this.listViewDrugs.GridLines = true;
            this.listViewDrugs.HideSelection = false;
            this.listViewDrugs.Location = new System.Drawing.Point(338, 173);
            this.listViewDrugs.MultiSelect = false;
            this.listViewDrugs.Name = "listViewDrugs";
            this.listViewDrugs.Size = new System.Drawing.Size(870, 415);
            this.listViewDrugs.TabIndex = 22;
            this.listViewDrugs.UseCompatibleStateImageBehavior = false;
            this.listViewDrugs.View = System.Windows.Forms.View.Details;
            // 
            // IDDrugs
            // 
            this.IDDrugs.Text = "ID";
            // 
            // TitleDrug
            // 
            this.TitleDrug.Text = "Название лекарства";
            this.TitleDrug.Width = 173;
            // 
            // Dosage
            // 
            this.Dosage.Text = "Дозировка";
            this.Dosage.Width = 182;
            // 
            // Maker
            // 
            this.Maker.Text = "Производитель";
            this.Maker.Width = 186;
            // 
            // ShelfLife
            // 
            this.ShelfLife.Text = "Срок годности";
            this.ShelfLife.Width = 173;
            // 
            // textBoxMaker
            // 
            this.textBoxMaker.Location = new System.Drawing.Point(14, 485);
            this.textBoxMaker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxMaker.Multiline = true;
            this.textBoxMaker.Name = "textBoxMaker";
            this.textBoxMaker.Size = new System.Drawing.Size(287, 55);
            this.textBoxMaker.TabIndex = 20;
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Location = new System.Drawing.Point(14, 357);
            this.textBoxDosage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxDosage.Multiline = true;
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(287, 55);
            this.textBoxDosage.TabIndex = 19;
            // 
            // textBoxTitleDrug
            // 
            this.textBoxTitleDrug.Location = new System.Drawing.Point(14, 173);
            this.textBoxTitleDrug.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxTitleDrug.Multiline = true;
            this.textBoxTitleDrug.Name = "textBoxTitleDrug";
            this.textBoxTitleDrug.Size = new System.Drawing.Size(287, 55);
            this.textBoxTitleDrug.TabIndex = 17;
            // 
            // labelMaker
            // 
            this.labelMaker.AutoSize = true;
            this.labelMaker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaker.Location = new System.Drawing.Point(8, 457);
            this.labelMaker.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(115, 19);
            this.labelMaker.TabIndex = 16;
            this.labelMaker.Text = "Производитель";
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDosage.Location = new System.Drawing.Point(8, 332);
            this.labelDosage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(82, 19);
            this.labelDosage.TabIndex = 15;
            this.labelDosage.Text = "Дозировка";
            // 
            // labelFormRelease
            // 
            this.labelFormRelease.AutoSize = true;
            this.labelFormRelease.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormRelease.Location = new System.Drawing.Point(8, 256);
            this.labelFormRelease.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFormRelease.Name = "labelFormRelease";
            this.labelFormRelease.Size = new System.Drawing.Size(115, 19);
            this.labelFormRelease.TabIndex = 14;
            this.labelFormRelease.Text = "Форма выпуска";
            // 
            // labelTitleDrug
            // 
            this.labelTitleDrug.AutoSize = true;
            this.labelTitleDrug.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleDrug.Location = new System.Drawing.Point(8, 147);
            this.labelTitleDrug.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitleDrug.Name = "labelTitleDrug";
            this.labelTitleDrug.Size = new System.Drawing.Size(148, 19);
            this.labelTitleDrug.TabIndex = 13;
            this.labelTitleDrug.Text = "Название лекарства";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetworkPharmaciec.Properties.Resources.biyxK7XkT;
            this.pictureBox1.Location = new System.Drawing.Point(14, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxShelfLife
            // 
            this.textBoxShelfLife.Location = new System.Drawing.Point(15, 580);
            this.textBoxShelfLife.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxShelfLife.Multiline = true;
            this.textBoxShelfLife.Name = "textBoxShelfLife";
            this.textBoxShelfLife.Size = new System.Drawing.Size(287, 55);
            this.textBoxShelfLife.TabIndex = 27;
            // 
            // labelShelfLife
            // 
            this.labelShelfLife.AutoSize = true;
            this.labelShelfLife.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShelfLife.Location = new System.Drawing.Point(9, 552);
            this.labelShelfLife.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelShelfLife.Name = "labelShelfLife";
            this.labelShelfLife.Size = new System.Drawing.Size(107, 19);
            this.labelShelfLife.TabIndex = 26;
            this.labelShelfLife.Text = "Срок годности";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 23);
            this.comboBox1.TabIndex = 28;
            // 
            // FormRelease
            // 
            this.FormRelease.Text = "Форма выпуска";
            this.FormRelease.Width = 128;
            // 
            // FormDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 710);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxShelfLife);
            this.Controls.Add(this.labelShelfLife);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDrugs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMaker);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.textBoxTitleDrug);
            this.Controls.Add(this.labelMaker);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.labelFormRelease);
            this.Controls.Add(this.labelTitleDrug);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormDrugs";
            this.Text = "FormDrugs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewDrugs;
        private System.Windows.Forms.ColumnHeader IDDrugs;
        private System.Windows.Forms.ColumnHeader TitleDrug;
        private System.Windows.Forms.ColumnHeader Dosage;
        private System.Windows.Forms.ColumnHeader Maker;
        private System.Windows.Forms.ColumnHeader ShelfLife;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxMaker;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.TextBox textBoxTitleDrug;
        private System.Windows.Forms.Label labelMaker;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.Label labelFormRelease;
        private System.Windows.Forms.Label labelTitleDrug;
        private System.Windows.Forms.TextBox textBoxShelfLife;
        private System.Windows.Forms.Label labelShelfLife;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader FormRelease;
    }
}