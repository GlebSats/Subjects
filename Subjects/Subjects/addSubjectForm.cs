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
    public partial class AddSubjectForm : Form
    {
        private SubjectManager subjectManager;
        public AddSubjectForm(SubjectManager subjectManager)
        {
            InitializeComponent();
            this.subjectManager = subjectManager;
        }
        // Cleaning help string of address 
        private void addAddrTextBox_Enter(object sender, EventArgs e)
        {
            addAddrTextBox.Text = string.Empty;
        }
        // Ok button event
        private void addOkButton_Click(object sender, EventArgs e)
        {
            try
            {
                subjectManager.addSubject(addNameTextBox.Text, addAddrTextBox.Text, addPNTextBox.Text, addMailTextBox.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
