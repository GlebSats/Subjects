using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Subjects
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private SubjectManager subjectManager = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Open connection to the database
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SubjectsDB"].ConnectionString);
            try
            {
                sqlConnection.Open();
            }
            catch 
            {
                MessageBox.Show("Сonnection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            subjectManager = new SubjectManager(sqlConnection); // Create SubjectManager class instance
            listBox.DataSource = subjectManager.subjectList; // Binding subjectList to listBox
        }
        // Add button event
        private void addButton_Click(object sender, EventArgs e)
        {
            AddSubjectForm addSubject = new AddSubjectForm(subjectManager);
            addSubject.ShowDialog();
        }
        // Edit button event
        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Subject subjectToEdit = (Subject)listBox.SelectedItem;
                EditSubjectForm editSubject = new EditSubjectForm(subjectManager, subjectToEdit.Name);
                editSubject.ShowDialog();
            }  
        }
        // Delete button event
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Subject subjectToDelete = (Subject)listBox.SelectedItem;
                subjectManager.deleteSubject(subjectToDelete);
            }
        }
        // Binding labels to subject parameters
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Subject subject = (Subject)listBox.SelectedItem;
                nameLabel.Text = subject.Name;
                addressLabel.Text = subject.Address;
                phoneLabel.Text = subject.PhoneNumber;
                emailLabel.Text = subject.Email;
            }
        }
    }
}
