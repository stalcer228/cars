namespace carsdb
{
    partial class Schedule
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
            this.id_выданного_автомобиляLabel = new System.Windows.Forms.Label();
            this.итоговая_ценаLabel = new System.Windows.Forms.Label();
            this.описаниеLabel = new System.Windows.Forms.Label();
            this.датаLabel = new System.Windows.Forms.Label();
            this.carsDataSet = new carsdb.carsDataSet();
            this.график_возвратаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.график_возвратаTableAdapter = new carsdb.carsDataSetTableAdapters.График_возвратаTableAdapter();
            this.tableAdapterManager = new carsdb.carsDataSetTableAdapters.TableAdapterManager();
            this.график_возвратаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.график_возвратаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.график_возвратаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_выданного_автомобиляTextBox = new System.Windows.Forms.TextBox();
            this.итоговая_ценаTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFind = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.график_возвратаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.график_возвратаBindingNavigator)).BeginInit();
            this.график_возвратаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.график_возвратаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_выданного_автомобиляLabel
            // 
            this.id_выданного_автомобиляLabel.AutoSize = true;
            this.id_выданного_автомобиляLabel.Location = new System.Drawing.Point(9, 45);
            this.id_выданного_автомобиляLabel.Name = "id_выданного_автомобиляLabel";
            this.id_выданного_автомобиляLabel.Size = new System.Drawing.Size(140, 13);
            this.id_выданного_автомобиляLabel.TabIndex = 2;
            this.id_выданного_автомобиляLabel.Text = "id выданного автомобиля:";
            this.id_выданного_автомобиляLabel.Click += new System.EventHandler(this.id_выданного_автомобиляLabel_Click);
            // 
            // итоговая_ценаLabel
            // 
            this.итоговая_ценаLabel.AutoSize = true;
            this.итоговая_ценаLabel.Location = new System.Drawing.Point(9, 71);
            this.итоговая_ценаLabel.Name = "итоговая_ценаLabel";
            this.итоговая_ценаLabel.Size = new System.Drawing.Size(85, 13);
            this.итоговая_ценаLabel.TabIndex = 4;
            this.итоговая_ценаLabel.Text = "Итоговая цена:";
            // 
            // описаниеLabel
            // 
            this.описаниеLabel.AutoSize = true;
            this.описаниеLabel.Location = new System.Drawing.Point(9, 97);
            this.описаниеLabel.Name = "описаниеLabel";
            this.описаниеLabel.Size = new System.Drawing.Size(60, 13);
            this.описаниеLabel.TabIndex = 6;
            this.описаниеLabel.Text = "Описание:";
            // 
            // датаLabel
            // 
            this.датаLabel.AutoSize = true;
            this.датаLabel.Location = new System.Drawing.Point(9, 124);
            this.датаLabel.Name = "датаLabel";
            this.датаLabel.Size = new System.Drawing.Size(36, 13);
            this.датаLabel.TabIndex = 8;
            this.датаLabel.Text = "Дата:";
            this.датаLabel.Click += new System.EventHandler(this.датаLabel_Click);
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "carsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // график_возвратаBindingSource
            // 
            this.график_возвратаBindingSource.DataMember = "График возврата";
            this.график_возвратаBindingSource.DataSource = this.carsDataSet;
            this.график_возвратаBindingSource.Filter = "";
            this.график_возвратаBindingSource.Sort = "";
            // 
            // график_возвратаTableAdapter
            // 
            this.график_возвратаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = carsdb.carsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.АрендодательTableAdapter = null;
            this.tableAdapterManager.Выдача_автомобилейTableAdapter = null;
            this.tableAdapterManager.График_возвратаTableAdapter = this.график_возвратаTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = null;
            // 
            // график_возвратаBindingNavigator
            // 
            this.график_возвратаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.график_возвратаBindingNavigator.BindingSource = this.график_возвратаBindingSource;
            this.график_возвратаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.график_возвратаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.график_возвратаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.график_возвратаBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripTextBoxFind,
            this.toolStripButton1});
            this.график_возвратаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.график_возвратаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.график_возвратаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.график_возвратаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.график_возвратаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.график_возвратаBindingNavigator.Name = "график_возвратаBindingNavigator";
            this.график_возвратаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.график_возвратаBindingNavigator.Size = new System.Drawing.Size(1112, 25);
            this.график_возвратаBindingNavigator.TabIndex = 0;
            this.график_возвратаBindingNavigator.Text = "bindingNavigator1";
            this.график_возвратаBindingNavigator.RefreshItems += new System.EventHandler(this.график_возвратаBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            // график_возвратаBindingNavigatorSaveItem
            // 
            this.график_возвратаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.график_возвратаBindingNavigatorSaveItem.Name = "график_возвратаBindingNavigatorSaveItem";
            this.график_возвратаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.график_возвратаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.график_возвратаBindingNavigatorSaveItem.Click += new System.EventHandler(this.график_возвратаBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Поиск";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // график_возвратаDataGridView
            // 
            this.график_возвратаDataGridView.AutoGenerateColumns = false;
            this.график_возвратаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.график_возвратаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.график_возвратаDataGridView.DataSource = this.график_возвратаBindingSource;
            this.график_возвратаDataGridView.Location = new System.Drawing.Point(0, 185);
            this.график_возвратаDataGridView.Name = "график_возвратаDataGridView";
            this.график_возвратаDataGridView.Size = new System.Drawing.Size(444, 94);
            this.график_возвратаDataGridView.TabIndex = 1;
            this.график_возвратаDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.график_возвратаDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_выданного_автомобиля";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_выданного_автомобиля";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Итоговая_цена";
            this.dataGridViewTextBoxColumn2.HeaderText = "Итоговая_цена";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // id_выданного_автомобиляTextBox
            // 
            this.id_выданного_автомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.график_возвратаBindingSource, "id_выданного_автомобиля", true));
            this.id_выданного_автомобиляTextBox.Location = new System.Drawing.Point(155, 42);
            this.id_выданного_автомобиляTextBox.Name = "id_выданного_автомобиляTextBox";
            this.id_выданного_автомобиляTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_выданного_автомобиляTextBox.TabIndex = 3;
            // 
            // итоговая_ценаTextBox
            // 
            this.итоговая_ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.график_возвратаBindingSource, "Итоговая_цена", true));
            this.итоговая_ценаTextBox.Location = new System.Drawing.Point(155, 68);
            this.итоговая_ценаTextBox.Name = "итоговая_ценаTextBox";
            this.итоговая_ценаTextBox.Size = new System.Drawing.Size(200, 20);
            this.итоговая_ценаTextBox.TabIndex = 5;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.график_возвратаBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(155, 94);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 20);
            this.описаниеTextBox.TabIndex = 7;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.график_возвратаBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(155, 120);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаDateTimePicker.TabIndex = 9;
            // 
            // checkBoxFind
            // 
            this.checkBoxFind.AutoSize = true;
            this.checkBoxFind.Location = new System.Drawing.Point(636, 120);
            this.checkBoxFind.Name = "checkBoxFind";
            this.checkBoxFind.Size = new System.Drawing.Size(66, 17);
            this.checkBoxFind.TabIndex = 10;
            this.checkBoxFind.Text = "Фильтр";
            this.checkBoxFind.UseVisualStyleBackColor = true;
            this.checkBoxFind.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Автомобиль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxFind);
            this.Controls.Add(this.id_выданного_автомобиляLabel);
            this.Controls.Add(this.id_выданного_автомобиляTextBox);
            this.Controls.Add(this.итоговая_ценаLabel);
            this.Controls.Add(this.итоговая_ценаTextBox);
            this.Controls.Add(this.описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(this.график_возвратаDataGridView);
            this.Controls.Add(this.график_возвратаBindingNavigator);
            this.Name = "Schedule";
            this.Text = "График возврата";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.график_возвратаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.график_возвратаBindingNavigator)).EndInit();
            this.график_возвратаBindingNavigator.ResumeLayout(false);
            this.график_возвратаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.график_возвратаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private carsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource график_возвратаBindingSource;
        private carsDataSetTableAdapters.График_возвратаTableAdapter график_возвратаTableAdapter;
        private carsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator график_возвратаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton график_возвратаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView график_возвратаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox id_выданного_автомобиляTextBox;
        private System.Windows.Forms.TextBox итоговая_ценаTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.CheckBox checkBoxFind;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id_выданного_автомобиляLabel;
        private System.Windows.Forms.Label итоговая_ценаLabel;
        private System.Windows.Forms.Label описаниеLabel;
        private System.Windows.Forms.Label датаLabel;
    }
}