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
            comboBoxLei.Items.Add("支取");          //在类别组合框中加入支取
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
                comboBoxItem.Items.Add("2");
            }
            else
            {
                comboBoxItem.Items.Add("充饭卡");
                comboBoxItem.Items.Add("点外卖");
                comboBoxItem.Items.Add("买水果");
                comboBoxItem.Items.Add("买日用品");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isNull = IsNull();
            if (isNull == true)
            {
                string data = comboBoxDateYear.Text.Trim() + "-" + comboBoxDateMonth.Text.Trim() + "-" + comboBoxDate.Text.Trim();
                string sql = string.Format("insert into {5} (ConsumeDate,Type,Catagory,Money,Description) values('{0}','{1}','{2}','{3}','{4}')", data, comboBoxLei.Text.Trim(), comboBoxItem.Text.Trim(), textMoney.Text.Trim(), textDescription.Text.Trim(), User);
                MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
                DBOperate.connection.Open();
                cmd.ExecuteNonQuery();
                if(comboBoxLei.Text=="收入")
                {
                    mf.income = mf.income + Convert.ToDouble(textMoney.Text);
                    mf.sum = mf.sum + Convert.ToDouble(textMoney.Text);
                    sql = string.Format("update Users set Credit = '{0}',Sum = '{2}' where UserName = '{1}'", mf.income, User, mf.sum);
                    cmd = new MySqlCommand(sql, DBOperate.connection);
                    cmd.ExecuteNonQuery();
                    mf.Money();
                }
                if(comboBoxLei.Text=="支取")
                {
                    mf.consume = mf.consume + Convert.ToDouble(textMoney.Text);
                    mf.sum = mf.sum - Convert.ToDouble(textMoney.Text);
                    sql = string.Format("update Users set Debit ='{0}',sum='{1}' where UserName='{2}'", mf.consume, mf.sum, User);
                    cmd = new MySqlCommand(sql, DBOperate.connection);
                    cmd.ExecuteNonQuery();
                    mf.Money();
                }

                string[] row = new string[6];
                row[1] = data;
                row[2] = comboBoxLei.Text.Trim();
                row[3] = comboBoxItem.Text.Trim();
                row[4] = textMoney.Text.Trim();
                row[5] = textDescription.Text.Trim();
                DBOperate.connection.Close();
                mf.insertData(row);
                MessageBox.Show("成功添加");
                this.Close();
            }
            else
            {
                MessageBox.Show("请按要求输入");
            }
        }

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
    }
}
