namespace Subjects
{
    partial class AddSubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubjectForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addOkButton = new System.Windows.Forms.Button();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.addAddrTextBox = new System.Windows.Forms.TextBox();
            this.addPNTextBox = new System.Windows.Forms.TextBox();
            this.addMailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(11, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone number:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name:";
            // 
            // addOkButton
            // 
            this.addOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOkButton.Location = new System.Drawing.Point(116, 283);
            this.addOkButton.Name = "addOkButton";
            this.addOkButton.Size = new System.Drawing.Size(103, 34);
            this.addOkButton.TabIndex = 12;
            this.addOkButton.Text = "OK";
            this.addOkButton.UseVisualStyleBackColor = true;
            this.addOkButton.Click += new System.EventHandler(this.addOkButton_Click);
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(116, 155);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.addNameTextBox.TabIndex = 13;
            // 
            // addAddrTextBox
            // 
            this.addAddrTextBox.Location = new System.Drawing.Point(116, 178);
            this.addAddrTextBox.Name = "addAddrTextBox";
            this.addAddrTextBox.Size = new System.Drawing.Size(189, 20);
            this.addAddrTextBox.TabIndex = 14;
            this.addAddrTextBox.Text = "Street,House number, City";
            this.addAddrTextBox.Enter += new System.EventHandler(this.addAddrTextBox_Enter);
            // 
            // addPNTextBox
            // 
            this.addPNTextBox.Location = new System.Drawing.Point(116, 201);
            this.addPNTextBox.Name = "addPNTextBox";
            this.addPNTextBox.Size = new System.Drawing.Size(189, 20);
            this.addPNTextBox.TabIndex = 15;
            // 
            // addMailTextBox
            // 
            this.addMailTextBox.Location = new System.Drawing.Point(116, 224);
            this.addMailTextBox.Name = "addMailTextBox";
            this.addMailTextBox.Size = new System.Drawing.Size(189, 20);
            this.addMailTextBox.TabIndex = 16;
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 321);
            this.Controls.Add(this.addMailTextBox);
            this.Controls.Add(this.addPNTextBox);
            this.Controls.Add(this.addAddrTextBox);
            this.Controls.Add(this.addNameTextBox);
            this.Controls.Add(this.addOkButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Subject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addOkButton;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.TextBox addAddrTextBox;
        private System.Windows.Forms.TextBox addPNTextBox;
        private System.Windows.Forms.TextBox addMailTextBox;
    }
}