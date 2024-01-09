// Ignore Spelling: Winform SQL

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Winform_SQL_Project
{
    class ContactRepo : ICantacts_Repo
    {
        private readonly string ConnectionString = "server=(localdb)\\localhost;database=Contact_DB;integrated security=true";
        public bool Delete(int ContactID)
        {
            throw new NotImplementedException();
        }

        public DataTable DeleteAll()
        {
            string Query = "DELETE FROM Contacts";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter Adaptor = new SqlDataAdapter(Query, ConnectionString);
            DataTable data = new DataTable();
            Adaptor.Fill(data);
            return data;
        }

        public bool insert(string name, string family, string phoneNumber, string Email)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                
                string Query = "Insert Into Contacts (Name,Family,Phone_Number,Email) values (@Name,@Family,@PhoneNumber,@Email)";
                // We used parameter to protect against SQL injection
                SqlCommand command = new SqlCommand(Query, connection);
                // SQL adapter can automatically open and close connection but command cant and we should close by our self
                command.Parameters.AddWithValue("@Name",name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Email", Email);
                connection.Open();
                command.ExecuteNonQuery();
                
                return true;
            }
            catch (Exception ix)
            {

                return false;
                
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectAll()
        {
            string Query = "Select * From Contacts";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlDataAdapter Adapter = new SqlDataAdapter(Query, ConnectionString);
            DataTable Data = new DataTable();
            Adapter.Fill(Data);
            return Data;
        }

        public DataTable SelectRow(int ContactID)
        {
            throw new NotImplementedException();
        }

        public bool Update(int ContactID, string name, string family, string phoneNumber, string Email)
        {
            throw new NotImplementedException();
        }
    }
}
