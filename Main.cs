﻿using System;
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
        //------------------------------------------------------------------
        public static int  ContactID;
        public static string Name , Family, phonenumber, Email54;
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }
        //------------------------------------------------------------------

       
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ContactID = int.Parse(DgDATA.CurrentRow.Cells[0].Value.ToString());
            Name = DgDATA.CurrentRow.Cells[1].Value.ToString();
            Family = DgDATA.CurrentRow.Cells[2].Value.ToString();
            phonenumber = DgDATA.CurrentRow.Cells[3].Value.ToString();
            Email54 = DgDATA.CurrentRow.Cells[4].Value.ToString();
            frmEdit editform = new frmEdit();
            editform.ShowDialog();
            RefreshTable();
        }


        //------------------------------------------------------------------

        private void RefreshTable()
        {
            DgDATA.DataSource = repo.SelectAll();
        }
        //------------------------------------------------------------------
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit addfrm = new frmAddOrEdit();
            addfrm.ShowDialog();
            if (addfrm.DialogResult == DialogResult.OK)
            {
                RefreshTable();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DgDATA.DataSource = repo.Search(txtSearch.Text);
        
        }


        //------------------------------------------------------------------


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DgDATA.CurrentRow != null)
            {
                string name = DgDATA.CurrentRow.Cells[1].Value.ToString();
                string family = DgDATA.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show($"Are you sure to delete {name} {family} ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ContactID = Convert.ToInt32(DgDATA.CurrentRow.Cells[0].Value.ToString());
                    repo.Delete(ContactID);
                    RefreshTable();
                }
            }
            else
            {
                MessageBox.Show("Please select a row!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
       
       
        //------------------------------------------------------------------
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ? ", "Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                repo.DeleteAll();
                RefreshTable();
            }
        }
        //------------------------------------------------------------------
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
