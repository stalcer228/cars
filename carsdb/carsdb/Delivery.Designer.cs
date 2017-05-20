namespace carsdb
{
    partial class Delivery
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
            System.Windows.Forms.Label id_клиентаLabel;
            System.Windows.Forms.Label id_арендодателяLabel;
            System.Windows.Forms.Label id_выданного_автомобиляLabel;
            System.Windows.Forms.Label id_автомобиляLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label датаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.carsDataSet = new carsdb.carsDataSet();
            this.выдача_автомобилейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выдача_автомобилейTableAdapter = new carsdb.carsDataSetTableAdapters.Выдача_автомобилейTableAdapter();
            this.tableAdapterManager = new carsdb.carsDataSetTableAdapters.TableAdapterManager();
            this.выдача_автомобилейBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.выдача_автомобилейBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.выдача_автомобилейDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.id_арендодателяTextBox = new System.Windows.Forms.TextBox();
            this.id_выданного_автомобиляTextBox = new System.Windows.Forms.TextBox();
            this.id_автомобиляTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            id_клиентаLabel = new System.Windows.Forms.Label();
            id_арендодателяLabel = new System.Windows.Forms.Label();
            id_выданного_автомобиляLabel = new System.Windows.Forms.Label();
            id_автомобиляLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_автомобилейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_автомобилейBindingNavigator)).BeginInit();
            this.выдача_автомобилейBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_автомобилейDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_клиентаLabel
            // 
            id_клиентаLabel.AutoSize = true;
            id_клиентаLabel.Location = new System.Drawing.Point(8, 47);
            id_клиентаLabel.Name = "id_клиентаLabel";
            id_клиентаLabel.Size = new System.Drawing.Size(62, 13);
            id_клиентаLabel.TabIndex = 2;
            id_клиентаLabel.Text = "id клиента:";
            // 
            // id_арендодателяLabel
            // 
            id_арендодателяLabel.AutoSize = true;
            id_арендодателяLabel.Location = new System.Drawing.Point(8, 73);
            id_арендодателяLabel.Name = "id_арендодателяLabel";
            id_арендодателяLabel.Size = new System.Drawing.Size(92, 13);
            id_арендодателяLabel.TabIndex = 4;
            id_арендодателяLabel.Text = "id арендодателя:";
            // 
            // id_выданного_автомобиляLabel
            // 
            id_выданного_автомобиляLabel.AutoSize = true;
            id_выданного_автомобиляLabel.Location = new System.Drawing.Point(8, 99);
            id_выданного_автомобиляLabel.Name = "id_выданного_автомобиляLabel";
            id_выданного_автомобиляLabel.Size = new System.Drawing.Size(140, 13);
            id_выданного_автомобиляLabel.TabIndex = 6;
            id_выданного_автомобиляLabel.Text = "id выданного автомобиля:";
            // 
            // id_автомобиляLabel
            // 
            id_автомобиляLabel.AutoSize = true;
            id_автомобиляLabel.Location = new System.Drawing.Point(8, 125);
            id_автомобиляLabel.Name = "id_автомобиляLabel";
            id_автомобиляLabel.Size = new System.Drawing.Size(82, 13);
            id_автомобиляLabel.TabIndex = 8;
            id_автомобиляLabel.Text = "id автомобиля:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(8, 151);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(60, 13);
            описаниеLabel.TabIndex = 10;
            описаниеLabel.Text = "Описание:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(8, 178);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(36, 13);
            датаLabel.TabIndex = 12;
            датаLabel.Text = "Дата:";
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "carsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выдача_автомобилейBindingSource
            // 
            this.выдача_автомобилейBindingSource.DataMember = "Выдача автомобилей";
            this.выдача_автомобилейBindingSource.DataSource = this.carsDataSet;
            // 
            // выдача_автомобилейTableAdapter
            // 
            this.выдача_автомобилейTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = carsdb.carsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.АрендодательTableAdapter = null;
            this.tableAdapterManager.Выдача_автомобилейTableAdapter = this.выдача_автомобилейTableAdapter;
            this.tableAdapterManager.График_возвратаTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            // 
            // выдача_автомобилейBindingNavigator
            // 
            this.выдача_автомобилейBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.выдача_автомобилейBindingNavigator.BindingSource = this.выдача_автомобилейBindingSource;
            this.выдача_автомобилейBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.выдача_автомобилейBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.выдача_автомобилейBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.выдача_автомобилейBindingNavigatorSaveItem});
            this.выдача_автомобилейBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.выдача_автомобилейBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.выдача_автомобилейBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.выдача_автомобилейBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.выдача_автомобилейBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.выдача_автомобилейBindingNavigator.Name = "выдача_автомобилейBindingNavigator";
            this.выдача_автомобилейBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.выдача_автомобилейBindingNavigator.Size = new System.Drawing.Size(734, 25);
            this.выдача_автомобилейBindingNavigator.TabIndex = 0;
            this.выдача_автомобилейBindingNavigator.Text = "bindingNavigator1";
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
            // выдача_автомобилейBindingNavigatorSaveItem
            // 
            this.выдача_автомобилейBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выдача_автомобилейBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("выдача_автомобилейBindingNavigatorSaveItem.Image")));
            this.выдача_автомобилейBindingNavigatorSaveItem.Name = "выдача_автомобилейBindingNavigatorSaveItem";
            this.выдача_автомобилейBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.выдача_автомобилейBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.выдача_автомобилейBindingNavigatorSaveItem.Click += new System.EventHandler(this.выдача_автомобилейBindingNavigatorSaveItem_Click);
            // 
            // выдача_автомобилейDataGridView
            // 
            this.выдача_автомобилейDataGridView.AutoGenerateColumns = false;
            this.выдача_автомобилейDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выдача_автомобилейDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.выдача_автомобилейDataGridView.DataSource = this.выдача_автомобилейBindingSource;
            this.выдача_автомобилейDataGridView.Location = new System.Drawing.Point(0, 284);
            this.выдача_автомобилейDataGridView.Name = "выдача_автомобилейDataGridView";
            this.выдача_автомобилейDataGridView.Size = new System.Drawing.Size(644, 108);
            this.выдача_автомобилейDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_клиента";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_арендодателя";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_арендодателя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_выданного_автомобиля";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_выданного_автомобиля";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_автомобиля";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_автомобиля";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // id_клиентаTextBox
            // 
            this.id_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдача_автомобилейBindingSource, "id_клиента", true));
            this.id_клиентаTextBox.Location = new System.Drawing.Point(154, 44);
            this.id_клиентаTextBox.Name = "id_клиентаTextBox";
            this.id_клиентаTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_клиентаTextBox.TabIndex = 3;
            // 
            // id_арендодателяTextBox
            // 
            this.id_арендодателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдача_автомобилейBindingSource, "id_арендодателя", true));
            this.id_арендодателяTextBox.Location = new System.Drawing.Point(154, 70);
            this.id_арендодателяTextBox.Name = "id_арендодателяTextBox";
            this.id_арендодателяTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_арендодателяTextBox.TabIndex = 5;
            // 
            // id_выданного_автомобиляTextBox
            // 
            this.id_выданного_автомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдача_автомобилейBindingSource, "id_выданного_автомобиля", true));
            this.id_выданного_автомобиляTextBox.Location = new System.Drawing.Point(154, 96);
            this.id_выданного_автомобиляTextBox.Name = "id_выданного_автомобиляTextBox";
            this.id_выданного_автомобиляTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_выданного_автомобиляTextBox.TabIndex = 7;
            // 
            // id_автомобиляTextBox
            // 
            this.id_автомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдача_автомобилейBindingSource, "id_автомобиля", true));
            this.id_автомобиляTextBox.Location = new System.Drawing.Point(154, 122);
            this.id_автомобиляTextBox.Name = "id_автомобиляTextBox";
            this.id_автомобиляTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_автомобиляTextBox.TabIndex = 9;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдача_автомобилейBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(154, 148);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 20);
            this.описаниеTextBox.TabIndex = 11;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выдача_автомобилейBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(154, 174);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаDateTimePicker.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Клиент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Арендодатель";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Автомобиль";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 419);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_клиентаLabel);
            this.Controls.Add(this.id_клиентаTextBox);
            this.Controls.Add(id_арендодателяLabel);
            this.Controls.Add(this.id_арендодателяTextBox);
            this.Controls.Add(id_выданного_автомобиляLabel);
            this.Controls.Add(this.id_выданного_автомобиляTextBox);
            this.Controls.Add(id_автомобиляLabel);
            this.Controls.Add(this.id_автомобиляTextBox);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(this.выдача_автомобилейDataGridView);
            this.Controls.Add(this.выдача_автомобилейBindingNavigator);
            this.Name = "Delivery";
            this.Text = "Выдача";
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_автомобилейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_автомобилейBindingNavigator)).EndInit();
            this.выдача_автомобилейBindingNavigator.ResumeLayout(false);
            this.выдача_автомобилейBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_автомобилейDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private carsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource выдача_автомобилейBindingSource;
        private carsDataSetTableAdapters.Выдача_автомобилейTableAdapter выдача_автомобилейTableAdapter;
        private carsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator выдача_автомобилейBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton выдача_автомобилейBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView выдача_автомобилейDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox id_клиентаTextBox;
        private System.Windows.Forms.TextBox id_арендодателяTextBox;
        private System.Windows.Forms.TextBox id_выданного_автомобиляTextBox;
        private System.Windows.Forms.TextBox id_автомобиляTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}