namespace ServiceCentre
{
    partial class AddRepairForm
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
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_nameClient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.comboBox_Brands = new System.Windows.Forms.ComboBox();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.bt_NewCategory = new System.Windows.Forms.Button();
            this.bt_NewBrand = new System.Windows.Forms.Button();
            this.bt_NewModel = new System.Windows.Forms.Button();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_TypeRepair = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Defect = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_kitView = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_Engineer = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_AddClient = new System.Windows.Forms.Button();
            this.bt_EditClient = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.comboBox_StatusRepair = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.bt_SaveNewRepair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Email
            // 
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Location = new System.Drawing.Point(12, 186);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(267, 20);
            this.textBox_Email.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "E-mail:";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Enabled = false;
            this.textBox_Address.Location = new System.Drawing.Point(12, 147);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(267, 20);
            this.textBox_Address.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Адрес:";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Enabled = false;
            this.textBox_Phone.Location = new System.Drawing.Point(12, 108);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(267, 20);
            this.textBox_Phone.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Телефон:";
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Enabled = false;
            this.textBox_Contact.Location = new System.Drawing.Point(12, 66);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(267, 20);
            this.textBox_Contact.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Контактное лицо:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название Компании, если ЧЛ - ФИО";
            // 
            // comboBox_nameClient
            // 
            this.comboBox_nameClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nameClient.FormattingEnabled = true;
            this.comboBox_nameClient.Location = new System.Drawing.Point(12, 21);
            this.comboBox_nameClient.Name = "comboBox_nameClient";
            this.comboBox_nameClient.Size = new System.Drawing.Size(267, 21);
            this.comboBox_nameClient.Sorted = true;
            this.comboBox_nameClient.TabIndex = 25;
            this.comboBox_nameClient.SelectedIndexChanged += new System.EventHandler(this.comboBox_nameClient_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Бренд изделия (Samsung, Asus...)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Модель изделия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Категория изделия (Ноутбук, Планшет...):";
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(365, 21);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Categories.Sorted = true;
            this.comboBox_Categories.TabIndex = 31;
            this.comboBox_Categories.SelectedIndexChanged += new System.EventHandler(this.comboBox_Categories_SelectedIndexChanged);
            // 
            // comboBox_Brands
            // 
            this.comboBox_Brands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Brands.FormattingEnabled = true;
            this.comboBox_Brands.Location = new System.Drawing.Point(365, 67);
            this.comboBox_Brands.Name = "comboBox_Brands";
            this.comboBox_Brands.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Brands.Sorted = true;
            this.comboBox_Brands.TabIndex = 32;
            this.comboBox_Brands.SelectedIndexChanged += new System.EventHandler(this.comboBox_Brands_SelectedIndexChanged);
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(365, 108);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Model.Sorted = true;
            this.comboBox_Model.TabIndex = 33;
            this.comboBox_Model.SelectedIndexChanged += new System.EventHandler(this.comboBox_Model_SelectedIndexChanged);
            // 
            // bt_NewCategory
            // 
            this.bt_NewCategory.Location = new System.Drawing.Point(636, 21);
            this.bt_NewCategory.Name = "bt_NewCategory";
            this.bt_NewCategory.Size = new System.Drawing.Size(75, 23);
            this.bt_NewCategory.TabIndex = 34;
            this.bt_NewCategory.Text = "Новая";
            this.bt_NewCategory.UseVisualStyleBackColor = true;
            this.bt_NewCategory.Click += new System.EventHandler(this.bt_NewCategory_Click);
            // 
            // bt_NewBrand
            // 
            this.bt_NewBrand.Location = new System.Drawing.Point(636, 67);
            this.bt_NewBrand.Name = "bt_NewBrand";
            this.bt_NewBrand.Size = new System.Drawing.Size(75, 23);
            this.bt_NewBrand.TabIndex = 35;
            this.bt_NewBrand.Text = "Новый";
            this.bt_NewBrand.UseVisualStyleBackColor = true;
            this.bt_NewBrand.Click += new System.EventHandler(this.bt_NewBrand_Click);
            // 
            // bt_NewModel
            // 
            this.bt_NewModel.Location = new System.Drawing.Point(636, 108);
            this.bt_NewModel.Name = "bt_NewModel";
            this.bt_NewModel.Size = new System.Drawing.Size(75, 23);
            this.bt_NewModel.TabIndex = 36;
            this.bt_NewModel.Text = "Новая";
            this.bt_NewModel.UseVisualStyleBackColor = true;
            this.bt_NewModel.Click += new System.EventHandler(this.bt_NewModel_Click);
            // 
            // textBox_SN
            // 
            this.textBox_SN.Location = new System.Drawing.Point(366, 147);
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(264, 20);
            this.textBox_SN.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Серийный номер изделия:";
            // 
            // comboBox_TypeRepair
            // 
            this.comboBox_TypeRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypeRepair.FormattingEnabled = true;
            this.comboBox_TypeRepair.Location = new System.Drawing.Point(366, 186);
            this.comboBox_TypeRepair.Name = "comboBox_TypeRepair";
            this.comboBox_TypeRepair.Size = new System.Drawing.Size(264, 21);
            this.comboBox_TypeRepair.Sorted = true;
            this.comboBox_TypeRepair.TabIndex = 40;
            this.comboBox_TypeRepair.SelectedIndexChanged += new System.EventHandler(this.comboBox_TypeRepair_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Тип ремонта:";
            // 
            // textBox_Defect
            // 
            this.textBox_Defect.Location = new System.Drawing.Point(717, 21);
            this.textBox_Defect.Multiline = true;
            this.textBox_Defect.Name = "textBox_Defect";
            this.textBox_Defect.Size = new System.Drawing.Size(267, 54);
            this.textBox_Defect.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(717, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Дефект:";
            // 
            // textBox_kitView
            // 
            this.textBox_kitView.Location = new System.Drawing.Point(717, 96);
            this.textBox_kitView.Multiline = true;
            this.textBox_kitView.Name = "textBox_kitView";
            this.textBox_kitView.Size = new System.Drawing.Size(267, 70);
            this.textBox_kitView.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(717, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Комплектность, внешнее состояние(Б/У, сколы...):";
            // 
            // comboBox_Engineer
            // 
            this.comboBox_Engineer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Engineer.FormattingEnabled = true;
            this.comboBox_Engineer.Location = new System.Drawing.Point(717, 186);
            this.comboBox_Engineer.Name = "comboBox_Engineer";
            this.comboBox_Engineer.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Engineer.Sorted = true;
            this.comboBox_Engineer.TabIndex = 46;
            this.comboBox_Engineer.SelectedIndexChanged += new System.EventHandler(this.comboBox_Engineer_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(718, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Инженер:";
            // 
            // bt_AddClient
            // 
            this.bt_AddClient.Location = new System.Drawing.Point(284, 20);
            this.bt_AddClient.Name = "bt_AddClient";
            this.bt_AddClient.Size = new System.Drawing.Size(75, 23);
            this.bt_AddClient.TabIndex = 47;
            this.bt_AddClient.Text = "Добавить";
            this.bt_AddClient.UseVisualStyleBackColor = true;
            this.bt_AddClient.Click += new System.EventHandler(this.bt_AddClient_Click);
            // 
            // bt_EditClient
            // 
            this.bt_EditClient.Location = new System.Drawing.Point(284, 65);
            this.bt_EditClient.Name = "bt_EditClient";
            this.bt_EditClient.Size = new System.Drawing.Size(75, 23);
            this.bt_EditClient.TabIndex = 48;
            this.bt_EditClient.Text = "Изменить";
            this.bt_EditClient.UseVisualStyleBackColor = true;
            this.bt_EditClient.Click += new System.EventHandler(this.bt_EditClient_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(990, 20);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(267, 54);
            this.textBox_Result.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(990, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Результат:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(990, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "Цена:";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(993, 96);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(59, 20);
            this.textBox_Price.TabIndex = 52;
            // 
            // comboBox_StatusRepair
            // 
            this.comboBox_StatusRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_StatusRepair.FormattingEnabled = true;
            this.comboBox_StatusRepair.Location = new System.Drawing.Point(993, 186);
            this.comboBox_StatusRepair.Name = "comboBox_StatusRepair";
            this.comboBox_StatusRepair.Size = new System.Drawing.Size(264, 21);
            this.comboBox_StatusRepair.Sorted = true;
            this.comboBox_StatusRepair.TabIndex = 54;
            this.comboBox_StatusRepair.SelectedIndexChanged += new System.EventHandler(this.comboBox_StatusRepair_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(991, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Состояние ремонта:";
            // 
            // bt_SaveNewRepair
            // 
            this.bt_SaveNewRepair.Location = new System.Drawing.Point(593, 249);
            this.bt_SaveNewRepair.Name = "bt_SaveNewRepair";
            this.bt_SaveNewRepair.Size = new System.Drawing.Size(181, 23);
            this.bt_SaveNewRepair.TabIndex = 55;
            this.bt_SaveNewRepair.Text = "Сохранить новый ремонт";
            this.bt_SaveNewRepair.UseVisualStyleBackColor = true;
            this.bt_SaveNewRepair.Click += new System.EventHandler(this.bt_SaveNewRepair_Click);
            // 
            // AddRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 314);
            this.Controls.Add(this.bt_SaveNewRepair);
            this.Controls.Add(this.comboBox_StatusRepair);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bt_EditClient);
            this.Controls.Add(this.bt_AddClient);
            this.Controls.Add(this.comboBox_Engineer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_kitView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_Defect);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_TypeRepair);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_SN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_NewModel);
            this.Controls.Add(this.bt_NewBrand);
            this.Controls.Add(this.bt_NewCategory);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.comboBox_Brands);
            this.Controls.Add(this.comboBox_Categories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_nameClient);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Contact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRepairForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового ремонта";
            this.Load += new System.EventHandler(this.AddRepairForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.ComboBox comboBox_Brands;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.Button bt_NewCategory;
        private System.Windows.Forms.Button bt_NewBrand;
        private System.Windows.Forms.Button bt_NewModel;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_TypeRepair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Defect;
        private System.Windows.Forms.TextBox textBox_kitView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_Engineer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_AddClient;
        private System.Windows.Forms.Button bt_EditClient;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.ComboBox comboBox_StatusRepair;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bt_SaveNewRepair;
        public System.Windows.Forms.ComboBox comboBox_nameClient;
        public System.Windows.Forms.TextBox textBox_Email;
        public System.Windows.Forms.TextBox textBox_Address;
        public System.Windows.Forms.TextBox textBox_Phone;
        public System.Windows.Forms.TextBox textBox_Contact;
    }
}