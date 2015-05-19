namespace Assignment4
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkButton = new System.Windows.Forms.Button();
            this.serviceList = new System.Windows.Forms.ComboBox();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.statusbox = new System.Windows.Forms.RichTextBox();
            this.statuslabel = new System.Windows.Forms.Label();
            this.urllabel = new System.Windows.Forms.Label();
            this.selectlabel = new System.Windows.Forms.Label();
            this.sortlabel = new System.Windows.Forms.Label();
            this.urlbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(728, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 341);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(35, 12);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(148, 39);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Connect to web services (Northwind)";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // serviceList
            // 
            this.serviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceList.FormattingEnabled = true;
            this.serviceList.Location = new System.Drawing.Point(223, 127);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(197, 21);
            this.serviceList.TabIndex = 4;
            this.serviceList.SelectedIndexChanged += new System.EventHandler(this.serviceList_SelectedIndexChanged);
            // 
            // categoryList
            // 
            this.categoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(506, 128);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(202, 21);
            this.categoryList.TabIndex = 5;
            this.categoryList.SelectedIndexChanged += new System.EventHandler(this.categoryList_SelectedIndexChanged);
            // 
            // statusbox
            // 
            this.statusbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbox.Location = new System.Drawing.Point(285, 12);
            this.statusbox.Name = "statusbox";
            this.statusbox.ReadOnly = true;
            this.statusbox.Size = new System.Drawing.Size(559, 39);
            this.statusbox.TabIndex = 6;
            this.statusbox.Text = "";
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Location = new System.Drawing.Point(219, 20);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(60, 20);
            this.statuslabel.TabIndex = 7;
            this.statuslabel.Text = "Status:";
            // 
            // urllabel
            // 
            this.urllabel.AutoSize = true;
            this.urllabel.Location = new System.Drawing.Point(14, 83);
            this.urllabel.Name = "urllabel";
            this.urllabel.Size = new System.Drawing.Size(203, 13);
            this.urllabel.TabIndex = 8;
            this.urllabel.Text = "Get Data from (any) service through URL:";
            // 
            // selectlabel
            // 
            this.selectlabel.AutoSize = true;
            this.selectlabel.Location = new System.Drawing.Point(113, 133);
            this.selectlabel.Name = "selectlabel";
            this.selectlabel.Size = new System.Drawing.Size(104, 13);
            this.selectlabel.TabIndex = 10;
            this.selectlabel.Text = "(OR) Select Service:";
            // 
            // sortlabel
            // 
            this.sortlabel.AutoSize = true;
            this.sortlabel.Location = new System.Drawing.Point(456, 133);
            this.sortlabel.Name = "sortlabel";
            this.sortlabel.Size = new System.Drawing.Size(44, 13);
            this.sortlabel.TabIndex = 11;
            this.sortlabel.Text = "Sort By:";
            // 
            // urlbox
            // 
            this.urlbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.urlbox.Location = new System.Drawing.Point(223, 80);
            this.urlbox.Name = "urlbox";
            this.urlbox.ReadOnly = true;
            this.urlbox.Size = new System.Drawing.Size(485, 20);
            this.urlbox.TabIndex = 12;
            this.urlbox.TextChanged += new System.EventHandler(this.urlbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 538);
            this.Controls.Add(this.urlbox);
            this.Controls.Add(this.sortlabel);
            this.Controls.Add(this.selectlabel);
            this.Controls.Add(this.urllabel);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.serviceList);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Connect to webservice (Northwind)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.ComboBox serviceList;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.RichTextBox statusbox;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label urllabel;
        private System.Windows.Forms.Label selectlabel;
        private System.Windows.Forms.Label sortlabel;
        private System.Windows.Forms.TextBox urlbox;
    }
}

