namespace Fruit_Basket
{
    /*
     public partial class Form1 : Form
     {
         const int APPLEPRICE = 30, BANANAPRICE = 10, ORANGEPRICE = 12, STRAWBERRYPRICE = 35, WATERMELONPRICE = 5, PINEAPPLEPRICE = 25;
         const int ONEITEM = 1, THREEITEM = 3, FIVEITEM = 5, TENITEM = 10, TWELVEITEM = 12, FIFTEENITEM = 15;
         public Form1()
         {
             InitializeComponent();
         }

         private void calculateButton_Click(object sender, EventArgs e)
         {
             int fruitIndex = 0, discountIndex = 0;
             int price = 0, numberOfItems = 0;
             int totalPrice = 0;

             if (fruitsDropDown.SelectedIndex != -1)
             {
                 if (quantityListBox.SelectedIndex != -1)
                 {
                     fruitIndex = fruitsDropDown.SelectedIndex;
                     discountIndex = quantityListBox.SelectedIndex;
                     switch (fruitIndex)
                     {
                         case 0:
                             price = APPLEPRICE; break;
                         case 1:
                             price = BANANAPRICE; break;
                         case 2:
                             price = ORANGEPRICE; break;
                         case 3:
                             price = STRAWBERRYPRICE; break;
                         case 4:
                             price = WATERMELONPRICE; break;
                         case 5:
                             price = PINEAPPLEPRICE; break;
                     }
                     switch (discountIndex)
                     {
                         case 0:
                             numberOfItems = ONEITEM; break;
                         case 1:
                             numberOfItems = THREEITEM; break;
                         case 2:
                             numberOfItems = FIVEITEM; break;
                         case 3:
                             numberOfItems = TENITEM; break;
                         case 4:
                             numberOfItems = TWELVEITEM; break;
                         case 5:
                             numberOfItems = FIFTEENITEM; break;
                     }
                     totalPrice = price * numberOfItems;
                     totalTextBox.Text = totalPrice.ToString();
                 }
                 else
                 {
                     MessageBox.Show("Enter a valid input");
                 }
             }
             else
             {
                 MessageBox.Show("Enter a valid input");
             }
         }
     }  */
    public partial class Form1 : Form
    {
        private readonly int[] prices = { 30, 10, 12, 35, 5, 25 };
        private readonly int[] quantities = { 1, 3, 5, 10, 12, 15 };
        private string[] fruitNames = { "Apple", "Banana", "Oranges", "Strawberry", "Watermelon", "Pineapple" };
        int totalPrice;

        int appleCount = 100, bananaCount = 100, orangeCount = 100, strawBerryCount = 100, waterMelonCount = 100, pineappleCount = 100;

        public Form1()
        {
            InitializeComponent();

            appleLabel.Visible = false;
            appletextBox.Visible = false;
            bananalabel.Visible = false;
            bananatextBox.Visible = false;
            orangelabel.Visible = false;
            orangetextBox.Visible = false;
            strawberrylabel.Visible = false;
            strawberrytextBox.Visible = false;
            watermelonlabel.Visible = false;
            watermelontextBox.Visible = false;
            pineapplelabel.Visible = false;
            pineappletextBox.Visible = false;
            quantitylabel.Visible = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int fruitIndex, discountIndex;
            int price, numberOfItems;

            if (fruitsDropDown.SelectedIndex != -1 && quantityListBox.SelectedIndex != -1)
            {
                fruitIndex = fruitsDropDown.SelectedIndex;
                discountIndex = quantityListBox.SelectedIndex;

                price = prices[fruitIndex];
                numberOfItems = quantities[discountIndex];

                totalPrice = price * numberOfItems;
                totalTextBox.Text = totalPrice.ToString();
            }
            else
            {
                MessageBox.Show("Enter a valid input");
            }

        }


