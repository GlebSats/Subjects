namespace Subjects
{
    partial class EditSubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSubjectForm));
            this.editMailTextBox = new System.Windows.Forms.TextBox();
            this.editPNTextBox = new System.Windows.Forms.TextBox();
            this.editAddrTextBox = new System.Windows.Forms.TextBox();
            this.editOkButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // editMailTextBox
            // 
            this.editMailTextBox.Location = new System.Drawing.Point(117, 220);
            this.editMailTextBox.Name = "editMailTextBox";
            this.editMailTextBox.Size = new System.Drawing.Size(189, 20);
            this.editMailTextBox.TabIndex = 26;
            // 
            // editPNTextBox
            // 
            this.editPNTextBox.Location = new System.Drawing.Point(117, 197);
            this.editPNTextBox.Name = "editPNTextBox";
            this.editPNTextBox.Size = new System.Drawing.Size(189, 20);
            this.editPNTextBox.TabIndex = 25;
            // 
            // editAddrTextBox
            // 
            this.editAddrTextBox.Location = new System.Drawing.Point(117, 174);
            this.editAddrTextBox.Name = "editAddrTextBox";
            this.editAddrTextBox.Size = new System.Drawing.Size(189, 20);
            this.editAddrTextBox.TabIndex = 24;
            this.editAddrTextBox.Text = "Street,House number, City";
            this.editAddrTextBox.Enter += new System.EventHandler(this.editAddrTextBox_Enter);
            // 
            // editOkButton
            // 
            this.editOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editOkButton.Location = new System.Drawing.Point(117, 279);
            this.editOkButton.Name = "editOkButton";
            this.editOkButton.Size = new System.Drawing.Size(103, 34);
            this.editOkButton.TabIndex = 22;
            this.editOkButton.Text = "OK";
            this.editOkButton.UseVisualStyleBackColor = true;
            this.editOkButton.Click += new System.EventHandler(this.editOkButton_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Phone number:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Address:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 103);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // editNameLabel
            // 
            this.editNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editNameLabel.Location = new System.Drawing.Point(114, 148);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(192, 23);
            this.editNameLabel.TabIndex = 27;
            this.editNameLabel.Text = "label1";
            // 
            // EditSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 321);
            this.Controls.Add(this.editNameLabel);
            this.Controls.Add(this.editMailTextBox);
            this.Controls.Add(this.editPNTextBox);
            this.Controls.Add(this.editAddrTextBox);
            this.Controls.Add(this.editOkButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Subject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editMailTextBox;
        private System.Windows.Forms.TextBox editPNTextBox;
        private System.Windows.Forms.TextBox editAddrTextBox;
        private System.Windows.Forms.Button editOkButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label editNameLabel;
    }
}