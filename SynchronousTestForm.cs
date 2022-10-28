using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciSynchronous
{
    public partial class SynchronousTestForm : Form
    {
        public SynchronousTestForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "Calculating Fibonacci(46)\r\n";
            outputTextBox.Refresh();
            DateTime startTime1 = DateTime.Now;
            long result1 = Fibonacci(46);
            DateTime endTime1 = DateTime.Now;

            outputTextBox.AppendText($"Fibonacci(46) = {result1}\r\n");
            double minutes = (endTime1 - startTime1).TotalMinutes;
            outputTextBox.AppendText($"Calculation time = {minutes:F6} minutes\r\n");

            outputTextBox.AppendText("Calculating Fibonacci(45)\r\n");
            outputTextBox.Refresh();
            DateTime startTime2 = DateTime.Now;
            long result2 = Fibonacci(45);
            DateTime endTime2 = DateTime.Now;

            outputTextBox.AppendText($"Fibonacci(45) = {result2}\r\n");
            minutes = (endTime2 - startTime2).TotalMinutes;
            outputTextBox.AppendText($"Calculating time = {minutes:F6} minutes\r\n\r\n");

            double totalMinutes = (endTime2 - startTime2).TotalMinutes;
            outputTextBox.AppendText($"Total calculation time = {totalMinutes:F6} minutes\r\n");
        }

        // Calculates nth Fibonacci number recursively
        public long Fibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
