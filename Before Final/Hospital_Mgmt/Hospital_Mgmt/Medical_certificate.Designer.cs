namespace Hospital_Mgmt
{
    partial class Medical_certificate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Patient_Name = new System.Windows.Forms.Label();
            this.lbl_Doc_Name = new System.Windows.Forms.Label();
            this.lbl_Medicine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Patient_Name
            // 
            this.lbl_Patient_Name.AutoSize = true;
            this.lbl_Patient_Name.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patient_Name.Location = new System.Drawing.Point(167, 50);
            this.lbl_Patient_Name.Name = "lbl_Patient_Name";
            this.lbl_Patient_Name.Size = new System.Drawing.Size(103, 21);
            this.lbl_Patient_Name.TabIndex = 0;
            this.lbl_Patient_Name.Text = "Pat_Name";
            this.lbl_Patient_Name.Click += new System.EventHandler(this.lbl_Patient_Name_Click);
            // 
            // lbl_Doc_Name
            // 
            this.lbl_Doc_Name.AutoSize = true;
            this.lbl_Doc_Name.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doc_Name.Location = new System.Drawing.Point(167, 92);
            this.lbl_Doc_Name.Name = "lbl_Doc_Name";
            this.lbl_Doc_Name.Size = new System.Drawing.Size(110, 21);
            this.lbl_Doc_Name.TabIndex = 1;
            this.lbl_Doc_Name.Text = "Doc_Name";
            // 
            // lbl_Medicine
            // 
            this.lbl_Medicine.AutoSize = true;
            this.lbl_Medicine.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Medicine.Location = new System.Drawing.Point(167, 140);
            this.lbl_Medicine.Name = "lbl_Medicine";
            this.lbl_Medicine.Size = new System.Drawing.Size(95, 21);
            this.lbl_Medicine.TabIndex = 2;
            this.lbl_Medicine.Text = "Medicine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "#*# Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medication:";
            // 
            // Medical_certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Medicine);
            this.Controls.Add(this.lbl_Doc_Name);
            this.Controls.Add(this.lbl_Patient_Name);
            this.Name = "Medical_certificate";
            this.Size = new System.Drawing.Size(286, 189);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Patient_Name;
        private System.Windows.Forms.Label lbl_Doc_Name;
        private System.Windows.Forms.Label lbl_Medicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
