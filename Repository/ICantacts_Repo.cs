using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;

namespace Winform_SQL_Project
{
    interface ICantacts_Repo
    {
        DataTable SelectAll();
        DataTable SelectRow(int ContactID);
        DataTable DeleteAll();
        bool insert(string name , string family , string phoneNumber , string Email);
        bool Delete(int ContactID);
        bool Update(int ContactID , string name, string family, string phoneNumber, string Email );
    }
}
