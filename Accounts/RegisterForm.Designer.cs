namespace Accounts
{
    partial class RegisterForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNameError = new System.Windows.Forms.Label();
            this.labelPasswordError = new System.Windows.Forms.Label();
            this.labelConfirmError = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAlimoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Location = new System.Drawing.Point(57, 261);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 30);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(199, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码：";
            // 
            // labelNameError
            // 
            this.labelNameError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNameError.AutoSize = true;
            this.labelNameError.Location = new System.Drawing.Point(166, 77);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(82, 15);
            this.labelNameError.TabIndex = 5;
            this.labelNameError.Text = "用户名为空";
            this.labelNameError.Visible = false;
            // 
            // labelPasswordError
            // 
            this.labelPasswordError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPasswordError.AutoSize = true;
            this.labelPasswordError.Location = new System.Drawing.Point(169, 130);
            this.labelPasswordError.Name = "labelPasswordError";
            this.labelPasswordError.Size = new System.Drawing.Size(67, 15);
            this.labelPasswordError.TabIndex = 6;
            this.labelPasswordError.Text = "密码为空";
            this.labelPasswordError.Visible = false;
            // 
            // labelConfirmError
            // 
            this.labelConfirmError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirmError.AutoSize = true;
            this.labelConfirmError.Location = new System.Drawing.Point(151, 183);
            this.labelConfirmError.Name = "labelConfirmError";
            this.labelConfirmError.Size = new System.Drawing.Size(97, 15);
            this.labelConfirmError.TabIndex = 7;
            this.labelConfirmError.Text = "确认密码为空";
            this.labelConfirmError.Visible = false;
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textName.Location = new System.Drawing.Point(123, 49);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(169, 25);
            this.textName.TabIndex = 8;
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            // 
            // textPassword
            // 
            this.textPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPassword.Location = new System.Drawing.Point(123, 102);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(169, 25);
            this.textPassword.TabIndex = 9;
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textConfirmPassword.Location = new System.Drawing.Point(123, 155);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.PasswordChar = '*';
            this.textConfirmPassword.Size = new System.Drawing.Size(169, 25);
            this.textConfirmPassword.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "每月生活费：";
            // 
            // textAlimoney
            // 
            this.textAlimoney.Location = new System.Drawing.Point(123, 209);
            this.textAlimoney.Name = "textAlimoney";
            this.textAlimoney.Size = new System.Drawing.Size(169, 25);
            this.textAlimoney.TabIndex = 12;
            this.textAlimoney.Text = "0";
            this.textAlimoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAlimoney_KeyPress);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 315);
            this.Controls.Add(this.textAlimoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelConfirmError);
            this.Controls.Add(this.labelPasswordError);
            this.Controls.Add(this.labelNameError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNameError;
        private System.Windows.Forms.Label labelPasswordError;
        private System.Windows.Forms.Label labelConfirmError;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAlimoney;
    }
}