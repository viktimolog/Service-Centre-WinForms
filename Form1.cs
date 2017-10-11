using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCentre
{
    public partial class Form1 : Form
    {
        private SQLActions sql;
        private int idFindRepair;
        private string SN;
        private string find;
        private string order;
        public Form1()
        {
            InitializeComponent();
            Icon icon = new Icon("SC.ico");
            this.Icon = icon;
            sql = new SQLActions();
            idFindRepair = 0;
            SN = "";
            order = "";
            find = "";
        }
        public int IdFindRepair { get { return idFindRepair; } set { idFindRepair = value; } }
        public string sN { get { return SN; } set { SN = value; } }
        public string Find { get { return find; } set { find = value; } }


     /*        public void loadForm1(int id = 0)//либо по номеру, либо все незавершенные, выводит не в том порядке столбцы
             {
                 List<RepairView> repairsView;

                 repairsView = sql.ShowRepairsNotFinishForDS();

                 dataGridView1.DataSource = repairsView;

                 dataGridView1.ReadOnly = true;
             }*/

        public void getRepairByOther(string find)
        {
            List<String[]> rows;

            dataGridView1.Columns.Clear();

            rows = sql.getRepairByOther(find);

            for (int i = 0; i < rows[0].Length; i++)
                dataGridView1.Columns.Add((rows[0])[i], (rows[0])[i]);

            for (int i = 1; i < rows.Count; i++)
                dataGridView1.Rows.Add(rows[i]);

            dataGridView1.ReadOnly = true;
        }

        public void getRepairBySN(string SN)
        {
            List<String[]> rows;

            dataGridView1.Columns.Clear();

            rows = sql.getRepairBySN(SN);

            for (int i = 0; i < rows[0].Length; i++)
                dataGridView1.Columns.Add((rows[0])[i], (rows[0])[i]);

            for (int i = 1; i < rows.Count; i++)
                dataGridView1.Rows.Add(rows[i]);

            dataGridView1.ReadOnly = true;
        }

        public void loadForm1(int id = 0)//либо по номеру, либо все незавершенные
        {
            List<String[]> rows;

            dataGridView1.Columns.Clear();

            if (id == 0) rows = sql.ShowRepairsNotFinish();
               else rows = sql.getRepairByNumber(id);


          /*  for(int i=0; i<rows.Count;i++)
            {
                MessageBox.Show("rows[i] = ", rows[i].ToString());
            }*/
            

            for (int i = 0; i < rows[0].Length; i++)
                dataGridView1.Columns.Add((rows[0])[i], (rows[0])[i]);

            for (int i = 1; i < rows.Count; i++)
            {
                dataGridView1.Rows.Add(rows[i]);
//                MessageBox.Show("rows[i] = ", rows[i].ToString());
            }


            dataGridView1.ReadOnly = true;
        }

        public void getAllRepairs()
        {
            List<String[]> rows;

            dataGridView1.Columns.Clear();

            rows = sql.getAllRepairs();

            //  MessageBox.Show("rows[0].Length = ", rows[0].Length.ToString()); ok

            //  MessageBox.Show("rows.Count = ", rows.Count.ToString()); ok


            for (int i = 0; i < rows[0].Length; i++)
                dataGridView1.Columns.Add((rows[0])[i], (rows[0])[i]);

            for (int i = 1; i < rows.Count; i++)
            {
                dataGridView1.Rows.Add(rows[i]);
//                MessageBox.Show("", rows[i].ToString());

            }


            dataGridView1.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadForm1();
        }

        private void добавитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddCategoryForm()).ShowDialog();
        }

        private void редактироватьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditCategoryForm()).ShowDialog();
        }

        private void добавитьБрендToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddBrandForm()).ShowDialog();
        }

        private void редактироватьБрендToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditBrandForm()).ShowDialog();
        }

        private void добавитьМодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddModelForm()).ShowDialog();
        }

        private void добавитьЗаказчикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client newClient = new Client();
            (new AddClientForm(newClient)).ShowDialog();
        }

        private void редактироватьЗаказчикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditClientForm()).ShowDialog();
        }

        public void test(DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString(), "Индекс строки");
        }

        private void добавитьРемонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddRepairForm()).ShowDialog();
            loadForm1();
        }

        private void редактироватьРемонтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new EditRepairForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()))).ShowDialog();
            loadForm1();
        }

        private void поНомеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindRepairByNumberForm f = new FindRepairByNumberForm();
            f.Owner = this;
            f.ShowDialog();
            loadForm1(idFindRepair);
        }

        private void показатьВсеРемонтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getAllRepairs();
        }

        private void толькоНезавершенныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm1();
        }

        private void печатьКвитанцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRepairForm editForm = new EditRepairForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

            editForm.loadEditRepairForm();

            //editForm.Visible = false;

            order = editForm.Order();

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.PrintPage += new PrintPageEventHandler(PRD);
                    printDocument1.DocumentName = "Order"; //Названия документа
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;//Передаем параметры
                    printDocument1.Print();//Начинаем процесс печати
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }

        }
        public void PRD(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString(order, new Font("Arial", 12), new SolidBrush(Color.Black), 0, 0);
        }//Конец печати

        private void печатьКвитанцииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            печатьКвитанцииToolStripMenuItem_Click(sender, e);
        }

        private void добавитьРемонтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            добавитьРемонтToolStripMenuItem_Click(sender, e);
        }

        private void редактироватьРемонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            редактироватьРемонтToolStripMenuItem1_Click(sender, e);
        }

        private void редактироватьМодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new EditModelForm()).ShowDialog();
        }

        private void поЗаказчикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindRepairBySNForm f = new FindRepairBySNForm();
            f.Owner = this;
            f.ShowDialog();
            getRepairBySN(sN);
        }

        private void поДругимПолямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindByOtherForm f = new FindByOtherForm();
            f.Owner = this;
            f.ShowDialog();
            getRepairByOther(Find);
        }
    }
}
