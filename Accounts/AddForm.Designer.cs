namespace Accounts
{
    partial class AddForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxLei = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDateYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDateMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(70, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxLei
            // 
            this.comboBoxLei.FormattingEnabled = true;
            this.comboBoxLei.Location = new System.Drawing.Point(95, 73);
            this.comboBoxLei.Name = "comboBoxLei";
            this.comboBoxLei.Size = new System.Drawing.Size(83, 23);
            this.comboBoxLei.TabIndex = 2;
            this.comboBoxLei.SelectedIndexChanged += new System.EventHandler(this.comboBoxLei_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "类别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "收支项目";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(257, 73);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(101, 23);
            this.comboBoxItem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "收支时间";
            // 
            // comboBoxDateYear
            // 
            this.comboBoxDateYear.FormattingEnabled = true;
            this.comboBoxDateYear.Location = new System.Drawing.Point(95, 21);
            this.comboBoxDateYear.Name = "comboBoxDateYear";
            this.comboBoxDateYear.Size = new System.Drawing.Size(83, 23);
            this.comboBoxDateYear.TabIndex = 7;
            this.comboBoxDateYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxDateYear_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "年";
            // 
            // comboBoxDateMonth
            // 
            this.comboBoxDateMonth.FormattingEnabled = true;
            this.comboBoxDateMonth.Location = new System.Drawing.Point(212, 21);
            this.comboBoxDateMonth.Name = "comboBoxDateMonth";
            this.comboBoxDateMonth.Size = new System.Drawing.Size(56, 23);
            this.comboBoxDateMonth.TabIndex = 9;
            this.comboBoxDateMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxDateMonth_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "日";
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(302, 21);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(56, 23);
            this.comboBoxDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "金额";
            // 
            // textMoney
            // 
            this.textMoney.Location = new System.Drawing.Point(95, 123);
            this.textMoney.Name = "textMoney";
            this.textMoney.Size = new System.Drawing.Size(129, 25);
            this.textMoney.TabIndex = 14;
            this.textMoney.Text = "0";
            this.textMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMoney_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "备注";
            // 
            // textDescription
            // 
            this.textDescription.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textDescription.Location = new System.Drawing.Point(95, 171);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(291, 87);
            this.textDescription.TabIndex = 16;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 339);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDateMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDateYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLei);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "添加";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxLei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDateYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDateMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textDescription;
    }
}