using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carsdb
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carsDataSet.Арендодатель". При необходимости она может быть перемещена или удалена.
            this.арендодательTableAdapter.Fill(this.carsDataSet.Арендодатель);

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?","Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Мариненко С.А.,745,2017", "О программе",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Мариненко С.А.,745,2017", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void автомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCar fd = new FormCar();
            fd.ShowDialog();
        }

        private void арендодательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.арендодательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDataSet);

        }

        private void арендодательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Owner fd = new Owner();
            fd.ShowDialog();
        }
    }
}
