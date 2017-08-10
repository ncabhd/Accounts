using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Accounts
{
    public partial class MainForm : Form
    {
        public double income = 0, consume = 0, sum = 0;
        public int i = 0;
        public LoginForm lg;
        public string User;
        public MainForm()
        {
            InitializeComponent();
        }

        public void getUser(string name)
        {
            User = name;
        }


        //开始的界面
        private void MainForm_Load(object sender, EventArgs e)
        {
            //时间
            DateTime dt = DateTime.Now;
            String date = dt.ToLongDateString();
            String time = dt.ToLongTimeString();
            labelTime.Text = date + time;
            //数据库
            PopulateDataGridView();
            //每日提醒
            SearchDay();
            //收入支取剩余
            showMoney();
        }

        //显示收入支取总和
        private void showMoney()
        {
            string sql = string.Format("select sum from Users where UserName='{0}'", User);
            MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
            DBOperate.connection.Open();
            sum = Convert.ToDouble(cmd.ExecuteScalar());
            sql = string.Format("select Credit from Users where UserName='{0}'", User);
            cmd = new MySqlCommand(sql, DBOperate.connection);
            income = Convert.ToDouble(cmd.ExecuteScalar());
            sql = string.Format("select Debit from Users where UserName='{0}'", User);
            cmd = new MySqlCommand(sql, DBOperate.connection);
            consume = Convert.ToDouble(cmd.ExecuteScalar());
            Money();
            DBOperate.connection.Close();
        }

        //总金额统计
        public void Money()
        {
            textIncome.Text = income.ToString();
            textConsume.Text = consume.ToString();
            textSum.Text = sum.ToString();
        }

        //每秒显示
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String date = dt.ToLongDateString();
            String time = dt.ToLongTimeString();
            labelTime.Text = date + time;
        }

        //打开添加的窗口
        private void btnInsert_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.mf = this;
            addForm.getUser(User);
            addForm.ShowDialog();
        }

        //打来查找的窗口
        private void btnFind_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.mf = this;
            searchForm.ShowDialog();
        }

        //退出询问，同时关闭所有窗口
        private void MainForm_FormClose(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认退出", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Dispose();
                Application.Exit();
            }
            {
                e.Cancel = true;
            }
        }

        //显示数据
        public void PopulateDataGridView()
        {
            i = 0;
            dataGridView1.Rows.Clear();
            string sql = string.Format("select * from {0} order by ConsumeDate desc", User);
            MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
            DBOperate.connection.Open();
            DataSet ds = new DataSet();
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i++;
                string[] row = new string[7];
                row[0] = i.ToString();
                row[1] = sdr["ConsumeDate"].ToString();
                row[2] = sdr["Type"].ToString();
                row[3] = sdr["Catagory"].ToString();
                row[4] = sdr["Money"].ToString();
                row[5] = sdr["Description"].ToString();
                row[6] = sdr["ID"].ToString();
                dataGridView1.Rows.Add(row);
            }
            DBOperate.connection.Close();
        }

        //删除键
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DialogResult dr = MessageBox.Show("确认删除", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    int a = dataGridView1.CurrentRow.Index;
                    string sql = string.Format("delete from {0} where ID='{1}'", User, dataGridView1.Rows[a].Cells[6].Value.ToString());
                    MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
                    DBOperate.connection.Open();
                    cmd.ExecuteNonQuery();
                    if (dataGridView1.Rows[a].Cells[2].Value.ToString() == "收入")
                    {
                        income = income - Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
                        sum = sum - Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
                        sql = string.Format("update Users set Credit='{0}',Sum='{1}' where UserName = '{2}'", income, sum, User);
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        cmd.ExecuteNonQuery();
                        if(Today(a)==true)
                        {
                            sql = string.Format("update Users set DaySum=DaySum+{0} where UserName='{1}'", Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), User);
                            cmd = new MySqlCommand(sql, DBOperate.connection);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    if (dataGridView1.Rows[a].Cells[2].Value.ToString() == "支取")
                    {
                        consume = consume - Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
                        sum = sum + Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
                        sql = string.Format("update Users set Debit='{0}',Sum='{1}' where UserName = '{2}'", consume, sum, User);
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        cmd.ExecuteNonQuery();
                        if (Today(a) == true)
                        {
                            sql = string.Format("update Users set DaySum=DaySum-{0} where UserName='{1}'", Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), User);
                            cmd = new MySqlCommand(sql, DBOperate.connection);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Money();
                    DBOperate.connection.Close();
                    PopulateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("请选择一条后再删除");
            }
        }

        //添加后重新显示数据
        public void insertData(string[] row)
        {
            PopulateDataGridView();
        }

        //查找后重新显示数据
        public void SearchData(string search)
        {
            i = 0;
            dataGridView1.Rows.Clear();
            string sql = string.Format("Select * from {1} where Type='{0}' order by ConsumeDate desc", search, User);
            MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
            DBOperate.connection.Open();
            //DataSet ds = new DataSet();
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                i++;
                string[] row = new string[6];
                row[0] = i.ToString();
                row[1] = sdr["ConsumeDate"].ToString();
                row[2] = sdr["Type"].ToString();
                row[3] = sdr["Catagory"].ToString();
                row[4] = sdr["Money"].ToString();
                row[5] = sdr["Description"].ToString();
                dataGridView1.Rows.Add(row);
            }
            DBOperate.connection.Close();
        }

        private void SearchDay()
        {
            string sql = string.Format("select * from Users where UserName='{0}'", User);
            MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
            DBOperate.connection.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                string boolMonth = sdr["Month"].ToString();
                string boolDay = sdr["Day"].ToString();
                string DaySum = sdr["DaySum"].ToString();
                DBOperate.connection.Close();
                if (boolMonth != "0")
                {
                    MessageBox.Show("本月生活费已添加");
                    sql = string.Format("update Users set Month='0' where UserName='{0}'", User);
                    cmd = new MySqlCommand(sql, DBOperate.connection);
                    DBOperate.connection.Open();
                    cmd.ExecuteNonQuery();
                    DBOperate.connection.Close();
                }
                if (boolDay != "0")
                {
                    DaySum = "您昨天共消费" + DaySum + "元";
                    MessageBox.Show(DaySum);
                    sql = string.Format("update Users set Day='0' where UserName='{0}'", User);
                    cmd = new MySqlCommand(sql, DBOperate.connection);
                    DBOperate.connection.Open();
                    cmd.ExecuteNonQuery();
                    DBOperate.connection.Close();
                }
            }
            else
            {
                DBOperate.connection.Close();
            }
        }

        private bool Today(int a)
        {
            bool isToday = false;
            DateTime dt = DateTime.Now;
            string year = dt.Year.ToString();
            string month = dt.Month.ToString();
            string day = dt.Day.ToString();
            string date = year + "-" + month + "-" + day;
            if(date==dataGridView1.Rows[a].Cells[1].Value.ToString())
            {
                isToday = true;
            }
            return isToday;
        }
        
    }
}