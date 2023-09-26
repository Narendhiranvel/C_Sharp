namespace MidAtlanticTours
{
    public partial class Form1 : Form
    {
        // Declaring constant variables
        const decimal fullPassenger = 9.50m;
        const decimal studentPassenger = 6.75m;
        const decimal childPassenger = 4.75m;

        // Declaring global variables
        int numberOfDrivers = 0;
        int totalPassengers;
        int addedPassengers;
        decimal totalDriverReceipts;
        decimal companyReceipts;
        decimal fullFareRecipts;
        decimal addedFullFare;
        decimal studentFareReceipts;
        decimal addedStudentFare;
        decimal childFareReceipts;
        decimal addedChildFare;

        public Form1()
        {
            InitializeComponent();
            driverPassengerGroupBox1.Visible = false;
            processPanel.Visible = false;
            driverSummaryGroupBox.Visible = false;
            driverNameTextBox.Focus();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            // On clicking proceed button
            driverPassengerGroupBox1.Enabled = true;
            clearButton.Enabled = false;
            summaryButton.Enabled = false;
            totaDriversLabelBox.Visible = false;
            totalDriversTextBox.Visible = false;
            processButton.Enabled = true;
            driverDetailsPanel.Visible = false;
            busPicture1.Location = new Point(284, 735);
            busPicture1.Height = 181;
            busPicture1.Width = 320;
            driverPassengerGroupBox1.Visible = true;
            fullFareTextBox.Focus();
            processPanel.Visible = true;
            driverPassengerGroupBox1.Location = new Point(171, 35);
            processPanel.Location = new Point(171, 255);
            Form1.ActiveForm.Text = "Data Entry for Driver: " + driverNameTextBox.Text + " Bus ID: " + busIdTextBox.Text;
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            processButton.Enabled = false;
            try
            {
                // local variables
                int fullFare = 0;
                int studentFare = 0;
                int childFare = 0;

                // Bring in user input and store in declared variables
                fullFare = int.Parse(fullFareTextBox.Text);
                try
                {
                    // Bring in user input and store in declared variables
                    studentFare = int.Parse(studentFareTextBox.Text);
                    try
                    {
                        // Bring in user input and store in declared variables
                        childFare = int.Parse(childFareTextBox.Text);

                        driverSummaryGroupBox.Visible = true;
                        clearButton.Enabled = true;
                        summaryButton.Enabled = true;

                        driverSummaryGroupBox.Location = new Point(171, 345);

                        // Calculations for total passengers
                        totalPassengers = fullFare + studentFare + childFare;
                        totalPassengerTextBox.Text = totalPassengers.ToString();

                        // Calculations for child fare receipts
                        childFareReceipts = (childFare * childPassenger);
                        childFareReceiptsTextBox.Text = childFareReceipts.ToString("C2");

                        // Calculations for student fare receipts
                        studentFareReceipts = (studentFare * studentPassenger);
                        studentFareReciptsTextBox.Text = studentFareReceipts.ToString("C2");

                        // Calculations for full fare receipts
                        fullFareRecipts = (fullFare * fullPassenger);
                        fullFareReciptsTextBox.Text = fullFareRecipts.ToString("C2");

                        // Calculations for total driver receipts
                        totalDriverReceipts = (fullFare * fullPassenger) + (studentFare * studentPassenger) + (childFare * childPassenger);
                        totalDriverReceiptsTextBox.Text = totalDriverReceipts.ToString("C2");

                        // Calculations for full fare percentage
                        decimal fullFarePercentage = ((fullFareRecipts) / (totalDriverReceipts));
                        fullFarePercentageTextBox.Text = (fullFarePercentage.ToString("P0"));

                        // Calculations for student fare percentage
                        decimal studentFarePercentage = ((studentFareReceipts) / (totalDriverReceipts));
                        studentFarePercentageTextBox.Text = studentFarePercentage.ToString("P0");

                        // Calculations for child fare percentage
                        decimal childFarePercentage = ((childFareReceipts) / (totalDriverReceipts));
                        childFarePercentageTextBox.Text = childFarePercentage.ToString("P0");

                        // Counting number of drivers
                        numberOfDrivers = numberOfDrivers + 1;
                        totalDriversTextBox.Text = numberOfDrivers.ToString();

                        // Total passengers of the company
                        addedPassengers = addedPassengers + totalPassengers;
                        // Total company receipts
                        companyReceipts = companyReceipts + totalDriverReceipts;
                        // Total full fare receipts of company
                        addedFullFare = addedFullFare + fullFareRecipts;
                        // Total students fare receipts of company
                        addedStudentFare = addedStudentFare + studentFareReceipts;
                        // Total child fare receipts of company
                        addedChildFare = addedChildFare + childFareReceipts;

                        driverPassengerGroupBox1.Enabled = false;
                    }
                    catch
                    {
                        // Exceptional Handling for Child Fare Text Box
                        MessageBox.Show("Please enter numerical data for Child passengers", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        driverSummaryGroupBox.Visible = false;
                        processButton.Enabled = true;
                        childFareTextBox.Focus();
                    }
                }
                catch
                {
                    // Exceptional Handling for Student Fare Text Box
                    MessageBox.Show("Please enter numerical data for Student passengers", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    driverSummaryGroupBox.Visible = false;
                    processButton.Enabled = true;
                    studentFareTextBox.Focus();
                }

            }
            catch
            {
                // Exceptional Handling for Full Fare Text Box
                MessageBox.Show("Please enter numerical data for Full passengers", "Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                driverSummaryGroupBox.Visible = false;
                processButton.Enabled = true;
                fullFareTextBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // On clicking clear button
            fullFareTextBox.Clear();
            studentFareTextBox.Clear();
            childFareTextBox.Clear();
            totalPassengerTextBox.Clear();
            totalDriverReceiptsTextBox.Clear();
            fullFareReciptsTextBox.Clear();
            fullFarePercentageTextBox.Clear();
            studentFareReciptsTextBox.Clear();
            studentFarePercentageTextBox.Clear();
            childFareReceiptsTextBox.Clear();
            childFarePercentageTextBox.Clear();

            driverPassengerGroupBox1.Visible = false;
            processPanel.Visible = false;
            driverNameTextBox.Clear();
            busIdTextBox.Clear();
            driverSummaryGroupBox.Visible = false;

            Form1.ActiveForm.Text = "Welcome To MAT Driver Portal";
            driverDetailsPanel.Visible = true;
            driverNameTextBox.Focus();
            busPicture1.Location = new Point(283, 197);
            busPicture1.Width = 343;
            busPicture1.Height = 193;
        }

        private void exirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            summaryButton.Enabled = false;
            Form1.ActiveForm.Text = "MAT Summary Data";
            driverPassengerGroupBox1.Visible = false;
            driverSummaryGroupBox.Text = "Company Summary";
            processButton.Enabled = false;
            totaDriversLabelBox.Visible = true;
            totalDriversTextBox.Visible = true;
            totalDriverReceiptsLabel.Text = "Total Company Receipts";

            totalPassengerTextBox.Text = addedPassengers.ToString();
            totalDriverReceiptsTextBox.Text = companyReceipts.ToString("C2");
            fullFareReciptsTextBox.Text = addedFullFare.ToString("C2");
            studentFareReciptsTextBox.Text = addedStudentFare.ToString("C2");
            childFareReceiptsTextBox.Text = addedChildFare.ToString("C2");

            // Calculations for full fare percentage of company
            decimal addedFullFarePercentage = ((addedFullFare) / (companyReceipts));
            fullFarePercentageTextBox.Text = (addedFullFarePercentage.ToString("P0"));

            // Calculations for student fare percentage of company
            decimal addedStudentFarePercentage = ((addedStudentFare) / (companyReceipts));
            studentFarePercentageTextBox.Text = (addedStudentFarePercentage.ToString("P0"));

            // Calculations for child fare percentage of company
            decimal addedChildlFarePercentage = ((addedChildFare) / (companyReceipts));
            childFarePercentageTextBox.Text = (addedChildlFarePercentage.ToString("P0"));
        }

        private void driverNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}