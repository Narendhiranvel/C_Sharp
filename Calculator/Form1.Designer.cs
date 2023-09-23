namespace Calculator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            calciPic = new PictureBox();
            firstNumberTest = new TextBox();
            secondNumberText = new TextBox();
            num1Label = new Label();
            num2Label = new Label();
            addButton = new Button();
            subButton = new Button();
            divButton = new Button();
            mulButton = new Button();
            Exit = new Button();
            Clear = new Button();
            clearToolTip = new ToolTip(components);
            closeToolBox = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)calciPic).BeginInit();
            SuspendLayout();
            // 
            // calciPic
            // 
            calciPic.Image = (Image)resources.GetObject("calciPic.Image");
            calciPic.Location = new Point(12, 12);
            calciPic.Name = "calciPic";
            calciPic.Size = new Size(65, 68);
            calciPic.SizeMode = PictureBoxSizeMode.StretchImage;
            calciPic.TabIndex = 0;
            calciPic.TabStop = false;
            // 
            // firstNumberTest
            // 
            firstNumberTest.Location = new Point(12, 158);
            firstNumberTest.Name = "firstNumberTest";
            firstNumberTest.Size = new Size(86, 27);
            firstNumberTest.TabIndex = 1;
            firstNumberTest.TextAlign = HorizontalAlignment.Center;
            // 
            // secondNumberText
            // 
            secondNumberText.Location = new Point(104, 158);
            secondNumberText.Name = "secondNumberText";
            secondNumberText.Size = new Size(86, 27);
            secondNumberText.TabIndex = 2;
            secondNumberText.TextAlign = HorizontalAlignment.Center;
            // 
            // num1Label
            // 
            num1Label.AutoSize = true;
            num1Label.Location = new Point(28, 135);
            num1Label.Name = "num1Label";
            num1Label.Size = new Size(49, 20);
            num1Label.TabIndex = 3;
            num1Label.Text = "Num1";
            // 
            // num2Label
            // 
            num2Label.AutoSize = true;
            num2Label.Location = new Point(123, 135);
            num2Label.Name = "num2Label";
            num2Label.Size = new Size(49, 20);
            num2Label.TabIndex = 4;
            num2Label.Text = "Num2";
            // 
            // addButton
            // 
            addButton.Location = new Point(4, 222);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 5;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subButton
            // 
            subButton.Location = new Point(104, 222);
            subButton.Name = "subButton";
            subButton.Size = new Size(94, 29);
            subButton.TabIndex = 6;
            subButton.Text = "-";
            subButton.UseVisualStyleBackColor = true;
            subButton.Click += subButton_Click;
            // 
            // divButton
            // 
            divButton.Location = new Point(104, 257);
            divButton.Name = "divButton";
            divButton.Size = new Size(94, 29);
            divButton.TabIndex = 7;
            divButton.Text = "/";
            divButton.UseVisualStyleBackColor = true;
            divButton.Click += divButton_Click;
            // 
            // mulButton
            // 
            mulButton.Location = new Point(4, 257);
            mulButton.Name = "mulButton";
            mulButton.Size = new Size(94, 29);
            mulButton.TabIndex = 8;
            mulButton.Text = "X";
            mulButton.UseVisualStyleBackColor = true;
            mulButton.Click += mulButton_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(266, 158);
            Exit.Name = "Exit";
            Exit.Size = new Size(51, 29);
            Exit.TabIndex = 9;
            Exit.Text = "Exit";
            closeToolBox.SetToolTip(Exit, "Close the application");
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(209, 158);
            Clear.Name = "Clear";
            Clear.Size = new Size(51, 29);
            Clear.TabIndex = 10;
            Clear.Text = "Clear";
            clearToolTip.SetToolTip(Clear, "Clear the data");
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 355);
            Controls.Add(Clear);
            Controls.Add(Exit);
            Controls.Add(mulButton);
            Controls.Add(divButton);
            Controls.Add(subButton);
            Controls.Add(addButton);
            Controls.Add(num2Label);
            Controls.Add(num1Label);
            Controls.Add(secondNumberText);
            Controls.Add(firstNumberTest);
            Controls.Add(calciPic);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)calciPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox calciPic;
        private TextBox firstNumberTest;
        private TextBox secondNumberText;
        private Label num1Label;
        private Label num2Label;
        private Button addButton;
        private Button subButton;
        private Button divButton;
        private Button mulButton;
        private Button Exit;
        private Button Clear;
        private ToolTip clearToolTip;
        private ToolTip closeToolBox;
    }
}