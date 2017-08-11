namespace Accounts
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPasswordError = new System.Windows.Forms.Label();
            this.labelAllError = new System.Windows.Forms.Label();
            this.labelNameError = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.ckbRemember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(43, 173);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Location = new System.Drawing.Point(207, 173);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 30);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // labelPasswordError
            // 
            this.labelPasswordError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPasswordError.AutoSize = true;
            this.labelPasswordError.Location = new System.Drawing.Point(145, 107);
            this.labelPasswordError.Name = "labelPasswordError";
            this.labelPasswordError.Size = new System.Drawing.Size(97, 15);
            this.labelPasswordError.TabIndex = 4;
            this.labelPasswordError.Text = "密码不能为空";
            this.labelPasswordError.Visible = false;
            // 
            // labelAllError
            // 
            this.labelAllError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAllError.AutoSize = true;
            this.labelAllError.Location = new System.Drawing.Point(110, 122);
            this.labelAllError.Name = "labelAllError";
            this.labelAllError.Size = new System.Drawing.Size(172, 15);
            this.labelAllError.TabIndex = 5;
            this.labelAllError.Text = "用户名不存在或密码错误";
            this.labelAllError.Visible = false;
            // 
            // labelNameError
            // 
            this.labelNameError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNameError.AutoSize = true;
            this.labelNameError.Location = new System.Drawing.Point(145, 47);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(112, 15);
            this.labelNameError.TabIndex = 7;
            this.labelNameError.Text = "用户名不能为空";
            this.labelNameError.Visible = false;
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.Location = new System.Drawing.Point(113, 19);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(169, 25);
            this.textName.TabIndex = 8;
            // 
            // textPassword
            // 
            this.textPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPassword.Location = new System.Drawing.Point(113, 79);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(169, 25);
            this.textPassword.TabIndex = 9;
            // 
            // ckbRemember
            // 
            this.ckbRemember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbRemember.AutoSize = true;
            this.ckbRemember.Location = new System.Drawing.Point(123, 140);
            this.ckbRemember.Name = "ckbRemember";
            this.ckbRemember.Size = new System.Drawing.Size(89, 19);
            this.ckbRemember.TabIndex = 10;
            this.ckbRemember.Text = "保存密码";
            this.ckbRemember.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 224);
            this.Controls.Add(this.ckbRemember);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelNameError);
            this.Controls.Add(this.labelAllError);
            this.Controls.Add(this.labelPasswordError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPasswordError;
        private System.Windows.Forms.Label labelAllError;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.CheckBox ckbRemember;
        private System.Windows.Forms.Label labelNameError;
    }
}

