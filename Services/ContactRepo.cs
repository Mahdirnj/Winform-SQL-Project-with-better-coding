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
        //---------------------------------------------------------------------------------------
        public bool Delete(int ContactID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                string Query = "DELETE FROM Contacts WHERE Contact_ID=@ContactID";
                SqlCommand command = new SqlCommand(Query,connection);
                command.Parameters.AddWithValue("@ContactID", ContactID);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                connection.Close();
            }
            
        }
        //----------------------------------------------------------------------------------------
        public bool DeleteAll()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                string Query = "DELETE FROM Contacts";
                SqlCommand command = new SqlCommand(Query, connection);
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

        //-----------------------------------------------------------------------------------------

        public bool Edit(int ContactID, string name, string family, string phoneNumber, string Email)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                string Query = "UPDATE Contacts SET Name=@Name,Family=@Family,Phone_Number=@phonenum,Email=@Email  WHERE Contact_ID=@CosID";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@CosID", ContactID);
                command.Parameters.AddWithValue("@Name",name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@phonenum", phoneNumber);
                command.Parameters.AddWithValue("@Email", Email);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ix)
            { 
                return false ;
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        //-----------------------------------------------------------------------------------------------

        public bool Insert(string name, string family, string phoneNumber, string Email)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {

                string Query = "Insert Into Contacts (Name,Family,Phone_Number,Email) values (@Name,@Family,@PhoneNumber,@Email)";
                // We used parameter to protect against SQL injection
                SqlCommand command = new SqlCommand(Query, connection);
                // SQL adapter can automatically open and close connection but command cant and we should close by our self
                command.Parameters.AddWithValue("@Name", name);
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


        //------------------------------------------------------------------------------------------

        public DataTable SelectAll() // show us the table
        {
            string Query = "Select * From Contacts";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlDataAdapter Adapter = new SqlDataAdapter(Query, ConnectionString);
            DataTable Data = new DataTable();
            Adapter.Fill(Data);
            return Data;
        }


        //----------------------------------------------------------------------------------------
        public DataTable SelectRow(int ContactID)
        {
            throw new NotImplementedException();
        }
    }
}
