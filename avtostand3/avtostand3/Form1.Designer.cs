﻿namespace avtostand3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодстоянкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествомашинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиестоянокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.допустимоеколичествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.платаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.автостоянкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtostandDataSet = new avtostand3.avtostandDataSet();
            this.автостоянкаTableAdapter = new avtostand3.avtostandDataSetTableAdapters.автостоянкаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtostandDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодстоянкиDataGridViewTextBoxColumn,
            this.количествомашинDataGridViewTextBoxColumn,
            this.названиестоянокDataGridViewTextBoxColumn,
            this.допустимоеколичествоDataGridViewTextBoxColumn,
            this.платаDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.автостоянкаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(657, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодстоянкиDataGridViewTextBoxColumn
            // 
            this.кодстоянкиDataGridViewTextBoxColumn.DataPropertyName = "Кодстоянки";
            this.кодстоянкиDataGridViewTextBoxColumn.HeaderText = "Кодстоянки";
            this.кодстоянкиDataGridViewTextBoxColumn.Name = "кодстоянкиDataGridViewTextBoxColumn";
            this.кодстоянкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествомашинDataGridViewTextBoxColumn
            // 
            this.количествомашинDataGridViewTextBoxColumn.DataPropertyName = "количество_машин";
            this.количествомашинDataGridViewTextBoxColumn.HeaderText = "количество_машин";
            this.количествомашинDataGridViewTextBoxColumn.Name = "количествомашинDataGridViewTextBoxColumn";
            this.количествомашинDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиестоянокDataGridViewTextBoxColumn
            // 
            this.названиестоянокDataGridViewTextBoxColumn.DataPropertyName = "название_стоянок";
            this.названиестоянокDataGridViewTextBoxColumn.HeaderText = "название_стоянок";
            this.названиестоянокDataGridViewTextBoxColumn.Name = "названиестоянокDataGridViewTextBoxColumn";
            this.названиестоянокDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // допустимоеколичествоDataGridViewTextBoxColumn
            // 
            this.допустимоеколичествоDataGridViewTextBoxColumn.DataPropertyName = "допустимое_количество";
            this.допустимоеколичествоDataGridViewTextBoxColumn.HeaderText = "допустимое_количество";
            this.допустимоеколичествоDataGridViewTextBoxColumn.Name = "допустимоеколичествоDataGridViewTextBoxColumn";
            this.допустимоеколичествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // платаDataGridViewTextBoxColumn
            // 
            this.платаDataGridViewTextBoxColumn.DataPropertyName = "плата";
            this.платаDataGridViewTextBoxColumn.HeaderText = "плата";
            this.платаDataGridViewTextBoxColumn.Name = "платаDataGridViewTextBoxColumn";
            this.платаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "город";
            this.городDataGridViewTextBoxColumn.HeaderText = "город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            this.городDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // автостоянкаBindingSource
            // 
            this.автостоянкаBindingSource.DataMember = "автостоянка";
            this.автостоянкаBindingSource.DataSource = this.avtostandDataSet;
            // 
            // avtostandDataSet
            // 
            this.avtostandDataSet.DataSetName = "avtostandDataSet";
            this.avtostandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автостоянкаTableAdapter
            // 
            this.автостоянкаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(693, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(693, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "ВЫХОД";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автостоянкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtostandDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private avtostandDataSet avtostandDataSet;
        private System.Windows.Forms.BindingSource автостоянкаBindingSource;
        private avtostandDataSetTableAdapters.автостоянкаTableAdapter автостоянкаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодстоянкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествомашинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиестоянокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn допустимоеколичествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn платаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

