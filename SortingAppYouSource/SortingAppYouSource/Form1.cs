using System;
using System.Windows.Forms;

namespace SortingAppYouSource
{
    public partial class Form1 : Form
    {
        private StringSorter stringSorter;
        private string originalComboBoxText;
        public Form1()
        {
            InitializeComponent();
            stringSorter = new StringSorter();

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            button1.Click += button1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            label2.TextChanged += label2_Click;

            comboBox1.Items.Add("BubbleSort");
            comboBox1.Items.Add("QuickSort");
            comboBox1.Items.Add("MergeSort");

            originalComboBoxText = comboBox1.Text;
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // This event is triggered when the sort button is clicked
            // You can put your logic here to handle the button click event
            string input = textBox1.Text; // Get input from textBox1

            // Check if an item is selected in the combobox
            if (comboBox1.SelectedItem != null)
            {
                string selectedStrategy = comboBox1.SelectedItem.ToString(); // Get selected sorting strategy

                // Perform sorting operation based on selected strategy
                string sortedString = string.Empty;
                switch (selectedStrategy)
                {
                    case "BubbleSort":
                        sortedString = stringSorter.BubbleSort(input);
                        break;
                    case "QuickSort":
                        sortedString = stringSorter.QuickSort(input);
                        break;
                    case "MergeSort":
                        sortedString = stringSorter.MergeSort(input);
                        break;
                    default:
                        break;
                }

                // Update label2 with sorted string
                label2.Text = sortedString;
            }
            else
            {
                // Handle case where no item is selected in combobox
                MessageBox.Show("Please select a sorting strategy.");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset input TextBox
            textBox1.Text = string.Empty;

            // Reset output label2
            label2.Text = string.Empty;

            // Reset selected index of ComboBox
            comboBox1.SelectedIndex = -1;

            // Restore the original text of the ComboBox
            comboBox1.Text = originalComboBoxText;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            // Show the help form
            string message = @"How to Use?

1. Input: Enter a string or letters into the input textbox.
   
2. Strategy: Choose a sorting strategy from the dropdown menu (e.g., BubbleSort, QuickSort, MergeSort).

3. Sort: Click the 'Sort' button to sort the input string based on the selected strategy.

4. Output: View the sorted output in the output label.

5. Reset: Click the 'Reset' button to clear the input, output, and selected strategy.

Example:
Input: ABCDE
Strategy: BubbleSort
Output: ABCDE

Example:
Input: 53124
Strategy: QuickSort
Output: 12345";
            MessageBox.Show(message, "How to Use?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
