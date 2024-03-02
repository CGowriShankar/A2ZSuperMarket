namespace SuperMarketBillingSystem
{
    partial class RequestFromCashier
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
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestFromCashierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.a2ZSuperMarketDataSet8 = new SuperMarketBillingSystem.A2ZSuperMarketDataSet8();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.requestFromCashierTableAdapter = new SuperMarketBillingSystem.A2ZSuperMarketDataSet8TableAdapters.RequestFromCashierTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFromCashierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2ZSuperMarketDataSet8)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Request from cashier to update SKU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 636);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(333, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Abbreviation\'s used : SKU - Stock Keeping Unit ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.requestFromCashierBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(583, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // requestFromCashierBindingSource1
            // 
            this.requestFromCashierBindingSource1.DataMember = "RequestFromCashier";
            this.requestFromCashierBindingSource1.DataSource = this.a2ZSuperMarketDataSet8;
            // 
            // a2ZSuperMarketDataSet8
            // 
            this.a2ZSuperMarketDataSet8.DataSetName = "A2ZSuperMarketDataSet8";
            this.a2ZSuperMarketDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1193, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 35);
            this.button2.TabIndex = 38;
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
            this.button1.TabIndex = 37;
            this.button1.Text = "Admin home page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // requestFromCashierTableAdapter
            // 
            this.requestFromCashierTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 100);
            this.panel3.TabIndex = 39;
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
            // RequestFromCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "RequestFromCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestFromCashier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RequestFromCashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFromCashierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2ZSuperMarketDataSet8)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        //private A2ZSuperMarketDataSet2 a2ZSuperMarketDataSet2;
        //private System.Windows.Forms.BindingSource requestFromCashierBindingSource;
        //private A2ZSuperMarketDataSet2TableAdapters.RequestFromCashierTableAdapter requestFromCashierTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private A2ZSuperMarketDataSet8 a2ZSuperMarketDataSet8;
        private System.Windows.Forms.BindingSource requestFromCashierBindingSource1;
        private A2ZSuperMarketDataSet8TableAdapters.RequestFromCashierTableAdapter requestFromCashierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
    }
}