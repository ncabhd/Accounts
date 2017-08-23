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
    public partial class MonthForm : Form
    {
        public MainForm mf;
        public MonthForm()
        {
            InitializeComponent();
        }

        private void MonthForm_Load(object sender, EventArgs e)
        {
            for (int i = 2000; i <= 2900; ++i)      //年组合框初始化
            {
                comboBoxDateYear.Items.Add(i.ToString());
            }
            DateTime dt = DateTime.Now;             //让年月日组合框显示当日信息
            comboBoxDateYear.Text = dt.Year.ToString();
            comboBoxDateMonth.Text = dt.Month.ToString();
            Add();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; ++i)               //添加月
            {
                comboBoxDateMonth.Items.Add(i.ToString());
            }
            comboBoxDateMonth.SelectedIndex = 0;        //显示1月
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            string Date = comboBoxDateYear.Text.ToString() + "-" + comboBoxDateMonth.Text.ToString();
            string sql = string.Format("select count(*) from {0}_Month where Date='{1}'", mf.User, Date);
            MySqlCommand cmd = new MySqlCommand(sql, DBOperate.connection);
            DBOperate.connection.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            DBOperate.connection.Close();
            if (result == 1)
            {
                sql = string.Format("select * from {0}_Month where Date='{1}'", mf.User, Date);
                cmd = new MySqlCommand(sql, DBOperate.connection);
                DBOperate.connection.Open();
                MySqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    textIncome.Text = sdr["Credit"].ToString();
                    textWork.Text = sdr["Work"].ToString();
                    textInOthers.Text = sdr["InOthers"].ToString();
                    textOutcome.Text = sdr["Debit"].ToString();
                    textFood.Text = sdr["Food"].ToString();
                    textSock.Text = sdr["Sock"].ToString();
                    textBus.Text = sdr["Bus"].ToString();
                    textPlay.Text = sdr["Play"].ToString();
                    textStudy.Text = sdr["Study"].ToString();
                    textStore.Text = sdr["Store"].ToString();
                    textOutOthers.Text = sdr["OutOthers"].ToString();
                }
                DBOperate.connection.Close();
            }
            else
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                    {
                        ctrl.Text = "0";
                    }
                }
            }
        }
    }
}
