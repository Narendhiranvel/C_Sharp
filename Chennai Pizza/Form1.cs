using System.Globalization;
using System.Transactions;

namespace Chennai_Pizza
{
    public partial class Form1 : Form
    {
        //Declaring Password
        const string ACTUALPASSWORD = "emp997";
        //Wrong password attempt count
        int remainingAttempts = 3;

        //initializing pizza items
        string[] pizzaItems = { "Texas BBQ", "Veg Supreme", "American Hot", "Farmhouse", "Hot and Spicy", "Tandoori Chicken",
            "Chicken Tikka", "Cheese Pizza", "Cheese and Corn", "Madras special", "Mumbai Special",
            "Andra Spice", "Kerala Supreme", "Delhi Special", "Fish and Prawn" };

        //initializing pizza prices
        int[] pizzaPrices = { 120, 90, 150, 175, 110, 125, 130, 80, 95, 135, 140, 145, 100, 75, 250 };

        //initializing total pizza quantities 
        int texasBbqQty = 50, vegSuperemeQty = 50, americanHotQty = 50, farmhouseQty = 50, hotAndSpicyQty = 50, tandooriChickenQty = 50, chickenTikkaQty = 50,
            cheezePizzaQty = 50, cheeseAndCornQty = 50, madrasSpecialQty = 50, mumbaiSpecialQty = 50, andraSpiceQty = 50, keralaSupremeQty = 50,
            delhiSpecialQty = 50, fishAndPrawnQty = 50;

        //initializing add on prices
        int[] addOnPrices = { 50, 30, 70, 20, 100, 0 };

