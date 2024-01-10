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
    public partial class frmEdit : Form
    {
        ICantacts_Repo repo;
        public frmEdit()
        {
            InitializeComponent();
            repo = new ContactRepo();
            
        }        
        private void frmEdit_Load(object sender, EventArgs e)
        {
            txtEditName.Text = Main.Name;
            txtEditLast.Text = Main.Family;
            txtEditPhone.Text = Main.phonenumber;
            txtEditEmail.Text = Main.Email54;
        }
    }
}
