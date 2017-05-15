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
    public partial class FormCar : Form
    {
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButton1.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
                (int)((DataRowView)автомобильBindingSource.Current)["код_автомобиля"];
            else
                return -1;
        }
        public FormCar()
        {
            InitializeComponent();
        }

        private void автомобильBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автомобильBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDataSet);

        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carsDataSet.Автомобиль". При необходимости она может быть перемещена или удалена.
            this.автомобильTableAdapter.Fill(this.carsDataSet.Автомобиль);

        }

        private void автомобильDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
