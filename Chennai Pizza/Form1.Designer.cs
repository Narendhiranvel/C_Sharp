namespace Chennai_Pizza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginPanel = new Panel();
            passwordIncorrectLabel = new Label();
            passwordMaskedTextBox = new MaskedTextBox();
            logInButton = new Button();
            pizzaLabel = new Label();
            pizzaPictureBox = new PictureBox();
            itemsPanel = new Panel();
            logoPic1PictureBox = new PictureBox();
            summaryListBox = new ListBox();
            summaryButton = new Button();
            searchByDateTransPanel = new Panel();
            searchClearButton = new Button();
            searchListBox = new ListBox();
            searchPanel = new Panel();
            searchTextBox = new TextBox();
            searchButton = new Button();
            dateRadioButton = new RadioButton();
            transactionRadioButton = new RadioButton();
            checkOutButton = new Button();
            clearCartButton = new Button();
            clearButton = new Button();
            discountPercentageLabel = new Label();
            discountLabel = new Label();
            totalTextBox = new TextBox();
            totalButton = new Button();
            cartListBox = new ListBox();
            addToCartButton = new Button();
            quantityTextBox = new TextBox();
            quantityLabel = new Label();
            noAddOnRadioButton = new RadioButton();
            chickenTenderRadioButton = new RadioButton();
            garlicSauceRadioButton = new RadioButton();
            paneerRadioButton = new RadioButton();
            doubleCheeseRadioButton = new RadioButton();
            friesRadioButton = new RadioButton();
            addOnLabel = new Label();
            itemsComboBox = new ComboBox();
            itemsLabel = new Label();
            inventoryButton = new Button();
            shopNamelabel = new Label();
            exitButton = new Button();
            clearSummaryButton = new Button();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pizzaPictureBox).BeginInit();
            itemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPic1PictureBox).BeginInit();
            searchByDateTransPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.BurlyWood;
            loginPanel.Controls.Add(passwordIncorrectLabel);
            loginPanel.Controls.Add(passwordMaskedTextBox);
            loginPanel.Controls.Add(logInButton);
            loginPanel.Controls.Add(pizzaLabel);
            loginPanel.Controls.Add(pizzaPictureBox);
            loginPanel.Location = new Point(525, 80);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(307, 427);
            loginPanel.TabIndex = 0;
            // 
            // passwordIncorrectLabel
            // 
            passwordIncorrectLabel.AutoSize = true;
            passwordIncorrectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordIncorrectLabel.ForeColor = Color.Red;
            passwordIncorrectLabel.Location = new Point(84, 330);
            passwordIncorrectLabel.Name = "passwordIncorrectLabel";
            passwordIncorrectLabel.Size = new Size(0, 20);
            passwordIncorrectLabel.TabIndex = 5;
            // 
            // passwordMaskedTextBox
            // 
            passwordMaskedTextBox.Location = new Point(62, 241);
            passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            passwordMaskedTextBox.PasswordChar = '*';
            passwordMaskedTextBox.Size = new Size(187, 27);
            passwordMaskedTextBox.TabIndex = 4;
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.SandyBrown;
            logInButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.ForeColor = SystemColors.ButtonHighlight;
            logInButton.Location = new Point(107, 286);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(94, 29);
            logInButton.TabIndex = 3;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // pizzaLabel
            // 
            pizzaLabel.AutoSize = true;
            pizzaLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            pizzaLabel.ForeColor = Color.MidnightBlue;
            pizzaLabel.Location = new Point(84, 179);
            pizzaLabel.Name = "pizzaLabel";
            pizzaLabel.Size = new Size(153, 28);
            pizzaLabel.TabIndex = 1;
            pizzaLabel.Text = "Chennai Pizza's";
            // 
            // pizzaPictureBox
            // 
            pizzaPictureBox.Image = (Image)resources.GetObject("pizzaPictureBox.Image");
            pizzaPictureBox.Location = new Point(62, 25);
            pizzaPictureBox.Name = "pizzaPictureBox";
            pizzaPictureBox.Size = new Size(187, 151);
            pizzaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pizzaPictureBox.TabIndex = 0;
            pizzaPictureBox.TabStop = false;
            // 
            // itemsPanel
            // 
            itemsPanel.BackColor = Color.BurlyWood;
            itemsPanel.Controls.Add(clearSummaryButton);
            itemsPanel.Controls.Add(logoPic1PictureBox);
            itemsPanel.Controls.Add(summaryListBox);
            itemsPanel.Controls.Add(summaryButton);
            itemsPanel.Controls.Add(searchByDateTransPanel);
            itemsPanel.Controls.Add(checkOutButton);
            itemsPanel.Controls.Add(clearCartButton);
            itemsPanel.Controls.Add(clearButton);
            itemsPanel.Controls.Add(discountPercentageLabel);
            itemsPanel.Controls.Add(discountLabel);
            itemsPanel.Controls.Add(totalTextBox);
            itemsPanel.Controls.Add(totalButton);
            itemsPanel.Controls.Add(cartListBox);
            itemsPanel.Controls.Add(addToCartButton);
            itemsPanel.Controls.Add(quantityTextBox);
            itemsPanel.Controls.Add(quantityLabel);
            itemsPanel.Controls.Add(noAddOnRadioButton);
            itemsPanel.Controls.Add(chickenTenderRadioButton);
            itemsPanel.Controls.Add(garlicSauceRadioButton);
            itemsPanel.Controls.Add(paneerRadioButton);
            itemsPanel.Controls.Add(doubleCheeseRadioButton);
            itemsPanel.Controls.Add(friesRadioButton);
            itemsPanel.Controls.Add(addOnLabel);
            itemsPanel.Controls.Add(itemsComboBox);
            itemsPanel.Controls.Add(itemsLabel);
            itemsPanel.Location = new Point(25, 83);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(1256, 585);
            itemsPanel.TabIndex = 1;
            // 
            // logoPic1PictureBox
            // 
            logoPic1PictureBox.Image = (Image)resources.GetObject("logoPic1PictureBox.Image");
            logoPic1PictureBox.Location = new Point(289, 87);
            logoPic1PictureBox.Name = "logoPic1PictureBox";
            logoPic1PictureBox.Size = new Size(128, 107);
            logoPic1PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPic1PictureBox.TabIndex = 25;
            logoPic1PictureBox.TabStop = false;
            // 
            // summaryListBox
            // 
            summaryListBox.FormattingEnabled = true;
            summaryListBox.HorizontalScrollbar = true;
            summaryListBox.ItemHeight = 20;
            summaryListBox.Location = new Point(936, 154);
            summaryListBox.Name = "summaryListBox";
            summaryListBox.Size = new Size(293, 364);
            summaryListBox.TabIndex = 24;
            // 
            // summaryButton
            // 
            summaryButton.BackColor = Color.SandyBrown;
            summaryButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            summaryButton.Location = new Point(1031, 102);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(94, 29);
            summaryButton.TabIndex = 23;
            summaryButton.Text = "&Summary";
            summaryButton.UseVisualStyleBackColor = false;
            summaryButton.Click += summaryButton_Click;
            // 
            // searchByDateTransPanel
            // 
            searchByDateTransPanel.BackColor = Color.LemonChiffon;
            searchByDateTransPanel.Controls.Add(searchClearButton);
            searchByDateTransPanel.Controls.Add(searchListBox);
            searchByDateTransPanel.Controls.Add(searchPanel);
            searchByDateTransPanel.Controls.Add(dateRadioButton);
            searchByDateTransPanel.Controls.Add(transactionRadioButton);
            searchByDateTransPanel.Location = new Point(442, 148);
            searchByDateTransPanel.Name = "searchByDateTransPanel";
            searchByDateTransPanel.Size = new Size(465, 420);
            searchByDateTransPanel.TabIndex = 16;
            // 
            // searchClearButton
            // 
            searchClearButton.BackColor = Color.SandyBrown;
            searchClearButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            searchClearButton.Location = new Point(17, 102);
            searchClearButton.Name = "searchClearButton";
            searchClearButton.Size = new Size(84, 29);
            searchClearButton.TabIndex = 22;
            searchClearButton.Text = "Clear";
            searchClearButton.UseVisualStyleBackColor = false;
            searchClearButton.Click += searchClearButton_Click;
            // 
            // searchListBox
            // 
            searchListBox.FormattingEnabled = true;
            searchListBox.ItemHeight = 20;
            searchListBox.Location = new Point(17, 137);
            searchListBox.Name = "searchListBox";
            searchListBox.Size = new Size(429, 264);
            searchListBox.TabIndex = 21;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.BurlyWood;
            searchPanel.Controls.Add(searchTextBox);
            searchPanel.Controls.Add(searchButton);
            searchPanel.Location = new Point(202, 13);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(238, 108);
            searchPanel.TabIndex = 11;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(58, 20);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(125, 27);
            searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.SandyBrown;
            searchButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(75, 64);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 20;
            searchButton.Text = "&Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // dateRadioButton
            // 
            dateRadioButton.AutoSize = true;
            dateRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateRadioButton.Location = new Point(17, 58);
            dateRadioButton.Name = "dateRadioButton";
            dateRadioButton.Size = new Size(133, 24);
            dateRadioButton.TabIndex = 18;
            dateRadioButton.TabStop = true;
            dateRadioButton.Text = "Search By Date";
            dateRadioButton.UseVisualStyleBackColor = true;
            // 
            // transactionRadioButton
            // 
            transactionRadioButton.AutoSize = true;
            transactionRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            transactionRadioButton.Location = new Point(17, 22);
            transactionRadioButton.Name = "transactionRadioButton";
            transactionRadioButton.Size = new Size(179, 24);
            transactionRadioButton.TabIndex = 17;
            transactionRadioButton.TabStop = true;
            transactionRadioButton.Text = "Search By Transaction";
            transactionRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkOutButton
            // 
            checkOutButton.BackColor = Color.SandyBrown;
            checkOutButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkOutButton.Location = new Point(94, 503);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(89, 29);
            checkOutButton.TabIndex = 14;
            checkOutButton.Text = "Check Out";
            checkOutButton.UseVisualStyleBackColor = false;
            checkOutButton.Click += checkOutButton_Click;
            // 
            // clearCartButton
            // 
            clearCartButton.BackColor = Color.SandyBrown;
            clearCartButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearCartButton.Location = new Point(209, 503);
            clearCartButton.Name = "clearCartButton";
            clearCartButton.Size = new Size(89, 29);
            clearCartButton.TabIndex = 15;
            clearCartButton.Text = "Clear Cart";
            clearCartButton.UseVisualStyleBackColor = false;
            clearCartButton.Click += clearCartButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.SandyBrown;
            clearButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Location = new Point(255, 228);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(84, 29);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // discountPercentageLabel
            // 
            discountPercentageLabel.AutoSize = true;
            discountPercentageLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            discountPercentageLabel.Location = new Point(29, 174);
            discountPercentageLabel.Name = "discountPercentageLabel";
            discountPercentageLabel.Size = new Size(0, 20);
            discountPercentageLabel.TabIndex = 16;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            discountLabel.Location = new Point(31, 206);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(0, 20);
            discountLabel.TabIndex = 15;
            // 
            // totalTextBox
            // 
            totalTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            totalTextBox.Location = new Point(126, 133);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(94, 27);
            totalTextBox.TabIndex = 10;
            // 
            // totalButton
            // 
            totalButton.BackColor = Color.SandyBrown;
            totalButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            totalButton.Location = new Point(28, 133);
            totalButton.Name = "totalButton";
            totalButton.Size = new Size(84, 29);
            totalButton.TabIndex = 9;
            totalButton.Text = "&Total";
            totalButton.UseVisualStyleBackColor = false;
            totalButton.Click += totalButton_Click;
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 20;
            cartListBox.Location = new Point(28, 273);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(351, 204);
            cartListBox.TabIndex = 12;
            // 
            // addToCartButton
            // 
            addToCartButton.BackColor = Color.SandyBrown;
            addToCartButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addToCartButton.Location = new Point(126, 229);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(104, 29);
            addToCartButton.TabIndex = 11;
            addToCartButton.Text = "Add to Cart";
            addToCartButton.UseVisualStyleBackColor = false;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            quantityTextBox.Location = new Point(126, 84);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(94, 27);
            quantityTextBox.TabIndex = 8;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.MidnightBlue;
            quantityLabel.Location = new Point(28, 87);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(70, 20);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "Quantity";
            // 
            // noAddOnRadioButton
            // 
            noAddOnRadioButton.AutoSize = true;
            noAddOnRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            noAddOnRadioButton.ForeColor = Color.MidnightBlue;
            noAddOnRadioButton.Location = new Point(744, 75);
            noAddOnRadioButton.Name = "noAddOnRadioButton";
            noAddOnRadioButton.Size = new Size(115, 24);
            noAddOnRadioButton.TabIndex = 7;
            noAddOnRadioButton.TabStop = true;
            noAddOnRadioButton.Text = "No Add On's\r\n";
            noAddOnRadioButton.UseVisualStyleBackColor = true;
            // 
            // chickenTenderRadioButton
            // 
            chickenTenderRadioButton.AutoSize = true;
            chickenTenderRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chickenTenderRadioButton.ForeColor = Color.MidnightBlue;
            chickenTenderRadioButton.Location = new Point(598, 75);
            chickenTenderRadioButton.Name = "chickenTenderRadioButton";
            chickenTenderRadioButton.Size = new Size(141, 44);
            chickenTenderRadioButton.TabIndex = 6;
            chickenTenderRadioButton.TabStop = true;
            chickenTenderRadioButton.Text = "Chicken Tenders\r\n         ₹100";
            chickenTenderRadioButton.UseVisualStyleBackColor = true;
            // 
            // garlicSauceRadioButton
            // 
            garlicSauceRadioButton.AutoSize = true;
            garlicSauceRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            garlicSauceRadioButton.ForeColor = Color.MidnightBlue;
            garlicSauceRadioButton.Location = new Point(442, 75);
            garlicSauceRadioButton.Name = "garlicSauceRadioButton";
            garlicSauceRadioButton.Size = new Size(113, 44);
            garlicSauceRadioButton.TabIndex = 5;
            garlicSauceRadioButton.TabStop = true;
            garlicSauceRadioButton.Text = "Garlic Sauce\r\n       ₹20";
            garlicSauceRadioButton.UseVisualStyleBackColor = true;
            // 
            // paneerRadioButton
            // 
            paneerRadioButton.AutoSize = true;
            paneerRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            paneerRadioButton.ForeColor = Color.MidnightBlue;
            paneerRadioButton.Location = new Point(744, 20);
            paneerRadioButton.Name = "paneerRadioButton";
            paneerRadioButton.Size = new Size(144, 44);
            paneerRadioButton.TabIndex = 4;
            paneerRadioButton.TabStop = true;
            paneerRadioButton.Text = "Paneer Toppings\r\n          ₹70";
            paneerRadioButton.UseVisualStyleBackColor = true;
            // 
            // doubleCheeseRadioButton
            // 
            doubleCheeseRadioButton.AutoSize = true;
            doubleCheeseRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            doubleCheeseRadioButton.ForeColor = Color.MidnightBlue;
            doubleCheeseRadioButton.Location = new Point(598, 20);
            doubleCheeseRadioButton.Name = "doubleCheeseRadioButton";
            doubleCheeseRadioButton.Size = new Size(140, 44);
            doubleCheeseRadioButton.TabIndex = 3;
            doubleCheeseRadioButton.TabStop = true;
            doubleCheeseRadioButton.Text = "Double Cheese  \r\n        ₹30";
            doubleCheeseRadioButton.UseVisualStyleBackColor = true;
            // 
            // friesRadioButton
            // 
            friesRadioButton.AutoSize = true;
            friesRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            friesRadioButton.ForeColor = Color.MidnightBlue;
            friesRadioButton.Location = new Point(442, 20);
            friesRadioButton.Name = "friesRadioButton";
            friesRadioButton.Size = new Size(148, 44);
            friesRadioButton.TabIndex = 2;
            friesRadioButton.TabStop = true;
            friesRadioButton.Text = "Fries and Drinks  \r\n        ₹50";
            friesRadioButton.UseVisualStyleBackColor = true;
            // 
            // addOnLabel
            // 
            addOnLabel.AutoSize = true;
            addOnLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addOnLabel.ForeColor = Color.MidnightBlue;
            addOnLabel.Location = new Point(359, 32);
            addOnLabel.Name = "addOnLabel";
            addOnLabel.Size = new Size(77, 20);
            addOnLabel.TabIndex = 2;
            addOnLabel.Text = "Add on's :";
            // 
            // itemsComboBox
            // 
            itemsComboBox.BackColor = SystemColors.ScrollBar;
            itemsComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            itemsComboBox.ForeColor = Color.MediumBlue;
            itemsComboBox.FormattingEnabled = true;
            itemsComboBox.Items.AddRange(new object[] { "Texas BBQ                ₹120", "Veg Supreme           ₹90", "American Hot          ₹150", "Farmhouse               ₹175", "Hot and Spicy          ₹110", "Tandoori Chicken     ₹125", "Chicken Tikka           ₹130", "Cheese Pizza            ₹80", "Cheese and Corn     ₹95", "Madras Special        ₹135", "Mumbai Special      ₹140", "Andra Spice             ₹145", "Kerala Supreme       ₹100", "Delhi Special           ₹75", "Fish and prawn        ₹250" });
            itemsComboBox.Location = new Point(94, 29);
            itemsComboBox.Name = "itemsComboBox";
            itemsComboBox.Size = new Size(204, 28);
            itemsComboBox.TabIndex = 1;
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            itemsLabel.ForeColor = Color.MidnightBlue;
            itemsLabel.Location = new Point(28, 32);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new Size(49, 20);
            itemsLabel.TabIndex = 0;
            itemsLabel.Text = "Items";
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.SandyBrown;
            inventoryButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryButton.Location = new Point(622, 695);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(104, 29);
            inventoryButton.TabIndex = 22;
            inventoryButton.Text = "I&nventory";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // shopNamelabel
            // 
            shopNamelabel.AutoSize = true;
            shopNamelabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            shopNamelabel.ForeColor = Color.MidnightBlue;
            shopNamelabel.Location = new Point(573, 40);
            shopNamelabel.Name = "shopNamelabel";
            shopNamelabel.Size = new Size(153, 28);
            shopNamelabel.TabIndex = 26;
            shopNamelabel.Text = "Chennai Pizza's";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.SandyBrown;
            exitButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(1177, 695);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(104, 29);
            exitButton.TabIndex = 25;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // clearSummaryButton
            // 
            clearSummaryButton.BackColor = Color.SandyBrown;
            clearSummaryButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearSummaryButton.Location = new Point(1041, 539);
            clearSummaryButton.Name = "clearSummaryButton";
            clearSummaryButton.Size = new Size(84, 29);
            clearSummaryButton.TabIndex = 26;
            clearSummaryButton.Text = "Clear";
            clearSummaryButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 790);
            Controls.Add(exitButton);
            Controls.Add(shopNamelabel);
            Controls.Add(inventoryButton);
            Controls.Add(itemsPanel);
            Controls.Add(loginPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pizzaPictureBox).EndInit();
            itemsPanel.ResumeLayout(false);
            itemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPic1PictureBox).EndInit();
            searchByDateTransPanel.ResumeLayout(false);
            searchByDateTransPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginPanel;
        private PictureBox pizzaPictureBox;
        private Label pizzaLabel;
        private Button logInButton;
        private MaskedTextBox passwordMaskedTextBox;
        private Label passwordIncorrectLabel;
        private Panel itemsPanel;
        private Label itemsLabel;
        private ComboBox itemsComboBox;
        private Label addOnLabel;
        private RadioButton friesRadioButton;
        private RadioButton doubleCheeseRadioButton;
        private RadioButton paneerRadioButton;
        private RadioButton garlicSauceRadioButton;
        private RadioButton chickenTenderRadioButton;
        private RadioButton noAddOnRadioButton;
        private Label quantityLabel;
        private TextBox quantityTextBox;
        private Button addToCartButton;
        private ListBox cartListBox;
        private Button totalButton;
        private TextBox totalTextBox;
        private Label discountLabel;
        private Label discountPercentageLabel;
        private Button clearButton;
        private Button clearCartButton;
        private Button checkOutButton;
        private Panel searchByDateTransPanel;
        private RadioButton transactionRadioButton;
        private RadioButton dateRadioButton;
        private Panel searchPanel;
        private TextBox searchTextBox;
        private Button searchButton;
        private ListBox searchListBox;
        private Button summaryButton;
        private ListBox summaryListBox;
        private Button inventoryButton;
        private PictureBox logoPic1PictureBox;
        private Label shopNamelabel;
        private Button exitButton;
        private Button searchClearButton;
        private Button clearSummaryButton;
    }
}