using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartDashboardApp
{
    public partial class Form1 : Form
    {
        private DataTable salesTable = new DataTable();

        private void AddSalesRecord(string month, decimal sales, decimal expenses)
        {
            decimal profit = sales - expenses;

            salesTable.Rows.Add(month, sales, expenses, profit);
        }
        private void UpdateDashboard()
        {
            decimal totalSales = 0;
            decimal totalExpenses = 0;
            decimal totalProfit = 0;

            string bestMonth = "-";
            decimal highestSales = 0;

            foreach (DataRow row in salesTable.Rows)
            {
                decimal sales = Convert.ToDecimal(row["Sales"]);
                decimal expenses = Convert.ToDecimal(row["Expenses"]);
                decimal profit = Convert.ToDecimal(row["Profit"]);

                totalSales += sales;
                totalExpenses += expenses;
                totalProfit += profit;

                if (sales > highestSales)
                {
                    highestSales = sales;
                    bestMonth = row["Month"].ToString();
                }
            }

            lblTotalSales.Text = $"RM {totalSales:0.00}";
            lblTotalExpenses.Text = $"RM {totalExpenses:0.00}";
            lblTotalProfit.Text = $"RM {totalProfit:0.00}";
            lblBestMonth.Text = bestMonth;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void lblTotalSales_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalSalesText_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            salesTable.Columns.Add("Month", typeof(string));
            salesTable.Columns.Add("Sales", typeof(decimal));
            salesTable.Columns.Add("Expenses", typeof(decimal));
            salesTable.Columns.Add("Profit", typeof(decimal));

            dgvSales.DataSource = salesTable;

            dgvSales.Columns["Sales"].DefaultCellStyle.Format = "0.00";
            dgvSales.Columns["Expenses"].DefaultCellStyle.Format = "0.00";
            dgvSales.Columns["Profit"].DefaultCellStyle.Format = "0.00";

            pnlChart.Paint += pnlChart_Paint;

            UpdateDashboard();

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            salesTable.Rows.Clear();

            AddSalesRecord("January", 12000m, 7000m);
            AddSalesRecord("February", 15000m, 8500m);
            AddSalesRecord("March", 18000m, 9000m);
            AddSalesRecord("April", 14000m, 7800m);
            AddSalesRecord("May", 22000m, 11000m);
            AddSalesRecord("June", 20000m, 10500m);

            UpdateDashboard();

            pnlChart.Invalidate();

            MessageBox.Show("Sample sales data loaded successfully.",
                            "Data Loaded",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }

        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);

            if (salesTable.Rows.Count == 0)
            {
                g.DrawString("No data to display.",
                             new Font("Segoe UI", 12, FontStyle.Bold),
                             Brushes.Gray,
                             20,
                             20);

                return;
            }

            decimal highestSales = 0;

            foreach (DataRow row in salesTable.Rows)
            {
                decimal sales = Convert.ToDecimal(row["Sales"]);

                if (sales > highestSales)
                {
                    highestSales = sales;
                }
            }

            if (highestSales == 0)
            {
                return;
            }

            int chartLeft = 50;
            int chartTop = 40;
            int chartWidth = pnlChart.Width - 80;
            int chartHeight = pnlChart.Height - 100;

            int barCount = salesTable.Rows.Count;
            int barSpacing = 15;
            int barWidth = (chartWidth / barCount) - barSpacing;

            if (barWidth < 20)
            {
                barWidth = 20;
            }

            Pen axisPen = new Pen(Color.Black, 2);
            Brush barBrush = Brushes.SteelBlue;
            Brush textBrush = Brushes.Black;

            Font labelFont = new Font("Segoe UI", 8);
            Font valueFont = new Font("Segoe UI", 8, FontStyle.Bold);
            Font titleFont = new Font("Segoe UI", 11, FontStyle.Bold);

            g.DrawString("Monthly Sales Chart", titleFont, textBrush, chartLeft, 10);

            g.DrawLine(axisPen,
                       chartLeft,
                       chartTop + chartHeight,
                       chartLeft + chartWidth,
                       chartTop + chartHeight);

            g.DrawLine(axisPen,
                       chartLeft,
                       chartTop,
                       chartLeft,
                       chartTop + chartHeight);

            for (int i = 0; i < salesTable.Rows.Count; i++)
            {
                DataRow row = salesTable.Rows[i];

                string month = row["Month"].ToString();
                decimal sales = Convert.ToDecimal(row["Sales"]);

                int barHeight = (int)((sales / highestSales) * chartHeight);

                int x = chartLeft + 10 + i * (barWidth + barSpacing);
                int y = chartTop + chartHeight - barHeight;

                g.FillRectangle(barBrush, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);

                g.DrawString($"RM {sales:0}",
                             valueFont,
                             textBrush,
                             x - 5,
                             y - 20);

                g.DrawString(month.Substring(0, 3),
                             labelFont,
                             textBrush,
                             x,
                             chartTop + chartHeight + 5);
            }

        }

        private void btnRefreshChart_Click(object sender, EventArgs e)
        {
            UpdateDashboard();
            pnlChart.Invalidate();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (salesTable.Rows.Count == 0)
            {
                MessageBox.Show("There is no dashboard data to clear.",
                                "No Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to clear all dashboard data?",
                                                  "Confirm Clear",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                salesTable.Rows.Clear();

                UpdateDashboard();
                pnlChart.Invalidate();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                      "Confirm Exit",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
