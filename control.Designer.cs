namespace WindowsFormsApp1
{
    partial class control
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
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.gaiDataSet = new WindowsFormsApp1.gaiDataSet();
            this.заявкаTableAdapter = new WindowsFormsApp1.gaiDataSetTableAdapters.ЗаявкаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "ЗАЯВЛЕНИЯ";
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
            this.button5.TabIndex = 12;
            this.button5.Text = "НАЗАД";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.заявкаBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.dataGridView1.Location = new System.Drawing.Point(41, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 323);
            this.dataGridView1.TabIndex = 13;
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
            // gaiDataSet
            // 
            this.gaiDataSet.DataSetName = "gaiDataSet";
            this.gaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявкаTableAdapter
            // 
            this.заявкаTableAdapter.ClearBeforeFill = true;
            // 
            // control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Name = "control";
            this.Text = "Просмотр заявлений";
            this.Load += new System.EventHandler(this.control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gaiDataSet gaiDataSet;
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