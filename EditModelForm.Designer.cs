namespace ServiceCentre
{
    partial class EditModelForm
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
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.comboBox_Brands = new System.Windows.Forms.ComboBox();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_newNameModel = new System.Windows.Forms.TextBox();
            this.bt_SaveModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(12, 117);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Model.TabIndex = 77;
            this.comboBox_Model.SelectedIndexChanged += new System.EventHandler(this.comboBox_Model_SelectedIndexChanged);
            // 
            // comboBox_Brands
            // 
            this.comboBox_Brands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Brands.FormattingEnabled = true;
            this.comboBox_Brands.Location = new System.Drawing.Point(12, 70);
            this.comboBox_Brands.Name = "comboBox_Brands";
            this.comboBox_Brands.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Brands.TabIndex = 76;
            this.comboBox_Brands.SelectedIndexChanged += new System.EventHandler(this.comboBox_Brands_SelectedIndexChanged);
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(12, 24);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(264, 21);
            this.comboBox_Categories.TabIndex = 75;
            this.comboBox_Categories.SelectedIndexChanged += new System.EventHandler(this.comboBox_Categories_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Бренд изделия (Samsung, Asus...)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Модель изделия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Категория изделия (Ноутбук, Планшет...):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Новое название модели:";
            // 
            // textBox_newNameModel
            // 
            this.textBox_newNameModel.Location = new System.Drawing.Point(12, 162);
            this.textBox_newNameModel.Name = "textBox_newNameModel";
            this.textBox_newNameModel.Size = new System.Drawing.Size(264, 20);
            this.textBox_newNameModel.TabIndex = 79;
            // 
            // bt_SaveModel
            // 
            this.bt_SaveModel.Location = new System.Drawing.Point(47, 212);
            this.bt_SaveModel.Name = "bt_SaveModel";
            this.bt_SaveModel.Size = new System.Drawing.Size(181, 23);
            this.bt_SaveModel.TabIndex = 94;
            this.bt_SaveModel.Text = "Сохранить модель";
            this.bt_SaveModel.UseVisualStyleBackColor = true;
            this.bt_SaveModel.Click += new System.EventHandler(this.bt_SaveModel_Click);
            // 
            // EditModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 262);
            this.Controls.Add(this.bt_SaveModel);
            this.Controls.Add(this.textBox_newNameModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.comboBox_Brands);
            this.Controls.Add(this.comboBox_Categories);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование модели";
            this.Load += new System.EventHandler(this.EditModelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.ComboBox comboBox_Brands;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_newNameModel;
        private System.Windows.Forms.Button bt_SaveModel;
    }
}