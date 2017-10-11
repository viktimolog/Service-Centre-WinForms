namespace ServiceCentre
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ремонтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРемонтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьРемонтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьКвитанцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЗаказчикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДругимПолямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеРемонтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толькоНезавершенныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаказчикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьЗаказчикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииИзделийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.брендыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьБрендToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьБрендToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиИзделийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьМодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьРемонтToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьРемонтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьКвитанцииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ремонтыToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.заказчикиToolStripMenuItem,
            this.категорииИзделийToolStripMenuItem,
            this.брендыToolStripMenuItem,
            this.моделиИзделийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1494, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ремонтыToolStripMenuItem
            // 
            this.ремонтыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРемонтToolStripMenuItem,
            this.редактироватьРемонтToolStripMenuItem1,
            this.печатьКвитанцииToolStripMenuItem});
            this.ремонтыToolStripMenuItem.Name = "ремонтыToolStripMenuItem";
            this.ремонтыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ремонтыToolStripMenuItem.Text = "Ремонты";
            // 
            // добавитьРемонтToolStripMenuItem
            // 
            this.добавитьРемонтToolStripMenuItem.Name = "добавитьРемонтToolStripMenuItem";
            this.добавитьРемонтToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.добавитьРемонтToolStripMenuItem.Text = "Добавить ремонт";
            this.добавитьРемонтToolStripMenuItem.Click += new System.EventHandler(this.добавитьРемонтToolStripMenuItem_Click);
            // 
            // редактироватьРемонтToolStripMenuItem1
            // 
            this.редактироватьРемонтToolStripMenuItem1.Name = "редактироватьРемонтToolStripMenuItem1";
            this.редактироватьРемонтToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.редактироватьРемонтToolStripMenuItem1.Text = "Редактировать ремонт";
            this.редактироватьРемонтToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьРемонтToolStripMenuItem1_Click);
            // 
            // печатьКвитанцииToolStripMenuItem
            // 
            this.печатьКвитанцииToolStripMenuItem.Name = "печатьКвитанцииToolStripMenuItem";
            this.печатьКвитанцииToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.печатьКвитанцииToolStripMenuItem.Text = "Печать квитанции";
            this.печатьКвитанцииToolStripMenuItem.Click += new System.EventHandler(this.печатьКвитанцииToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруToolStripMenuItem,
            this.поЗаказчикуToolStripMenuItem,
            this.поДругимПолямToolStripMenuItem,
            this.показатьВсеРемонтыToolStripMenuItem,
            this.толькоНезавершенныеToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поНомеруToolStripMenuItem
            // 
            this.поНомеруToolStripMenuItem.Name = "поНомеруToolStripMenuItem";
            this.поНомеруToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.поНомеруToolStripMenuItem.Text = "По номеру ремонта";
            this.поНомеруToolStripMenuItem.Click += new System.EventHandler(this.поНомеруToolStripMenuItem_Click);
            // 
            // поЗаказчикуToolStripMenuItem
            // 
            this.поЗаказчикуToolStripMenuItem.Name = "поЗаказчикуToolStripMenuItem";
            this.поЗаказчикуToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.поЗаказчикуToolStripMenuItem.Text = "По серийному номеру";
            this.поЗаказчикуToolStripMenuItem.Click += new System.EventHandler(this.поЗаказчикуToolStripMenuItem_Click);
            // 
            // поДругимПолямToolStripMenuItem
            // 
            this.поДругимПолямToolStripMenuItem.Name = "поДругимПолямToolStripMenuItem";
            this.поДругимПолямToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.поДругимПолямToolStripMenuItem.Text = "По другим полям";
            this.поДругимПолямToolStripMenuItem.Click += new System.EventHandler(this.поДругимПолямToolStripMenuItem_Click);
            // 
            // показатьВсеРемонтыToolStripMenuItem
            // 
            this.показатьВсеРемонтыToolStripMenuItem.Name = "показатьВсеРемонтыToolStripMenuItem";
            this.показатьВсеРемонтыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.показатьВсеРемонтыToolStripMenuItem.Text = "Показать все ремонты";
            this.показатьВсеРемонтыToolStripMenuItem.Click += new System.EventHandler(this.показатьВсеРемонтыToolStripMenuItem_Click);
            // 
            // толькоНезавершенныеToolStripMenuItem
            // 
            this.толькоНезавершенныеToolStripMenuItem.Name = "толькоНезавершенныеToolStripMenuItem";
            this.толькоНезавершенныеToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.толькоНезавершенныеToolStripMenuItem.Text = "Только незавершенные";
            this.толькоНезавершенныеToolStripMenuItem.Click += new System.EventHandler(this.толькоНезавершенныеToolStripMenuItem_Click);
            // 
            // заказчикиToolStripMenuItem
            // 
            this.заказчикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаказчикаToolStripMenuItem,
            this.редактироватьЗаказчикаToolStripMenuItem});
            this.заказчикиToolStripMenuItem.Name = "заказчикиToolStripMenuItem";
            this.заказчикиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.заказчикиToolStripMenuItem.Text = "Заказчики";
            // 
            // добавитьЗаказчикаToolStripMenuItem
            // 
            this.добавитьЗаказчикаToolStripMenuItem.Name = "добавитьЗаказчикаToolStripMenuItem";
            this.добавитьЗаказчикаToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.добавитьЗаказчикаToolStripMenuItem.Text = "Добавить заказчика";
            this.добавитьЗаказчикаToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаказчикаToolStripMenuItem_Click);
            // 
            // редактироватьЗаказчикаToolStripMenuItem
            // 
            this.редактироватьЗаказчикаToolStripMenuItem.Name = "редактироватьЗаказчикаToolStripMenuItem";
            this.редактироватьЗаказчикаToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.редактироватьЗаказчикаToolStripMenuItem.Text = "Редактировать заказчика";
            this.редактироватьЗаказчикаToolStripMenuItem.Click += new System.EventHandler(this.редактироватьЗаказчикаToolStripMenuItem_Click);
            // 
            // категорииИзделийToolStripMenuItem
            // 
            this.категорииИзделийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКатегориюToolStripMenuItem,
            this.редактироватьКатегориюToolStripMenuItem});
            this.категорииИзделийToolStripMenuItem.Name = "категорииИзделийToolStripMenuItem";
            this.категорииИзделийToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.категорииИзделийToolStripMenuItem.Text = "Категории изделий";
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.добавитьКатегориюToolStripMenuItem.Text = "Добавить категорию";
            this.добавитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.добавитьКатегориюToolStripMenuItem_Click);
            // 
            // редактироватьКатегориюToolStripMenuItem
            // 
            this.редактироватьКатегориюToolStripMenuItem.Name = "редактироватьКатегориюToolStripMenuItem";
            this.редактироватьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.редактироватьКатегориюToolStripMenuItem.Text = "Редактировать категорию";
            this.редактироватьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.редактироватьКатегориюToolStripMenuItem_Click);
            // 
            // брендыToolStripMenuItem
            // 
            this.брендыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьБрендToolStripMenuItem,
            this.редактироватьБрендToolStripMenuItem});
            this.брендыToolStripMenuItem.Name = "брендыToolStripMenuItem";
            this.брендыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.брендыToolStripMenuItem.Text = "Бренды";
            // 
            // добавитьБрендToolStripMenuItem
            // 
            this.добавитьБрендToolStripMenuItem.Name = "добавитьБрендToolStripMenuItem";
            this.добавитьБрендToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.добавитьБрендToolStripMenuItem.Text = "Добавить бренд";
            this.добавитьБрендToolStripMenuItem.Click += new System.EventHandler(this.добавитьБрендToolStripMenuItem_Click);
            // 
            // редактироватьБрендToolStripMenuItem
            // 
            this.редактироватьБрендToolStripMenuItem.Name = "редактироватьБрендToolStripMenuItem";
            this.редактироватьБрендToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.редактироватьБрендToolStripMenuItem.Text = "Редактировать бренд";
            this.редактироватьБрендToolStripMenuItem.Click += new System.EventHandler(this.редактироватьБрендToolStripMenuItem_Click);
            // 
            // моделиИзделийToolStripMenuItem
            // 
            this.моделиИзделийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьМодельToolStripMenuItem,
            this.редактироватьМодельToolStripMenuItem});
            this.моделиИзделийToolStripMenuItem.Name = "моделиИзделийToolStripMenuItem";
            this.моделиИзделийToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.моделиИзделийToolStripMenuItem.Text = "Модели изделий";
            // 
            // добавитьМодельToolStripMenuItem
            // 
            this.добавитьМодельToolStripMenuItem.Name = "добавитьМодельToolStripMenuItem";
            this.добавитьМодельToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.добавитьМодельToolStripMenuItem.Text = "Добавить модель";
            this.добавитьМодельToolStripMenuItem.Click += new System.EventHandler(this.добавитьМодельToolStripMenuItem_Click);
            // 
            // редактироватьМодельToolStripMenuItem
            // 
            this.редактироватьМодельToolStripMenuItem.Name = "редактироватьМодельToolStripMenuItem";
            this.редактироватьМодельToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.редактироватьМодельToolStripMenuItem.Text = "Редактировать модель";
            this.редактироватьМодельToolStripMenuItem.Click += new System.EventHandler(this.редактироватьМодельToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1494, 363);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.редактироватьРемонтToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьРемонтToolStripMenuItem1,
            this.редактироватьРемонтToolStripMenuItem,
            this.печатьКвитанцииToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 70);
            // 
            // добавитьРемонтToolStripMenuItem1
            // 
            this.добавитьРемонтToolStripMenuItem1.Name = "добавитьРемонтToolStripMenuItem1";
            this.добавитьРемонтToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.добавитьРемонтToolStripMenuItem1.Text = "Добавить ремонт";
            this.добавитьРемонтToolStripMenuItem1.Click += new System.EventHandler(this.добавитьРемонтToolStripMenuItem1_Click);
            // 
            // редактироватьРемонтToolStripMenuItem
            // 
            this.редактироватьРемонтToolStripMenuItem.Name = "редактироватьРемонтToolStripMenuItem";
            this.редактироватьРемонтToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.редактироватьРемонтToolStripMenuItem.Text = "Редактировать ремонт";
            this.редактироватьРемонтToolStripMenuItem.Click += new System.EventHandler(this.редактироватьРемонтToolStripMenuItem_Click);
            // 
            // печатьКвитанцииToolStripMenuItem1
            // 
            this.печатьКвитанцииToolStripMenuItem1.Name = "печатьКвитанцииToolStripMenuItem1";
            this.печатьКвитанцииToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.печатьКвитанцииToolStripMenuItem1.Text = "Печать квитанции";
            this.печатьКвитанцииToolStripMenuItem1.Click += new System.EventHandler(this.печатьКвитанцииToolStripMenuItem1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервисный центр: ВСЕСВИТ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ремонтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНомеруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЗаказчикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДругимПолямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказчикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаказчикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьЗаказчикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииИзделийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиИзделийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМодельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьМодельToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem брендыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьБрендToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьБрендToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРемонтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьРемонтToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеРемонтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толькоНезавершенныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьКвитанцииToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьРемонтToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьРемонтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьКвитанцииToolStripMenuItem1;
    }
}

