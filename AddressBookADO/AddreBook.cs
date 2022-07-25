using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AddressBookADO
{
    public class AddressBook
    {
        const string connection = "Data Source=.;Initial Catalog = AddressBook; Integrated Security = True";
        SqlConnection sql = new SqlConnection(connection);
        public void AddressBookRetrieve()
        {
            string query = @"Select FirstName , LastName , Address , City , State , Zip , PhoneNumber , Email , type From Addressbook;";
            SqlCommand command = new SqlCommand(query, sql);
            Contact contact = new Contact();
            sql.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        contact.FirstName = reader.GetString(0);
                        contact.LastName = reader.GetString(1);
                        contact.Address = reader.GetString(2);
                        contact.City = reader.GetString(3);
                        contact.State = reader.GetString(4);
                        contact.Zip = Convert.ToDouble(reader.GetInt64(5));
                        contact.PhoneNumber = Convert.ToDouble(reader.GetInt64(6));
                        contact.Email = reader.GetString(7);
                        contact.type = reader.GetString(8);
                        Console.WriteLine(" First Name: " + contact.FirstName + " Last Name: " + contact.LastName + " Address: " + contact.Address
                            + " City: " + contact.City + " State : " + contact.State + " Zip: " + contact.Zip + " Phone Number: " + contact.PhoneNumber
                            + " Email: " + contact.Email + " type: " + contact.type);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void InsertContact()
        {
            string select = @"Insert into AddressbooK (FirstName ,LastName,Address,City,State,zip,PhoneNumber,Email,type) VALUES( 'Nidhi','Yadav','Jankipuram','Lucknow','Uttar Pradesh',756477,943852854728,'nidhi@gmail.com','Friend')";
            SqlCommand cmd = new SqlCommand(select, sql);
            cmd.CommandType = CommandType.Text;
            sql.Open();
            try
            {
                var con = cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sql.Close();
        }
        public void ContactByDate()
        {
            string select = @"UPDATE Addressbook SET Date = '12-11-2020' where FirstName = 'Rohal' ";
            SqlCommand command = new SqlCommand(select, sql);
            command.CommandType = CommandType.Text;
            sql.Open();
            try
            {
                var contact = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sql.Close();
        }
        public string RetrieveContactByDate()
        {
            string select = @"Select * FROM Addressbook Where date BETWEEN CAST('2019-04-10' AS date) AND ('2020-04-11')";
            SqlCommand command = new SqlCommand(select,sql);
            sql.Open();
                Contact contact = new Contact();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        contact.FirstName = reader.GetString(0);
                        contact.LastName = reader.GetString(1);
                        contact.Address = reader.GetString(2);
                        contact.City = reader.GetString(3);
                        contact.State = reader.GetString(4);
                        contact.Zip = Convert.ToDouble(reader.GetInt64(5));
                        contact.PhoneNumber = Convert.ToDouble(reader.GetInt64(6));
                        contact.Email = reader.GetString(7);
                        contact.type = reader.GetString(8);
                        Console.WriteLine(" First Name: " + contact.FirstName + " Last Name: " + contact.LastName + " Address: " + contact.Address
                            + " City: " + contact.City + " State : " + contact.State + " Zip: " + contact.Zip + " Phone Number: " + contact.PhoneNumber
                            + " Email: " + contact.Email + " type: " + contact.type);
                    }
                }
                reader.Close();
                this.sql.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return contact.FirstName;
        }
        public int RetrieveNumOfContactByCity()
        {
            string select = @"SELECT COUNT (City) FROM Addressbook where City ='Patna'";
            SqlCommand command = new SqlCommand(select, sql);
            Contact contact = new Contact();
            int count =0;
            sql.Open();
            try
            {
                count = (int)command.ExecuteScalar();
                Console.WriteLine("No Of Contact in a city: " +count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count;
        }
    }
}
