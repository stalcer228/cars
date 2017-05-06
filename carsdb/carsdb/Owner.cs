﻿using System;
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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void арендодательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.арендодательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carsDataSet);

        }

        private void Owner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carsDataSet.Арендодатель". При необходимости она может быть перемещена или удалена.
            this.арендодательTableAdapter.Fill(this.carsDataSet.Арендодатель);

        }
    }
}