        public Form1()
        {
            InitializeComponent();
            clearCartButton.Click += clearCartButton_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            passwordMaskedTextBox.Focus();
            itemsPanel.Visible = false;
            inventoryButton.Visible = false;
            shopNamelabel.Visible = false;
            exitButton.Visible = false;

        }
        //Login Button
        private void logInButton_Click(object sender, EventArgs e)
        {
            string checkPassword = passwordMaskedTextBox.Text;

            if (string.IsNullOrEmpty(checkPassword))
            {
                passwordMaskedTextBox.Focus();
                MessageBox.Show("Password Text Box is empty. Please enter a password.");
                return;
            }
            //Checking for correct password
            if (checkPassword == ACTUALPASSWORD)
            {
                loginPanel.Visible = false;
                itemsPanel.Visible = true;
                inventoryButton.Visible = true;
                shopNamelabel.Visible = true;
                exitButton.Visible = true;
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
                    logInButton.Enabled = false;
                    this.Close();
                }
            }
        }
        //total button functionality
        private void totalButton_Click(object sender, EventArgs e)
        {
            //initializing index for selecting items from combobox
            int pizzaIndex;
            int price, numberOfItems = 0;
            int addOn = 0;

            //If any item is selected from dropdown
            if (itemsComboBox.SelectedIndex != -1)
            {
                //points to index of selected item
                pizzaIndex = itemsComboBox.SelectedIndex;
                price = pizzaPrices[pizzaIndex];

                try
                {
                    //parsing for integer value
                    numberOfItems = int.Parse(quantityTextBox.Text);

                    // Check if the entered quantity is greater than the available stock
                    if (CheckStockAvailability(pizzaIndex, numberOfItems))
                    {
                        int availableQuantity = GetAvailableQuantity(pizzaIndex);
                        MessageBox.Show($"The entered quantity of {pizzaItems[pizzaIndex]} is not available. Available Quantity {GetAvailableQuantity(pizzaIndex)} ", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                //Catching invalid inputs
                catch
                {
                    MessageBox.Show("Please enter a valid number in quantity text box");
                    return;
                }

                // Check if at least one add on is selected
                if (friesRadioButton.Checked)
                {
                    addOn = addOnPrices[0];
                }
                else if (doubleCheeseRadioButton.Checked)
                {
                    addOn = addOnPrices[1];
                }
                else if (paneerRadioButton.Checked)
                {
                    addOn = addOnPrices[2];
                }
                else if (garlicSauceRadioButton.Checked)
                {
                    addOn = addOnPrices[3];
                }
                else if (chickenTenderRadioButton.Checked)
                {
                    addOn = addOnPrices[4];
                }
                else if (noAddOnRadioButton.Checked)
                {
                    addOn = addOnPrices[5];
                }
                else
                {
                    MessageBox.Show("Please select at least one add-on.");
                    return;
                }
                //formula for getting total
                decimal total = (price + addOn) * numberOfItems;

                // Apply discounts based on quantity selected
                decimal discount = 0;
                decimal discountPercentage = 0;
                if (numberOfItems >= 10)
                {
                    // 20% discount for 10 or more items
                    discountPercentage = 20;
                    discount = total * 0.2m;
                    total -= discount;
                }
                else if (numberOfItems >= 7)
                {
                    // 15% discount for 7 or more items
                    discountPercentage = 15;
                    discount = total * 0.15m;
                    total -= discount;
                }
                else if (numberOfItems >= 5)
                {
                    // 10% discount for 5 or more items
                    discountPercentage = 10;
                    discount = total * 0.1m;
                    total -= discount;
                }
                else if (numberOfItems >= 3)
                {
                    // 5% discount for 3 or more items
                    discountPercentage = 5;
                    discount = total * 0.05m;
                    total -= discount;
                }
                // Display the total as currency format
                totalTextBox.Text = total.ToString("C");
                discountLabel.Text = $"Discount Applied: {discount.ToString("C")}";
                discountPercentageLabel.Text = $"Discount Percentage: {discountPercentage}%";
            }
            else
            {
                MessageBox.Show("Please select an item from the items list.");
            }
        }

        // Function to get available quantity in inventory
        private int GetAvailableQuantity(int pizzaIndex)
        {
            switch (pizzaIndex)
            {
                case 0: return texasBbqQty;
                case 1: return vegSuperemeQty;
                case 2: return americanHotQty;
                case 3: return farmhouseQty;
                case 4: return hotAndSpicyQty;
                case 5: return tandooriChickenQty;
                case 6: return chickenTikkaQty;
                case 7: return cheezePizzaQty;
                case 8: return cheeseAndCornQty;
                case 9: return madrasSpecialQty;
                case 10: return mumbaiSpecialQty;
                case 11: return andraSpiceQty;
                case 12: return keralaSupremeQty;
                case 13: return delhiSpecialQty;
                case 14: return fishAndPrawnQty;
                default: return 0;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear selected item in ComboBox
            itemsComboBox.SelectedIndex = -1;
            // Uncheck add-ons RadioButtons
            friesRadioButton.Checked = false;
            doubleCheeseRadioButton.Checked = false;
            paneerRadioButton.Checked = false;
            garlicSauceRadioButton.Checked = false;
            chickenTenderRadioButton.Checked = false;
            noAddOnRadioButton.Checked = false;
            // Clear quantityTextBox
            quantityTextBox.Clear();
            // Clear totalTextBox
            totalTextBox.Clear();
            // Clear discountLabel
            discountLabel.Text = "Discount Applied: ";
            discountPercentageLabel.Text = "Discount Percentage: ";
        }

        private bool CheckStockAvailability(int pizzaIndex, int quantity)
        {
            switch (pizzaIndex)
            {
                case 0:
                    return quantity > vegSuperemeQty;
                case 1:
                    return quantity > vegSuperemeQty;
                case 2:
                    return quantity > americanHotQty;
                case 3:
                    return quantity > farmhouseQty;
                case 4:
                    return quantity > hotAndSpicyQty;
                case 5:
                    return quantity > tandooriChickenQty;
                case 6:
                    return quantity > chickenTikkaQty;
                case 7:
                    return quantity > cheezePizzaQty;
                case 8:
                    return quantity > cheeseAndCornQty;
                case 9:
                    return quantity > madrasSpecialQty;
                case 10:
                    return quantity > mumbaiSpecialQty;
                case 11:
                    return quantity > andraSpiceQty;
                case 12:
                    return quantity > keralaSupremeQty;
                case 13:
                    return quantity > delhiSpecialQty;
                case 14:
                    return quantity > fishAndPrawnQty;
                default:
                    return false;
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (itemsComboBox.SelectedIndex != -1)
            {
                string selectedItem = pizzaItems[itemsComboBox.SelectedIndex];
                int quantity;

                try
                {
                    quantity = int.Parse(quantityTextBox.Text);

                    // Check if the entered quantity is greater than the available stock
                    if (CheckStockAvailability(itemsComboBox.SelectedIndex, quantity))
                    {
                        MessageBox.Show($"Available quantity for {selectedItem} is insufficient.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number in quantity text box");
                    return;
                }

                int pizzaIndex = itemsComboBox.SelectedIndex;
                int price = pizzaPrices[pizzaIndex];
                int addOn = 0;

                // Check if at least one add-on is selected
                if (friesRadioButton.Checked)
                {
                    addOn = addOnPrices[0];
                }
                else if (doubleCheeseRadioButton.Checked)
                {
                    addOn = addOnPrices[1];
                }
                else if (paneerRadioButton.Checked)
                {
                    addOn = addOnPrices[2];
                }
                else if (garlicSauceRadioButton.Checked)
                {
                    addOn = addOnPrices[3];
                }
                else if (chickenTenderRadioButton.Checked)
                {
                    addOn = addOnPrices[4];
                }
                else if (noAddOnRadioButton.Checked)
                {
                    addOn = addOnPrices[5];
                }
                else
                {
                    MessageBox.Show("Please select at least one add-on.");
                    return;
                }

                decimal total = (price + addOn) * quantity;

                // Apply quantity-based discounts
                decimal discount = 0;
                decimal discountPercentage = 0;
                if (quantity >= 10)
                {
                    // 20% discount for 10 or more items
                    discountPercentage = 20;
                    discount = total * 0.2m;
                    total -= discount;
                }
                else if (quantity >= 7)
                {
                    // 15% discount for 7 or more items
                    discountPercentage = 15;
                    discount = total * 0.15m;
                    total -= discount;
                }
                else if (quantity >= 5)
                {
                    // 10% discount for 5 or more items
                    discountPercentage = 10;
                    discount = total * 0.1m;
                    total -= discount;
                }
                else if (quantity >= 3)
                {
                    // 5% discount for 3 or more items
                    discountPercentage = 5;
                    discount = total * 0.05m;
                    total -= discount;
                }

                string cartItem = $"x {quantity}, {selectedItem}: {total:C}";

                cartListBox.Items.Add(cartItem);
                UpdateInventory(pizzaIndex, quantity);  // Update inventory here
                ClearOrderDetails();
            }
            else
            {
                MessageBox.Show("Please select an item from the items list.");
            }
        }

        // Function to check and update inventory
        private void UpdateInventory(int pizzaIndex, int quantity)
        {
            switch (pizzaIndex)
            {
                case 0: texasBbqQty -= quantity; break;
                case 1: vegSuperemeQty -= quantity; break;
                case 2: americanHotQty -= quantity; break;
                case 3: farmhouseQty -= quantity; break;
                case 4: hotAndSpicyQty -= quantity; break;
                case 5: tandooriChickenQty -= quantity; break;
                case 6: chickenTikkaQty -= quantity; break;
                case 7: cheezePizzaQty -= quantity; break;
                case 8: cheeseAndCornQty -= quantity; break;
                case 9: madrasSpecialQty -= quantity; break;
                case 10: mumbaiSpecialQty -= quantity; break;
                case 11: andraSpiceQty -= quantity; break;
                case 12: keralaSupremeQty -= quantity; break;
                case 13: delhiSpecialQty -= quantity; break;
                case 14: fishAndPrawnQty -= quantity; break;
            }
        }

        private void ClearOrderDetails()
        {
            itemsComboBox.SelectedIndex = -1;
            friesRadioButton.Checked = false;
            doubleCheeseRadioButton.Checked = false;
            paneerRadioButton.Checked = false;
            garlicSauceRadioButton.Checked = false;
            chickenTenderRadioButton.Checked = false;
            noAddOnRadioButton.Checked = false;
            quantityTextBox.Clear();
            totalTextBox.Clear();
            discountLabel.Text = "Discount Applied: ";
            discountPercentageLabel.Text = "Discount Percentage: ";
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            cartListBox.Items.Clear();
        }

        //Generates Unique transaction ID
        private string GenerateTransactionId()
        {
            // Generate a random transaction ID with 2 letters and 4 numbers
            Random random = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string transactionId = $"{letters[random.Next(26)]}{letters[random.Next(26)]}{random.Next(10000):D4}";
            return transactionId;
        }
        //Fetches current date
        private string GetCurrentDate()
        {
            // Get the current date in the specified format
            return DateTime.Now.ToString("dd-MM-yyyy");
        }
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.Items.Count > 0)
            {
                decimal grandTotal = 0;

                // Accumulate the total amount from each item in the cart
                foreach (string cartItem in cartListBox.Items)
                {
                    // Extract the total amount from the cart item string
                    string[] parts = cartItem.Split(':');
                    if (parts.Length == 2 && decimal.TryParse(parts[1].Trim(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal itemTotal))
                    {
                        grandTotal += itemTotal;
                    }
                }

                // Generate transaction ID and get current date
                string transactionId = GenerateTransactionId();
                string transactionDate = GetCurrentDate();

                // Asks for confirmation with transaction ID
                DialogResult result = MessageBox.Show($"Transaction ID: {transactionId}\nDo you want to proceed with the checkout?\nGrand Total: {grandTotal:C}", "Checkout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Writes transaction details to "transactions.txt"
                    using (StreamWriter writer = new StreamWriter("transactions.txt", true))
                    {
                        writer.WriteLine($"Transaction Id: {transactionId}");
                        writer.WriteLine($"Date: {transactionDate}");
                        foreach (string cartItem in cartListBox.Items)
                        {
                            writer.WriteLine($"Item: {cartItem}");
                        }
                        writer.WriteLine($"Total: {grandTotal:C}");
                        writer.WriteLine(new string('_', 80));
                    }

                    MessageBox.Show("Checkout successful! Thank you for your order.", "Checkout Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the cart after successful checkout
                    cartListBox.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Checkout canceled.", "Checkout Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Your cart is empty. Add items before checking out.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchCriteria = searchTextBox.Text.Trim();
            searchListBox.Items.Clear();

            if (string.IsNullOrWhiteSpace(searchCriteria))
            {
                MessageBox.Show("Please enter a search term (e.g., Transaction ID or Date).", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (StreamReader inputFile = File.OpenText("transactions.txt"))
                {
                    string transactionDetails = "";
                    bool isMatchingTransaction = false;

                    while (!inputFile.EndOfStream)
                    {
                        string line = inputFile.ReadLine();

                        // Checks for the word
                        if (transactionRadioButton.Checked && line.Trim().StartsWith("Transaction Id:", StringComparison.OrdinalIgnoreCase))
                        {
                            string transacId = line.Replace("Transaction Id:", "");
                            // Transaction ID Radio button should be clicked for searching by trans id
                            if (transacId.Trim() == searchCriteria)
                            {
                                isMatchingTransaction = true;
                            }
                            else
                            {
                                isMatchingTransaction = false;
                            }
                        }
                        // Check for the date
                        else if (dateRadioButton.Checked && line.Trim().StartsWith("Date:", StringComparison.OrdinalIgnoreCase))
                        {
                            string transacDate = line.Replace("Date:", "").Trim();
                            // Date Radio button should be clicked for searching by date
                            if (transacDate == searchCriteria)
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

                        // Check for the separator line to reset the flag
                        if (line.Contains(new string('_', 80)))
                        {
                            isMatchingTransaction = false;
                        }
                    }

                    if (!string.IsNullOrEmpty(transactionDetails))
                    {
                        // Print all the lines
                        foreach (string line1 in transactionDetails.Split('\n'))
                        {
                            if (!string.IsNullOrWhiteSpace(line1))
                            {
                                searchListBox.Items.Add(line1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            {
                decimal totalRevenue = 0;
                int count = 0;
                decimal averageRevenuePerOrder = 0;

                List<string> transactionIds = new List<string>();

                try
                {
                    using (StreamReader inputFile = File.OpenText("transactions.txt"))
                    {
                        string line;
                        string currentTransactionId = null;

                        while ((line = inputFile.ReadLine()) != null)
                        {
                            if (line.StartsWith("Transaction Id:"))
                            {
                                // If a new transaction ID is found, accumulate the total for the previous transaction
                                if (currentTransactionId != null)
                                {
                                    count++;
                                    // Add transaction ID to the list
                                    transactionIds.Add(currentTransactionId);
                                }

                                currentTransactionId = line.Replace("Transaction Id:", "").Trim();
                            }
                            else if (line.StartsWith("Total: ₹"))
                            {
                                // Extract and parse the total amount
                                string value = line.Substring(line.IndexOf('₹') + 1).Trim();
                                if (decimal.TryParse(value, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalAmount))
                                {
                                    totalRevenue += totalAmount;
                                }
                            }
                        }

                        // Account for the last transaction in the file
                        if (currentTransactionId != null)
                        {
                            count++;
                            // Add the last transaction ID to the list
                            transactionIds.Add(currentTransactionId);
                        }
                    }

                    if (count > 0)
                    {
                        averageRevenuePerOrder = totalRevenue / count;

                        // Clear existing items
                        summaryListBox.Items.Clear();

                        // Display all transaction IDs
                        foreach (var transactionId in transactionIds)
                        {
                            summaryListBox.Items.Add("Transaction Id: " + transactionId);
                        }

                        // Display summary information
                        summaryListBox.Items.Add("");
                        // Empty line for separation
                        summaryListBox.Items.Add("Total Revenue: " + totalRevenue.ToString("C"));
                        summaryListBox.Items.Add("Number of Orders: " + count);
                        summaryListBox.Items.Add("Average Revenue per Order: " + averageRevenuePerOrder.ToString("C"));
                    }
                    else
                    {
                        MessageBox.Show("No transaction details found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while reading the transactions file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Pass inventory quantities to Form2
            form2.SetInventoryQuantities(texasBbqQty, vegSuperemeQty, americanHotQty, farmhouseQty, hotAndSpicyQty,
                tandooriChickenQty, chickenTikkaQty, cheezePizzaQty, cheeseAndCornQty, madrasSpecialQty, mumbaiSpecialQty,
                andraSpiceQty, keralaSupremeQty, delhiSpecialQty, fishAndPrawnQty);

            // Show Form2 as a dialog (blocking until Form2 is closed)
            form2.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchClearButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            searchListBox.Items.Clear();
        }
    }
}