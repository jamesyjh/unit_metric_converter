using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitsWindowsConverter_1
{
    enum UnitType
    {
        Length,
        Time,
        Temperature,
        Weight
    }

    public partial class UnitConversionForm : Form
    {

        private TextBox FocusedTextBox;

        // Hold references to the conversion functions themselves. This makes it easier
        // to specify which conversion belongs to which textbox.
        private Func<double, double> Convert1Into2 = Length.FeetToMeters;
        private Func<double, double> Convert2Into1 = Length.MetersToFeet;

        public UnitConversionForm()
        {
            InitializeComponent();
            FocusedTextBox = unitTextBox1;
        }

        /**
         * Automatically convert the amount entered into either textbox.
         */
        private void unitTextBox_TextChanged(Object sender, EventArgs e)
        {
            // If there is nothing in the focused text box, do nothing
            if (FocusedTextBox.Text == String.Empty)
            {
                return;
            }

            if (FocusedTextBox == unitTextBox1)
            {
                unitTextBox2.Text = Convert1Into2(Double.Parse(unitTextBox1.Text)).ToString();
            } 
            else
            {
                unitTextBox1.Text = Convert2Into1(Double.Parse(unitTextBox2.Text)).ToString();
            }  
        }
        
        /**
         * Restricts input to text boxes to only be digits, a single decimal, or the backspace key.
         */
        private void unitTextBoxRestrictInput_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Only allow digits, decimal, and backspace keys
            if (Char.IsDigit((char)e.KeyValue) || e.KeyCode == Keys.Decimal 
                || e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Back)
            {
                // If a decimal is already present in the textbox, do not allow a second
                if (textBox.Text.Contains('.') 
                    && (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod))
                {
                    e.SuppressKeyPress = true;
                }
            } 
            else
            {
                e.SuppressKeyPress = true;
            }
        }

        /**
         * Update labels and conversion function to match the specific type of units selected.
         */
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == lengthRadioButton)
            {
                Convert1Into2 = Length.FeetToMeters;
                Convert2Into1 = Length.MetersToFeet;

                unitLabel1.Text = "Feet";
                unitLabel2.Text = "Meters";
            }
            else if (sender == temperatureRadioButton)
            {
                Convert1Into2 = Temperature.FahrenheitToCelcius;
                Convert2Into1 = Temperature.CelciusToFahrenheit;

                unitLabel1.Text = "Fahrenheit";
                unitLabel2.Text = "Celcius";
            }
            else if (sender == timeRadioButton)
            {
                Convert1Into2 = Times.MinutesToHours;
                Convert2Into1 = Times.HoursToMinutes;

                unitLabel1.Text = "Minutes";
                unitLabel2.Text = "Hours";
            } 
            else // weight
            {
                Convert1Into2 = Weight.PoundsToKilograms;
                Convert2Into1 = Weight.KilogramsToPounds;

                unitLabel1.Text = "Pounds";
                unitLabel2.Text = "Kilograms";
            }

            // Reset textboxes after a unit change
            unitTextBox1.ResetText();
            unitTextBox2.ResetText();
        }

        /**
         * Clear all inputs and refocus the textbox that was most recently used.
         */
        private void clearButton_Clicked(object sender, EventArgs e)
        {
            unitTextBox1.ResetText();
            unitTextBox2.ResetText();
            FocusedTextBox.Focus();
        }

        /**
         * Append the digit/decimal clicked and refocus the textbox that was added to
         */
        private void digitButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            FocusedTextBox.Focus();
            if (!FocusedTextBox.Text.Contains('.') || button.Text != ".")
            {
                // Append the text and set the cursor to *after* the inserted text.
                FocusedTextBox.Text += button.Text;
                FocusedTextBox.Select(FocusedTextBox.Text.Length, 0);
            }
        }

        /**
         * Set this textbox as the most recently accessed.
         */
        private void textBox_Enter(object sender, EventArgs e)
        {
            FocusedTextBox = (TextBox)sender;
        }
    }
}
