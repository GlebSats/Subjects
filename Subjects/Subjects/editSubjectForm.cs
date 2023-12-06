using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subjects
{
    public partial class EditSubjectForm : Form
    {
        private SubjectManager subjectManager;
        public EditSubjectForm(SubjectManager subjectManager, string nameToEdit)
        {
            InitializeComponent();
            this.subjectManager = subjectManager;  
            editNameLabel.Text = nameToEdit;
        }
        // Cleaning help string of address
        private void editAddrTextBox_Enter(object sender, EventArgs e)
        {
            editAddrTextBox.Text = string.Empty;
        }
        // Ok button event
        private void editOkButton_Click(object sender, EventArgs e)
        {
            try
            {
                subjectManager.editSubject(editNameLabel.Text, editAddrTextBox.Text, editPNTextBox.Text, editMailTextBox.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
