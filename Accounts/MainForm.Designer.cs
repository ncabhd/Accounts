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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(17, 309);
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
            this.dataGridView1.Location = new System.Drawing.Point(161, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(749, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "序号";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 55;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "日期";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.Width = 65;
            // 
            // ColumnLei
            // 
            this.ColumnLei.HeaderText = "类别";
            this.ColumnLei.Name = "ColumnLei";
            this.ColumnLei.Width = 55;
            // 
            // ColumnMu
            // 
            this.ColumnMu.HeaderText = "收支项目";
            this.ColumnMu.Name = "ColumnMu";
            this.ColumnMu.Width = 80;
            // 
            // ColumnMoney
            // 
            this.ColumnMoney.HeaderText = "金钱";
            this.ColumnMoney.Name = "ColumnMoney";
            this.ColumnMoney.Width = 65;
            // 
            // ColumnBei
            // 
            this.ColumnBei.HeaderText = "备注";
            this.ColumnBei.Name = "ColumnBei";
            this.ColumnBei.Width = 180;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 45);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 62);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "新 增 条 目";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(12, 126);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(143, 61);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "查 找 条 目";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 61);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删 除 条 目";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "当前显示内容统计：收入";
            // 
            // textIncome
            // 
            this.textIncome.Location = new System.Drawing.Point(431, 306);
            this.textIncome.Name = "textIncome";
            this.textIncome.Size = new System.Drawing.Size(90, 25);
            this.textIncome.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "支取";
            // 
            // textConsume
            // 
            this.textConsume.Location = new System.Drawing.Point(570, 306);
            this.textConsume.Name = "textConsume";
            this.textConsume.Size = new System.Drawing.Size(90, 25);
            this.textConsume.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "剩余";
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(709, 306);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(90, 25);
            this.textSum.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 356);
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
            this.Name = "MainForm";
            this.Text = "Accounts";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLei;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBei;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}