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
        DataTable Search(string Parameter);
        bool DeleteAll();
        bool Insert(string name , string family , string phoneNumber , string Email);
        bool Delete(int ContactID);
        bool Edit(int ContactID , string name, string family, string phoneNumber, string Email );
    }
}
