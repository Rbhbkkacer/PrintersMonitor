﻿namespace printer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.printersDataSet = new printer.printersDataSet();
            this.printersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printersTableAdapter = new printer.printersDataSetTableAdapters.PrintersTableAdapter();
            this.currentErorrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentErorrsTableAdapter = new printer.printersDataSetTableAdapters.CurrentErorrsTableAdapter();
            this.tableAdapterManager = new printer.printersDataSetTableAdapters.TableAdapterManager();
            this.currentErorrsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentErorrsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentErorrsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // printersDataSet
            // 
            this.printersDataSet.DataSetName = "printersDataSet";
            this.printersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printersBindingSource
            // 
            this.printersBindingSource.DataMember = "Printers";
            this.printersBindingSource.DataSource = this.printersDataSet;
            // 
            // printersTableAdapter
            // 
            this.printersTableAdapter.ClearBeforeFill = true;
            // 
            // currentErorrsBindingSource
            // 
            this.currentErorrsBindingSource.DataMember = "CurrentErorrs";
            this.currentErorrsBindingSource.DataSource = this.printersDataSet;
            // 
            // currentErorrsTableAdapter
            // 
            this.currentErorrsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CurrentErorrsTableAdapter = this.currentErorrsTableAdapter;
            this.tableAdapterManager.ErorrsLogTableAdapter = null;
            this.tableAdapterManager.PrintersTableAdapter = this.printersTableAdapter;
            this.tableAdapterManager.UpdateOrder = printer.printersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // currentErorrsDataGridView
            // 
            this.currentErorrsDataGridView.AutoGenerateColumns = false;
            this.currentErorrsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentErorrsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.currentErorrsDataGridView.DataSource = this.currentErorrsBindingSource;
            this.currentErorrsDataGridView.Location = new System.Drawing.Point(612, 30);
            this.currentErorrsDataGridView.Name = "currentErorrsDataGridView";
            this.currentErorrsDataGridView.Size = new System.Drawing.Size(300, 353);
            this.currentErorrsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "printer_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "printer_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Error";
            this.dataGridViewTextBoxColumn2.HeaderText = "Error";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // printersDataGridView
            // 
            this.printersDataGridView.AutoGenerateColumns = false;
            this.printersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.printersDataGridView.DataSource = this.printersBindingSource;
            this.printersDataGridView.Location = new System.Drawing.Point(16, 30);
            this.printersDataGridView.Name = "printersDataGridView";
            this.printersDataGridView.Size = new System.Drawing.Size(590, 353);
            this.printersDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "invnom";
            this.dataGridViewTextBoxColumn4.HeaderText = "invnom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mark_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "mark_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "coment";
            this.dataGridViewTextBoxColumn6.HeaderText = "coment";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ip";
            this.dataGridViewTextBoxColumn7.HeaderText = "ip";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 432);
            this.Controls.Add(this.printersDataGridView);
            this.Controls.Add(this.currentErorrsDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentErorrsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentErorrsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private printersDataSet printersDataSet;
        private System.Windows.Forms.BindingSource printersBindingSource;
        private printersDataSetTableAdapters.PrintersTableAdapter printersTableAdapter;
        private System.Windows.Forms.BindingSource currentErorrsBindingSource;
        private printersDataSetTableAdapters.CurrentErorrsTableAdapter currentErorrsTableAdapter;
        private printersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView currentErorrsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView printersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

