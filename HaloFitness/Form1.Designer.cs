namespace HaloFitness
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
            trainingStudioLabel = new Label();
            haloFitnessPictureBox = new PictureBox();
            fitnessPictureBox = new PictureBox();
            programButton = new Button();
            HomePagePanel = new Panel();
            programListBox = new ListBox();
            sessionsListBox = new ListBox();
            jumpIntoLabel = new Label();
            worldOfLabel = new Label();
            fitnessLabel = new Label();
            paticipantsNumberLabel = new Label();
            participantsNumberTextBox = new TextBox();
            displayButton = new Button();
            outputLabel = new Label();
            oneToOneRadioButton = new RadioButton();
            smallGroupRadioButton = new RadioButton();
            mediumGroupRadioButton = new RadioButton();
            programLabel = new Label();
            freeBottleCheckBox = new CheckBox();
            customizedBottleCheckBox = new CheckBox();
            optionalUpgradePanel = new Panel();
            notRequiredRadioButton = new RadioButton();
            displayPanel = new Panel();
            numberOfLabel = new Label();
            sessionsPanel = new Panel();
            discountLabel = new Label();
            bundleLabel = new Label();
            sessionLabel = new Label();
            nomberLabel = new Label();
            costSummaryLabel = new Label();
            clearButton = new Button();
            bookButton = new Button();
            summaryButton = new Button();
            exitButton = new Button();
            optionalUpgradeCheckBox = new CheckBox();
            displayToolTip = new ToolTip(components);
            clearToolTip = new ToolTip(components);
            exitToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)haloFitnessPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fitnessPictureBox).BeginInit();
            HomePagePanel.SuspendLayout();
            optionalUpgradePanel.SuspendLayout();
            displayPanel.SuspendLayout();
            sessionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // trainingStudioLabel
            // 
            trainingStudioLabel.AutoSize = true;
            trainingStudioLabel.BackColor = Color.Transparent;
            trainingStudioLabel.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            trainingStudioLabel.ForeColor = SystemColors.ActiveCaptionText;
            trainingStudioLabel.Location = new Point(48, 15);
            trainingStudioLabel.Name = "trainingStudioLabel";
            trainingStudioLabel.Size = new Size(270, 39);
            trainingStudioLabel.TabIndex = 0;
            trainingStudioLabel.Text = "Training Studio";
            // 
            // haloFitnessPictureBox
            // 
            haloFitnessPictureBox.Image = (Image)resources.GetObject("haloFitnessPictureBox.Image");
            haloFitnessPictureBox.Location = new Point(94, 94);
            haloFitnessPictureBox.Name = "haloFitnessPictureBox";
            haloFitnessPictureBox.Size = new Size(361, 198);
            haloFitnessPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            haloFitnessPictureBox.TabIndex = 1;
            haloFitnessPictureBox.TabStop = false;
            // 
            // fitnessPictureBox
            // 
            fitnessPictureBox.Image = (Image)resources.GetObject("fitnessPictureBox.Image");
            fitnessPictureBox.Location = new Point(694, 116);
            fitnessPictureBox.Name = "fitnessPictureBox";
            fitnessPictureBox.Size = new Size(332, 441);
            fitnessPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            fitnessPictureBox.TabIndex = 2;
            fitnessPictureBox.TabStop = false;
            // 
            // programButton
            // 
            programButton.BackColor = Color.FromArgb(224, 224, 224);
            programButton.FlatStyle = FlatStyle.Flat;
            programButton.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            programButton.Location = new Point(156, 415);
            programButton.Name = "programButton";
            programButton.Size = new Size(196, 54);
            programButton.TabIndex = 1;
            programButton.Text = "Add Participants";
            programButton.UseVisualStyleBackColor = false;
            programButton.Click += programButton_Click;
            // 
            // HomePagePanel
            // 
            HomePagePanel.BackColor = SystemColors.Control;
            HomePagePanel.BackgroundImage = (Image)resources.GetObject("HomePagePanel.BackgroundImage");
            HomePagePanel.Controls.Add(trainingStudioLabel);
            HomePagePanel.Location = new Point(0, 1);
            HomePagePanel.Name = "HomePagePanel";
            HomePagePanel.Size = new Size(1159, 67);
            HomePagePanel.TabIndex = 4;
            // 
            // programListBox
            // 
            programListBox.BackColor = Color.White;
            programListBox.BorderStyle = BorderStyle.None;
            programListBox.FormattingEnabled = true;
            programListBox.ItemHeight = 17;
            programListBox.Items.AddRange(new object[] { "Circuit Training                                    ₹25", "Pilates                                                    ₹40", "High-intensity interval training          ₹25", "Aerobics                                                ₹25", "Fitness Boot Camp                               ₹20", "Weigh Training                                      ₹25", "Agility                                                      ₹50", "Yoga                                                        ₹35", "Speed Training                                      ₹45" });
            programListBox.Location = new Point(94, 133);
            programListBox.Name = "programListBox";
            programListBox.Size = new Size(339, 170);
            programListBox.TabIndex = 5;
            // 
            // sessionsListBox
            // 
            sessionsListBox.FormattingEnabled = true;
            sessionsListBox.ItemHeight = 17;
            sessionsListBox.Items.AddRange(new object[] { "       1                    0%", "       3                    5%", "       5                   10%", "       7                   15%", "      10                  20%", "      12                  30%" });
            sessionsListBox.Location = new Point(549, 163);
            sessionsListBox.Name = "sessionsListBox";
            sessionsListBox.Size = new Size(192, 140);
            sessionsListBox.TabIndex = 6;
            // 
            // jumpIntoLabel
            // 
            jumpIntoLabel.AutoSize = true;
            jumpIntoLabel.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            jumpIntoLabel.Location = new Point(156, 298);
            jumpIntoLabel.Name = "jumpIntoLabel";
            jumpIntoLabel.Size = new Size(196, 43);
            jumpIntoLabel.TabIndex = 7;
            jumpIntoLabel.Text = "Jump Into";
            // 
            // worldOfLabel
            // 
            worldOfLabel.AutoSize = true;
            worldOfLabel.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            worldOfLabel.Location = new Point(156, 335);
            worldOfLabel.Name = "worldOfLabel";
            worldOfLabel.Size = new Size(251, 43);
            worldOfLabel.TabIndex = 8;
            worldOfLabel.Text = "The World Of";
            // 
            // fitnessLabel
            // 
            fitnessLabel.AutoSize = true;
            fitnessLabel.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            fitnessLabel.Location = new Point(156, 371);
            fitnessLabel.Name = "fitnessLabel";
            fitnessLabel.Size = new Size(148, 43);
            fitnessLabel.TabIndex = 9;
            fitnessLabel.Text = "Fitness";
            // 
            // paticipantsNumberLabel
            // 
            paticipantsNumberLabel.AutoSize = true;
            paticipantsNumberLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            paticipantsNumberLabel.Location = new Point(94, 325);
            paticipantsNumberLabel.Name = "paticipantsNumberLabel";
            paticipantsNumberLabel.Size = new Size(206, 25);
            paticipantsNumberLabel.TabIndex = 10;
            paticipantsNumberLabel.Text = "Number of Participants";
            // 
            // participantsNumberTextBox
            // 
            participantsNumberTextBox.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            participantsNumberTextBox.Location = new Point(335, 325);
            participantsNumberTextBox.Name = "participantsNumberTextBox";
            participantsNumberTextBox.Size = new Size(72, 31);
            participantsNumberTextBox.TabIndex = 8;
            participantsNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // displayButton
            // 
            displayButton.BackColor = Color.Silver;
            displayButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            displayButton.Location = new Point(94, 428);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(106, 25);
            displayButton.TabIndex = 11;
            displayButton.Text = "&Display";
            displayToolTip.SetToolTip(displayButton, "Click to display the booking details\r\n\r\n\r\n");
            displayButton.UseVisualStyleBackColor = false;
            displayButton.Click += displayButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(3, 6);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(52, 17);
            outputLabel.TabIndex = 0;
            outputLabel.Text = "label1";
            // 
            // oneToOneRadioButton
            // 
            oneToOneRadioButton.AutoSize = true;
            oneToOneRadioButton.Location = new Point(3, 8);
            oneToOneRadioButton.Name = "oneToOneRadioButton";
            oneToOneRadioButton.Size = new Size(231, 21);
            oneToOneRadioButton.TabIndex = 2;
            oneToOneRadioButton.TabStop = true;
            oneToOneRadioButton.Text = "One To One Training       ₹25";
            oneToOneRadioButton.UseVisualStyleBackColor = true;
            oneToOneRadioButton.CheckedChanged += oneToOneRadioButton_CheckedChanged;
            // 
            // smallGroupRadioButton
            // 
            smallGroupRadioButton.AutoSize = true;
            smallGroupRadioButton.Location = new Point(3, 34);
            smallGroupRadioButton.Name = "smallGroupRadioButton";
            smallGroupRadioButton.Size = new Size(231, 21);
            smallGroupRadioButton.TabIndex = 15;
            smallGroupRadioButton.TabStop = true;
            smallGroupRadioButton.Text = "Small Group Training      ₹15";
            smallGroupRadioButton.UseVisualStyleBackColor = true;
            smallGroupRadioButton.CheckedChanged += smallGroupRadioButton_CheckedChanged;
            // 
            // mediumGroupRadioButton
            // 
            mediumGroupRadioButton.AutoSize = true;
            mediumGroupRadioButton.Location = new Point(3, 60);
            mediumGroupRadioButton.Name = "mediumGroupRadioButton";
            mediumGroupRadioButton.Size = new Size(226, 21);
            mediumGroupRadioButton.TabIndex = 16;
            mediumGroupRadioButton.TabStop = true;
            mediumGroupRadioButton.Text = "Medium Group Training   ₹5";
            mediumGroupRadioButton.UseVisualStyleBackColor = true;
            mediumGroupRadioButton.CheckedChanged += mediumGroupRadioButton_CheckedChanged;
            // 
            // programLabel
            // 
            programLabel.AutoSize = true;
            programLabel.BackColor = Color.Silver;
            programLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            programLabel.Location = new Point(94, 116);
            programLabel.Name = "programLabel";
            programLabel.Size = new Size(339, 17);
            programLabel.TabIndex = 18;
            programLabel.Text = "Programs                                 Price per session";
            // 
            // freeBottleCheckBox
            // 
            freeBottleCheckBox.AutoSize = true;
            freeBottleCheckBox.Location = new Point(94, 362);
            freeBottleCheckBox.Name = "freeBottleCheckBox";
            freeBottleCheckBox.Size = new Size(261, 21);
            freeBottleCheckBox.TabIndex = 9;
            freeBottleCheckBox.Text = "Avail free Halo Sport Cap Bottle";
            freeBottleCheckBox.UseVisualStyleBackColor = true;
            // 
            // customizedBottleCheckBox
            // 
            customizedBottleCheckBox.AutoSize = true;
            customizedBottleCheckBox.Location = new Point(94, 388);
            customizedBottleCheckBox.Name = "customizedBottleCheckBox";
            customizedBottleCheckBox.Size = new Size(343, 21);
            customizedBottleCheckBox.TabIndex = 10;
            customizedBottleCheckBox.Text = "Customised Halo Sport Cap Bottle for ₹7.99";
            customizedBottleCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionalUpgradePanel
            // 
            optionalUpgradePanel.BackColor = SystemColors.ButtonHighlight;
            optionalUpgradePanel.Controls.Add(notRequiredRadioButton);
            optionalUpgradePanel.Controls.Add(oneToOneRadioButton);
            optionalUpgradePanel.Controls.Add(smallGroupRadioButton);
            optionalUpgradePanel.Controls.Add(mediumGroupRadioButton);
            optionalUpgradePanel.Location = new Point(844, 133);
            optionalUpgradePanel.Name = "optionalUpgradePanel";
            optionalUpgradePanel.Size = new Size(241, 119);
            optionalUpgradePanel.TabIndex = 7;
            // 
            // notRequiredRadioButton
            // 
            notRequiredRadioButton.AutoSize = true;
            notRequiredRadioButton.Location = new Point(3, 87);
            notRequiredRadioButton.Name = "notRequiredRadioButton";
            notRequiredRadioButton.Size = new Size(189, 21);
            notRequiredRadioButton.TabIndex = 17;
            notRequiredRadioButton.TabStop = true;
            notRequiredRadioButton.Text = "Training Not Required";
            notRequiredRadioButton.UseVisualStyleBackColor = true;
            notRequiredRadioButton.CheckedChanged += notRequiredRadioButton_CheckedChanged;
            // 
            // displayPanel
            // 
            displayPanel.BackColor = SystemColors.ButtonHighlight;
            displayPanel.Controls.Add(outputLabel);
            displayPanel.Location = new Point(549, 348);
            displayPanel.Name = "displayPanel";
            displayPanel.Size = new Size(420, 212);
            displayPanel.TabIndex = 2;
            // 
            // numberOfLabel
            // 
            numberOfLabel.AutoSize = true;
            numberOfLabel.BackColor = Color.Silver;
            numberOfLabel.Location = new Point(597, 95);
            numberOfLabel.Name = "numberOfLabel";
            numberOfLabel.Size = new Size(0, 17);
            numberOfLabel.TabIndex = 23;
            // 
            // sessionsPanel
            // 
            sessionsPanel.BackColor = Color.Silver;
            sessionsPanel.Controls.Add(discountLabel);
            sessionsPanel.Controls.Add(bundleLabel);
            sessionsPanel.Controls.Add(sessionLabel);
            sessionsPanel.Controls.Add(nomberLabel);
            sessionsPanel.Location = new Point(549, 116);
            sessionsPanel.Name = "sessionsPanel";
            sessionsPanel.Size = new Size(192, 46);
            sessionsPanel.TabIndex = 24;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            discountLabel.Location = new Point(108, 17);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(72, 17);
            discountLabel.TabIndex = 3;
            discountLabel.Text = "Discount";
            // 
            // bundleLabel
            // 
            bundleLabel.AutoSize = true;
            bundleLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bundleLabel.Location = new Point(112, 0);
            bundleLabel.Name = "bundleLabel";
            bundleLabel.Size = new Size(59, 17);
            bundleLabel.TabIndex = 2;
            bundleLabel.Text = "Bundle";
            // 
            // sessionLabel
            // 
            sessionLabel.AutoSize = true;
            sessionLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sessionLabel.Location = new Point(3, 17);
            sessionLabel.Name = "sessionLabel";
            sessionLabel.Size = new Size(73, 17);
            sessionLabel.TabIndex = 1;
            sessionLabel.Text = "Sessions";
            // 
            // nomberLabel
            // 
            nomberLabel.AutoSize = true;
            nomberLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nomberLabel.Location = new Point(3, 0);
            nomberLabel.Name = "nomberLabel";
            nomberLabel.Size = new Size(84, 17);
            nomberLabel.TabIndex = 0;
            nomberLabel.Text = "Number of";
            // 
            // costSummaryLabel
            // 
            costSummaryLabel.AutoSize = true;
            costSummaryLabel.BackColor = Color.Silver;
            costSummaryLabel.Location = new Point(549, 328);
            costSummaryLabel.Name = "costSummaryLabel";
            costSummaryLabel.Size = new Size(205, 17);
            costSummaryLabel.TabIndex = 25;
            costSummaryLabel.Text = "Cost Summary per booking";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Silver;
            clearButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(236, 428);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(106, 25);
            clearButton.TabIndex = 26;
            clearButton.Text = "&Clear";
            clearToolTip.SetToolTip(clearButton, "Click here to clear the form");
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // bookButton
            // 
            bookButton.BackColor = Color.Silver;
            bookButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bookButton.Location = new Point(370, 428);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(106, 25);
            bookButton.TabIndex = 27;
            bookButton.Text = "&Book";
            bookButton.UseVisualStyleBackColor = false;
            bookButton.Click += bookButton_Click;
            // 
            // summaryButton
            // 
            summaryButton.BackColor = Color.Silver;
            summaryButton.Location = new Point(94, 474);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(106, 25);
            summaryButton.TabIndex = 28;
            summaryButton.Text = "&Summary";
            summaryButton.UseVisualStyleBackColor = false;
            summaryButton.Click += summaryButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Silver;
            exitButton.Location = new Point(236, 472);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 29;
            exitButton.Text = "E&xit ";
            exitToolTip.SetToolTip(exitButton, "Close the application");
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // optionalUpgradeCheckBox
            // 
            optionalUpgradeCheckBox.AutoSize = true;
            optionalUpgradeCheckBox.BackColor = Color.Silver;
            optionalUpgradeCheckBox.Location = new Point(847, 113);
            optionalUpgradeCheckBox.Name = "optionalUpgradeCheckBox";
            optionalUpgradeCheckBox.Size = new Size(158, 21);
            optionalUpgradeCheckBox.TabIndex = 30;
            optionalUpgradeCheckBox.Text = "Optional Upgrade";
            optionalUpgradeCheckBox.UseVisualStyleBackColor = false;
            optionalUpgradeCheckBox.CheckedChanged += optionalUpgradeCheckBox_CheckedChanged;
            // 
            // displayToolTip
            // 
            displayToolTip.IsBalloon = true;
            displayToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // clearToolTip
            // 
            clearToolTip.IsBalloon = true;
            clearToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // exitToolTip
            // 
            exitToolTip.IsBalloon = true;
            exitToolTip.ToolTipIcon = ToolTipIcon.Warning;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 677);
            Controls.Add(optionalUpgradeCheckBox);
            Controls.Add(exitButton);
            Controls.Add(summaryButton);
            Controls.Add(bookButton);
            Controls.Add(clearButton);
            Controls.Add(costSummaryLabel);
            Controls.Add(sessionsPanel);
            Controls.Add(numberOfLabel);
            Controls.Add(displayPanel);
            Controls.Add(optionalUpgradePanel);
            Controls.Add(customizedBottleCheckBox);
            Controls.Add(freeBottleCheckBox);
            Controls.Add(programLabel);
            Controls.Add(displayButton);
            Controls.Add(participantsNumberTextBox);
            Controls.Add(paticipantsNumberLabel);
            Controls.Add(fitnessLabel);
            Controls.Add(worldOfLabel);
            Controls.Add(jumpIntoLabel);
            Controls.Add(sessionsListBox);
            Controls.Add(programListBox);
            Controls.Add(HomePagePanel);
            Controls.Add(programButton);
            Controls.Add(fitnessPictureBox);
            Controls.Add(haloFitnessPictureBox);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Halo Fitness";
            ((System.ComponentModel.ISupportInitialize)haloFitnessPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fitnessPictureBox).EndInit();
            HomePagePanel.ResumeLayout(false);
            HomePagePanel.PerformLayout();
            optionalUpgradePanel.ResumeLayout(false);
            optionalUpgradePanel.PerformLayout();
            displayPanel.ResumeLayout(false);
            displayPanel.PerformLayout();
            sessionsPanel.ResumeLayout(false);
            sessionsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label trainingStudioLabel;
        private PictureBox haloFitnessPictureBox;
        private PictureBox fitnessPictureBox;
        private Button programButton;
        private Panel HomePagePanel;
        private ListBox programListBox;
        private ListBox sessionsListBox;
        private Label jumpIntoLabel;
        private Label worldOfLabel;
        private Label fitnessLabel;
        private Label paticipantsNumberLabel;
        private TextBox participantsNumberTextBox;
        private Button displayButton;
        private Label outputLabel;
        private RadioButton oneToOneRadioButton;
        private RadioButton smallGroupRadioButton;
        private RadioButton mediumGroupRadioButton;
        private Label programLabel;
        private CheckBox freeBottleCheckBox;
        private CheckBox customizedBottleCheckBox;
        private Panel optionalUpgradePanel;
        private Panel displayPanel;
        private Label numberOfLabel;
        private Panel sessionsPanel;
        private Label nomberLabel;
        private Label sessionLabel;
        private Label bundleLabel;
        private Label discountLabel;
        private Label costSummaryLabel;
        private RadioButton notRequiredRadioButton;
        private Button clearButton;
        private Button bookButton;
        private Button summaryButton;
        private Button exitButton;
        private CheckBox optionalUpgradeCheckBox;
        private ToolTip displayToolTip;
        private ToolTip clearToolTip;
        private ToolTip exitToolTip;
    }
}