        private void cartButton_Click(object sender, EventArgs e)
        {
            if (fruitsDropDown.SelectedIndex != -1 && quantityListBox.SelectedIndex != -1)
            {
                int fruitIndex = fruitsDropDown.SelectedIndex;
                int quantityIndex = quantityListBox.SelectedIndex;

                // Deduct the selected quantity from the respective fruit count
                switch (fruitIndex)
                {
                    case 0: // Apple
                        appleCount -= quantities[quantityIndex];
                        break;
                    case 1: // Banana
                        bananaCount -= quantities[quantityIndex];
                        break;
                    case 2: // Orange
                        orangeCount -= quantities[quantityIndex];
                        break;
                    case 3: // Strawberry
                        strawBerryCount -= quantities[quantityIndex];
                        break;
                    case 4: // Watermelon
                        waterMelonCount -= quantities[quantityIndex];
                        break;
                    case 5: // Pineapple
                        pineappleCount -= quantities[quantityIndex];
                        break;
                    default:
                        break;
                }

                // Display the updated counts in the respective text boxes
                appletextBox.Text = appleCount.ToString();
                bananatextBox.Text = bananaCount.ToString();
                orangetextBox.Text = orangeCount.ToString();
                strawberrytextBox.Text = strawBerryCount.ToString();
                watermelontextBox.Text = waterMelonCount.ToString();
                pineappletextBox.Text = pineappleCount.ToString();

                // Add the item to the cartListBox
                int totalPrice = prices[fruitIndex] * quantities[quantityIndex];
                string fruitName = fruitNames[fruitIndex];
                cartListBox.Items.Add($"{fruitName}: {totalPrice}");
            }
            else
            {
                MessageBox.Show("Enter a valid input");
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            int totalItems = 0;
            for (int i = 0; i < cartListBox.Items.Count; i++)
            {
                string itemString = cartListBox.Items[i].ToString();
                int currentItemPrice;

                // Extract the price from the item string
                if (int.TryParse(itemString.Split(':')[1].Trim(), out currentItemPrice))
                {
                    totalItems += currentItemPrice;
                }
            }
            totalLabel.Text = totalItems.ToString();
        }

        private void fileWriteButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = File.AppendText("fruits.txt"))
            {
                for (int i = 0; i < cartListBox.Items.Count; i++)
                {
                    string itemString = cartListBox.Items[i].ToString();
                    int currentItemPrice;

                    // Extract the price from the item string
                    if (int.TryParse(itemString.Split(':')[1].Trim(), out currentItemPrice))
                    {
                        outputFile.WriteLine(itemString);

                    }
                }
                outputFile.WriteLine(" ");
                outputFile.WriteLine($"Total: {totalLabel.Text}");

            }

            using (StreamReader inputFile = File.OpenText("fruits.txt"))
            {
                string fileContent = inputFile.ReadToEnd();
                fileWriteLabel.Text = fileContent;
            }
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            fruitsDropDown.Visible = false;
            quantityListBox.Visible = false;
            priceLabel.Visible = false;
            totalTextBox.Visible = false;
            calculateButton.Visible = false;
            cartListBox.Visible = false;
            totalLabel.Visible = false;
            cartButton.Visible = false;
            totalButton.Visible = false;
            fileWriteLabel.Visible = false;
            fileWriteButton.Visible = false;

            appleLabel.Visible = true;
            appletextBox.Visible = true;
            bananalabel.Visible = true;
            bananatextBox.Visible = true;
            orangelabel.Visible = true;
            orangetextBox.Visible = true;
            strawberrylabel.Visible = true;
            strawberrytextBox.Visible = true;
            watermelonlabel.Visible = true;
            watermelontextBox.Visible = true;
            pineapplelabel.Visible = true;
            pineappletextBox.Visible = true;
            quantitylabel.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            appletextBox.Text = appleCount.ToString();
            bananatextBox.Text = bananaCount.ToString();
            orangetextBox.Text = orangeCount.ToString();
            strawberrytextBox.Text = strawBerryCount.ToString();
            watermelontextBox.Text = waterMelonCount.ToString();
            pineappletextBox.Text = pineappleCount.ToString();

            fruitsDropDown.Visible = true;
            quantityListBox.Visible = true;
            priceLabel.Visible = true;
            totalTextBox.Visible = true;
            calculateButton.Visible = true;
            cartListBox.Visible = true;
            totalLabel.Visible = true;
            cartButton.Visible = true;
            totalButton.Visible = true;
            fileWriteLabel.Visible = true;
            fileWriteButton.Visible = true;

            appleLabel.Visible = false;
            appletextBox.Visible = false;
            bananalabel.Visible = false;
            bananatextBox.Visible = false;
            orangelabel.Visible = false;
            orangetextBox.Visible = false;
            strawberrylabel.Visible = false;
            strawberrytextBox.Visible = false;
            watermelonlabel.Visible = false;    
            watermelontextBox.Visible = false;
            pineapplelabel.Visible = false;
            pineappletextBox.Visible = false;
            quantitylabel.Visible = false;
        }
    }
}