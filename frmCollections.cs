using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CollectionLab_Project
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class FrmCollections : Form
    {
        // class-level constants
        private const int MAX_ELEMENTS = 17;
        private const int MIN_VALUE = -1217;
        private const int MAX_VALUE = 1217;

        // class-level collection
        private int[] numbers = new int[MAX_ELEMENTS];
        private int currentCount = 0;
        private object btnAddNumber;

        public FrmCollections()
        {
            InitializeComponent();

            // Set desired sizes
            rtbCollection.Size = new Size(400, 250);
            rtbStats.Size = new Size(400, 200);

            // Attach event handlers
            btnAdd.Click += BtnAdd_Click;
            btnStatistics.Click += BtnStatistics_Click;
            btnReset.Click += BtnReset_Click;
            btnExit.Click += BtnExit_Click;
            txtNumber.TextChanged += TxtNumber_TextChanged;
            rtbStats.TextChanged += rtbStats_TextChanged_1;
        }

        // Add Number button handler
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            rtbCollection.Clear();
            rtbStats.Clear();

            string input = txtNumber.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                ShowError("Input is empty. Please enter a number between -1217 and 1217.");
                txtNumber.Text = "";
                return;
            }

            if (!int.TryParse(input, out int value))
            {
                ShowError("Invalid input. Please enter a valid number (no decimals).");
                txtNumber.Text = "";
                return;
            }

            if (value < MIN_VALUE)
            {
                ShowError($"Value Out Of Range: {value} is too small (minimum {MIN_VALUE}).");
                txtNumber.Text = "";
                return;
            }

            if (value > MAX_VALUE)
            {
                ShowError($"Value Out Of Range: {value} is too big (maximum {MAX_VALUE}).");
                txtNumber.Text = "";
                return;
            }

            if (currentCount >= MAX_ELEMENTS)
            {
                ShowError("Collection Full Error: Cannot add more than 17 numbers.");
                txtNumber.Text = "";
                return;
            }

            numbers[currentCount] = value;
            currentCount++;

            txtNumber.Text = "";
            rtbCollection.Clear();
            rtbStats.Clear();
            rtbStats.Text = $"Number added. {MAX_ELEMENTS - currentCount} slots remaining.";
        }

        // Statistics button handler
        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            rtbCollection.Clear();
            rtbStats.Clear();

            if (currentCount == 0)
            {
                rtbStats.Text = "No numbers in the collection. Please add numbers before requesting statistics.";
                return;
            }

            // Display collection, one number per line
            for (int i = 0; i < currentCount; i++)
            {
                rtbCollection.AppendText(numbers[i].ToString() + Environment.NewLine);
            }

            // Compute sum, min, max
            long sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < currentCount; i++)
            {
                int val = numbers[i];
                sum += val;
                if (val < min) min = val;
                if (val > max) max = val;
            }

            double average = (double)sum / currentCount;

            rtbStats.AppendText($"Average: {average:F4}" + Environment.NewLine);
            rtbStats.AppendText($"High Number: {max}" + Environment.NewLine);
            rtbStats.AppendText($"Low Number: {min}" + Environment.NewLine);
            rtbStats.AppendText($"Count: {currentCount}" + Environment.NewLine);

            // Median
            try
            {
                double median = CalculateMedian();
                rtbStats.AppendText($"Median: {median:F4}" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                rtbStats.AppendText("Median Error: " + ex.Message + Environment.NewLine);
            }

            // After displaying, clear the collection and textbox per spec (ready to start over)
            ClearCollection();
            txtNumber.Text = "";
        }

        // Reset button handler
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearCollection();
            rtbCollection.Clear();
            rtbStats.Clear();
            rtbStats.Text = "Collection cleared.";
            txtNumber.Text = "";
        }

        // Exit button handler
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Text changed handler
        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {
            // Implementation goes here, or leave empty if not needed yet
        }

        private void rtbStats_TextChanged_1(object sender, EventArgs e)
        {
            // Your logic here
        }

        // Helper to display error messages in Stats box
        private void ShowError(string message)
        {
            rtbStats.Text = "Error: " + message;
        }

        // Clears the internal collection and resets counter
        private void ClearCollection()
        {
            currentCount = 0;
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = 0;
        }

        // Median calculation
        private double CalculateMedian()
        {
            if (currentCount == 0)
                throw new InvalidOperationException("No elements to calculate median.");

            int[] sorted = new int[currentCount];
            Array.Copy(numbers, sorted, currentCount);
            Array.Sort(sorted);

            if (currentCount % 2 == 1)
            {
                return sorted[currentCount / 2];
            }
            else
            {
                int mid1 = sorted[(currentCount / 2) - 1];
                int mid2 = sorted[currentCount / 2];
                return (mid1 + mid2) / 2.0;
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}