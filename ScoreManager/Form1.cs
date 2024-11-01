using System;
using System.Windows.Forms;

namespace ScoreCalculation
{
    public partial class Form1 : Form
    {
        // Constructor for Form1
        public Form1()
        {
            InitializeComponent();
            // Display the current date in LblDate
            LblDate.Text = DateTime.Now.ToShortDateString();
            // Start the timer to update the time display
            timer1.Start();

            // Adding event handlers for text fields
            TxtLang.Enter += TxtLang_Enter; // Triggered when TxtLang gains focus
            TxtTech.Enter += TxtTech_Enter; // Triggered when TxtTech gains focus
            TxtNIC.KeyPress += TxtNIC_KeyPress; // Event to handle key presses in TxtNIC
        }

        // Timer tick event to update the current time
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update LblHour with the current time
            LblHour.Text = DateTime.Now.ToLongTimeString();
        }

        // Restrict input in TxtLang to numeric values only
        private void TxtLang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and the Backspace key
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Prevent the input of non-numeric characters
            }
        }

        // Restrict input in TxtTech to numeric values only
        private void TxtTech_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and the Backspace key
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Prevent the input of non-numeric characters
            }
        }

        // Handle key presses in TxtNIC to ensure numeric input
        private void TxtNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or the Backspace key
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Block non-numeric characters
                // Show a warning message for invalid input
                MessageBox.Show("Please enter a valid identification number ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for TxtLang when it gains focus
        private void TxtLang_Enter(object sender, EventArgs e)
        {
            // Show an informational message when focusing on TxtLang
            MessageBox.Show("Please enter a grade between 0 and 20.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for TxtTech when it gains focus
        private void TxtTech_Enter(object sender, EventArgs e)
        {
            // Show an informational message when focusing on TxtTech
            MessageBox.Show("Please enter a grade between 0 and 20.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Validate input in TxtLang when it loses focus
        private void TxtLang_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Check if the input is empty
            if (string.IsNullOrWhiteSpace(TxtLang.Text))
            {
                MessageBox.Show("You need to enter a grade."); // Prompt user to enter a grade
                e.Cancel = true; // Prevent focus from leaving the control
            }
            // Check if the input grade exceeds 20
            else if (ParseInt(TxtLang.Text) > 20)
            {
                MessageBox.Show("The grade must be between 0 and 20."); // Notify user of the invalid grade
                TxtLang.SelectAll(); // Select all text in the field for correction
                e.Cancel = true; // Prevent focus from leaving the control
            }
        }

        // Validate input in TxtTech when it loses focus
        private void TxtTech_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Check if the input is empty
            if (string.IsNullOrWhiteSpace(TxtTech.Text))
            {
                MessageBox.Show("You need to enter a grade."); // Prompt user to enter a grade
                e.Cancel = true; // Prevent focus from leaving the control
            }
            // Check if the input grade exceeds 20
            else if (ParseInt(TxtTech.Text) > 20)
            {
                MessageBox.Show("The grade must be between 0 and 20."); // Notify user of the invalid grade
                TxtTech.SelectAll(); // Select all text in the field for correction
                e.Cancel = true; // Prevent focus from leaving the control
            }
        }

        // Generate a random chance value and display it in TxtChance
        private void BtnCh_Click(object sender, EventArgs e)
        {
            Random alea = new Random(); // Create a random number generator
            int x = alea.Next(0, 16); // Generate a random number between 0 and 15
            TxtChance.Text = x.ToString(); // Convert the number to a string and display it
        }

        // Reset all fields and controls to their default values
        private void BtnIni_Click(object sender, EventArgs e)
        {
            // Clear text fields
            TxtNIC.Text = "";
            TxtTel.Text = "";
            TxtLName.Text = "";
            TxtFName.Text = "";
            TxtLang.Text = "0";
            TxtTech.Text = "0";
            TxtChance.Text = "0";
            TxtScore.Text = "0";

            // Reset radio buttons and checkboxes
            RdMas.Checked = false;
            RdFem.Checked = false;
            ChkExper.Checked = false;
            ChkMotiv.Checked = false;
            ChkDip.Checked = false;

            // Reset the age selection
            CmbAge.SelectedIndex = -1;
            BtnAdd.Enabled = false; // Disable the Add button until valid input is entered
        }

        // Calculate and display the score based on input values
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            // Check for required fields and selections
            if (string.IsNullOrWhiteSpace(TxtNIC.Text) || string.IsNullOrWhiteSpace(TxtTel.Text) ||
                string.IsNullOrWhiteSpace(TxtLName.Text) || string.IsNullOrWhiteSpace(TxtFName.Text) ||
                string.IsNullOrWhiteSpace(TxtLang.Text) || string.IsNullOrWhiteSpace(TxtTech.Text) ||
                CmbAge.SelectedIndex == -1)
            {
                MessageBox.Show("You must enter all the information."); // Prompt user to fill in all fields
                return; // Exit the method if any fields are empty
            }

            // Parse the language and technical grades
            int noteLang = ParseInt(TxtLang.Text);
            int noteTech = ParseInt(TxtTech.Text);
            int note = noteLang + noteTech; // Calculate the total of both grades

            // Determine the score based on gender selection
            int sexe = RdMas.Checked ? 7 : (RdFem.Checked ? 5 : 0);
            int bonus = 0; // Initialize bonus points
            // Add bonus points based on checkboxes
            if (ChkExper.Checked) bonus += 15;
            if (ChkMotiv.Checked) bonus += 10;
            if (ChkDip.Checked) bonus += 5;

            // Determine age bonus based on the selected age
            int age;
            switch (CmbAge.SelectedIndex)
            {
                case 0: age = 20; break; // Age group 1
                case 1: age = 10; break; // Age group 2
                case 2: age = 5; break; // Age group 3
                default: age = 0; break; // No age bonus
            }

            // Get the random chance value and calculate the final score
            int chance = ParseInt(TxtChance.Text);
            int score = note + sexe + bonus + age + chance; // Sum all components to get the final score
            TxtScore.Text = score.ToString(); // Display the score
            BtnAdd.Enabled = true; // Enable the Add button for further actions
        }

        // Add current data to the ListBox and reset fields
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Add data to respective ListBoxes
            Lst1.Items.Add(TxtNIC.Text); // Add NIC to list
            Lst2.Items.Add(TxtLName.Text); // Add last name to list
            Lst3.Items.Add(TxtFName.Text); // Add first name to list
            Lst4.Items.Add(TxtScore.Text); // Add score to list

            BtnAdd.Enabled = false; // Disable the Add button after adding

            // Reset all relevant TextBox fields to default values
            TxtNIC.Text = "";
            TxtLName.Text = "";
            TxtFName.Text = "";
            TxtTel.Text = "";
            TxtLang.Text = "0";
            TxtTech.Text = "0";
            TxtChance.Text = "0";
            TxtScore.Text = "0";

            // Reset any additional controls as necessary
            RdMas.Checked = false;
            RdFem.Checked = false;
            ChkExper.Checked = false;
            ChkMotiv.Checked = false;
            ChkDip.Checked = false;
            CmbAge.SelectedIndex = -1; // Reset age selection
        }

        // Helper method to parse integer values safely
        private int ParseInt(string text)
        {
            // Try to convert the input text to an integer
            if (int.TryParse(text, out int result))
            {
                return result; // Return the parsed integer if successful
            }
            return 0; // Return 0 if parsing fails
        }
    }
}
