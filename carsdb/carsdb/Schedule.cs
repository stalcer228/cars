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
            try
            {
                this.Validate();
                this.график_возвратаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.carsDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carsDataSet.График_возврата". При необходимости она может быть перемещена или удалена.
            this.график_возвратаTableAdapter.Fill(this.carsDataSet.График_возврата);
        }

        private void график_возвратаBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void датаLabel_Click(object sender, EventArgs e)
        {

        }

        private void график_возвратаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void id_выданного_автомобиляLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBoxFind.Checked)
                {
                    if (toolStripTextBoxFind.Text == "")
                        MessageBox.Show("Вы ничего не задали", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        try
                        {
                            график_возвратаBindingSource.Filter =
                            GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Ошибка фильтрации \n" +
                            err.Message);
                        }
                }
                else
                    график_возвратаBindingSource.Filter = "";
                if (график_возвратаBindingSource.Count == 0)
                {
                    MessageBox.Show("Нет таких");
                    график_возвратаBindingSource.Filter = "";
                    checkBoxFind.Checked = false;
                }
            }
        }
        string GetSelectedFieldName()
        {
            return
            график_возвратаDataGridView.Columns[график_возвратаDataGridView.CurrentCell.ColumnIndex
            ].DataPropertyName;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            {
                if (toolStripTextBoxFind.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int indexPos;
                try
                {
                    indexPos =
                    график_возвратаBindingSource.Find(GetSelectedFieldName(),
                    toolStripButton1.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка поиска \n" + err.Message);
                    return;
                }
                if (indexPos > -1)
                    график_возвратаBindingSource.Position = indexPos;
                else
                {
                    MessageBox.Show("Такой цены нет", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    график_возвратаBindingSource.Position = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*{
                int id = -1;
                if
                (((DataRowView)график_возвратаBindingSource.Current)["код_автомобиля"].ToString() !=
                "")
                {
                    id =
                    (int)(((DataRowView)график_возвратаBindingSource.Current)["код_автомобиля"]);
                }
                id = FormCar.fw.ShowSelectForm(id);
                if (id >= 0)
                {
                    MessageBox.Show(id.ToString());
                    ((DataRowView)график_возвратаBindingSource.Current)["код_автомобиля"]
                    = id;
                    график_возвратаBindingSource.EndEdit();
                }
            }*/
        }

        
    }
}
