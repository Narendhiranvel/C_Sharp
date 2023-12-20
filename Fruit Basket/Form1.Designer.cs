namespace Fruit_Basket
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
            quantityListBox = new ListBox();
            calculateButton = new Button();
            priceLabel = new Label();
            totalTextBox = new TextBox();
            fruitsDropDown = new ComboBox();
            cartButton = new Button();
            cartListBox = new ListBox();
            totalButton = new Button();
            fileWriteLabel = new Label();
            fileWriteButton = new Button();
            totalLabel = new Label();
            inventoryButton = new Button();
            backButton = new Button();
            appleLabel = new Label();
            appletextBox = new TextBox();
            bananalabel = new Label();
            bananatextBox = new TextBox();
            orangelabel = new Label();
            orangetextBox = new TextBox();
            strawberrylabel = new Label();
            watermelonlabel = new Label();
            pineapplelabel = new Label();
            strawberrytextBox = new TextBox();
            watermelontextBox = new TextBox();
            pineappletextBox = new TextBox();
            quantitylabel = new Label();
            SuspendLayout();
            // 
            // quantityListBox
            // 
            quantityListBox.FormattingEnabled = true;
            quantityListBox.ItemHeight = 20;
            quantityListBox.Items.AddRange(new object[] { "          1           ", "          3           ", "          5          ", "          10         ", "          12         ", "          15         " });
            quantityListBox.Location = new Point(260, 47);
            quantityListBox.Name = "quantityListBox";
            quantityListBox.Size = new Size(109, 144);
            quantityListBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(260, 207);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 29);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(30, 207);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price";
            // 
            // totalTextBox
            // 
            totalTextBox.Location = new Point(90, 204);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(125, 27);
            totalTextBox.TabIndex = 4;
            // 
            // fruitsDropDown
            // 
            fruitsDropDown.FormattingEnabled = true;
            fruitsDropDown.Items.AddRange(new object[] { "Apple              ₹30", "Banana            ₹10", "Oranges          ₹12", "Strawberry      ₹35", "Watermelon    ₹5", "Pineapple        ₹25" });
            fruitsDropDown.Location = new Point(64, 47);
            fruitsDropDown.Name = "fruitsDropDown";
            fruitsDropDown.Size = new Size(151, 28);
            fruitsDropDown.TabIndex = 5;
            fruitsDropDown.Text = "Fruits";
            // 
            // cartButton
            // 
            cartButton.Location = new Point(45, 455);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(94, 58);
            cartButton.TabIndex = 6;
            cartButton.Text = "Add To Cart";
            cartButton.UseVisualStyleBackColor = true;
            cartButton.Click += cartButton_Click;
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 20;
            cartListBox.Location = new Point(45, 307);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(207, 124);
            cartListBox.TabIndex = 7;
            // 
            // totalButton
            // 
            totalButton.Location = new Point(158, 455);
            totalButton.Name = "totalButton";
            totalButton.Size = new Size(94, 29);
            totalButton.TabIndex = 8;
            totalButton.Text = "Total";
            totalButton.UseVisualStyleBackColor = true;
            totalButton.Click += totalButton_Click;
            // 
            // fileWriteLabel
            // 
            fileWriteLabel.AutoSize = true;
            fileWriteLabel.Location = new Point(515, 299);
            fileWriteLabel.Name = "fileWriteLabel";
            fileWriteLabel.Size = new Size(50, 20);
            fileWriteLabel.TabIndex = 9;
            fileWriteLabel.Text = "label1";
            // 
            // fileWriteButton
            // 
            fileWriteButton.Location = new Point(493, 402);
            fileWriteButton.Name = "fileWriteButton";
            fileWriteButton.Size = new Size(94, 29);
            fileWriteButton.TabIndex = 10;
            fileWriteButton.Text = "File";
            fileWriteButton.UseVisualStyleBackColor = true;
            fileWriteButton.Click += fileWriteButton_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(312, 318);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(50, 20);
            totalLabel.TabIndex = 11;
            totalLabel.Text = "label1";
            // 
            // inventoryButton
            // 
            inventoryButton.Location = new Point(493, 455);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(94, 29);
            inventoryButton.TabIndex = 12;
            inventoryButton.Text = "Inventory";
            inventoryButton.UseVisualStyleBackColor = true;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(663, 484);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 13;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // appleLabel
            // 
            appleLabel.AutoSize = true;
            appleLabel.Location = new Point(381, 62);
            appleLabel.Name = "appleLabel";
            appleLabel.Size = new Size(49, 20);
            appleLabel.TabIndex = 14;
            appleLabel.Text = "Apple";
            // 
            // appletextBox
            // 
            appletextBox.Location = new Point(493, 62);
            appletextBox.Name = "appletextBox";
            appletextBox.Size = new Size(125, 27);
            appletextBox.TabIndex = 15;
            // 
            // bananalabel
            // 
            bananalabel.AutoSize = true;
            bananalabel.Location = new Point(381, 114);
            bananalabel.Name = "bananalabel";
            bananalabel.Size = new Size(58, 20);
            bananalabel.TabIndex = 16;
            bananalabel.Text = "Banana";
            // 
            // bananatextBox
            // 
            bananatextBox.Location = new Point(493, 114);
            bananatextBox.Name = "bananatextBox";
            bananatextBox.Size = new Size(125, 27);
            bananatextBox.TabIndex = 17;
            // 
            // orangelabel
            // 
            orangelabel.AutoSize = true;
            orangelabel.Location = new Point(381, 160);
            orangelabel.Name = "orangelabel";
            orangelabel.Size = new Size(58, 20);
            orangelabel.TabIndex = 18;
            orangelabel.Text = "Orange";
            // 
            // orangetextBox
            // 
            orangetextBox.Location = new Point(493, 157);
            orangetextBox.Name = "orangetextBox";
            orangetextBox.Size = new Size(125, 27);
            orangetextBox.TabIndex = 19;
            // 
            // strawberrylabel
            // 
            strawberrylabel.AutoSize = true;
            strawberrylabel.Location = new Point(381, 211);
            strawberrylabel.Name = "strawberrylabel";
            strawberrylabel.Size = new Size(80, 20);
            strawberrylabel.TabIndex = 20;
            strawberrylabel.Text = "Strawberry";
            // 
            // watermelonlabel
            // 
            watermelonlabel.AutoSize = true;
            watermelonlabel.Location = new Point(381, 262);
            watermelonlabel.Name = "watermelonlabel";
            watermelonlabel.Size = new Size(90, 20);
            watermelonlabel.TabIndex = 21;
            watermelonlabel.Text = "Watermelon";
            // 
            // pineapplelabel
            // 
            pineapplelabel.AutoSize = true;
            pineapplelabel.Location = new Point(381, 307);
            pineapplelabel.Name = "pineapplelabel";
            pineapplelabel.Size = new Size(75, 20);
            pineapplelabel.TabIndex = 22;
            pineapplelabel.Text = "Pineapple";
            // 
            // strawberrytextBox
            // 
            strawberrytextBox.Location = new Point(493, 204);
            strawberrytextBox.Name = "strawberrytextBox";
            strawberrytextBox.Size = new Size(125, 27);
            strawberrytextBox.TabIndex = 23;
            // 
            // watermelontextBox
            // 
            watermelontextBox.Location = new Point(493, 255);
            watermelontextBox.Name = "watermelontextBox";
            watermelontextBox.Size = new Size(125, 27);
            watermelontextBox.TabIndex = 24;
            // 
            // pineappletextBox
            // 
            pineappletextBox.Location = new Point(493, 304);
            pineappletextBox.Name = "pineappletextBox";
            pineappletextBox.Size = new Size(125, 27);
            pineappletextBox.TabIndex = 25;
            // 
            // quantitylabel
            // 
            quantitylabel.AutoSize = true;
            quantitylabel.Location = new Point(515, 23);
            quantitylabel.Name = "quantitylabel";
            quantitylabel.Size = new Size(65, 20);
            quantitylabel.TabIndex = 26;
            quantitylabel.Text = "Quantity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(quantitylabel);
            Controls.Add(pineappletextBox);
            Controls.Add(watermelontextBox);
            Controls.Add(strawberrytextBox);
            Controls.Add(pineapplelabel);
            Controls.Add(watermelonlabel);
            Controls.Add(strawberrylabel);
            Controls.Add(orangetextBox);
            Controls.Add(orangelabel);
            Controls.Add(bananatextBox);
            Controls.Add(bananalabel);
            Controls.Add(appletextBox);
            Controls.Add(appleLabel);
            Controls.Add(backButton);
            Controls.Add(inventoryButton);
            Controls.Add(totalLabel);
            Controls.Add(fileWriteButton);
            Controls.Add(fileWriteLabel);
            Controls.Add(totalButton);
            Controls.Add(cartListBox);
            Controls.Add(cartButton);
            Controls.Add(fruitsDropDown);
            Controls.Add(totalTextBox);
            Controls.Add(priceLabel);
            Controls.Add(calculateButton);
            Controls.Add(quantityListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox quantityListBox;
        private Button calculateButton;
        private Label priceLabel;
        private TextBox totalTextBox;
        private ComboBox fruitsDropDown;
        private Button cartButton;
        private ListBox cartListBox;
        private Button totalButton;
        private Label fileWriteLabel;
        private Button fileWriteButton;
        private Label totalLabel;
        private Button inventoryButton;
        private Button backButton;
        private Label appleLabel;
        private TextBox appletextBox;
        private Label bananalabel;
        private TextBox bananatextBox;
        private Label orangelabel;
        private TextBox orangetextBox;
        private Label strawberrylabel;
        private Label watermelonlabel;
        private Label pineapplelabel;
        private TextBox strawberrytextBox;
        private TextBox watermelontextBox;
        private TextBox pineappletextBox;
        private Label quantitylabel;
    }
}