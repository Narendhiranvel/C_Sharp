using System.Linq;
using System.Transactions;

namespace Invest4u
{
    public partial class Form1 : Form
    {
        // Investment year constants
        const int ONEYEAR = 1, THREEYEAR = 3, FIVEYEAR = 5, TENYEAR = 10;
        //Interest constants
        const decimal SMALLONEYEARINTEREST = 0.005000m, SMALLTHREEYEARINTEREST = 0.006250m, SMALLFIVEYEARINTEREST = 0.007125m, SMALLTENYEARINTEREST = 0.011250m,
            LARGEONEYEARINTEREST = 0.006000m, LARGETHREEYEARINTEREST = 0.007250m, LARGEFIVEYEARINTEREST = 0.008125m, LARGETENYEARINTEREST = 0.012500m;
        // Declaring principal Amount
        decimal principalAmount = 0m;
        // Declaring maturity period
        decimal oneYearMaturity, threeYearMaturity, fiveYearMaturity, tenYearMaturity;
        // Application password
        const string ACTUALPASSWORD = "ShowMeTheMoney#";
        // Attemps for incorrect password
        int remainingAttempts = 3;
        decimal totalProfitAmount = 0;
        int transId;
        int term = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            invest4uPictureBox1.Visible = false;
            passwordIncorrectLabel.Visible = false;
            investmentOptionsGroupBox.Visible = false;
            smallIvestlentListBox.Visible = false;
            largeInvestListBox.Visible = false;
            maturityAmountPanel.Visible = false;
            noteLabel.Text = "Note: Investments of greater than 1 Million for 5 Years or" + "\n" +
                "                more receive an additional ₹25,000 on term" + "\n" +
                "                                         completion";
            proceedButton.Enabled = false;
            investmentDetailsGroupBox.Visible = false;
            summaryButton.Visible = false;
            searchTextBox.Visible = false;
            searchButton.Visible = false;
            summaryListBox.Visible = false;
            searchPanel.Visible = false;
            investmentSummaryLabel.Visible = false;
            searchByTransIdRadioButton.Visible = false;
            searchEmailIdRadioButton.Visible = false;
            searchDateRadioButton.Visible = false;
            searchResultLabel.Visible = false;
            searchResultListBox.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Gets entered password from text box
            string checkPassword = passwordMaskedTextBox.Text;

            // Action for empty password
            if (string.IsNullOrEmpty(checkPassword))
            {
                passwordMaskedTextBox.Focus();
                MessageBox.Show("Password Text Box is empty. Please enter a password.");
                return;
            }

