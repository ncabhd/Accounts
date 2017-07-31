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

namespace Accounts
{
    public partial class MainForm : Form
    {
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


        //开始的界面，显示时间
        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String date = dt.ToLongDateString();
            String time = dt.ToLongTimeString();
            labelTime.Text = date + time;
            
            dataGridView1.ClearSelection();
        }

        //每秒显示
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String date = dt.ToLongDateString();
            String time = dt.ToLongTimeString();
            labelTime.Text = date + time;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            //toolStripButtonDelete.Enabled = true;
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
    }
}
