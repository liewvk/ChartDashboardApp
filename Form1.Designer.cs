namespace ChartDashboardApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnRefreshChart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalSalesText = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalExpensesText = new System.Windows.Forms.Label();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblTotalProfitText = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblBestMonthText = new System.Windows.Forms.Label();
            this.lblBestMonth = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(347, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sales Dashboard";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(73, 81);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(193, 40);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Sample Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnRefreshChart
            // 
            this.btnRefreshChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshChart.Location = new System.Drawing.Point(279, 81);
            this.btnRefreshChart.Name = "btnRefreshChart";
            this.btnRefreshChart.Size = new System.Drawing.Size(192, 40);
            this.btnRefreshChart.TabIndex = 2;
            this.btnRefreshChart.Text = "Refresh Chart";
            this.btnRefreshChart.UseVisualStyleBackColor = true;
            this.btnRefreshChart.Click += new System.EventHandler(this.btnRefreshChart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(73, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(279, 135);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalSalesText
            // 
            this.lblTotalSalesText.AutoSize = true;
            this.lblTotalSalesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesText.Location = new System.Drawing.Point(70, 24);
            this.lblTotalSalesText.Name = "lblTotalSalesText";
            this.lblTotalSalesText.Size = new System.Drawing.Size(106, 22);
            this.lblTotalSalesText.TabIndex = 5;
            this.lblTotalSalesText.Text = "Total Sales:";
            this.lblTotalSalesText.Click += new System.EventHandler(this.lblTotalSalesText_Click);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(182, 24);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(60, 22);
            this.lblTotalSales.TabIndex = 5;
            this.lblTotalSales.Text = "$ 0.00";
            this.lblTotalSales.Click += new System.EventHandler(this.lblTotalSales_Click);
            // 
            // lblTotalExpensesText
            // 
            this.lblTotalExpensesText.AutoSize = true;
            this.lblTotalExpensesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpensesText.Location = new System.Drawing.Point(36, 85);
            this.lblTotalExpensesText.Name = "lblTotalExpensesText";
            this.lblTotalExpensesText.Size = new System.Drawing.Size(140, 22);
            this.lblTotalExpensesText.TabIndex = 5;
            this.lblTotalExpensesText.Text = "Total Expenses:";
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpenses.Location = new System.Drawing.Point(177, 85);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(65, 22);
            this.lblTotalExpenses.TabIndex = 5;
            this.lblTotalExpenses.Text = " $ 0.00";
            // 
            // lblTotalProfitText
            // 
            this.lblTotalProfitText.AutoSize = true;
            this.lblTotalProfitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfitText.Location = new System.Drawing.Point(73, 55);
            this.lblTotalProfitText.Name = "lblTotalProfitText";
            this.lblTotalProfitText.Size = new System.Drawing.Size(103, 22);
            this.lblTotalProfitText.TabIndex = 5;
            this.lblTotalProfitText.Text = "Total Profit:";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(182, 55);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(60, 22);
            this.lblTotalProfit.TabIndex = 5;
            this.lblTotalProfit.Text = "$ 0.00";
            // 
            // lblBestMonthText
            // 
            this.lblBestMonthText.AutoSize = true;
            this.lblBestMonthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestMonthText.Location = new System.Drawing.Point(70, 119);
            this.lblBestMonthText.Name = "lblBestMonthText";
            this.lblBestMonthText.Size = new System.Drawing.Size(105, 22);
            this.lblBestMonthText.TabIndex = 5;
            this.lblBestMonthText.Text = "Best Month:";
            // 
            // lblBestMonth
            // 
            this.lblBestMonth.AutoSize = true;
            this.lblBestMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestMonth.Location = new System.Drawing.Point(199, 119);
            this.lblBestMonth.Name = "lblBestMonth";
            this.lblBestMonth.Size = new System.Drawing.Size(16, 22);
            this.lblBestMonth.TabIndex = 5;
            this.lblBestMonth.Text = "-";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(21, 226);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(450, 350);
            this.dgvSales.TabIndex = 6;
            // 
            // pnlChart
            // 
            this.pnlChart.Location = new System.Drawing.Point(501, 226);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(450, 350);
            this.pnlChart.TabIndex = 7;
            this.pnlChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.lblTotalSalesText);
            this.groupBox1.Controls.Add(this.lblTotalSales);
            this.groupBox1.Controls.Add(this.lblTotalProfitText);
            this.groupBox1.Controls.Add(this.lblBestMonth);
            this.groupBox1.Controls.Add(this.lblTotalExpenses);
            this.groupBox1.Controls.Add(this.lblBestMonthText);
            this.groupBox1.Controls.Add(this.lblTotalProfit);
            this.groupBox1.Controls.Add(this.lblTotalExpensesText);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(625, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefreshChart);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart and Dashboard App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnRefreshChart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalSalesText;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalExpensesText;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblTotalProfitText;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblBestMonthText;
        private System.Windows.Forms.Label lblBestMonth;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

