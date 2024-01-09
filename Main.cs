using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_SQL_Project
{
    public partial class Main : Form
    {
        ICantacts_Repo repo;
        public Main()
        {
            InitializeComponent();
            repo = new ContactRepo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            DgDATA.DataSource = repo.SelectAll();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit addfrm = new frmAddOrEdit();
            addfrm.ShowDialog();
            if (addfrm.DialogResult == DialogResult.OK)
            {
                RefreshTable();
            }
        }
    }
}
