namespace SuperMarketBillingSystem
{
    partial class CashierRequestAdminToUpdateSKU
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestFromCashierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.a2ZSuperMarketDataSet6 = new SuperMarketBillingSystem.A2ZSuperMarketDataSet6();
            this.requestFromCashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestFromCashierTableAdapter = new SuperMarketBillingSystem.A2ZSuperMarketDataSet6TableAdapters.RequestFromCashierTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFromCashierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2ZSuperMarketDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFromCashierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKUBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(1197, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Home page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Request admin to update SKU!";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(609, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 35);
            this.button4.TabIndex = 33;
            this.button4.Text = "Send Request";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(655, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 32;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.requestFromCashierBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(558, 426);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(246, 165);
            this.dataGridView2.TabIndex = 34;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "Sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "Sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            this.snoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestFromCashierBindingSource1
            // 
            this.requestFromCashierBindingSource1.DataMember = "RequestFromCashier";
            this.requestFromCashierBindingSource1.DataSource = this.a2ZSuperMarketDataSet6;
            // 
            // a2ZSuperMarketDataSet6
            // 
            this.a2ZSuperMarketDataSet6.DataSetName = "A2ZSuperMarketDataSet6";
            this.a2ZSuperMarketDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestFromCashierTableAdapter
            // 
            this.requestFromCashierTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Item Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1354, 100);
            this.panel3.TabIndex = 36;
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
            // CashierRequestAdminToUpdateSKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "CashierRequestAdminToUpdateSKU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierRequestAdminToUpdateSKU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierRequestAdminToUpdateSKU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFromCashierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2ZSuperMarketDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestFromCashierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKUBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        //private A2ZSuperMarketDataSet1 a2ZSuperMarketDataSet1;
        private System.Windows.Forms.BindingSource sKUBindingSource;
        //private A2ZSuperMarketDataSet1TableAdapters.SKUTableAdapter sKUTableAdapter;
        //private A2ZSuperMarketDataSet5 a2ZSuperMarketDataSet5;
        private System.Windows.Forms.BindingSource requestFromCashierBindingSource;
        //private A2ZSuperMarketDataSet5TableAdapters.RequestFromCashierTableAdapter requestFromCashierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private A2ZSuperMarketDataSet6 a2ZSuperMarketDataSet6;
        private System.Windows.Forms.BindingSource requestFromCashierBindingSource1;
        private A2ZSuperMarketDataSet6TableAdapters.RequestFromCashierTableAdapter requestFromCashierTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
    }
}