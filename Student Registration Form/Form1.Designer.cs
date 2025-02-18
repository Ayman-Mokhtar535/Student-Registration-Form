namespace Student_Registration_Form
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            label1 = new Label();
            label2 = new Label();
            emailText = new TextBox();
            label3 = new Label();
            passwordText = new TextBox();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            label4 = new Label();
            birthdate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            submitButton = new Button();
            nameText = new TextBox();
            label7 = new Label();
            countryComboBox = new ComboBox();
            colorDialogBtn = new Button();
            colorDialog = new ColorDialog();
            checkEmailReport = new Label();
            showButton = new Button();
            hideButton = new Button();
            resultText1 = new Label();
            groupBox1 = new GroupBox();
            resultText2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(141, 33);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 1;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(144, 91);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 3;
            label2.Text = "Email :";
            // 
            // emailText
            // 
            emailText.Location = new Point(279, 98);
            emailText.Name = "emailText";
            emailText.Size = new Size(262, 27);
            emailText.TabIndex = 2;
            emailText.Validating += emailText_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(85, 154);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 5;
            label3.Text = "Password :";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(279, 159);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(226, 27);
            passwordText.TabIndex = 4;
            passwordText.UseSystemPasswordChar = true;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Font = new Font("Arial Rounded MT Bold", 12F);
            maleRadioButton.ForeColor = SystemColors.ButtonHighlight;
            maleRadioButton.Location = new Point(298, 217);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(77, 27);
            maleRadioButton.TabIndex = 6;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Font = new Font("Arial Rounded MT Bold", 12F);
            femaleRadioButton.ForeColor = SystemColors.ButtonHighlight;
            femaleRadioButton.Location = new Point(434, 217);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(102, 27);
            femaleRadioButton.TabIndex = 7;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(119, 212);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 8;
            label4.Text = "Gender :";
            // 
            // birthdate
            // 
            birthdate.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthdate.Location = new Point(279, 327);
            birthdate.Name = "birthdate";
            birthdate.Size = new Size(257, 31);
            birthdate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(93, 322);
            label5.Name = "label5";
            label5.Size = new Size(159, 32);
            label5.TabIndex = 11;
            label5.Text = "Birthdate :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(112, 376);
            label6.Name = "label6";
            label6.Size = new Size(139, 32);
            label6.TabIndex = 13;
            label6.Text = "Country :";
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitButton.Location = new Point(337, 443);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(159, 55);
            submitButton.TabIndex = 14;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // nameText
            // 
            nameText.Location = new Point(279, 40);
            nameText.Name = "nameText";
            nameText.Size = new Size(262, 27);
            nameText.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(27, 267);
            label7.Name = "label7";
            label7.Size = new Size(225, 32);
            label7.TabIndex = 15;
            label7.Text = "Favorite Color :";
            // 
            // countryComboBox
            // 
            countryComboBox.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Items.AddRange(new object[] { "Afghanistan  ", "Albania  ", "Algeria  ", "Andorra  ", "Angola  ", "Antigua and Barbuda  ", "Argentina  ", "Armenia  ", "Australia  ", "Austria  ", "Azerbaijan  ", "Bahamas  ", "Bahrain  ", "Bangladesh  ", "Barbados  ", "Belarus  ", "Belgium  ", "Belize  ", "Benin  ", "Bhutan  ", "Bolivia  ", "Bosnia and Herzegovina  ", "Botswana  ", "Brazil  ", "Brunei  ", "Bulgaria  ", "Burkina Faso  ", "Burundi  ", "Cabo Verde  ", "Cambodia  ", "Cameroon  ", "Canada  ", "Central African Republic  ", "Chad  ", "Chile  ", "China  ", "Colombia  ", "Comoros  ", "Congo (Congo-Brazzaville)  ", "Congo (Congo-Kinshasa)  ", "Costa Rica  ", "Croatia  ", "Cuba  ", "Cyprus  ", "Czechia (Czech Republic)  ", "Denmark  ", "Djibouti  ", "Dominica  ", "Dominican Republic  ", "Ecuador  ", "Egypt  ", "El Salvador  ", "Equatorial Guinea  ", "Eritrea  ", "Estonia  ", "Eswatini (Swaziland)  ", "Ethiopia  ", "Fiji  ", "Finland  ", "France  ", "Gabon  ", "Gambia  ", "Georgia  ", "Germany  ", "Ghana  ", "Greece  ", "Grenada  ", "Guatemala  ", "Guinea  ", "Guinea-Bissau  ", "Guyana  ", "Haiti  ", "Honduras  ", "Hungary  ", "Iceland  ", "India  ", "Indonesia  ", "Iran  ", "Iraq  ", "Ireland  ", "Israel  ", "Italy  ", "Jamaica  ", "Japan  ", "Jordan  ", "Kazakhstan  ", "Kenya  ", "Kiribati  ", "Kuwait  ", "Kyrgyzstan  ", "Laos  ", "Latvia  ", "Lebanon  ", "Lesotho  ", "Liberia  ", "Libya  ", "Liechtenstein  ", "Lithuania  ", "Luxembourg  ", "Madagascar  ", "Malawi  ", "Malaysia  ", "Maldives  ", "Mali  ", "Malta  ", "Marshall Islands  ", "Mauritania  ", "Mauritius  ", "Mexico  ", "Micronesia  ", "Moldova  ", "Monaco  ", "Mongolia  ", "Montenegro  ", "Morocco  ", "Mozambique  ", "Myanmar (Burma)  ", "Namibia  ", "Nauru  ", "Nepal  ", "Netherlands  ", "New Zealand  ", "Nicaragua  ", "Niger  ", "Nigeria  ", "North Korea  ", "North Macedonia  ", "Norway  ", "Oman  ", "Pakistan  ", "Palau  ", "Palestine  ", "Panama  ", "Papua New Guinea  ", "Paraguay  ", "Peru  ", "Philippines  ", "Poland  ", "Portugal  ", "Qatar  ", "Romania  ", "Russia  ", "Rwanda  ", "Saint Kitts and Nevis  ", "Saint Lucia  ", "Saint Vincent and the Grenadines  ", "Samoa  ", "San Marino  ", "Sao Tome and Principe  ", "Saudi Arabia  ", "Senegal  ", "Serbia  ", "Seychelles  ", "Sierra Leone  ", "Singapore  ", "Slovakia  ", "Slovenia  ", "Solomon Islands  ", "Somalia  ", "South Africa  ", "South Korea  ", "South Sudan  ", "Spain  ", "Sri Lanka  ", "Sudan  ", "Suriname  ", "Sweden  ", "Switzerland  ", "Syria  ", "Tajikistan  ", "Tanzania  ", "Thailand  ", "Timor-Leste  ", "Togo  ", "Tonga  ", "Trinidad and Tobago  ", "Tunisia  ", "Turkey  ", "Turkmenistan  ", "Tuvalu  ", "Uganda  ", "Ukraine  ", "United Arab Emirates  ", "United Kingdom  ", "United States  ", "Uruguay  ", "Uzbekistan  ", "Vanuatu  ", "Vatican City  ", "Venezuela  ", "Vietnam  ", "Yemen  ", "Zambia  ", "Zimbabwe  " });
            countryComboBox.Location = new Point(279, 383);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(257, 31);
            countryComboBox.TabIndex = 16;
            // 
            // colorDialogBtn
            // 
            colorDialogBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colorDialogBtn.Location = new Point(281, 267);
            colorDialogBtn.Name = "colorDialogBtn";
            colorDialogBtn.Size = new Size(260, 32);
            colorDialogBtn.TabIndex = 17;
            colorDialogBtn.Text = "Choose Color";
            colorDialogBtn.UseVisualStyleBackColor = true;
            colorDialogBtn.Click += colorDialogBtn_Click;
            // 
            // checkEmailReport
            // 
            checkEmailReport.AutoSize = true;
            checkEmailReport.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkEmailReport.Location = new Point(559, 105);
            checkEmailReport.Name = "checkEmailReport";
            checkEmailReport.Size = new Size(0, 20);
            checkEmailReport.TabIndex = 18;
            // 
            // showButton
            // 
            showButton.BackColor = Color.White;
            showButton.Image = (Image)resources.GetObject("showButton.Image");
            showButton.Location = new Point(504, 159);
            showButton.Name = "showButton";
            showButton.Size = new Size(37, 27);
            showButton.TabIndex = 20;
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // hideButton
            // 
            hideButton.BackColor = Color.White;
            hideButton.Image = (Image)resources.GetObject("hideButton.Image");
            hideButton.Location = new Point(504, 159);
            hideButton.Name = "hideButton";
            hideButton.Size = new Size(37, 27);
            hideButton.TabIndex = 20;
            hideButton.UseVisualStyleBackColor = false;
            hideButton.Click += hideButton_Click;
            // 
            // resultText1
            // 
            resultText1.AutoSize = true;
            resultText1.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultText1.ForeColor = Color.White;
            resultText1.Location = new Point(6, 27);
            resultText1.Name = "resultText1";
            resultText1.Size = new Size(0, 32);
            resultText1.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(resultText2);
            groupBox1.Controls.Add(resultText1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(27, 520);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 107);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Result";
            // 
            // resultText2
            // 
            resultText2.AutoSize = true;
            resultText2.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultText2.ForeColor = Color.White;
            resultText2.Location = new Point(6, 59);
            resultText2.Name = "resultText2";
            resultText2.Size = new Size(0, 32);
            resultText2.TabIndex = 21;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(953, 639);
            Controls.Add(groupBox1);
            Controls.Add(showButton);
            Controls.Add(checkEmailReport);
            Controls.Add(colorDialogBtn);
            Controls.Add(countryComboBox);
            Controls.Add(label7);
            Controls.Add(submitButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(birthdate);
            Controls.Add(label4);
            Controls.Add(femaleRadioButton);
            Controls.Add(maleRadioButton);
            Controls.Add(label3);
            Controls.Add(passwordText);
            Controls.Add(label2);
            Controls.Add(nameText);
            Controls.Add(emailText);
            Controls.Add(label1);
            Controls.Add(hideButton);
            Name = "mainForm";
            Text = "Student Registration Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox emailText;
        private Label label3;
        private TextBox passwordText;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private Label label4;
        private DateTimePicker birthdate;
        private Label label5;
        private Label label6;
        private Button submitButton;
        private TextBox nameText;
        private Label label7;
        private ComboBox countryComboBox;
        private Button colorDialogBtn;
        private ColorDialog colorDialog;
        private Label checkEmailReport;
        private Button showButton;
        private Button hideButton;
        private Label resultText1;
        private GroupBox groupBox1;
        private Label resultText2;
    }
}
