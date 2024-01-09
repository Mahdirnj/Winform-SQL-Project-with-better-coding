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
    public partial class frmAddOrEdit : Form
    {
        ICantacts_Repo repo;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repo = new ContactRepo();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            this.Name = "Add Contact";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                bool isSucsses = repo.Insert(txtAddName.Text, txtAddLast.Text, txtAddPhone.Text, txtAddEmail.Text);

                if (isSucsses == true)
                {
                    MessageBox.Show("Operation was successful","Successful" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Operation was failure  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        bool isValid()
        {


            if (txtAddName.Text == "" || txtAddLast.Text == "" || txtAddPhone.Text == "")
            {
                MessageBox.Show("Please fill the required info ! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }
    }
}
