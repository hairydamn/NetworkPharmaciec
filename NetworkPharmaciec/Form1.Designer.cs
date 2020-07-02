namespace NetworkPharmaciec
{
    partial class FormPharm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitlePharm = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.textBoxTitlePharm = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewPharm = new System.Windows.Forms.ListView();
            this.IDPharm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitlePharm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitlePharm
            // 
            this.labelTitlePharm.AutoSize = true;
            this.labelTitlePharm.Location = new System.Drawing.Point(11, 129);
            this.labelTitlePharm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitlePharm.Name = "labelTitlePharm";
            this.labelTitlePharm.Size = new System.Drawing.Size(126, 19);
            this.labelTitlePharm.TabIndex = 0;
            this.labelTitlePharm.Text = "Название аптеки";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(11, 224);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(100, 19);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Адрес аптеки";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(11, 331);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(67, 19);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Телефон";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(11, 440);
            this.labelHours.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(98, 19);
            this.labelHours.TabIndex = 3;
            this.labelHours.Text = "Часы работы";
            // 
            // textBoxTitlePharm
            // 
            this.textBoxTitlePharm.Location = new System.Drawing.Point(16, 152);
            this.textBoxTitlePharm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxTitlePharm.Multiline = true;
            this.textBoxTitlePharm.Name = "textBoxTitlePharm";
            this.textBoxTitlePharm.Size = new System.Drawing.Size(247, 48);
            this.textBoxTitlePharm.TabIndex = 4;
            this.textBoxTitlePharm.TextChanged += new System.EventHandler(this.TextBoxTitlePharm_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(16, 248);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(247, 48);
            this.textBoxAddress.TabIndex = 5;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.TextBoxAddress_TextChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(16, 353);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(247, 48);
            this.textBoxPhone.TabIndex = 6;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.TextBoxPhone_TextChanged);
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(16, 464);
            this.textBoxHours.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxHours.Multiline = true;
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(247, 48);
            this.textBoxHours.TabIndex = 7;
            this.textBoxHours.TextChanged += new System.EventHandler(this.TextBoxHours_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetworkPharmaciec.Properties.Resources.biyxK7XkT;
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listViewPharm
            // 
            this.listViewPharm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDPharm,
            this.TitlePharm,
            this.Address,
            this.Phone,
            this.Hours});
            this.listViewPharm.FullRowSelect = true;
            this.listViewPharm.GridLines = true;
            this.listViewPharm.HideSelection = false;
            this.listViewPharm.Location = new System.Drawing.Point(294, 152);
            this.listViewPharm.MultiSelect = false;
            this.listViewPharm.Name = "listViewPharm";
            this.listViewPharm.Size = new System.Drawing.Size(746, 360);
            this.listViewPharm.TabIndex = 9;
            this.listViewPharm.UseCompatibleStateImageBehavior = false;
            this.listViewPharm.View = System.Windows.Forms.View.Details;
            this.listViewPharm.SelectedIndexChanged += new System.EventHandler(this.ListViewPharm_SelectedIndexChanged);
            // 
            // IDPharm
            // 
            this.IDPharm.Text = "ID";
            // 
            // TitlePharm
            // 
            this.TitlePharm.Text = "Название аптеки";
            this.TitlePharm.Width = 173;
            // 
            // Address
            // 
            this.Address.Text = "Адрес аптеки";
            this.Address.Width = 148;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 186;
            // 
            // Hours
            // 
            this.Hours.Text = "Часы работы";
            this.Hours.Width = 173;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(501, 531);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(165, 63);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(875, 531);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(165, 63);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Лекарства";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(682, 531);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(165, 63);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // FormPharm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 657);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewPharm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxTitlePharm);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTitlePharm);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormPharm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPharm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitlePharm;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.TextBox textBoxTitlePharm;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewPharm;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader IDPharm;
        private System.Windows.Forms.ColumnHeader TitlePharm;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Hours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEdit;
    }
}

