namespace HotelManagementSystem.hotel
{
    partial class Report
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAnnual = new System.Windows.Forms.RadioButton();
            this.rdWeekly = new System.Windows.Forms.RadioButton();
            this.rdMonthly = new System.Windows.Forms.RadioButton();
            this.rdDialy = new System.Windows.Forms.RadioButton();
            this.dataGridReport = new System.Windows.Forms.DataGridView();
            this.res_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAnnual);
            this.groupBox1.Controls.Add(this.rdWeekly);
            this.groupBox1.Controls.Add(this.rdMonthly);
            this.groupBox1.Controls.Add(this.rdDialy);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(163, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // rdAnnual
            // 
            this.rdAnnual.AutoSize = true;
            this.rdAnnual.Location = new System.Drawing.Point(319, 29);
            this.rdAnnual.Name = "rdAnnual";
            this.rdAnnual.Size = new System.Drawing.Size(89, 24);
            this.rdAnnual.TabIndex = 7;
            this.rdAnnual.TabStop = true;
            this.rdAnnual.Text = "Annually";
            this.rdAnnual.UseVisualStyleBackColor = true;
            this.rdAnnual.CheckedChanged += new System.EventHandler(this.rdAnnual_CheckedChanged);
            // 
            // rdWeekly
            // 
            this.rdWeekly.AutoSize = true;
            this.rdWeekly.Location = new System.Drawing.Point(115, 30);
            this.rdWeekly.Name = "rdWeekly";
            this.rdWeekly.Size = new System.Drawing.Size(81, 24);
            this.rdWeekly.TabIndex = 6;
            this.rdWeekly.TabStop = true;
            this.rdWeekly.Text = "Weekly";
            this.rdWeekly.UseVisualStyleBackColor = true;
            this.rdWeekly.CheckedChanged += new System.EventHandler(this.rdWeekly_CheckedChanged);
            // 
            // rdMonthly
            // 
            this.rdMonthly.AutoSize = true;
            this.rdMonthly.Location = new System.Drawing.Point(224, 30);
            this.rdMonthly.Name = "rdMonthly";
            this.rdMonthly.Size = new System.Drawing.Size(86, 24);
            this.rdMonthly.TabIndex = 5;
            this.rdMonthly.TabStop = true;
            this.rdMonthly.Text = "Monthly";
            this.rdMonthly.UseVisualStyleBackColor = true;
            this.rdMonthly.CheckedChanged += new System.EventHandler(this.rdMonthly_CheckedChanged);
            // 
            // rdDialy
            // 
            this.rdDialy.AutoSize = true;
            this.rdDialy.Location = new System.Drawing.Point(28, 30);
            this.rdDialy.Name = "rdDialy";
            this.rdDialy.Size = new System.Drawing.Size(62, 24);
            this.rdDialy.TabIndex = 4;
            this.rdDialy.TabStop = true;
            this.rdDialy.Text = "Daily";
            this.rdDialy.UseVisualStyleBackColor = true;
            this.rdDialy.CheckedChanged += new System.EventHandler(this.rdDialy_CheckedChanged);
            // 
            // dataGridReport
            // 
            this.dataGridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.res_number,
            this.Total,
            this.created_at});
            this.dataGridReport.Location = new System.Drawing.Point(163, 171);
            this.dataGridReport.Name = "dataGridReport";
            this.dataGridReport.Size = new System.Drawing.Size(428, 222);
            this.dataGridReport.TabIndex = 1;
            // 
            // res_number
            // 
            this.res_number.DataPropertyName = "res_number";
            this.res_number.HeaderText = "Reservation ID";
            this.res_number.Name = "res_number";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Date";
            this.created_at.Name = "created_at";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(472, 411);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(119, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.label5.Location = new System.Drawing.Point(423, 413);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Total";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(795, 485);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dataGridReport);
            this.Controls.Add(this.groupBox1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridReport;
        private System.Windows.Forms.RadioButton rdMonthly;
        private System.Windows.Forms.RadioButton rdDialy;
        private System.Windows.Forms.RadioButton rdAnnual;
        private System.Windows.Forms.RadioButton rdWeekly;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
    }
}