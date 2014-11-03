using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Lesson09
{
    public partial class SummaryForm : Form
    {
        //Class level variables
        private decimal totalSalesDecimal, averageSalesDecimal;
        private int numberOfSalesInteger;

        public SummaryForm()
        {
            InitializeComponent();
        }

        //define the Property for total sales
        public decimal totalSales
        {
            set
            {
                totalSalesDecimal = value;
            }
        }

        public decimal averageSales
        {
            set
            {
                averageSalesDecimal = value;
            }
        }

        public int numberOfSales
        {
            set
            {
                numberOfSalesInteger = value;
            }
        }

        private void SummaryForm_Activated(object sender, EventArgs e)
        {
            //display the information
            totalSalexTextBox.Text = totalSalesDecimal.ToString("c");
            averageSalesTextBox.Text = averageSalesDecimal.ToString("c");
            numberCustomersTextBox.Text = numberOfSalesInteger.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
