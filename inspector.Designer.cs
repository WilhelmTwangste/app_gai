namespace WindowsFormsApp1
{
    partial class inspector
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.инспекторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gaiDataSet = new WindowsFormsApp1.gaiDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.инспекторTableAdapter = new WindowsFormsApp1.gaiDataSetTableAdapters.ИнспекторTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.gaiDataSet1 = new WindowsFormsApp1.gaiDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаподачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типТСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаавтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельавтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINкодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОзаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусзаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDИнспектораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заявкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDИнспектораDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заявкаTableAdapter = new WindowsFormsApp1.gaiDataSetTableAdapters.ЗаявкаTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.инспекторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaiDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(51, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "НАЗНАЧИТЬ ИНСПЕКТОРА";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(26, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 306);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button1.Location = new System.Drawing.Point(80, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ВВОД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "НОМЕР ЗАЯВЛЕНИЯ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(14, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 13);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "НОМЕР ИНСПЕКТОРА";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(14, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 13);
            this.textBox1.TabIndex = 9;
            // 
            // инспекторBindingSource
            // 
            this.инспекторBindingSource.DataMember = "Инспектор";
            this.инспекторBindingSource.DataSource = this.gaiDataSet;
            // 
            // gaiDataSet
            // 
            this.gaiDataSet.DataSetName = "gaiDataSet";
            this.gaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(444, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "СУЩЕСТВУЮЩИЕ ИНСПЕКТОРЫ";
            // 
            // инспекторTableAdapter
            // 
            this.инспекторTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button5.Location = new System.Drawing.Point(706, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 27);
            this.button5.TabIndex = 16;
            this.button5.Text = "НАЗАД";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gaiDataSet1
            // 
            this.gaiDataSet1.DataSetName = "gaiDataSet";
            this.gaiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(407, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 312);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " ЗАЯВЛЕНИЯ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗаявкиDataGridViewTextBoxColumn,
            this.датаподачиDataGridViewTextBoxColumn,
            this.типТСDataGridViewTextBoxColumn,
            this.маркаавтоDataGridViewTextBoxColumn,
            this.модельавтоDataGridViewTextBoxColumn,
            this.vINкодDataGridViewTextBoxColumn,
            this.фИОзаявителяDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn,
            this.статусзаявкиDataGridViewTextBoxColumn,
            this.iDИнспектораDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.заявкаBindingSource;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.dataGridView2.Location = new System.Drawing.Point(3, 9);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(321, 264);
            this.dataGridView2.TabIndex = 31;
            // 
            // iDЗаявкиDataGridViewTextBoxColumn
            // 
            this.iDЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "ID_Заявки";
            this.iDЗаявкиDataGridViewTextBoxColumn.HeaderText = "ID_Заявки";
            this.iDЗаявкиDataGridViewTextBoxColumn.Name = "iDЗаявкиDataGridViewTextBoxColumn";
            // 
            // датаподачиDataGridViewTextBoxColumn
            // 
            this.датаподачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_подачи";
            this.датаподачиDataGridViewTextBoxColumn.HeaderText = "Дата_подачи";
            this.датаподачиDataGridViewTextBoxColumn.Name = "датаподачиDataGridViewTextBoxColumn";
            // 
            // типТСDataGridViewTextBoxColumn
            // 
            this.типТСDataGridViewTextBoxColumn.DataPropertyName = "Тип_ТС";
            this.типТСDataGridViewTextBoxColumn.HeaderText = "Тип_ТС";
            this.типТСDataGridViewTextBoxColumn.Name = "типТСDataGridViewTextBoxColumn";
            // 
            // маркаавтоDataGridViewTextBoxColumn
            // 
            this.маркаавтоDataGridViewTextBoxColumn.DataPropertyName = "Марка_авто";
            this.маркаавтоDataGridViewTextBoxColumn.HeaderText = "Марка_авто";
            this.маркаавтоDataGridViewTextBoxColumn.Name = "маркаавтоDataGridViewTextBoxColumn";
            // 
            // модельавтоDataGridViewTextBoxColumn
            // 
            this.модельавтоDataGridViewTextBoxColumn.DataPropertyName = "Модель_авто";
            this.модельавтоDataGridViewTextBoxColumn.HeaderText = "Модель_авто";
            this.модельавтоDataGridViewTextBoxColumn.Name = "модельавтоDataGridViewTextBoxColumn";
            // 
            // vINкодDataGridViewTextBoxColumn
            // 
            this.vINкодDataGridViewTextBoxColumn.DataPropertyName = "VIN_код";
            this.vINкодDataGridViewTextBoxColumn.HeaderText = "VIN_код";
            this.vINкодDataGridViewTextBoxColumn.Name = "vINкодDataGridViewTextBoxColumn";
            // 
            // фИОзаявителяDataGridViewTextBoxColumn
            // 
            this.фИОзаявителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО_заявителя";
            this.фИОзаявителяDataGridViewTextBoxColumn.HeaderText = "ФИО_заявителя";
            this.фИОзаявителяDataGridViewTextBoxColumn.Name = "фИОзаявителяDataGridViewTextBoxColumn";
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            // 
            // статусзаявкиDataGridViewTextBoxColumn
            // 
            this.статусзаявкиDataGridViewTextBoxColumn.DataPropertyName = "Статус_заявки";
            this.статусзаявкиDataGridViewTextBoxColumn.HeaderText = "Статус_заявки";
            this.статусзаявкиDataGridViewTextBoxColumn.Name = "статусзаявкиDataGridViewTextBoxColumn";
            // 
            // iDИнспектораDataGridViewTextBoxColumn
            // 
            this.iDИнспектораDataGridViewTextBoxColumn.DataPropertyName = "ID_Инспектора";
            this.iDИнспектораDataGridViewTextBoxColumn.HeaderText = "ID_Инспектора";
            this.iDИнспектораDataGridViewTextBoxColumn.Name = "iDИнспектораDataGridViewTextBoxColumn";
            // 
            // примечаниеDataGridViewTextBoxColumn
            // 
            this.примечаниеDataGridViewTextBoxColumn.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.Name = "примечаниеDataGridViewTextBoxColumn";
            // 
            // заявкаBindingSource
            // 
            this.заявкаBindingSource.DataMember = "Заявка";
            this.заявкаBindingSource.DataSource = this.gaiDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(345, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ИНСПЕКТОРЫ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDИнспектораDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.номертелефонаDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.инспекторBindingSource;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(321, 264);
            this.dataGridView3.TabIndex = 32;
            // 
            // iDИнспектораDataGridViewTextBoxColumn1
            // 
            this.iDИнспектораDataGridViewTextBoxColumn1.DataPropertyName = "ID_Инспектора";
            this.iDИнспектораDataGridViewTextBoxColumn1.HeaderText = "ID_Инспектора";
            this.iDИнспектораDataGridViewTextBoxColumn1.Name = "iDИнспектораDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО_инспектора";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО_инспектора";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // номертелефонаDataGridViewTextBoxColumn1
            // 
            this.номертелефонаDataGridViewTextBoxColumn1.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn1.HeaderText = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn1.Name = "номертелефонаDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn2.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // заявкаTableAdapter
            // 
            this.заявкаTableAdapter.ClearBeforeFill = true;
            // 
            // inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "inspector";
            this.Text = "Назначение инспектора";
            this.Load += new System.EventHandler(this.inspector_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.инспекторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaiDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private gaiDataSet gaiDataSet;
        private System.Windows.Forms.BindingSource инспекторBindingSource;
        private gaiDataSetTableAdapters.ИнспекторTableAdapter инспекторTableAdapter;
        private System.Windows.Forms.Button button5;
        private gaiDataSet gaiDataSet1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИнспектораDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource заявкаBindingSource;
        private gaiDataSetTableAdapters.ЗаявкаTableAdapter заявкаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаподачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типТСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаавтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельавтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINкодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОзаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусзаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDИнспектораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
    }
}