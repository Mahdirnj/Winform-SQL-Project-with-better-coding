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

       public int ContID = Main.ContactID;
       public string Names, Family, Phonumbe, Email;
       
        private void frmEdit_Load(object sender, EventArgs e)
        {
            Name = Main.Name;
            Family = Main.Family;
            Phonumbe = Main.phonenumber;
            Email = Main.Email54;

            txtEditName.Text = Name;
            txtEditLast.Text = Family;
            txtEditPhone.Text = Phonumbe;
            txtEditEmail.Text = Email;
            

        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            repo.Edit(ContID,txtEditName.Text,txtEditLast.Text,txtEditPhone.Text,txtEditEmail.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
