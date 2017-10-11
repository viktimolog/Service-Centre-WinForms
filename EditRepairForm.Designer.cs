namespace ServiceCentre
{
    partial class EditRepairForm
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
            this.bt_SaveRepair = new System.Windows.Forms.Button();
            this.comboBox_StatusRepair = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bt_EditClient = new System.Windows.Forms.Button();
            this.bt_AddClient = new System.Windows.Forms.Button();
            this.comboBox_Engineer = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_kitView = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Defect = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_TypeRepair = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_NewModel = new System.Windows.Forms.Button();
            this.bt_NewBrand = new System.Windows.Forms.Button();
            this.bt_NewCategory = new System.Windows.Forms.Button();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.comboBox_Brands = new System.Windows.Forms.ComboBox();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_nameClient = new System.Windows.Forms.ComboBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // bt_SaveRepair
            // 
            this.bt_SaveRepair.Location = new System.Drawing.Point(588, 282);
            this.bt_SaveRepair.Name = "bt_SaveRepair";
            this.bt_SaveRepair.Size = new System.Drawing.Size(181, 23);
            this.bt_SaveRepair.TabIndex = 93;
            this.bt_SaveRepair.Text = "Сохранить изменения";
            this.bt_SaveRepair.UseVisualStyleBackColor = true;
            this.bt_SaveRepair.Click += new System.EventHandler(this.bt_SaveRepair_Click);
            // 
            // comboBox_StatusRepair
            // 
            this.comboBox_StatusRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_StatusRepair.FormattingEnabled = true;
            this.comboBox_StatusRepair.Location = new System.Drawing.Point(988, 219);
            this.comboBox_StatusRepair.Name = "comboBox_StatusRepair";
            this.comboBox_StatusRepair.Size = new System.Drawing.Size(264, 21);
            this.comboBox_StatusRepair.Sorted = true;
            this.comboBox_StatusRepair.TabIndex = 92;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(986, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 91;
            this.label16.Text = "Состояние ремонта:";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(988, 129);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(59, 20);
            this.textBox_Price.TabIndex = 90;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(985, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 89;
            this.label15.Text = "Цена:";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(985, 53);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(267, 54);
            this.textBox_Result.TabIndex = 88;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(985, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 87;
            this.label14.Text = "Результат:";
            // 
            // bt_EditClient
            // 
            this.bt_EditClient.Location = new System.Drawing.Point(276, 98);
            this.bt_EditClient.Name = "bt_EditClient";
            this.bt_EditClient.Size = new System.Drawing.Size(75, 23);
            this.bt_EditClient.TabIndex = 86;
            this.bt_EditClient.Text = "Изменить";
            this.bt_EditClient.UseVisualStyleBackColor = true;
            this.bt_EditClient.Click += new System.EventHandler(this.bt_EditClient_Click);
            // 
            // bt_AddClient
            // 
            this.bt_AddClient.Location = new System.Drawing.Point(276, 53);
            this.bt_AddClient.Name = "bt_AddClient";
            this.bt_AddClient.Size = new System.Drawing.Size(75, 23);
            this.bt_AddClient.TabIndex = 85;
            this.bt_AddClient.Text = "Добавить";
            this.bt_AddClient.UseVisualStyleBackColor = true;
            this.bt_AddClient.Click += new System.EventHandler(this.bt_AddClient_Click);
            // 
            // comboBox_Engineer
            // 
            this.comboBox_Engineer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Engineer.FormattingEnabled = true;
            this.comboBox_Engineer.Location = new System.Drawing.Point(712, 219);
            this.comboBox_Engineer.Name = "comboBox_Engineer";
            this.comboBox_Engineer.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Engineer.Sorted = true;
            this.comboBox_Engineer.TabIndex = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(713, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "Инженер:";
            // 
            // textBox_kitView
            // 
            this.textBox_kitView.Location = new System.Drawing.Point(712, 129);
            this.textBox_kitView.Multiline = true;
            this.textBox_kitView.Name = "textBox_kitView";
            this.textBox_kitView.Size = new System.Drawing.Size(267, 70);
            this.textBox_kitView.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(712, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "Комплектность, внешнее состояние(Б/У, сколы...):";
            // 
            // textBox_Defect
            // 
            this.textBox_Defect.Location = new System.Drawing.Point(712, 54);
            this.textBox_Defect.Multiline = true;
            this.textBox_Defect.Name = "textBox_Defect";
            this.textBox_Defect.Size = new System.Drawing.Size(267, 54);
            this.textBox_Defect.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(712, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Дефект:";
            // 
            // comboBox_TypeRepair
            // 
            this.comboBox_TypeRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypeRepair.FormattingEnabled = true;
            this.comboBox_TypeRepair.Location = new System.Drawing.Point(361, 219);
            this.comboBox_TypeRepair.Name = "comboBox_TypeRepair";
            this.comboBox_TypeRepair.Size = new System.Drawing.Size(264, 21);
            this.comboBox_TypeRepair.Sorted = true;
            this.comboBox_TypeRepair.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Тип ремонта:";
            // 
            // textBox_SN
            // 
            this.textBox_SN.Location = new System.Drawing.Point(361, 180);
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(264, 20);
            this.textBox_SN.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Серийный номер изделия:";
            // 
            // bt_NewModel
            // 
            this.bt_NewModel.Location = new System.Drawing.Point(631, 141);
            this.bt_NewModel.Name = "bt_NewModel";
            this.bt_NewModel.Size = new System.Drawing.Size(75, 23);
            this.bt_NewModel.TabIndex = 74;
            this.bt_NewModel.Text = "Новая";
            this.bt_NewModel.UseVisualStyleBackColor = true;
            this.bt_NewModel.Click += new System.EventHandler(this.bt_NewModel_Click);
            // 
            // bt_NewBrand
            // 
            this.bt_NewBrand.Location = new System.Drawing.Point(631, 100);
            this.bt_NewBrand.Name = "bt_NewBrand";
            this.bt_NewBrand.Size = new System.Drawing.Size(75, 23);
            this.bt_NewBrand.TabIndex = 73;
            this.bt_NewBrand.Text = "Новый";
            this.bt_NewBrand.UseVisualStyleBackColor = true;
            this.bt_NewBrand.Click += new System.EventHandler(this.bt_NewBrand_Click);
            // 
            // bt_NewCategory
            // 
            this.bt_NewCategory.Location = new System.Drawing.Point(631, 54);
            this.bt_NewCategory.Name = "bt_NewCategory";
            this.bt_NewCategory.Size = new System.Drawing.Size(75, 23);
            this.bt_NewCategory.TabIndex = 72;
            this.bt_NewCategory.Text = "Новая";
            this.bt_NewCategory.UseVisualStyleBackColor = true;
            this.bt_NewCategory.Click += new System.EventHandler(this.bt_NewCategory_Click);
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(360, 141);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Model.Sorted = true;
            this.comboBox_Model.TabIndex = 71;
            // 
            // comboBox_Brands
            // 
            this.comboBox_Brands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Brands.FormattingEnabled = true;
            this.comboBox_Brands.Location = new System.Drawing.Point(360, 100);
            this.comboBox_Brands.Name = "comboBox_Brands";
            this.comboBox_Brands.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Brands.Sorted = true;
            this.comboBox_Brands.TabIndex = 70;
            this.comboBox_Brands.SelectedIndexChanged += new System.EventHandler(this.comboBox_Brands_SelectedIndexChanged);
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(360, 54);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Categories.Sorted = true;
            this.comboBox_Categories.TabIndex = 69;
            this.comboBox_Categories.SelectedIndexChanged += new System.EventHandler(this.comboBox_Categories_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Бренд изделия (Samsung, Asus...)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Модель изделия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Категория изделия (Ноутбук, Планшет...):";
            // 
            // comboBox_nameClient
            // 
            this.comboBox_nameClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nameClient.FormattingEnabled = true;
            this.comboBox_nameClient.Location = new System.Drawing.Point(10, 54);
            this.comboBox_nameClient.Name = "comboBox_nameClient";
            this.comboBox_nameClient.Size = new System.Drawing.Size(264, 21);
            this.comboBox_nameClient.TabIndex = 65;
            this.comboBox_nameClient.SelectedIndexChanged += new System.EventHandler(this.comboBox_nameClient_SelectedIndexChanged);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Location = new System.Drawing.Point(10, 219);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(264, 20);
            this.textBox_Email.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "E-mail:";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Enabled = false;
            this.textBox_Address.Location = new System.Drawing.Point(10, 180);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(264, 20);
            this.textBox_Address.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Адрес:";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Enabled = false;
            this.textBox_Phone.Location = new System.Drawing.Point(10, 141);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(264, 20);
            this.textBox_Phone.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Телефон:";
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Enabled = false;
            this.textBox_Contact.Location = new System.Drawing.Point(10, 99);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(264, 20);
            this.textBox_Contact.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Контактное лицо:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Название Компании, если ЧЛ - ФИО";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 94;
            this.label17.Text = "Номер:";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Enabled = false;
            this.textBox_Number.Location = new System.Drawing.Point(51, 6);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(118, 20);
            this.textBox_Number.TabIndex = 95;
            // 
            // textBox_Date
            // 
            this.textBox_Date.Enabled = false;
            this.textBox_Date.Location = new System.Drawing.Point(214, 6);
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(137, 20);
            this.textBox_Date.TabIndex = 97;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(175, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 96;
            this.label18.Text = "Дата:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // EditRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 338);
            this.Controls.Add(this.textBox_Date);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.bt_SaveRepair);
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
            this.Name = "EditRepairForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование ремонта";
            this.Load += new System.EventHandler(this.EditRepairForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_SaveRepair;
        private System.Windows.Forms.ComboBox comboBox_StatusRepair;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt_EditClient;
        private System.Windows.Forms.Button bt_AddClient;
        private System.Windows.Forms.ComboBox comboBox_Engineer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_kitView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Defect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_TypeRepair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_NewModel;
        private System.Windows.Forms.Button bt_NewBrand;
        private System.Windows.Forms.Button bt_NewCategory;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.ComboBox comboBox_Brands;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_nameClient;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}