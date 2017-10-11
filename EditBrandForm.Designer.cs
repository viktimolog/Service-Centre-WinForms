namespace ServiceCentre
{
    partial class EditBrandForm
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
            this.bt_Save = new System.Windows.Forms.Button();
            this.textBox_nameBrand = new System.Windows.Forms.TextBox();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.comboBox_Brands = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Categories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(106, 158);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 9;
            this.bt_Save.Text = "Сохранить";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // textBox_nameBrand
            // 
            this.textBox_nameBrand.Location = new System.Drawing.Point(9, 88);
            this.textBox_nameBrand.Name = "textBox_nameBrand";
            this.textBox_nameBrand.Size = new System.Drawing.Size(259, 20);
            this.textBox_nameBrand.TabIndex = 8;
            // 
            // bt_Edit
            // 
            this.bt_Edit.Location = new System.Drawing.Point(106, 46);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(75, 23);
            this.bt_Edit.TabIndex = 7;
            this.bt_Edit.Text = "Изменить";
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // comboBox_Brands
            // 
            this.comboBox_Brands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Brands.FormattingEnabled = true;
            this.comboBox_Brands.Location = new System.Drawing.Point(9, 19);
            this.comboBox_Brands.Name = "comboBox_Brands";
            this.comboBox_Brands.Size = new System.Drawing.Size(259, 21);
            this.comboBox_Brands.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите бренд из списка:";
            // 
            // comboBox_Categories
            // 
            this.comboBox_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Categories.FormattingEnabled = true;
            this.comboBox_Categories.Location = new System.Drawing.Point(12, 131);
            this.comboBox_Categories.Name = "comboBox_Categories";
            this.comboBox_Categories.Size = new System.Drawing.Size(259, 21);
            this.comboBox_Categories.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите категорию бренда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Новое имя бренда:";
            // 
            // EditBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 188);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Categories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.textBox_nameBrand);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.comboBox_Brands);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBrandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование Бренда";
            this.Load += new System.EventHandler(this.EditBrandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox textBox_nameBrand;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.ComboBox comboBox_Brands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Categories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}