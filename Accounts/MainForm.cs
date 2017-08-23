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
using System.Data.SQLite;


namespace Accounts
{
    public partial class MainForm : Form
    {
        public double income = 0, consume = 0, sum = 0;     //收入支出总和
        public int i = 0;       //记录个数
        public LoginForm lg;
        public string User;     //用户名
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
            //显示数据库
            PopulateDataGridView();
            //每日提醒
            SearchDay();
            //收入支取剩余
            showMoney();
        }

        //显示收入支取总和
        private void showMoney()
        {
            string sql = string.Format("select sum from Users where UserName='{0}'", User);     //sum保存用户总和
            MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
            DBOperate.connection.Open();
            sum = Convert.ToDouble(cmd.ExecuteScalar());
            sql = string.Format("select Credit from Users where UserName='{0}'", User);
            cmd = new MySqlCommand(sql, DBOperate.connection);
            income = Convert.ToDouble(cmd.ExecuteScalar());
            sql = string.Format("select Debit from Users where UserName='{0}'", User);
            cmd = new MySqlCommand(sql, DBOperate.connection);
            consume = Convert.ToDouble(cmd.ExecuteScalar());
            Money();        //总金额统计
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
            DialogResult result = MessageBox.Show("是否确认退出", "提醒", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
            dataGridView1.Rows.Clear();     //清空dataGridView1
            string sql = string.Format("select * from {0} order by ConsumeDate desc", User);
            MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
            DBOperate.connection.Open();
            //DataSet ds = new DataSet();
            MySqlDataReader sdr = cmd.ExecuteReader();
            //把数据放到一个string数组，插到dataGridView
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
                    string sql = string.Format("delete from {0} where ID='{1}'", 
                        User, dataGridView1.Rows[a].Cells[6].Value.ToString());
                    MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
                    DBOperate.connection.Open();
                    cmd.ExecuteNonQuery();
                    DBOperate.connection.Close();
                    //收入和支出对和的判断
                    string b = dataGridView1.Rows[a].Cells[1].Value.ToString();
                    int bit = 0;
                    int temp = 0;
                    for(int i=0;i<b.Length;++i)
                    {
                        if(b[i]=='-')
                        {
                            if(temp==0)
                            {
                                temp = 1;
                            }
                            else
                            {
                                bit = i;
                                break;
                            }
                        }
                    }
                    string month="";
                    for(int i=0;i<bit;++i)
                    {
                        month = month + b[i];
                    }
                    if (dataGridView1.Rows[a].Cells[2].Value.ToString() == "收入")
                    {
                        income = income - Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
                        sum = sum - Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
                        sql = string.Format("update Users set Credit='{0}',Sum='{1}' where UserName = '{2}'", 
                            income, sum, User);
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        DBOperate.connection.Open();
                        cmd.ExecuteNonQuery();
                        DBOperate.connection.Close();
                        sql = string.Format("update {0}_Month set Credit=Credit-{1} where Date='{2}'",
                            User, dataGridView1.Rows[a].Cells[4].Value, month);
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        DBOperate.connection.Open();
                        cmd.ExecuteNonQuery();
                        DBOperate.connection.Close();
                        //如果是当天则记录下来
                        if(Today(a)==true)
                        {
                            sql = string.Format("update Users set DaySum2=DaySum2+{0} where UserName='{1}'", 
                                Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), User);
                            cmd = new MySqlCommand(sql, DBOperate.connection);
                            DBOperate.connection.Open();
                            cmd.ExecuteNonQuery();
                            DBOperate.connection.Close();
                        }
                        if (dataGridView1.Rows[a].Cells[3].Value.ToString() == "兼职")
                        {
                            sql = string.Format("update {0}_Month set Work=Work-{1} where Date='{2}'",
                                User, Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), month);
                        }

                        if (dataGridView1.Rows[a].Cells[3].Value.ToString() == "其他")
                        {
                            sql = string.Format("update {0}_Month set InOthers=InOthers-{1} where Date='{2}'",
                                User, Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), month);
                        }
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        DBOperate.connection.Open();
                        cmd.ExecuteNonQuery();
                        DBOperate.connection.Close();
                    }

                    if (dataGridView1.Rows[a].Cells[2].Value.ToString() == "支出")
                    {
                        consume = consume - Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
                        sum = sum + Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value);
                        sql = string.Format("update Users set Debit='{0}',Sum='{1}' where UserName = '{2}'", 
                            consume, sum, User);
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        DBOperate.connection.Open();
                        cmd.ExecuteNonQuery();
                        DBOperate.connection.Close();
                        sql = string.Format("update {0}_Month set Debit=Debit-{1} where Date='{2}'",
                            User, dataGridView1.Rows[a].Cells[4].Value, month);
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        DBOperate.connection.Open();
                        cmd.ExecuteNonQuery();
                        DBOperate.connection.Close();
                        if (Today(a) == true)
                        {
                            sql = string.Format("update Users set DaySum2=DaySum2-{0} where UserName='{1}'", 
                                Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), User);
                            cmd = new MySqlCommand(sql, DBOperate.connection);
                            DBOperate.connection.Open();
                            cmd.ExecuteNonQuery();
                            DBOperate.connection.Close();
                        }
                        if (dataGridView1.Rows[a].Cells[3].Value.ToString() == "餐饮")
                        {
                            sql = string.Format("update {0}_Month set Food=Food-{1} where Date='{2}'",
                                User, Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), month);
                        }

                        if (dataGridView1.Rows[a].Cells[3].Value.ToString() == "零食")
                        {
                            sql = string.Format("update {0}_Month set Sock=Sock-{1} where Date='{2}'",
                                User, Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), month);
                        }

                        if (dataGridView1.Rows[a].Cells[3].Value.ToString() == "公交")
                        {
                            sql = string.Format("update {0}_Month set Bus=Bus-{1} where Date='{2}'",
                                User, Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), month);
                        }

                        if (dataGridView1.Rows[a].Cells[3].Value.ToString() == "娱乐")
                        {
                            sql = string.Format("update {0}_Month set Play=Play-{1} where Date='{2}'",
                                User, Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), month);
                        }

                        if (dataGridView1.Rows[a].Cells[3].Value.ToString() == "学习")
                        {
                            sql = string.Format("update {0}_Month set Study=Study-{1} where Date='{2}'",
                                User, Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), month);
                        }

                        if (dataGridView1.Rows[a].Cells[3].Value.ToString() == "日杂")
                        {
                            sql = string.Format("update {0}_Month set Store=Store-{1} where Date='{2}'",
                                User, Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), month);
                        }

                        if (dataGridView1.Rows[a].Cells[3].Value.ToString() == "其他")
                        {
                            sql = string.Format("update {0}_Month set OutOthers=OutOthers-{1} where Date='{2}'",
                                User, Convert.ToDouble(dataGridView1.Rows[a].Cells[4].Value), month);
                        }
                        cmd = new MySqlCommand(sql, DBOperate.connection);
                        DBOperate.connection.Open();
                        cmd.ExecuteNonQuery();
                        DBOperate.connection.Close();
                    }
                    Money();
                    PopulateDataGridView();     //显示数据
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
            string sql = string.Format("select * from {1} where Type='{0}' order by ConsumeDate desc", 
                search, User);
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

        private void textIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textConsume_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //清空账号
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确认清楚该账号", "提醒", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //清空
            if (result == DialogResult.OK)
            {
                string sql = string.Format("delete from Users where UserName='{0}'", User);
                MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
                DBOperate.connection.Open();
                cmd.ExecuteNonQuery();
                sql = string.Format("drop table {0}", User);
                cmd = new MySqlCommand(sql, DBOperate.connection);
                cmd.ExecuteNonQuery();
                DBOperate.connection.Close();
                //本地清空保存的记录
                sql = string.Format("update SavePasswords set UserName='',UserPassword=''");
                SQLiteCommand smd = new SQLiteCommand(sql, m_db.Connection);
                m_db.Connection.Open();
                smd.ExecuteNonQuery();
                m_db.Connection.Close();
                this.Dispose();
                Application.Exit();

                sql = string.Format("drop table {0}_Month", User);
                cmd = new MySqlCommand(sql, DBOperate.connection);
                DBOperate.connection.Open();
                cmd.ExecuteNonQuery();
                DBOperate.connection.Close();
            }
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            DayForm df = new DayForm();
            df.mf = this;
            df.ShowDialog();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            MonthForm MonthF = new MonthForm();
            MonthF.mf = this;
            MonthF.ShowDialog();
        }

        //检查自动提醒和添加生活费
        private void SearchDay()
        {
            string sql = string.Format("select * from Users where UserName='{0}'", User);
            MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
            DBOperate.connection.Open();
            MySqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                //读取数据中判断是都加的东西
                //数据库每次都要打开再关闭再打开再关闭
                string boolMonth = sdr["Month"].ToString();
                string boolDay = sdr["Day"].ToString();
                string DaySum = sdr["DaySum1"].ToString();
                DBOperate.connection.Close();
                textDaySum.Text = DaySum;
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

        //判断是否是当天
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