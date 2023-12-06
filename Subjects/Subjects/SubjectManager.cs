using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.Common;

namespace Subjects
{
    public class SubjectManager // Manage subject class
    {
        public BindingList<Subject> subjectList { get; set; } // List of Subjects
        private SqlConnection connection = null;
        public SubjectManager(SqlConnection connection)
        {
            subjectList = new BindingList<Subject>();
            this.connection = connection;
            // Import data from database
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Address, PhoneNumber, Email FROM Subjects", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                Subject subject = new Subject(row["Name"].ToString(), row["Address"].ToString(), row["PhoneNumber"].ToString(), row["Email"].ToString());
                subjectList.Add(subject);
            }
        }
        public void addSubject(string name, string address, string phone, string email)
        {
            if (subjectList.Any(s => s.Name == name)) 
            {
                throw new ArgumentException("A subject with the same name already exists");
            }
            if (name.Length < 2)
            {
                throw new ArgumentException("The name is too short");
            }
            if (!isValidAddress(address))
            {
                throw new ArgumentException("Incorrect address format");
            }
            if (!isValidPhone(phone))
            {
                throw new ArgumentException("Incorrect phone number format");
            }
            if (!isValidEMail(email))
            {
                throw new ArgumentException("Incorrect email format");
            }
            // Add subject to the list 
            Subject subject = new Subject(name, address, phone, email);
            subjectList.Add(subject);
            // Add subject to the database
            SqlCommand addCommand = new SqlCommand(
                $"INSERT INTO [Subjects] (Name, Address, PhoneNumber, Email) VALUES (@Name, @Address, @PhoneNumber, @Email)",
                connection);
            addCommand.Parameters.AddWithValue("Name", name);
            addCommand.Parameters.AddWithValue("Address", address);
            addCommand.Parameters.AddWithValue("PhoneNumber", phone);
            addCommand.Parameters.AddWithValue("Email", email);
            addCommand.ExecuteNonQuery();
        }
        public void editSubject(string name, string address, string phone, string email) 
        {
            if (!isValidAddress(address))
            {
                throw new ArgumentException("Incorrect address format");
            }
            if (!isValidPhone(phone))
            {
                throw new ArgumentException("Incorrect phone number format");
            }
            if (!isValidEMail(email))
            {
                throw new ArgumentException("Incorrect email format");
            }
            // Edit subject in the list
            Subject subjectToEdit = subjectList.FirstOrDefault(s => s.Name == name);
            subjectToEdit.Address = address;
            subjectToEdit.PhoneNumber = phone;
            subjectToEdit.Email = email;
            // Edit subject in the database
            SqlCommand editCommand = new SqlCommand(
                $"UPDATE Subjects SET Address = @Address, PhoneNumber = @PhoneNumber, Email=@Email WHERE Name = @Name",
                connection);
            editCommand.Parameters.AddWithValue("Name", name);
            editCommand.Parameters.AddWithValue("Address", address);
            editCommand.Parameters.AddWithValue("PhoneNumber", phone);
            editCommand.Parameters.AddWithValue("Email", email);
            editCommand.ExecuteNonQuery();
        }
        public void deleteSubject(Subject subject)
        {
            // Delete subject from the list
            subjectList.Remove(subject);
            // Delete subject from the database
            SqlCommand deleteCommand = new SqlCommand(
                "DELETE FROM Subjects WHERE Name = @Name",
                connection);
            deleteCommand.Parameters.AddWithValue("Name", subject.Name);
            deleteCommand.ExecuteNonQuery();
        }
        private bool isValidAddress(string address) // Address check
        {
            if (Regex.IsMatch(address, @"^.{3,},(?!0$)\d+,.{3,}$"))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        private bool isValidEMail(string email) // Mail check
        {
            try
            {
                var temp = new System.Net.Mail.MailAddress(email);
                return temp.Address.Equals(email);
            }
            catch 
            {
                return false;
            }
        }
        private bool isValidPhone(string phone) // Phone number check
        {
            if (phone.Length < 3)
            {
                return false;
            }

            if (Regex.IsMatch(phone, @"^[+]?[0-9]+$"))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
