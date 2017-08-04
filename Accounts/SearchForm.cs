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

        private void SearchForm_Load(object sender, EventArgs e)
        {
            ss = radioButtonIn.Text.Trim();
        }

        private void radioButtonIn_CheckedChanged(object sender, EventArgs e)
        {
            ss = radioButtonIn.Text.Trim();
        }

        private void radioButtonOut_CheckedChanged(object sender, EventArgs e)
        {
            ss = radioButtonOut.Text.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
