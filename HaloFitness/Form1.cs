using System.Reflection.Metadata;

namespace HaloFitness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            programListBox.Visible = false;
            sessionsListBox.Visible = false;
            paticipantsNumberLabel.Visible = false;
            participantsNumberTextBox.Visible = false;
            displayButton.Visible = false;
            oneToOneRadioButton.Visible = false;
            smallGroupRadioButton.Visible = false;
            mediumGroupRadioButton.Visible = false;
            optionalUpgradeCheckBox.Visible = false;
            programLabel.Visible = false;
            freeBottleCheckBox.Visible = false;
            customizedBottleCheckBox.Visible = false;
            optionalUpgradePanel.Visible = false;
            displayPanel.Visible = false;
            sessionsPanel.Visible = false;
            costSummaryLabel.Visible = false;
            clearButton.Visible = false;
            bookButton.Visible = false;
            summaryButton.Visible = false;
            exitButton.Visible = false;
        }
        // Declared constant string for program
        const string PROGRAM1 = "Circuit Training", PROGRAM2 = "Pilates", PROGRAM3 = "High-intensity interval training",
            PROGRAM4 = "Aerobics", PROGRAM5 = "Fitness Boot Camp", PROGRAM6 = "Weight Training", PROGRAM7 = "Agility",
            PROGRAM8 = "Yoga", PROGRAM9 = "Speed Training";
        // Declared constants for price per session
        const decimal PRICEPERSESSION1 = 25m, PRICEPERSESSION2 = 40m, PRICEPERSESSION3 = 25m, PRICEPERSESSION4 = 25m,
            PRICEPERSESSION5 = 20m, PRICEPERSESSION6 = 25m, PRICEPERSESSION7 = 50m, PRICEPERSESSION8 = 35m, PRICEPERSESSION9 = 45m;
        // Declared constants for number of sessions
        const int SESSION1 = 1, SESSION3 = 3, SESSION5 = 5, SESSION7 = 7, SESSION10 = 10, SESSION12 = 12;
        // Declared constants for discounts
        const decimal DISCOUNT1 = 0.00m, DISCOUNT2 = 0.05m, DISCOUNT3 = 0.1m, DISCOUNT4 = 0.15m, DISCOUNT5 = 0.20m, DISCOUNT6 = 0.30m;
        // Declared revenue count for calculating revenue average
        int revenueCount = 0;
        // Declared variables for optional upgrade
        int oneToOneTraining = 25, smallGroupTraining = 15, mediumGroupTraining = 5, noTraining = 0;
        // Declared variables for getting number of participants and calculating total participants
        int numberOfParticipants = 0, totalParticipants = 0;
        // Declared variables for calculating total bottle cost and sum of total bottle cost from all bookings
        decimal totalBottleCost = 0m, totalBottleCostSum = 0;
        // For getting string value of program
        string program = "";
        // Declared variable for calculating total price per session
        decimal totalPriceOnSession = 0m;
        int numberOfSession = 0, optionalUpgrade = 0, totalSessions = 0, totalOptionalUpgrade = 0;
        decimal totalProgramCost = 0m, programBookingTotalValue = 0m, averageRevenue = 0;
        int groupDiscountCount = 0;
        // Declared variable for calculating sum of all price on sessions and optional upgrades
        decimal sumTotalPriceOnSession = 0, sumTotalOptionalUpgrade = 0;


        private void programButton_Click(object sender, EventArgs e)
        {
            haloFitnessPictureBox.Location = new Point(72, 520);
            haloFitnessPictureBox.Size = new Size(236, 130);
            fitnessPictureBox.Visible = false;
            programButton.Visible = false;
            jumpIntoLabel.Visible = false;
            worldOfLabel.Visible = false;
            fitnessLabel.Visible = false;
            programListBox.Visible = true;
            sessionsListBox.Visible = true;
            paticipantsNumberLabel.Visible = true;
            participantsNumberTextBox.Visible = true;
            displayButton.Visible = true;
            customizedBottleCheckBox.Visible = true;
            oneToOneRadioButton.Visible = true;
            smallGroupRadioButton.Visible = true;
            mediumGroupRadioButton.Visible = true;
            optionalUpgradeCheckBox.Visible = true;
            programLabel.Visible = true;
            freeBottleCheckBox.Visible = true;
            optionalUpgradePanel.Enabled = false;
            optionalUpgradePanel.Visible = true;
            sessionsPanel.Visible = true;
            clearButton.Visible = true;
            bookButton.Visible = true;
            bookButton.Enabled = false;
            summaryButton.Visible = true;
            summaryButton.Enabled = false;
            exitButton.Visible = true;
            Form1.ActiveForm.Text = "Program Details";
        }

        private void displayButton_Click(object sender, EventArgs e)
        {

            int programIndex = 0, pricePerSessionIndex = 0;
            decimal discount = 0m;
            decimal bottleCost = 0m;
            decimal pricePerSession = 0m;
            decimal programCost = 0m;
            decimal haloExtraDiscount = 0.075M;
            decimal groupDiscount = 0m;

            // Condition if the program list box is selected
            if (programListBox.SelectedIndex != -1)
            {
                // condition if session list box is selected
                if (sessionsListBox.SelectedIndex != -1)
                {
                    programIndex = programListBox.SelectedIndex;
                    pricePerSessionIndex = sessionsListBox.SelectedIndex;
                    // Switch statement for selecting the program
                    switch (programIndex)
                    {
                        case 0:
                            program = PROGRAM1; pricePerSession = PRICEPERSESSION1;
                            break;
                        case 1:
                            program = PROGRAM2; pricePerSession = PRICEPERSESSION2;
                            break;
                        case 2:
                            program = PROGRAM3; pricePerSession = PRICEPERSESSION3;
                            break;
                        case 3:
                            program = PROGRAM4; pricePerSession = PRICEPERSESSION4;
                            break;
                        case 4:
                            program = PROGRAM5; pricePerSession = PRICEPERSESSION5;
                            break;
                        case 5:
                            program = PROGRAM6; pricePerSession = PRICEPERSESSION6;
                            break;
                        case 6:
                            program = PROGRAM7; pricePerSession = PRICEPERSESSION7;
                            break;
                        case 7:
                            program = PROGRAM8; pricePerSession = PRICEPERSESSION8;
                            break;
                        case 8:
                            program = PROGRAM9; pricePerSession = PRICEPERSESSION9;
                            break;
                    }
                    // Switch statement for selecting the number of sessions
                    switch (pricePerSessionIndex)
                    {
                        case 0:
                            numberOfSession = SESSION1; discount = DISCOUNT1;
                            break;
                        case 1:
                            numberOfSession = SESSION3; discount = DISCOUNT2;
                            break;
                        case 2:
                            numberOfSession = SESSION5; discount = DISCOUNT3;
                            break;
                        case 3:
                            numberOfSession = SESSION7; discount = DISCOUNT4;
                            break;
                        case 4:
                            numberOfSession = SESSION10; discount = DISCOUNT5;
                            break;
                        case 5:
                            numberOfSession = SESSION12; discount = DISCOUNT6;
                            break;
                    }
                    // Parsing participants number text box
                    if (int.TryParse(participantsNumberTextBox.Text, out numberOfParticipants) && numberOfParticipants > 0)
                    {
                        // Bottle cost when customised bottle checkbox is clicked
                        if (customizedBottleCheckBox.Checked)
                        {
                            bottleCost = 7.99m;
                            totalBottleCost = bottleCost * numberOfParticipants;
                        }
                        else
                        {
                            bottleCost = 0m;
                            totalBottleCost = 0m;
                        }
                        // Calculating total price on session
                        totalPriceOnSession = pricePerSession * numberOfSession * numberOfParticipants;
                        // Calculating total price on optional upgrade
                        totalOptionalUpgrade = optionalUpgrade * numberOfSession * numberOfParticipants;

                        if (numberOfParticipants >= 1 && numberOfParticipants < 4)
                        {
                            bookButton.Enabled = true;
                            displayPanel.Visible = true;
                            costSummaryLabel.Visible = true;
                            // Program cost calculations for number of participants below four and greater than 0
                            programCost = ((((pricePerSession + optionalUpgrade) - (discount * (pricePerSession + optionalUpgrade))) *
                                numberOfSession) + bottleCost) * numberOfParticipants;
                            totalProgramCost = programCost;
                            totalProgramCost = programCost;
                            // Display booking details
                            outputLabel.Text = "Choosen program: " + program + "\n" +
                                    "Price per session: " + pricePerSession.ToString("C") + "\n" +
                                    "Number of session: " + numberOfSession + "\n" +
                                    "Number of participans: " + numberOfParticipants + "\n" +
                                    "Total session price: " + totalPriceOnSession.ToString("C") + "\n" +
                                    "Total optional upgrade cost: " + totalOptionalUpgrade.ToString("C") + "\n" +
                                    "Bundle discount Applied: " + discount.ToString("P0") + "\n" +
                                    "Personalized Bottle Cost: " + totalBottleCost.ToString("C2") + "\n" +
                                    "Amount need to be paid: " + totalProgramCost.ToString("C2");
                        }
                        // Calculations for number of participants greater than 3
                        else
                        {
                            bookButton.Enabled = true;
                            costSummaryLabel.Visible = true;
                            displayPanel.Visible = true;
                            // Group discount is applied if any one of the optional upgrade is selected
                            if (optionalUpgrade != 0)
                            {
                                programCost = ((((pricePerSession + optionalUpgrade) - (discount * (pricePerSession + optionalUpgrade))) *
                                     numberOfSession) + bottleCost) * numberOfParticipants;
                                groupDiscount = (programCost - (programCost * haloExtraDiscount));
                                totalProgramCost = groupDiscount;
                                // Display booking details
                                outputLabel.Text = "Choosen program: " + program + "\n" +
                                    "Price per session: " + pricePerSession.ToString("C") + "\n" +
                                    "Number of session: " + numberOfSession + "\n" +
                                    "Number of participans: " + numberOfParticipants + "\n" +
                                    "Total session price: " + totalPriceOnSession.ToString("C") + "\n" +
                                    "Total optional upgrade cost: " + totalOptionalUpgrade.ToString("C") + "\n" +
                                    "Bundle discount Applied: " + discount.ToString("P0") + "\n" +
                                    "Extra discount applied : " + haloExtraDiscount.ToString("P2") + "\n" +
                                    "Personalized Bottle Cost: " + totalBottleCost.ToString("C2") + "\n" +
                                    "Amount need to be paid: " + totalProgramCost.ToString("C2");
                            }
                            // Calculations if number of participants in greater than 3 and no optional upgrade is selected
                            else
                            {
                                programCost = ((((pricePerSession + optionalUpgrade) - (discount * (pricePerSession + optionalUpgrade))) *
                                   numberOfSession) + bottleCost) * numberOfParticipants;
                                totalProgramCost = programCost;
                                // Display booking details
                                outputLabel.Text = "Choosen program: " + program + "\n" +
                                   "Price per session: " + pricePerSession.ToString("C") + "\n" +
                                   "Number of session: " + numberOfSession + "\n" +
                                   "Number of participans: " + numberOfParticipants + "\n" +
                                   "Total session price: " + totalPriceOnSession.ToString("C") + "\n" +
                                   "Total optional upgrade cost: " + totalOptionalUpgrade.ToString("C") + "\n" +
                                   "Bundle discount Applied: " + discount.ToString("P0") + "\n" +
                                   "Personalized Bottle Cost: " + totalBottleCost.ToString("C2") + "\n" +
                                   "Amount need to be paid: " + totalProgramCost.ToString("C2");
                            }
                        }
                    }
                    // Result if number of participants is not valid
                    else
                    {
                        MessageBox.Show("Please provide a valid entry for the number of participants", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Result if number of sessions list box is not selected
                else
                {
                    MessageBox.Show("Please select the listed number of sessions", "Session needs tobe selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            // Result if program list box is not selected 
            else
            {
                MessageBox.Show("Please select the program", "Program needs tobe selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // Reset the selected entries when clear button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            programListBox.ClearSelected();
            sessionsListBox.ClearSelected();
            notRequiredRadioButton.Select();
            participantsNumberTextBox.Clear();
            customizedBottleCheckBox.Checked = false;
            freeBottleCheckBox.Checked = false;
            costSummaryLabel.Visible = false;
            displayPanel.Visible = false;
            bookButton.Enabled = false;
        }
        // Close the program when exit button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            // Confirmation message if book button is clicked
            string confirmationMessage = "Confirm Booking" + "\n" + "Choosen Program: " + program +
                "\n" + "Duration of the program: " + numberOfSession + " Sessions" +
                "\n" + "Total Cost: " + totalProgramCost.ToString("C2");

            DialogResult result = MessageBox.Show(confirmationMessage, "Booking Confirmation ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (numberOfParticipants > 3)
                {
                    if (oneToOneRadioButton.Checked || smallGroupRadioButton.Checked || mediumGroupRadioButton.Checked)
                    {
                        groupDiscountCount++;
                    }
                }
                MessageBox.Show("Booking confirmed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearButton_Click(sender, e);
                summaryButton.Enabled = true;

                // Calculating the sum of all program booking value
                programBookingTotalValue += totalProgramCost;
                revenueCount += 1;
                // Calculating average revenue
                averageRevenue = programBookingTotalValue / revenueCount;
                // Calculating total sessions from all booking
                totalSessions += numberOfSession;
                // Calculating total participants from all booking
                totalParticipants += numberOfParticipants;
                // Calculating total bottle cost from all booking
                totalBottleCostSum += totalBottleCost;
                sumTotalPriceOnSession += totalPriceOnSession;
                // Calculating total optional update cost from all booking
                sumTotalOptionalUpgrade += totalOptionalUpgrade;

            }
            // Mesaage if the booking is not confirmed
            else
            {
                MessageBox.Show("Booking canceled.", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        // Displaying total booking summary
        private void summaryButton_Click(object sender, EventArgs e)
        {
            costSummaryLabel.Visible = true;
            costSummaryLabel.Text = "Total cost summary";
            displayPanel.Visible = true;
            outputLabel.Text = "\n" + " Total Revenue: " + programBookingTotalValue.ToString("C2") + "\n" +
                " Average revenue per booking : " + averageRevenue.ToString("C2") + "\n" + "\n" +

                "Number of bookings with group discounts applied: " + groupDiscountCount + "\n" +
                "Total participants enrolled : " + totalParticipants + "\n" +
                "Total number of sessions booked: " + totalSessions + "\n" +
                "Total earnings from session bookings: " + sumTotalPriceOnSession.ToString("C2") + "\n" +
                "Total earnings from optional upgrades: " + sumTotalOptionalUpgrade.ToString("C2") + "\n" +
                "Total earnings from customised bottle : " + totalBottleCostSum.ToString("C2");
        }

        private void oneToOneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (oneToOneRadioButton.Checked)
            {
                optionalUpgrade = oneToOneTraining;
            }
            else
            {
                optionalUpgrade = 0;
            }
        }

        private void smallGroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (smallGroupRadioButton.Checked)
            {
                optionalUpgrade = smallGroupTraining;
            }
            else
            {
                optionalUpgrade = 0;
            }
        }

        private void mediumGroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumGroupRadioButton.Checked)
            {
                optionalUpgrade = mediumGroupTraining;
            }
            else
            {
                optionalUpgrade = 0;
            }
        }

        private void notRequiredRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (notRequiredRadioButton.Checked)
            {
                optionalUpgrade = noTraining;
            }
        }

        private void optionalUpgradeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (optionalUpgradeCheckBox.Checked)
            {
                optionalUpgradePanel.Enabled = true;
            }
            else
            {
                optionalUpgradePanel.Enabled = false;
            }
        }
    }
}