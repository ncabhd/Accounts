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
    public partial class AddForm : Form
    {
        public MainForm mf;
        public string User;

        public void getUser(string name)
        {
            User = name;
        }

        public AddForm()
        {
            InitializeComponent();
        }

        //窗口初始化
        private void AddForm_Load(object sender, EventArgs e)
        {
            comboBoxLei.Items.Add("收入");          //在类别组合框口加入收入
            comboBoxLei.Items.Add("支出");          //在类别组合框中加入支出
            comboBoxLei.SelectedIndex = 0;          
            comboBoxItem.SelectedIndex = 0;         //类别和项目显示第一个
            for (int i = 2000; i <= 2900; ++i)      //年组合框初始化
            {
                comboBoxDateYear.Items.Add(i.ToString());
            }
            DateTime dt = DateTime.Now;             //让年月日组合框显示当日信息
            comboBoxDateYear.Text = dt.Year.ToString();
            comboBoxDateMonth.Text = dt.Month.ToString();
            comboBoxDate.Text = dt.Day.ToString();
        }

        //关闭改窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //类别组合框
        private void comboBoxLei_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxItem.Items.Clear();             //清空项目组合框的内容
            if (comboBoxLei.SelectedIndex == 0)     //如果是收入
            {
                comboBoxItem.Items.Add("兼职");
                comboBoxItem.Items.Add("其他");
            }
            else
            {
                comboBoxItem.Items.Add("充饭卡");
                comboBoxItem.Items.Add("点外卖");
                comboBoxItem.Items.Add("买水果");
                comboBoxItem.Items.Add("买日用品");
                comboBoxItem.Items.Add("其他");
            }
            comboBoxItem.SelectedIndex = 0;         //显示第一个
        }

        //年组合框
        private void comboBoxDateYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDateMonth.Items.Clear();            //清空月日
            comboBoxDate.Items.Clear();
            for (int i = 1; i <= 12; ++i)               //添加月
            {
                comboBoxDateMonth.Items.Add(i.ToString());
            }
            comboBoxDateMonth.SelectedIndex = 0;        //显示1月1日
            comboBoxDate.SelectedIndex = 0;
        }

        //月组合框
        private void comboBoxDateMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDate.Items.Clear();         //清空日
            for(int i = 1; i <= 28; ++i)        //日添加28个
            {
                comboBoxDate.Items.Add(i.ToString());
            }
            int year = Convert.ToInt32(comboBoxDateYear.SelectedItem.ToString());          //获取选择的年月
            int month = Convert.ToInt32(comboBoxDateMonth.SelectedItem.ToString());
            int temp = 29;
            if ((year % 4 == 0 && year % 100 != 0 || year % 400 == 0) && month == 2)        //闰年还是二月加入29
            {
                comboBoxDate.Items.Add(temp.ToString());
            }
            temp += 1;
            if (month == 4 || month == 6 || month == 9 || month == 11)          //根据月份加入30/31
            {
                for (int i = 29; i <= temp; ++i)
                {
                    comboBoxDate.Items.Add(i.ToString());
                }
            }
            temp += 1;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                for (int i = 29; i <= temp; ++i)
                {
                    comboBoxDate.Items.Add(i.ToString());
                }
            }
            comboBoxDate.SelectedIndex = 0;         //显示1日
        }

        //添加键
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isNull = IsNull();
            if (isNull == true)     //如果不全是空
            {
                string data = comboBoxDateYear.Text.Trim() + "-" + comboBoxDateMonth.Text.Trim() + "-" + comboBoxDate.Text.Trim();      //获取时间
                string sql = string.Format("insert into {5} (ConsumeDate,Type,Catagory,Money,Description) values('{0}','{1}','{2}','{3}','{4}')",
                    data, comboBoxLei.Text.Trim(), comboBoxItem.Text.Trim(), textMoney.Text.Trim(), textDescription.Text.Trim(), User);     //向MySQL插入
                MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
                DBOperate.connection.Open();
                cmd.ExecuteNonQuery();
                if(comboBoxLei.Text=="收入")
                {
                    mf.income = mf.income + Convert.ToDouble(textMoney.Text);   //主菜单的收入的值
                    mf.income = Math.Round(mf.income, 2);       //四舍五入
                    mf.sum = mf.sum + Convert.ToDouble(textMoney.Text);     //主菜单的总资产
                    mf.sum = Math.Round(mf.sum, 2);
                    sql = string.Format("update Users set Credit = '{0}',Sum = '{2}' where UserName = '{1}'", mf.income, User, mf.sum);     //更新MySQL中的收入和总资产
                    cmd = new MySqlCommand(sql, DBOperate.connection);
                    cmd.ExecuteNonQuery();
                    mf.Money();             //更改主菜单的值
                    if(Today()==true)       //如果添加的是当天的帐，记录下来
                    {
                        sql = string.Format("update Users set DaySum2=DaySum2-{0} where UserName='{1}'", Convert.ToDouble(textMoney.Text), User);
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        cmd.ExecuteNonQuery();
                    }
                }
                //支出同收入
                if(comboBoxLei.Text=="支出")
                {
                    mf.consume = mf.consume + Convert.ToDouble(textMoney.Text);     //主菜单的支取
                    mf.income = Math.Round(mf.income, 2);
                    mf.sum = mf.sum - Convert.ToDouble(textMoney.Text);
                    mf.sum = Math.Round(mf.sum, 2);
                    sql = string.Format("update Users set Debit ='{0}',sum='{1}' where UserName='{2}'", mf.consume, mf.sum, User);
                    cmd = new MySqlCommand(sql, DBOperate.connection);
                    cmd.ExecuteNonQuery();
                    mf.Money();
                    if (Today() == true)
                    {
                        sql = string.Format("update Users set DaySum2=DaySum2+{0} where UserName='{1}'", Convert.ToDouble(textMoney.Text), User);
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        cmd.ExecuteNonQuery();
                    }
                }
                //建一个string数组添加到datagridview
                string[] row = new string[6];
                row[1] = data;
                row[2] = comboBoxLei.Text.Trim();
                row[3] = comboBoxItem.Text.Trim();
                row[4] = textMoney.Text.Trim();
                row[5] = textDescription.Text.Trim();
                DBOperate.connection.Close();
                mf.insertData(row);     //主菜单插入
                MessageBox.Show("成功添加");
                this.Close();
            }
            else
            {
                MessageBox.Show("请按要求输入");
            }
        }

        //判断是否为空
        public bool IsNull()
        {
            bool isnull = true;
            if (comboBoxDateYear.Text.Trim() == string.Empty)
            {
                isnull = false;
            }
            if(comboBoxDateMonth.Text.Trim()==string.Empty)
            {
                isnull = false;
            }
            if(comboBoxDate.Text.Trim()==string.Empty)
            {
                isnull = false;
            }
            if(comboBoxLei.Text.Trim()==string.Empty)
            {
                isnull = false;
            }
            if(comboBoxItem.Text.Trim()==string.Empty)
            {
                isnull = false;
            }
            if (textMoney.Text.Trim() == string.Empty)
            {
                isnull = false;
            }
            return isnull;
        }

        //判断是否为当天
        private bool Today()
        {
            bool isToday = false;
            DateTime dt = DateTime.Now;
            if(dt.Year.ToString()==comboBoxDateYear.Text)
            {
                if(dt.Month.ToString()==comboBoxDateMonth.Text)
                {
                    if(dt.Day.ToString()==comboBoxDate.Text)
                    {
                        isToday = true;
                    }
                }
            }
            return isToday;
        }

        private void textMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar) && e.KeyChar != 0x2E)        //？？待查
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')       //金额只允许输入一个"."
            {
                TextBox tb = sender as TextBox;

                if (tb.Text == "")      //如果之前没有输入，在前面加个"0."
                {
                    tb.Text = "0.";
                    tb.Select(tb.Text.Length, 0);
                    e.Handled = true;
                }
                else if (tb.Text.Contains("."))     //之前有"."不能在输入
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }

                //e.Handled true不能输入
                //          false能输入

            }
        }
    }
}
