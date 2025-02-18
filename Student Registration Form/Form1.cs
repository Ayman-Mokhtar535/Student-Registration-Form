using System.Text.RegularExpressions;

namespace Student_Registration_Form
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void emailText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            const string pattern = "^[A-Za-z0-9]{4,16}" + @"@[A-Za-z]{4,16}\." + "(com)$";
            if (string.IsNullOrEmpty(emailText.Text))
            {
                checkEmailReport.Text = "You have to write an Email.";
                checkEmailReport.ForeColor = Color.Red;
            }
            else if (!Regex.IsMatch(emailText.Text, pattern))
            {
                checkEmailReport.Text = "You have to write a valid Email.";
                checkEmailReport.ForeColor = Color.Red;
            }
            else
            {
                checkEmailReport.Text = "Valid Email.";
                checkEmailReport.ForeColor = Color.Green;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (passwordText.UseSystemPasswordChar)
            {
                hideButton.BringToFront();
                passwordText.UseSystemPasswordChar = false;
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (!passwordText.UseSystemPasswordChar)
            {
                showButton.BringToFront();
                passwordText.UseSystemPasswordChar = true;
            }
        }
        private Color favColor;
        private void colorDialogBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                favColor = colorDialog.Color;
                colorDialogBtn.BackColor = favColor;
                colorDialogBtn.Text = string.Empty;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string gender = maleRadioButton.Checked ? "Male" : "Female";
            resultText1.Text = $" \" {nameText.Text}, {emailText.Text}, {gender},";
            resultText2.Text = $" {colorDialog.Color.Name}, Birthdate: {birthdate.Value.ToShortDateString()}, Country: {countryComboBox.Text} \"";

            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            colorDialogBtn.BackColor = SystemColors.Control;
            colorDialogBtn.Text = "Choose Color";
            checkEmailReport.Text = string.Empty;

            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is TextBox txt)
                {
                    txt.Clear();
                }
                else if (ctrl is ComboBox cbox )
                {
                    cbox.SelectedIndex = -1;
                }
                else if (ctrl is DateTimePicker date)
                {
                    date.Value = DateTime.Today;
                }
            }
        }
    }
}
