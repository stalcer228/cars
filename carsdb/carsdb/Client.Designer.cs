namespace carsdb
{
    partial class Client
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label водительские_праваLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label паспортLabel;
            this.carsDataSet = new carsdb.carsDataSet();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new carsdb.carsDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new carsdb.carsDataSetTableAdapters.TableAdapterManager();
            this.id_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.водительские_праваTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.паспортTextBox = new System.Windows.Forms.TextBox();
            id_клиентаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            водительские_праваLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            паспортLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "carsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.carsDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = carsdb.carsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.АрендодательTableAdapter = null;
            this.tableAdapterManager.Выдача_автомобилейTableAdapter = null;
            this.tableAdapterManager.График_возвратаTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            // 
            // id_клиентаLabel
            // 
            id_клиентаLabel.AutoSize = true;
            id_клиентаLabel.Location = new System.Drawing.Point(7, 15);
            id_клиентаLabel.Name = "id_клиентаLabel";
            id_клиентаLabel.Size = new System.Drawing.Size(62, 13);
            id_клиентаLabel.TabIndex = 0;
            id_клиентаLabel.Text = "id клиента:";
            // 
            // id_клиентаTextBox
            // 
            this.id_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "id_клиента", true));
            this.id_клиентаTextBox.Location = new System.Drawing.Point(128, 12);
            this.id_клиентаTextBox.Name = "id_клиентаTextBox";
            this.id_клиентаTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_клиентаTextBox.TabIndex = 1;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(7, 41);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 2;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(128, 38);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(100, 20);
            this.фамилияTextBox.TabIndex = 3;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(7, 67);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 4;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(128, 64);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 20);
            this.имяTextBox.TabIndex = 5;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(7, 93);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 6;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(128, 90);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(100, 20);
            this.отчествоTextBox.TabIndex = 7;
            // 
            // водительские_праваLabel
            // 
            водительские_праваLabel.AutoSize = true;
            водительские_праваLabel.Location = new System.Drawing.Point(7, 119);
            водительские_праваLabel.Name = "водительские_праваLabel";
            водительские_праваLabel.Size = new System.Drawing.Size(115, 13);
            водительские_праваLabel.TabIndex = 8;
            водительские_праваLabel.Text = "Водительские права:";
            // 
            // водительские_праваTextBox
            // 
            this.водительские_праваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Водительские_права", true));
            this.водительские_праваTextBox.Location = new System.Drawing.Point(128, 116);
            this.водительские_праваTextBox.Name = "водительские_праваTextBox";
            this.водительские_праваTextBox.Size = new System.Drawing.Size(100, 20);
            this.водительские_праваTextBox.TabIndex = 9;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(7, 145);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 10;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(128, 142);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.адресTextBox.TabIndex = 11;
            // 
            // паспортLabel
            // 
            паспортLabel.AutoSize = true;
            паспортLabel.Location = new System.Drawing.Point(7, 171);
            паспортLabel.Name = "паспортLabel";
            паспортLabel.Size = new System.Drawing.Size(53, 13);
            паспортLabel.TabIndex = 12;
            паспортLabel.Text = "Паспорт:";
            // 
            // паспортTextBox
            // 
            this.паспортTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Паспорт", true));
            this.паспортTextBox.Location = new System.Drawing.Point(128, 168);
            this.паспортTextBox.Name = "паспортTextBox";
            this.паспортTextBox.Size = new System.Drawing.Size(100, 20);
            this.паспортTextBox.TabIndex = 13;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 210);
            this.Controls.Add(id_клиентаLabel);
            this.Controls.Add(this.id_клиентаTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(водительские_праваLabel);
            this.Controls.Add(this.водительские_праваTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(паспортLabel);
            this.Controls.Add(this.паспортTextBox);
            this.Name = "Client";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private carsDataSet carsDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private carsDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private carsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_клиентаTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox водительские_праваTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox паспортTextBox;
    }
}