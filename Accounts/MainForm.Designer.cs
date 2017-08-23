namespace Accounts
{
    partial class MainForm
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
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textConsume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDaySum = new System.Windows.Forms.TextBox();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 309);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(79, 15);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "labelTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnDate,
            this.ColumnLei,
            this.ColumnMu,
            this.ColumnMoney,
            this.ColumnBei,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(182, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(713, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "序号";
            this.ColumnID.MinimumWidth = 10;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 75;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "日期";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 85;
            // 
            // ColumnLei
            // 
            this.ColumnLei.HeaderText = "类别";
            this.ColumnLei.Name = "ColumnLei";
            this.ColumnLei.ReadOnly = true;
            this.ColumnLei.Width = 75;
            // 
            // ColumnMu
            // 
            this.ColumnMu.HeaderText = "收支项目";
            this.ColumnMu.Name = "ColumnMu";
            this.ColumnMu.ReadOnly = true;
            // 
            // ColumnMoney
            // 
            this.ColumnMoney.HeaderText = "金钱";
            this.ColumnMoney.Name = "ColumnMoney";
            this.ColumnMoney.ReadOnly = true;
            this.ColumnMoney.Width = 85;
            // 
            // ColumnBei
            // 
            this.ColumnBei.HeaderText = "备注";
            this.ColumnBei.Name = "ColumnBei";
            this.ColumnBei.ReadOnly = true;
            this.ColumnBei.Width = 250;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(20, 41);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 38);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "新 增 条 目";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(20, 85);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(143, 38);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "查 找 条 目";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 38);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删 除 条 目";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "当前显示内容统计：收入";
            // 
            // textIncome
            // 
            this.textIncome.Location = new System.Drawing.Point(371, 306);
            this.textIncome.Name = "textIncome";
            this.textIncome.Size = new System.Drawing.Size(90, 25);
            this.textIncome.TabIndex = 7;
            this.textIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIncome_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "支取";
            // 
            // textConsume
            // 
            this.textConsume.Location = new System.Drawing.Point(510, 306);
            this.textConsume.Name = "textConsume";
            this.textConsume.Size = new System.Drawing.Size(90, 25);
            this.textConsume.TabIndex = 9;
            this.textConsume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textConsume_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "剩余";
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(649, 306);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(90, 25);
            this.textSum.TabIndex = 11;
            this.textSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "昨日花费";
            // 
            // textDaySum
            // 
            this.textDaySum.Location = new System.Drawing.Point(818, 306);
            this.textDaySum.Name = "textDaySum";
            this.textDaySum.Size = new System.Drawing.Size(100, 25);
            this.textDaySum.TabIndex = 13;
            this.textDaySum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(49, 261);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(84, 29);
            this.btnEmpty.TabIndex = 14;
            this.btnEmpty.Text = "回收账号";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(20, 129);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(143, 38);
            this.btnDay.TabIndex = 15;
            this.btnDay.Text = "查 询 某 日";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(20, 173);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(143, 38);
            this.btnMonth.TabIndex = 16;
            this.btnMonth.Text = "查 询 某 月";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 356);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.textDaySum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textConsume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "主目录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClose);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textConsume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDaySum;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLei;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBei;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnMonth;
    }
}