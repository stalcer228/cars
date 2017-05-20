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
    public partial class Client : Form
    
    {
        public Client()
        {
            InitializeComponent();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDataSet);

        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carsDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.carsDataSet.Клиент);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButton1.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
                (int)((DataRowView)клиентBindingSource.Current)["id_клиента"];
            else
                return -1;
        }
    }
}
