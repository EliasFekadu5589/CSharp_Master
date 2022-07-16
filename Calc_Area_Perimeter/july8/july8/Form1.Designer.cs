namespace july8
{
    partial class Form1
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_custName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Item_name = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(331, 312);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(144, 37);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_s);
            this.btn_submit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_submit_MouseClick);
            // 
            // lbl_custName
            // 
            this.lbl_custName.AutoSize = true;
            this.lbl_custName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custName.Location = new System.Drawing.Point(223, 41);
            this.lbl_custName.Name = "lbl_custName";
            this.lbl_custName.Size = new System.Drawing.Size(68, 23);
            this.lbl_custName.TabIndex = 1;
            this.lbl_custName.Text = "Name";
            this.lbl_custName.Click += new System.EventHandler(this.lbl_name);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(345, 44);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(144, 22);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lbl_Item_name
            // 
            this.lbl_Item_name.AutoSize = true;
            this.lbl_Item_name.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item_name.Location = new System.Drawing.Point(191, 111);
            this.lbl_Item_name.Name = "lbl_Item_name";
            this.lbl_Item_name.Size = new System.Drawing.Size(123, 23);
            this.lbl_Item_name.TabIndex = 3;
            this.lbl_Item_name.Text = "Item name:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(223, 168);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(65, 23);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(221, 246);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(67, 23);
            this.lbl_count.TabIndex = 5;
            this.lbl_count.Text = "count";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(345, 249);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(144, 22);
            this.txt_count.TabIndex = 6;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(345, 168);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(144, 22);
            this.txt_price.TabIndex = 7;
            // 
            // txt_item_name
            // 
            this.txt_item_name.Location = new System.Drawing.Point(345, 112);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.Size = new System.Drawing.Size(144, 22);
            this.txt_item_name.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_item_name);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_Item_name);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_custName);
            this.Controls.Add(this.btn_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_custName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Item_name;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_item_name;
    }
}

