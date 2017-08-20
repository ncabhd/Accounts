using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts
{
    public partial class SearchForm : Form
    {
        public MainForm mf;
        string ss = string.Empty;

        public SearchForm()
        {
            InitializeComponent();
        }

        //获取ss
        private void SearchForm_Load(object sender, EventArgs e)
        {
            //默认是收入
            ss = radioButtonIn.Text.Trim();
        }

        //收入
        private void radioButtonIn_CheckedChanged(object sender, EventArgs e)
        {
            ss = radioButtonIn.Text.Trim();
        }

        //支出
        private void radioButtonOut_CheckedChanged(object sender, EventArgs e)
        {
            ss = radioButtonOut.Text.Trim();
        }

        //全部
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ss = radioButtonAll.Text.Trim();
        }

        //取消键
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //查找键
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (ss == "全部")
            {
                mf.PopulateDataGridView();
            }
            else
            {
                mf.SearchData(ss);
            }
            this.Close();
        } 
    }
}
