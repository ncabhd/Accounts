using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Accounts
{
    public partial class RegisterForm : Form
    {
        public LoginForm lg;
        public RegisterForm()
        {
            InitializeComponent();
        }

        //注册按钮
        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool isNotEmpty = CheckEmpty();
            if (isNotEmpty == true)
            {
                if (getResist() == true)
                {
                    MessageBox.Show("该用户已经注册，请重新输入注册");
                    textName.SelectAll();
                    textName.Focus();
                }
                else
                {
                    string sql = string.Format("insert into Users Values('{3}','{0}','{1}','{2}','{3}','{3}','{3}')", textName.Text.Trim(), textPassword.Text.Trim(),textAlimoney.Text.Trim(),0);
                    MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
                    DBOperate.connection.Open();
                    int count = cmd.ExecuteNonQuery();
                    DBOperate.connection.Close();
                    if (count == 1)
                    {
                        MessageBox.Show("注册成功");
                        lg.getUserName(textName.Text.Trim());
                        sql = string.Format("create table {0}(ID int not null auto_increment, ConsumeDate Varchar(10), Type Varchar(5), Catagory varchar(10), Money double(123,2), Description varchar(50),primary key (ID));", textName.Text.Trim());
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        DBOperate.connection.Open();
                        cmd.ExecuteNonQuery();
                        DBOperate.connection.Close();
                        this.Close();
                    }
                }
            }
        }

        //检查是否注册过
        public bool getResist()
        {
            bool isRight = false;
            //count(*)返回数目
            string sql = string.Format("select count(*) from Users where UserName='{0}'", textName.Text);
            MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
            DBOperate.connection.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            DBOperate.connection.Close();
            if (result == 1)
            {
                isRight = true;
            }
            return isRight;
        }

        //检查用户有没有填进去东西
        private bool CheckEmpty()
        {
            bool result = true;
            if (textName.Text.Trim() == string.Empty)
            {
                labelNameError.Visible = true;
                result = false;
            }
            else
            {
                labelNameError.Visible = false;
            }
            if (textPassword.Text.Trim() == string.Empty)
            {
                labelPasswordError.Visible = true;
                result = false;
            }
            else
            {
                labelPasswordError.Visible = false;
            }
            if (textConfirmPassword.Text.Trim() == string.Empty)
            {
                labelConfirmError.Visible = true;
                result = false;
            }
            else
            {
                //检查两个密码是否相同
                if (textConfirmPassword.Text.Trim() != textPassword.Text.Trim())
                {
                    labelConfirmError.Text = "两次密码不同";
                    labelConfirmError.Visible = true;
                    result = false;
                }
                else
                {
                    labelConfirmError.Visible = false;
                }
            }
            return result;
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