            // Correct password entered
            if (checkPassword == ACTUALPASSWORD)
            {
                investPictureBox.Visible = false;
                invest4uPictureBox1.Visible = true;
                passwordPanel.Visible = false;
                investmentOptionsGroupBox.Visible = true;
                summaryButton.Visible = true;
                searchTextBox.Visible = true;
                searchButton.Visible = true;
                searchPanel.Visible = true;
                summaryListBox.Visible = true;
                investmentSummaryLabel.Visible = true;
                searchByTransIdRadioButton.Visible = true;
                searchEmailIdRadioButton.Visible = true;
                searchDateRadioButton.Visible = true;
                searchResultLabel.Visible = true;
                searchResultListBox.Visible = true;
                searchByTransIdRadioButton.Checked = true;
                investmentPrincipalTextBox.Focus();
            }
            else
            {
                // Number of attempts reduces for each password
                remainingAttempts--;
                if (remainingAttempts > 0)
                {
                    passwordIncorrectLabel.Visible = true;
                    passwordIncorrectLabel.Text = "Incorrect password." + "\n" + "        Try again" + "\n" + "  Attempts Left " + remainingAttempts;
                    passwordMaskedTextBox.Clear();
                    passwordMaskedTextBox.Focus();
                }
                // Application closes if maximum password attempts reached
                else
                {
                    passwordIncorrectLabel.Text = "Incorrect password." + "\n" + "Maximum attempts reached." + "\n" + "Application will now close.";
                    passwordMaskedTextBox.Clear();
                    passwordMaskedTextBox.Enabled = false;
                    loginButton.Enabled = false;
                    this.Close();
                }
            }
        }
        // Formula for calculating maturity amount over trems
        private decimal CalculateMaturityAmount(int years, decimal interestRate)
        {

            decimal annualInterestRate = (interestRate * 12) / 100;

            decimal maturityAmount = principalAmount * (decimal)Math.Pow(1 + (double)annualInterestRate, years);
            return maturityAmount;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            largeInvestListBox.ClearSelected();
            smallIvestlentListBox.ClearSelected();
            // Parsing text box value to integer
            if (decimal.TryParse(investmentPrincipalTextBox.Text, out principalAmount))
            {
                // For investment amount less than or equal to 100000
                if (principalAmount > 0 && principalAmount <= 100000)
                {
                    proceedButton.Enabled = true;
                    largeInvestListBox.Visible = false;
                    smallIvestlentListBox.Visible = true;
                    maturityAmountPanel.Visible = true;
                    oneYearMaturity = CalculateMaturityAmount(ONEYEAR, SMALLONEYEARINTEREST);
                    threeYearMaturity = CalculateMaturityAmount(THREEYEAR, SMALLTHREEYEARINTEREST);
                    fiveYearMaturity = CalculateMaturityAmount(FIVEYEAR, SMALLFIVEYEARINTEREST);
                    tenYearMaturity = CalculateMaturityAmount(TENYEAR, SMALLTENYEARINTEREST);

                    oneYearLabel.Text = oneYearMaturity.ToString("C");
                    threeYearLabel.Text = threeYearMaturity.ToString("C");
                    fiveYearLabel.Text = fiveYearMaturity.ToString("C");
                    tenYearLabel.Text = tenYearMaturity.ToString("C");
                }
                // For investment amount less than greater than 100000
                else if (principalAmount > 100000)
                {
                    proceedButton.Enabled = true;
                    smallIvestlentListBox.Visible = false;
                    largeInvestListBox.Visible = true;
                    maturityAmountPanel.Visible = true;
                    oneYearMaturity = CalculateMaturityAmount(ONEYEAR, LARGEONEYEARINTEREST);
                    threeYearMaturity = CalculateMaturityAmount(THREEYEAR, LARGETHREEYEARINTEREST);
                    fiveYearMaturity = CalculateMaturityAmount(FIVEYEAR, LARGEFIVEYEARINTEREST);
                    tenYearMaturity = CalculateMaturityAmount(TENYEAR, LARGETENYEARINTEREST);

                    oneYearLabel.Text = oneYearMaturity.ToString("C");
                    threeYearLabel.Text = threeYearMaturity.ToString("C");
                    fiveYearLabel.Text = fiveYearMaturity.ToString("C");
                    tenYearLabel.Text = tenYearMaturity.ToString("C");
                }
                // for invalid inputs
                else
                {
                    MessageBox.Show("Please enter a valid principal amount.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid principal amount.");
            }
        }

        // Generates random 6 digit number for transaction ID
        private int transactionNumber()
        {
            Random random = new Random();
            int uniqueCode = random.Next(100000, 999999);

            return uniqueCode;
        }

        // Notes the date of transaction
        private string recordDate()
        {
            DateTime transactionDate = DateTime.Now;
            return transactionDate.ToShortDateString();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {

            decimal interestRate = 0, maturity = 0;
            int smallInvestIndex = smallIvestlentListBox.SelectedIndex;  // Get the selected index
            int largeInvestIndex = largeInvestListBox.SelectedIndex;
            
            // Investment term not selected
            if (largeInvestListBox.Visible && largeInvestListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a term of investment.");
            }
            
            else if (smallIvestlentListBox.Visible && smallIvestlentListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a term of investment.");
            }
            // Investment term selected for amount less than or equal to 100000
            else if (smallIvestlentListBox.Visible && smallIvestlentListBox.SelectedIndex != -1)
            {
                switch (smallInvestIndex)
                {
                    case 0:
                        term = ONEYEAR * 12; interestRate = SMALLONEYEARINTEREST;
                        maturity = CalculateMaturityAmount(ONEYEAR, SMALLONEYEARINTEREST);
                        break;
                    case 1:
                        term = THREEYEAR * 12; interestRate = SMALLTHREEYEARINTEREST;
                        maturity = CalculateMaturityAmount(THREEYEAR, SMALLTHREEYEARINTEREST);
                        break;
                    case 2:
                        term = FIVEYEAR * 12; interestRate = SMALLFIVEYEARINTEREST;
                        maturity = CalculateMaturityAmount(FIVEYEAR, SMALLFIVEYEARINTEREST); ;
                        break;
                    case 3:
                        term = TENYEAR * 12; interestRate = SMALLTENYEARINTEREST;
                        maturity = CalculateMaturityAmount(TENYEAR, SMALLTENYEARINTEREST);
                        break;
                }
                // Calculate  profit
                totalProfitAmount = maturity - principalAmount;
                dateLabel.Text = recordDate();
                transId = transactionNumber();
                transIdTextBox.Text = transId.ToString();
                investAmountTextBox.Text = principalAmount.ToString("n2");
                durationTextBox.Text = term.ToString();
                iRTextBox.Text = interestRate.ToString("n6");
                profitTextBox.Text = totalProfitAmount.ToString("n2");
                investmentDetailsGroupBox.Visible = true;
            }

            // Investment term selected for amount greater than 100000
            else if (largeInvestListBox.Visible && largeInvestListBox.SelectedIndex != -1)
            {

                switch (largeInvestIndex)
                {
                    case 0:
                        term = ONEYEAR * 12; interestRate = LARGEONEYEARINTEREST;
                        maturity = CalculateMaturityAmount(ONEYEAR, LARGEONEYEARINTEREST);
                        break;
                    case 1:
                        term = THREEYEAR * 12; interestRate = LARGETHREEYEARINTEREST;
                        maturity = CalculateMaturityAmount(THREEYEAR, LARGETHREEYEARINTEREST);
                        break;
                    case 2:
                        term = FIVEYEAR * 12; interestRate = LARGEFIVEYEARINTEREST;
                        maturity = CalculateMaturityAmount(FIVEYEAR, LARGEFIVEYEARINTEREST); ;
                        break;
                    case 3:
                        term = TENYEAR * 12; interestRate = LARGETENYEARINTEREST;
                        maturity = CalculateMaturityAmount(TENYEAR, LARGETENYEARINTEREST);
                        break;
                }
                totalProfitAmount = maturity - principalAmount;
                dateLabel.Text = recordDate();
                transId = transactionNumber();
                transIdTextBox.Text = transId.ToString();
                investAmountTextBox.Text = principalAmount.ToString("n2");
                durationTextBox.Text = term.ToString();
                iRTextBox.Text = interestRate.ToString("n6");
                profitTextBox.Text = totalProfitAmount.ToString("n2");
                investmentDetailsGroupBox.Visible = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            smallIvestlentListBox.ClearSelected();
            largeInvestListBox.ClearSelected();
            investmentPrincipalTextBox.Clear();
            maturityAmountPanel.Visible = false;
            proceedButton.Enabled = false;
            investmentDetailsGroupBox.Visible = false;
            summaryListBox.Items.Clear();
            searchResultListBox.Items.Clear();
            nameTextBox.Clear();
            mailIdTextBox.Clear();
            phonTextBox.Clear();
            searchTextBox.Clear();

            investmentPrincipalTextBox.Focus();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Stores client details
            string clientDetails = GetClientDetails();
            // Asks for conformation
            DialogResult result = MessageBox.Show("Client Details:\n" + clientDetails + "\n\nDo you wish to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Conformed
            if (result == DialogResult.Yes)
            {
                // Save the transaction to a text file
                SaveTransaction(clientDetails);
                MessageBox.Show("Transaction saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearButton_Click(sender, e);
            }

            // not conformed
            else
            {
                MessageBox.Show("Transaction not saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetClientDetails()
        {
            // formatted string with client details
            string details = $"Transaction ID: {transIdTextBox.Text}\n" +
                            $"Date: {dateLabel.Text}\n" +
                            $"Email: {mailIdTextBox.Text}\n" +
                            $"Principal Amount: {investAmountTextBox.Text}\n" +
                            $"Duration: {durationTextBox.Text}\n" +
                            $"Interest Rate: {iRTextBox.Text}\n" +
                            $"Total Profit: {profitTextBox.Text}\n" +
                            $"Name: {nameTextBox.Text}\n" +
                            $"Phone: {phonTextBox.Text}";
            return details;
        }
        // Method for writing on to file
        private void SaveTransaction(string details)
        {
            // Define the path to the text file where transactions will be saved

            string filePath = "transactionDetails.txt";

            try
            {
                using (StreamWriter transDetailsWriter = new StreamWriter(filePath, true))
                {
                    transDetailsWriter.WriteLine(details);
                    transDetailsWriter.WriteLine(new string('-', 40));
                }
            }
            // Exception handled
            catch (IOException ex)
            {
                MessageBox.Show("An error occurred while saving the transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            int totalDuration = 0;
            int averageDuration = 0;
            string transactionDetails;
            string allTransactionDetails = "";

            if (File.Exists("transactionDetails.txt"))
            {
                // Initialize the total amount invested
                decimal totalAmountInvested = 0; 
                decimal totalInterestAccruing = 0;
                decimal averageAmountInvested = 0;

                // Read the contents of the file
                using (StreamReader inputFile = File.OpenText("transactionDetails.txt"))
                {
                    string line;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        if (line.StartsWith("Principal Amount:"))
                        {
                            // Extract and parse the principal amount
                            string value = line.Substring(line.IndexOf(':') + 1).Trim();
                            if (decimal.TryParse(value, out decimal principalAmount))
                            {
                                totalAmountInvested += principalAmount;
                            }
                        }
                        if (line.StartsWith("Total Profit:"))
                        {
                            // Extract and parse the total profit amount
                            string value = line.Substring(line.IndexOf(':') + 1).Trim();
                            if (decimal.TryParse(value, out decimal totalProfitAmount))
                            {
                                totalInterestAccruing += totalProfitAmount;
                            }
                        }
                        if (line.StartsWith("Duration:"))
                        {
                            // Extract and parse the duration (in months)
                            string value = line.Substring(line.IndexOf(':') + 1).Trim();
                            if (int.TryParse(value, out int duration))
                            {
                                totalDuration += duration;
                            }
                        }
                        if (line.StartsWith("Transaction ID:"))
                        {
                            allTransactionDetails += line + "\n";
                            count++;
                        }
                    }
                }

                if (totalAmountInvested > 0)
                {
                    averageDuration = totalDuration / count;

                    // Display the total amount invested
                    averageAmountInvested = totalAmountInvested / count;
                    // Clear existing items
                    summaryListBox.Items.Clear(); 
                    foreach (string line in allTransactionDetails.Split('\n'))
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            summaryListBox.Items.Add(line);
                        }
                    }
                    summaryListBox.Items.Add("");
                    summaryListBox.Items.Add("Total Amount Invested: " + totalAmountInvested.ToString("C"));
                    summaryListBox.Items.Add("Total Interest Accruing: " + totalInterestAccruing.ToString("C"));
                    summaryListBox.Items.Add("Average amount Invested: " + averageAmountInvested.ToString("C"));
                    summaryListBox.Items.Add("Average Duration: " + averageDuration);
                }
                else
                {
                    MessageBox.Show("No transaction details found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No transaction details found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            {
                string searchCriteria = searchTextBox.Text.Trim();
                searchResultListBox.Items.Clear();
                // Search box is empty
                if (string.IsNullOrWhiteSpace(searchCriteria))
                {
                    MessageBox.Show("Please enter a search term (e.g., Transaction ID, Email ID, or Date).", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    // Opens file
                    using (StreamReader inputFile = File.OpenText("transactionDetails.txt"))
                    {
                        string transactionDetails = "";
                        bool isMatchingTransaction = false;

                        // Loop checks end of line
                        while (!inputFile.EndOfStream)
                        {
                            string line = inputFile.ReadLine();
                            // checks for the word
                            if (line.StartsWith("Transaction ID:"))
                            {
                                string transacId = line.Replace("Transaction ID: ", "");
                                // Transaction ID Radio button should be clicked for searching by trans id
                                if (searchByTransIdRadioButton.Checked && transacId.Contains(searchCriteria))
                                {
                                    isMatchingTransaction = true;
                                }
                                else
                                {
                                    isMatchingTransaction = false;
                                }
                            }

                            if (isMatchingTransaction)
                            {
                                // Add line with a line break
                                transactionDetails += line + "\n"; 
                            }
                        }

                        if (!string.IsNullOrEmpty(transactionDetails))
                        {
                            // Print all the lines
                            foreach (string line1 in transactionDetails.Split('\n'))
                            {
                                if (!string.IsNullOrWhiteSpace(line1))
                                {
                                    searchResultListBox.Items.Add(line1);
                                }
                            }
                        }
                    }

                    // Search by email
                    using (StreamReader inputFile = File.OpenText("transactionDetails.txt"))
                    {
                        string emailDetails = "";
                        bool isMatchingEmail = false;

                        while (!inputFile.EndOfStream)
                        {
                            string line2 = inputFile.ReadLine();

                            if (line2.StartsWith("Email:"))
                            {
                                string email = line2.Replace("Email: ", "");

                                if (searchEmailIdRadioButton.Checked && email.Contains(searchCriteria))
                                {
                                    isMatchingEmail = true;
                                }
                                else
                                {
                                    isMatchingEmail = false;
                                }
                            }

                            if (isMatchingEmail)
                            {
                                emailDetails += line2 + "\n";
                            }
                        }

                        if (!string.IsNullOrEmpty(emailDetails))
                        {
                            foreach (string line3 in emailDetails.Split('\n'))
                            {
                                if (!string.IsNullOrWhiteSpace(line3))
                                {
                                    searchResultListBox.Items.Add(line3);
                                    if (line3.Contains("-"))
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    // Search by date
                    using (StreamReader inputFile = File.OpenText("transactionDetails.txt"))
                    {
                        string dateDetails = "";
                        bool isMatchingDate = false;

                        while (!inputFile.EndOfStream)
                        {
                            string line4 = inputFile.ReadLine();

                            if (line4.StartsWith("Date:"))
                            {
                                string date = line4.Replace("Date: ", "");

                                if (searchDateRadioButton.Checked && date.Contains(searchCriteria))
                                {
                                    isMatchingDate = true;
                                }
                                else
                                {
                                    isMatchingDate = false;
                                }
                            }

                            if (isMatchingDate)
                            {
                                dateDetails += line4 + "\n"; 
                            }
                        }

                        if (!string.IsNullOrEmpty(dateDetails))
                        {
                            foreach (string line5 in dateDetails.Split('\n'))
                            {
                                if (!string.IsNullOrWhiteSpace(line5))
                                {
                                    searchResultListBox.Items.Add(line5);
                                }
                            }
                        }
                    }
                }
                // Exception Handled
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (searchResultListBox.Items.Count == 0)
                {
                    searchResultListBox.Items.Add("No matching transaction found.");
                }
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
