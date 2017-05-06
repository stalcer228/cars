namespace carsdb
{
    partial class FormCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCar));
            System.Windows.Forms.Label id_автомобиляLabel;
            System.Windows.Forms.Label маркаLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label описаниеLabel;
            this.carsDataSet = new carsdb.carsDataSet();
            this.автомобильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобильTableAdapter = new carsdb.carsDataSetTableAdapters.АвтомобильTableAdapter();
            this.tableAdapterManager = new carsdb.carsDataSetTableAdapters.TableAdapterManager();
            this.автомобильBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.автомобильBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_автомобиляTextBox = new System.Windows.Forms.TextBox();
            this.маркаTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            id_автомобиляLabel = new System.Windows.Forms.Label();
            маркаLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingNavigator)).BeginInit();
            this.автомобильBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "carsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобильBindingSource
            // 
            this.автомобильBindingSource.DataMember = "Автомобиль";
            this.автомобильBindingSource.DataSource = this.carsDataSet;
            // 
            // автомобильTableAdapter
            // 
            this.автомобильTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = carsdb.carsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = this.автомобильTableAdapter;
            this.tableAdapterManager.АрендодательTableAdapter = null;
            this.tableAdapterManager.Выдача_автомобилейTableAdapter = null;
            this.tableAdapterManager.График_возвратаTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            // 
            // автомобильBindingNavigator
            // 
            this.автомобильBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.автомобильBindingNavigator.BindingSource = this.автомобильBindingSource;
            this.автомобильBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.автомобильBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.автомобильBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.автомобильBindingNavigatorSaveItem});
            this.автомобильBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.автомобильBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.автомобильBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.автомобильBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.автомобильBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.автомобильBindingNavigator.Name = "автомобильBindingNavigator";
            this.автомобильBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.автомобильBindingNavigator.Size = new System.Drawing.Size(558, 25);
            this.автомобильBindingNavigator.TabIndex = 0;
            this.автомобильBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // автомобильBindingNavigatorSaveItem
            // 
            this.автомобильBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.автомобильBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("автомобильBindingNavigatorSaveItem.Image")));
            this.автомобильBindingNavigatorSaveItem.Name = "автомобильBindingNavigatorSaveItem";
            this.автомобильBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.автомобильBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.автомобильBindingNavigatorSaveItem.Click += new System.EventHandler(this.автомобильBindingNavigatorSaveItem_Click);
            // 
            // id_автомобиляLabel
            // 
            id_автомобиляLabel.AutoSize = true;
            id_автомобиляLabel.Location = new System.Drawing.Point(12, 35);
            id_автомобиляLabel.Name = "id_автомобиляLabel";
            id_автомобиляLabel.Size = new System.Drawing.Size(82, 13);
            id_автомобиляLabel.TabIndex = 1;
            id_автомобиляLabel.Text = "id автомобиля:";
            // 
            // id_автомобиляTextBox
            // 
            this.id_автомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "id_автомобиля", true));
            this.id_автомобиляTextBox.Location = new System.Drawing.Point(100, 32);
            this.id_автомобиляTextBox.Name = "id_автомобиляTextBox";
            this.id_автомобиляTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_автомобиляTextBox.TabIndex = 2;
            // 
            // маркаLabel
            // 
            маркаLabel.AutoSize = true;
            маркаLabel.Location = new System.Drawing.Point(12, 61);
            маркаLabel.Name = "маркаLabel";
            маркаLabel.Size = new System.Drawing.Size(43, 13);
            маркаLabel.TabIndex = 3;
            маркаLabel.Text = "Марка:";
            // 
            // маркаTextBox
            // 
            this.маркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "Марка", true));
            this.маркаTextBox.Location = new System.Drawing.Point(100, 58);
            this.маркаTextBox.Name = "маркаTextBox";
            this.маркаTextBox.Size = new System.Drawing.Size(100, 20);
            this.маркаTextBox.TabIndex = 4;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(12, 87);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 5;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "Цена", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.ценаTextBox.Location = new System.Drawing.Point(100, 84);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ценаTextBox.TabIndex = 6;
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(12, 113);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(60, 13);
            описаниеLabel.TabIndex = 7;
            описаниеLabel.Text = "Описание:";
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(100, 110);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(100, 20);
            this.описаниеTextBox.TabIndex = 8;
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 335);
            this.Controls.Add(id_автомобиляLabel);
            this.Controls.Add(this.id_автомобиляTextBox);
            this.Controls.Add(маркаLabel);
            this.Controls.Add(this.маркаTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.автомобильBindingNavigator);
            this.Name = "FormCar";
            this.Text = "Автомобиль";
            this.Load += new System.EventHandler(this.FormCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingNavigator)).EndInit();
            this.автомобильBindingNavigator.ResumeLayout(false);
            this.автомобильBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private carsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource автомобильBindingSource;
        private carsDataSetTableAdapters.АвтомобильTableAdapter автомобильTableAdapter;
        private carsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator автомобильBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton автомобильBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_автомобиляTextBox;
        private System.Windows.Forms.TextBox маркаTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
    }
}