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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void выдача_автомобилейBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выдача_автомобилейBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDataSet);

        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carsDataSet.Выдача_автомобилей". При необходимости она может быть перемещена или удалена.
            this.выдача_автомобилейTableAdapter.Fill(this.carsDataSet.Выдача_автомобилей);

        }
    }
}
