using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Accounts
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //注册
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //新建一个注册窗口
            RegisterForm rForm = new RegisterForm();
            rForm.lg = this;
            rForm.Show();
        }

        //从注册获取姓名
        public void getUserName(string name)
        {
            textName.Text = name;
        }

        //获取保存的密码
        public void getPassword()
        {
            //检测有没有myDataBase
            if (File.Exists("myDataBase.sqlite"))
            {
                string sql = string.Format("select * from SavePasswords");      //把本地密码读取出来
                SQLiteCommand cmd = new SQLiteCommand(sql, m_db.Connection);
                m_db.Connection.Open();
                DataSet ds = new DataSet();
                SQLiteDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                textName.Text = sdr["UserName"].ToString();
                textPassword.Text = sdr["UserPassword"].ToString();
                sdr.Close();
                m_db.Connection.Close();
                ckbRemember.Checked = true;     //让记住密码保持打开
            }
            else
            {
                setDataBase();      //建一个本地数据库
            }
        }

        //保存密码到本地
        public void savePassword()
        {
            if (!File.Exists("myDataBase.sqlite"))
            {
                setDataBase();
            }
            string sql = string.Format("update SavePasswords set UserName='{0}',UserPassword='{1}'",
                textName.Text.Trim(), textPassword.Text.Trim());        //更新本地密码
            SQLiteCommand cmd = new SQLiteCommand(sql, m_db.Connection);
            m_db.Connection.Open();
            cmd.ExecuteNonQuery();
            m_db.Connection.Close();
        }

        //新建本地数据库
        public void setDataBase()
        {
            SQLiteConnection.CreateFile("myDataBase.sqlite");
            string sql = "create table SavePasswords (UserName varchar(20),UserPassword varchar(20))";
            m_db.Connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, m_db.Connection);
            cmd.ExecuteNonQuery();
            sql="insert into SavePasswords (UserName, UserPassword) values (NULL,NULL)";
            cmd = new SQLiteCommand(sql, m_db.Connection);
            cmd.ExecuteNonQuery();
            m_db.Connection.Close();
        }

        //登陆键
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isNotEmpty = CheckEmpty();
            if(isNotEmpty==true)
            {
                string sql = string.Format("select count(*) from Users where UserName='{0}' and UserPassword='{1}'", 
                    textName.Text.Trim(), textPassword.Text.Trim());
                DBOperate.connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                DBOperate.connection.Close();
                //返回个数
                if (count > 0)
                {
                    if (ckbRemember.Checked == true)
                    {
                        this.savePassword();
                    }
                    MainForm mForm = new MainForm();
                    mForm.lg = this;
                    mForm.getUser(textName.Text.Trim());        //把用户名传到主菜单
                    mForm.Show();
                    DBOperate.connection.Close();
                    this.Hide();
                }
                else
                {
                    labelAllError.Visible = true;
                }
            }
        }

        //判断是否为空
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
            if(textPassword.Text.Trim()==string.Empty)
            {
                labelPasswordError.Visible = true;
                result = true;
            }
            else
            {
                labelPasswordError.Visible = false;
            }
            return result;
        }

        //初始化
        private void LoginForm_Load(object sender, EventArgs e)
        {
            getPassword();
            this.textName.Select();

            //调用cmd
            /*
            string str = System.Environment.CurrentDirectory;
            str = "cacls \"" + str + "\" /e /t /g everyone:F";
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.Verb = "RunAs";
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(str);
            p.StandardInput.WriteLine("exit");

            p.StandardInput.AutoFlush = true;
            //p.StandardInput.WriteLine("exit");
            //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
            //同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令



            //获取cmd窗口的输出信息
            string output = p.StandardOutput.ReadToEnd();

            //StreamReader reader = p.StandardOutput;
            //string line=reader.ReadLine();
            //while (!reader.EndOfStream)
            //{
            //    str += line + "  ";
            //    line = reader.ReadLine();
            //}

            p.WaitForExit();//等待程序执行完退出进程
            p.Close();
            */
        }
    }
}
