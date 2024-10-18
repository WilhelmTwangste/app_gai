namespace WindowsFormsApp1
{
    partial class izmen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.заявкаTableAdapter = new WindowsFormsApp1.gaiDataSetTableAdapters.ЗаявкаTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaiDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 100);
            this.dataGridView1.TabIndex = 18;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 149);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "ПРИМЕЧАНИЕ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button1.Location = new System.Drawing.Point(30, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "ВВОД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "НОМЕР ЗАЯВЛЕНИЯ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(13, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 13);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(14, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 13);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(53, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ПРИМЕЧАНИЕ";
            // 
            // заявкаTableAdapter
            // 
            this.заявкаTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(195, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 149);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(11, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "НОМЕР СТАТУСА";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button2.Location = new System.Drawing.Point(30, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "ВВОД";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(9, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "НОМЕР ЗАЯВЛЕНИЯ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(13, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 13);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(14, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 13);
            this.textBox4.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(249, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "СТАТУС";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Location = new System.Drawing.Point(107, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 106);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button3.Location = new System.Drawing.Point(37, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "УДАЛИТЬ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(9, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "НОМЕР ЗАЯВЛЕНИЯ";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(14, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 13);
            this.textBox6.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(150, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "УДАЛЕНИЕ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Location = new System.Drawing.Point(510, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 106);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button4.Location = new System.Drawing.Point(33, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "ПОИСК";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "НОМЕР ЗАЯВЛЕНИЯ";
            this.label4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(14, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 13);
            this.textBox5.TabIndex = 9;
            this.textBox5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(558, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "ПОИСК";
            this.label8.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Location = new System.Drawing.Point(419, 150);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 149);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label11.Location = new System.Drawing.Point(11, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "НОМЕР ТЕЛЕФОНА";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button5.Location = new System.Drawing.Point(35, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "ИЗМЕНИТЬ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(9, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "НОМЕР ЗАЯВЛЕНИЯ";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(13, 79);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(140, 13);
            this.textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(14, 37);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(140, 13);
            this.textBox8.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(437, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "НОМЕР ТЕЛЕФОНА";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.textBox9);
            this.groupBox6.Controls.Add(this.textBox10);
            this.groupBox6.Location = new System.Drawing.Point(603, 150);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(171, 149);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(11, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "ФИО";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button6.Location = new System.Drawing.Point(35, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 26);
            this.button6.TabIndex = 11;
            this.button6.Text = "ИЗМЕНИТЬ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label15.Location = new System.Drawing.Point(9, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "НОМЕР ЗАЯВЛЕНИЯ";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(13, 79);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(140, 13);
            this.textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(14, 37);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(140, 13);
            this.textBox10.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label16.Location = new System.Drawing.Point(621, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "ИМЯ ЗАЯВИТЕЛЯ";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(174)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 9F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button7.Location = new System.Drawing.Point(706, 416);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 27);
            this.button7.TabIndex = 27;
            this.button7.Text = "НАЗАД";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // izmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "izmen";
            this.Text = "Изменение";
            this.Load += new System.EventHandler(this.izmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaiDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button7;
    }
}