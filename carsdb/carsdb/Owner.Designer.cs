namespace carsdb
{
    partial class Owner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner));
            System.Windows.Forms.Label id_арендодателяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            this.арендодательBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.арендодательBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.арендодательDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.арендодательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDataSet = new carsdb.carsDataSet();
            this.арендодательTableAdapter = new carsdb.carsDataSetTableAdapters.АрендодательTableAdapter();
            this.tableAdapterManager = new carsdb.carsDataSetTableAdapters.TableAdapterManager();
            this.id_арендодателяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            id_арендодателяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.арендодательBindingNavigator)).BeginInit();
            this.арендодательBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.арендодательDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендодательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // арендодательBindingNavigator
            // 
            this.арендодательBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.арендодательBindingNavigator.BindingSource = this.арендодательBindingSource;
            this.арендодательBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.арендодательBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.арендодательBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.арендодательBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.арендодательBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.арендодательBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.арендодательBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.арендодательBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.арендодательBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.арендодательBindingNavigator.Name = "арендодательBindingNavigator";
            this.арендодательBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.арендодательBindingNavigator.Size = new System.Drawing.Size(600, 25);
            this.арендодательBindingNavigator.TabIndex = 0;
            this.арендодательBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // арендодательBindingNavigatorSaveItem
            // 
            this.арендодательBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.арендодательBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("арендодательBindingNavigatorSaveItem.Image")));
            this.арендодательBindingNavigatorSaveItem.Name = "арендодательBindingNavigatorSaveItem";
            this.арендодательBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.арендодательBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.арендодательBindingNavigatorSaveItem.Click += new System.EventHandler(this.арендодательBindingNavigatorSaveItem_Click);
            // 
            // арендодательDataGridView
            // 
            this.арендодательDataGridView.AutoGenerateColumns = false;
            this.арендодательDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.арендодательDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.арендодательDataGridView.DataSource = this.арендодательBindingSource;
            this.арендодательDataGridView.Location = new System.Drawing.Point(0, 264);
            this.арендодательDataGridView.Name = "арендодательDataGridView";
            this.арендодательDataGridView.Size = new System.Drawing.Size(443, 175);
            this.арендодательDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_арендодателя";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_арендодателя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // арендодательBindingSource
            // 
            this.арендодательBindingSource.DataMember = "Арендодатель";
            this.арендодательBindingSource.DataSource = this.carsDataSet;
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "carsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // арендодательTableAdapter
            // 
            this.арендодательTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = carsdb.carsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.АрендодательTableAdapter = this.арендодательTableAdapter;
            this.tableAdapterManager.Выдача_автомобилейTableAdapter = null;
            this.tableAdapterManager.График_возвратаTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            // 
            // id_арендодателяLabel
            // 
            id_арендодателяLabel.AutoSize = true;
            id_арендодателяLabel.Location = new System.Drawing.Point(13, 48);
            id_арендодателяLabel.Name = "id_арендодателяLabel";
            id_арендодателяLabel.Size = new System.Drawing.Size(92, 13);
            id_арендодателяLabel.TabIndex = 2;
            id_арендодателяLabel.Text = "id арендодателя:";
            // 
            // id_арендодателяTextBox
            // 
            this.id_арендодателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендодательBindingSource, "id_арендодателя", true));
            this.id_арендодателяTextBox.Location = new System.Drawing.Point(111, 45);
            this.id_арендодателяTextBox.Name = "id_арендодателяTextBox";
            this.id_арендодателяTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_арендодателяTextBox.TabIndex = 3;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(13, 74);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 4;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендодательBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(111, 71);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(100, 20);
            this.фамилияTextBox.TabIndex = 5;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(13, 100);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 6;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендодательBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(111, 97);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 20);
            this.имяTextBox.TabIndex = 7;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(13, 126);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 8;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендодательBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(111, 123);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(100, 20);
            this.отчествоTextBox.TabIndex = 9;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 459);
            this.Controls.Add(id_арендодателяLabel);
            this.Controls.Add(this.id_арендодателяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(this.арендодательDataGridView);
            this.Controls.Add(this.арендодательBindingNavigator);
            this.Name = "Owner";
            this.Text = "Арендодатель";
            this.Load += new System.EventHandler(this.Owner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.арендодательBindingNavigator)).EndInit();
            this.арендодательBindingNavigator.ResumeLayout(false);
            this.арендодательBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.арендодательDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендодательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private carsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource арендодательBindingSource;
        private carsDataSetTableAdapters.АрендодательTableAdapter арендодательTableAdapter;
        private carsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator арендодательBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton арендодательBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView арендодательDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox id_арендодателяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
    }
}