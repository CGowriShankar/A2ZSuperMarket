namespace SuperMarketBillingSystem
{
    partial class AdminUpdateCustomer
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.a2ZSuperMarketDataSet13 = new SuperMarketBillingSystem.A2ZSuperMarketDataSet13();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerTableAdapter1 = new SuperMarketBillingSystem.A2ZSuperMarketDataSet13TableAdapters.CustomerTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2ZSuperMarketDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1193, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 35);
            this.button2.TabIndex = 37;
            this.button2.Text = "Logout Admin";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1193, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 36;
            this.button1.Text = "Admin home page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Update customer";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(236, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 35);
            this.button3.TabIndex = 39;
            this.button3.Text = "Edit customer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(447, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 35);
            this.button4.TabIndex = 40;
            this.button4.Text = "Delete customer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.customerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(790, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(341, 237);
            this.dataGridView1.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CustID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CustID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Mobile";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mobile";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this.a2ZSuperMarketDataSet13;
            // 
            // a2ZSuperMarketDataSet13
            // 
            this.a2ZSuperMarketDataSet13.DataSetName = "A2ZSuperMarketDataSet13";
            this.a2ZSuperMarketDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(344, 524);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 35);
            this.button5.TabIndex = 42;
            this.button5.Text = "Update record";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Update mobile";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(403, 457);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource2, "CustID", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(403, 402);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 100);
            this.panel3.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(569, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "A2Z Super Market";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "AdminUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUpdateCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminUpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2ZSuperMarketDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        //private A2ZSuperMarketDataSet3 a2ZSuperMarketDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        //private A2ZSuperMarketDataSet3TableAdapters.CustomerTableAdapter customerTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
       // private A2ZSuperMarketDataSet2 a2ZSuperMarketDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        //private A2ZSuperMarketDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
       // private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
       // private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
       // private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private A2ZSuperMarketDataSet13 a2ZSuperMarketDataSet13;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private A2ZSuperMarketDataSet13TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
    }
}