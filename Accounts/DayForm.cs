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
    public partial class DayForm : Form
    {
        public MainForm mf;

        public DayForm()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowDay();
        }

        private void ShowDay()
        {
            string Date = monthCalendar1.SelectionStart.Year.ToString() + "-" +
                monthCalendar1.SelectionStart.Month.ToString() + "-" +
                monthCalendar1.SelectionStart.Day.ToString();
            int i = 0;
            dataGridView1.Rows.Clear();
            string sql = string.Format("select * from {0} where ConsumeDate='{1}'", mf.User, Date);
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

        private void DayForm_Load(object sender, EventArgs e)
        {
            ShowDay();
        }
    }
}
