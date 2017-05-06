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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void график_возвратаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.график_возвратаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDataSet);

        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carsDataSet.График_возврата". При необходимости она может быть перемещена или удалена.
            this.график_возвратаTableAdapter.Fill(this.carsDataSet.График_возврата);

        }
    }
}
