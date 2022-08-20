namespace E_Inventory
{
    partial class AddProduct
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
            this.components = new System.ComponentModel.Container();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_inventoryNumber = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.clb_color = new System.Windows.Forms.CheckedListBox();
            this.gbx_size = new System.Windows.Forms.GroupBox();
            this.rbtn_large = new System.Windows.Forms.RadioButton();
            this.rbtn_medium = new System.Windows.Forms.RadioButton();
            this.rbtn_small = new System.Windows.Forms.RadioButton();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_inventoryNumber = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_userText = new System.Windows.Forms.Label();
            this.dgview_dataOutput = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedColorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbx_size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_dataOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(89, 74);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(82, 29);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_inventoryNumber
            // 
            this.lbl_inventoryNumber.AutoSize = true;
            this.lbl_inventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventoryNumber.Location = new System.Drawing.Point(89, 140);
            this.lbl_inventoryNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inventoryNumber.Name = "lbl_inventoryNumber";
            this.lbl_inventoryNumber.Size = new System.Drawing.Size(218, 29);
            this.lbl_inventoryNumber.TabIndex = 1;
            this.lbl_inventoryNumber.Text = "Inventory Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(89, 210);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(67, 29);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Date";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(89, 282);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(74, 29);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "Price";
            // 
            // clb_color
            // 
            this.clb_color.FormattingEnabled = true;
            this.clb_color.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Green",
            "Blue"});
            this.clb_color.Location = new System.Drawing.Point(95, 351);
            this.clb_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clb_color.Name = "clb_color";
            this.clb_color.Size = new System.Drawing.Size(125, 89);
            this.clb_color.TabIndex = 4;
            // 
            // gbx_size
            // 
            this.gbx_size.Controls.Add(this.rbtn_large);
            this.gbx_size.Controls.Add(this.rbtn_medium);
            this.gbx_size.Controls.Add(this.rbtn_small);
            this.gbx_size.Location = new System.Drawing.Point(268, 351);
            this.gbx_size.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_size.Name = "gbx_size";
            this.gbx_size.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_size.Size = new System.Drawing.Size(259, 97);
            this.gbx_size.TabIndex = 5;
            this.gbx_size.TabStop = false;
            this.gbx_size.Text = "Size";
            // 
            // rbtn_large
            // 
            this.rbtn_large.AutoSize = true;
            this.rbtn_large.Location = new System.Drawing.Point(173, 39);
            this.rbtn_large.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_large.Name = "rbtn_large";
            this.rbtn_large.Size = new System.Drawing.Size(63, 20);
            this.rbtn_large.TabIndex = 2;
            this.rbtn_large.TabStop = true;
            this.rbtn_large.Text = "Large";
            this.rbtn_large.UseVisualStyleBackColor = true;
            this.rbtn_large.CheckedChanged += new System.EventHandler(this.rbtn_large_CheckedChanged);
            // 
            // rbtn_medium
            // 
            this.rbtn_medium.AutoSize = true;
            this.rbtn_medium.Location = new System.Drawing.Point(83, 39);
            this.rbtn_medium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_medium.Name = "rbtn_medium";
            this.rbtn_medium.Size = new System.Drawing.Size(76, 20);
            this.rbtn_medium.TabIndex = 1;
            this.rbtn_medium.TabStop = true;
            this.rbtn_medium.Text = "Medium";
            this.rbtn_medium.UseVisualStyleBackColor = true;
            this.rbtn_medium.CheckedChanged += new System.EventHandler(this.rbtn_medium_CheckedChanged);
            // 
            // rbtn_small
            // 
            this.rbtn_small.AutoSize = true;
            this.rbtn_small.Location = new System.Drawing.Point(8, 39);
            this.rbtn_small.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtn_small.Name = "rbtn_small";
            this.rbtn_small.Size = new System.Drawing.Size(62, 20);
            this.rbtn_small.TabIndex = 0;
            this.rbtn_small.TabStop = true;
            this.rbtn_small.Text = "Small";
            this.rbtn_small.UseVisualStyleBackColor = true;
            this.rbtn_small.CheckedChanged += new System.EventHandler(this.rbtn_small_CheckedChanged);
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Location = new System.Drawing.Point(167, 213);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(265, 22);
            this.dtp_date.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(184, 74);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(265, 26);
            this.txt_name.TabIndex = 7;
            // 
            // txt_inventoryNumber
            // 
            this.txt_inventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inventoryNumber.Location = new System.Drawing.Point(332, 140);
            this.txt_inventoryNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_inventoryNumber.Name = "txt_inventoryNumber";
            this.txt_inventoryNumber.Size = new System.Drawing.Size(265, 26);
            this.txt_inventoryNumber.TabIndex = 8;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(175, 282);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(265, 26);
            this.txt_price.TabIndex = 9;
            // 
            // lbl_userText
            // 
            this.lbl_userText.AutoSize = true;
            this.lbl_userText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userText.Location = new System.Drawing.Point(931, 63);
            this.lbl_userText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userText.Name = "lbl_userText";
            this.lbl_userText.Size = new System.Drawing.Size(93, 39);
            this.lbl_userText.TabIndex = 10;
            this.lbl_userText.Text = "User";
            // 
            // dgview_dataOutput
            // 
            this.dgview_dataOutput.AutoGenerateColumns = false;
            this.dgview_dataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_dataOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.inventoryNumberDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.selectedColorsDataGridViewTextBoxColumn,
            this.selectedSizeDataGridViewTextBoxColumn});
            this.dgview_dataOutput.DataSource = this.productBindingSource;
            this.dgview_dataOutput.Location = new System.Drawing.Point(95, 486);
            this.dgview_dataOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgview_dataOutput.Name = "dgview_dataOutput";
            this.dgview_dataOutput.RowHeadersWidth = 51;
            this.dgview_dataOutput.Size = new System.Drawing.Size(938, 133);
            this.dgview_dataOutput.TabIndex = 11;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(631, 420);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 28);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(772, 420);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 28);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(913, 420);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 28);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // inventoryNumberDataGridViewTextBoxColumn
            // 
            this.inventoryNumberDataGridViewTextBoxColumn.DataPropertyName = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.HeaderText = "InventoryNumber";
            this.inventoryNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inventoryNumberDataGridViewTextBoxColumn.Name = "inventoryNumberDataGridViewTextBoxColumn";
            this.inventoryNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // selectedColorsDataGridViewTextBoxColumn
            // 
            this.selectedColorsDataGridViewTextBoxColumn.DataPropertyName = "SelectedColors";
            this.selectedColorsDataGridViewTextBoxColumn.HeaderText = "SelectedColors";
            this.selectedColorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.selectedColorsDataGridViewTextBoxColumn.Name = "selectedColorsDataGridViewTextBoxColumn";
            this.selectedColorsDataGridViewTextBoxColumn.Width = 125;
            // 
            // selectedSizeDataGridViewTextBoxColumn
            // 
            this.selectedSizeDataGridViewTextBoxColumn.DataPropertyName = "SelectedSize";
            this.selectedSizeDataGridViewTextBoxColumn.HeaderText = "SelectedSize";
            this.selectedSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.selectedSizeDataGridViewTextBoxColumn.Name = "selectedSizeDataGridViewTextBoxColumn";
            this.selectedSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(E_Inventory.Product);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1127, 674);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgview_dataOutput);
            this.Controls.Add(this.lbl_userText);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_inventoryNumber);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.gbx_size);
            this.Controls.Add(this.clb_color);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_inventoryNumber);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.gbx_size.ResumeLayout(false);
            this.gbx_size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_dataOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_inventoryNumber;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.CheckedListBox clb_color;
        private System.Windows.Forms.GroupBox gbx_size;
        private System.Windows.Forms.RadioButton rbtn_large;
        private System.Windows.Forms.RadioButton rbtn_medium;
        private System.Windows.Forms.RadioButton rbtn_small;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_inventoryNumber;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_userText;
        private System.Windows.Forms.DataGridView dgview_dataOutput;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedColorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}