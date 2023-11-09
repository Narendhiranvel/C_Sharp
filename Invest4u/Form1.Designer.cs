namespace Invest4u
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
            passwordPanel = new Panel();
            passwordIncorrectLabel = new Label();
            loginButton = new Button();
            passwordMaskedTextBox = new MaskedTextBox();
            investPictureBox = new PictureBox();
            investmentOptionsGroupBox = new GroupBox();
            exitButton = new Button();
            invest4uPictureBox1 = new PictureBox();
            summaryButton = new Button();
            proceedButton = new Button();
            clearButton = new Button();
            noteLabel = new Label();
            largeInvestListBox = new ListBox();
            maturityAmountPanel = new Panel();
            tenYearLabel = new Label();
            fiveYearLabel = new Label();
            threeYearLabel = new Label();
            oneYearLabel = new Label();
            maturityLabel = new Label();
            displayButton = new Button();
            panel1 = new Panel();
            interestRateLabel = new Label();
            termLabel = new Label();
            smallIvestlentListBox = new ListBox();
            investmentPrincipalTextBox = new TextBox();
            investmentPrincipalLabel = new Label();
            investmentDetailsGroupBox = new GroupBox();
            submitButton = new Button();
            phonTextBox = new TextBox();
            mailIdTextBox = new TextBox();
            nameTextBox = new TextBox();
            phoneLabel = new Label();
            mailIdLabel = new Label();
            nameLabel = new Label();
            profitTextBox = new TextBox();
            iRTextBox = new TextBox();
            durationTextBox = new TextBox();
            investAmountTextBox = new TextBox();
            transIdTextBox = new TextBox();
            profitLabel = new Label();
            iRLabel = new Label();
            durationLabel = new Label();
            investAmountLabel = new Label();
            dateLabel = new Label();
            transactionIdLabel = new Label();
            searchResultListBox = new ListBox();
            searchButton = new Button();
            searchTextBox = new TextBox();
            summaryListBox = new ListBox();
            searchPanel = new Panel();
            investmentSummaryLabel = new Label();
            searchByTransIdRadioButton = new RadioButton();
            searchEmailIdRadioButton = new RadioButton();
            searchDateRadioButton = new RadioButton();
            searchResultLabel = new Label();
            displayToolTip1 = new ToolTip(components);
            proceedToolTip = new ToolTip(components);
            clearToolTip = new ToolTip(components);
            summaryToolTip = new ToolTip(components);
            searchToolTip = new ToolTip(components);
            passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)investPictureBox).BeginInit();
            investmentOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invest4uPictureBox1).BeginInit();
            maturityAmountPanel.SuspendLayout();
            panel1.SuspendLayout();
            investmentDetailsGroupBox.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.PaleTurquoise;
            passwordPanel.Controls.Add(passwordIncorrectLabel);
            passwordPanel.Controls.Add(loginButton);
            passwordPanel.Controls.Add(passwordMaskedTextBox);
            passwordPanel.Controls.Add(investPictureBox);
            passwordPanel.Location = new Point(397, 65);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(359, 393);
            passwordPanel.TabIndex = 0;
            // 
            // passwordIncorrectLabel
            // 
            passwordIncorrectLabel.AutoSize = true;
            passwordIncorrectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordIncorrectLabel.ForeColor = Color.IndianRed;
            passwordIncorrectLabel.Location = new Point(114, 300);
            passwordIncorrectLabel.Name = "passwordIncorrectLabel";
            passwordIncorrectLabel.Size = new Size(51, 20);
            passwordIncorrectLabel.TabIndex = 2;
            passwordIncorrectLabel.Text = "label1";
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ControlDarkDark;
            loginButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(133, 268);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 1;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordMaskedTextBox
            // 
            passwordMaskedTextBox.Location = new Point(93, 219);
            passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            passwordMaskedTextBox.PasswordChar = '*';
            passwordMaskedTextBox.Size = new Size(173, 27);
            passwordMaskedTextBox.TabIndex = 0;
            // 
            // investPictureBox
            // 
            investPictureBox.Image = (Image)resources.GetObject("investPictureBox.Image");
            investPictureBox.Location = new Point(75, 17);
            investPictureBox.Name = "investPictureBox";
            investPictureBox.Size = new Size(206, 162);
            investPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            investPictureBox.TabIndex = 1;
            investPictureBox.TabStop = false;
            // 
            // investmentOptionsGroupBox
            // 
            investmentOptionsGroupBox.BackColor = Color.PaleTurquoise;
            investmentOptionsGroupBox.Controls.Add(exitButton);
            investmentOptionsGroupBox.Controls.Add(invest4uPictureBox1);
            investmentOptionsGroupBox.Controls.Add(summaryButton);
            investmentOptionsGroupBox.Controls.Add(proceedButton);
            investmentOptionsGroupBox.Controls.Add(clearButton);
            investmentOptionsGroupBox.Controls.Add(noteLabel);
            investmentOptionsGroupBox.Controls.Add(largeInvestListBox);
            investmentOptionsGroupBox.Controls.Add(maturityAmountPanel);
            investmentOptionsGroupBox.Controls.Add(displayButton);
            investmentOptionsGroupBox.Controls.Add(panel1);
            investmentOptionsGroupBox.Controls.Add(smallIvestlentListBox);
            investmentOptionsGroupBox.Controls.Add(investmentPrincipalTextBox);
            investmentOptionsGroupBox.Controls.Add(investmentPrincipalLabel);
            investmentOptionsGroupBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            investmentOptionsGroupBox.ForeColor = SystemColors.ActiveCaptionText;
            investmentOptionsGroupBox.Location = new Point(29, 65);
            investmentOptionsGroupBox.Name = "investmentOptionsGroupBox";
            investmentOptionsGroupBox.Size = new Size(605, 286);
            investmentOptionsGroupBox.TabIndex = 2;
            investmentOptionsGroupBox.TabStop = false;
            investmentOptionsGroupBox.Text = "Investment Options";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(473, 238);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 18;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // invest4uPictureBox1
            // 
            invest4uPictureBox1.Image = (Image)resources.GetObject("invest4uPictureBox1.Image");
            invest4uPictureBox1.Location = new Point(522, 14);
            invest4uPictureBox1.Name = "invest4uPictureBox1";
            invest4uPictureBox1.Size = new Size(77, 53);
            invest4uPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            invest4uPictureBox1.TabIndex = 4;
            invest4uPictureBox1.TabStop = false;
            // 
            // summaryButton
            // 
            summaryButton.ForeColor = SystemColors.ActiveCaptionText;
            summaryButton.Location = new Point(363, 238);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(94, 29);
            summaryButton.TabIndex = 6;
            summaryButton.Text = "&Summary";
            summaryToolTip.SetToolTip(summaryButton, "View Transaction Summary");
            summaryButton.UseVisualStyleBackColor = true;
            summaryButton.Click += summaryButton_Click;
            // 
            // proceedButton
            // 
            proceedButton.Location = new Point(364, 202);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(94, 29);
            proceedButton.TabIndex = 4;
            proceedButton.Text = "&Proceed";
            proceedToolTip.SetToolTip(proceedButton, "Proceed with Investment");
            proceedButton.UseVisualStyleBackColor = true;
            proceedButton.Click += proceedButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(473, 201);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 5;
            clearButton.Text = "&Clear";
            clearToolTip.SetToolTip(clearButton, "Clear the filters");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            noteLabel.Location = new Point(48, 201);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(31, 16);
            noteLabel.TabIndex = 8;
            noteLabel.Text = "note";
            // 
            // largeInvestListBox
            // 
            largeInvestListBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            largeInvestListBox.FormattingEnabled = true;
            largeInvestListBox.ItemHeight = 17;
            largeInvestListBox.Items.AddRange(new object[] { "    1 Year                             0.006000%", "    3 Years                           0.007250%", "    5 Years                           0.008125%", "   10 Years                          0.012500% " });
            largeInvestListBox.Location = new Point(48, 109);
            largeInvestListBox.Name = "largeInvestListBox";
            largeInvestListBox.Size = new Size(298, 89);
            largeInvestListBox.TabIndex = 3;
            // 
            // maturityAmountPanel
            // 
            maturityAmountPanel.BackColor = SystemColors.ButtonHighlight;
            maturityAmountPanel.Controls.Add(tenYearLabel);
            maturityAmountPanel.Controls.Add(fiveYearLabel);
            maturityAmountPanel.Controls.Add(threeYearLabel);
            maturityAmountPanel.Controls.Add(oneYearLabel);
            maturityAmountPanel.Controls.Add(maturityLabel);
            maturityAmountPanel.Location = new Point(363, 67);
            maturityAmountPanel.Name = "maturityAmountPanel";
            maturityAmountPanel.Size = new Size(154, 129);
            maturityAmountPanel.TabIndex = 7;
            // 
            // tenYearLabel
            // 
            tenYearLabel.AutoSize = true;
            tenYearLabel.Location = new Point(16, 92);
            tenYearLabel.Name = "tenYearLabel";
            tenYearLabel.Size = new Size(52, 17);
            tenYearLabel.TabIndex = 11;
            tenYearLabel.Text = "label4";
            // 
            // fiveYearLabel
            // 
            fiveYearLabel.AutoSize = true;
            fiveYearLabel.Location = new Point(16, 75);
            fiveYearLabel.Name = "fiveYearLabel";
            fiveYearLabel.Size = new Size(52, 17);
            fiveYearLabel.TabIndex = 10;
            fiveYearLabel.Text = "label3";
            // 
            // threeYearLabel
            // 
            threeYearLabel.AutoSize = true;
            threeYearLabel.Location = new Point(16, 57);
            threeYearLabel.Name = "threeYearLabel";
            threeYearLabel.Size = new Size(52, 17);
            threeYearLabel.TabIndex = 9;
            threeYearLabel.Text = "label2";
            // 
            // oneYearLabel
            // 
            oneYearLabel.AutoSize = true;
            oneYearLabel.Location = new Point(16, 40);
            oneYearLabel.Name = "oneYearLabel";
            oneYearLabel.Size = new Size(52, 17);
            oneYearLabel.TabIndex = 8;
            oneYearLabel.Text = "label1";
            // 
            // maturityLabel
            // 
            maturityLabel.AutoSize = true;
            maturityLabel.BackColor = Color.Salmon;
            maturityLabel.Location = new Point(16, 13);
            maturityLabel.Name = "maturityLabel";
            maturityLabel.Size = new Size(127, 17);
            maturityLabel.TabIndex = 7;
            maturityLabel.Text = "Maturity Amount";
            // 
            // displayButton
            // 
            displayButton.Location = new Point(363, 25);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(94, 29);
            displayButton.TabIndex = 2;
            displayButton.Text = "Display";
            displayToolTip1.SetToolTip(displayButton, "Display Investment options\r\n\r\n");
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(interestRateLabel);
            panel1.Controls.Add(termLabel);
            panel1.Location = new Point(48, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 41);
            panel1.TabIndex = 5;
            // 
            // interestRateLabel
            // 
            interestRateLabel.AutoSize = true;
            interestRateLabel.ForeColor = SystemColors.ActiveCaptionText;
            interestRateLabel.Location = new Point(173, 13);
            interestRateLabel.Name = "interestRateLabel";
            interestRateLabel.Size = new Size(103, 17);
            interestRateLabel.TabIndex = 3;
            interestRateLabel.Text = "Interest Rate";
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.ForeColor = SystemColors.ActiveCaptionText;
            termLabel.Location = new Point(26, 13);
            termLabel.Name = "termLabel";
            termLabel.Size = new Size(46, 17);
            termLabel.TabIndex = 2;
            termLabel.Text = "Term";
            // 
            // smallIvestlentListBox
            // 
            smallIvestlentListBox.FormattingEnabled = true;
            smallIvestlentListBox.ItemHeight = 17;
            smallIvestlentListBox.Items.AddRange(new object[] { "    1 Year                             0.005000%", "    3 Years                           0.006250%", "    5 Years                           0.007125%", "   10 Years                          0.011250% " });
            smallIvestlentListBox.Location = new Point(48, 107);
            smallIvestlentListBox.Name = "smallIvestlentListBox";
            smallIvestlentListBox.Size = new Size(298, 89);
            smallIvestlentListBox.TabIndex = 4;
            // 
            // investmentPrincipalTextBox
            // 
            investmentPrincipalTextBox.Location = new Point(199, 28);
            investmentPrincipalTextBox.Name = "investmentPrincipalTextBox";
            investmentPrincipalTextBox.Size = new Size(125, 25);
            investmentPrincipalTextBox.TabIndex = 1;
            investmentPrincipalTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // investmentPrincipalLabel
            // 
            investmentPrincipalLabel.AutoSize = true;
            investmentPrincipalLabel.ForeColor = SystemColors.ActiveCaptionText;
            investmentPrincipalLabel.Location = new Point(19, 31);
            investmentPrincipalLabel.Name = "investmentPrincipalLabel";
            investmentPrincipalLabel.Size = new Size(157, 17);
            investmentPrincipalLabel.TabIndex = 0;
            investmentPrincipalLabel.Text = "Investment Principal";
            // 
            // investmentDetailsGroupBox
            // 
            investmentDetailsGroupBox.BackColor = Color.PaleTurquoise;
            investmentDetailsGroupBox.Controls.Add(submitButton);
            investmentDetailsGroupBox.Controls.Add(phonTextBox);
            investmentDetailsGroupBox.Controls.Add(mailIdTextBox);
            investmentDetailsGroupBox.Controls.Add(nameTextBox);
            investmentDetailsGroupBox.Controls.Add(phoneLabel);
            investmentDetailsGroupBox.Controls.Add(mailIdLabel);
            investmentDetailsGroupBox.Controls.Add(nameLabel);
            investmentDetailsGroupBox.Controls.Add(profitTextBox);
            investmentDetailsGroupBox.Controls.Add(iRTextBox);
            investmentDetailsGroupBox.Controls.Add(durationTextBox);
            investmentDetailsGroupBox.Controls.Add(investAmountTextBox);
            investmentDetailsGroupBox.Controls.Add(transIdTextBox);
            investmentDetailsGroupBox.Controls.Add(profitLabel);
            investmentDetailsGroupBox.Controls.Add(iRLabel);
            investmentDetailsGroupBox.Controls.Add(durationLabel);
            investmentDetailsGroupBox.Controls.Add(investAmountLabel);
            investmentDetailsGroupBox.Controls.Add(dateLabel);
            investmentDetailsGroupBox.Controls.Add(transactionIdLabel);
            investmentDetailsGroupBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            investmentDetailsGroupBox.Location = new Point(29, 368);
            investmentDetailsGroupBox.Name = "investmentDetailsGroupBox";
            investmentDetailsGroupBox.Size = new Size(605, 253);
            investmentDetailsGroupBox.TabIndex = 4;
            investmentDetailsGroupBox.TabStop = false;
            investmentDetailsGroupBox.Text = "Investment Details";
            // 
            // submitButton
            // 
            submitButton.ForeColor = SystemColors.ActiveCaptionText;
            submitButton.Location = new Point(412, 182);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 17;
            submitButton.Text = "&Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // phonTextBox
            // 
            phonTextBox.Location = new Point(379, 124);
            phonTextBox.Name = "phonTextBox";
            phonTextBox.Size = new Size(188, 25);
            phonTextBox.TabIndex = 16;
            // 
            // mailIdTextBox
            // 
            mailIdTextBox.Location = new Point(379, 93);
            mailIdTextBox.Name = "mailIdTextBox";
            mailIdTextBox.Size = new Size(188, 25);
            mailIdTextBox.TabIndex = 15;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(379, 62);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(188, 25);
            nameTextBox.TabIndex = 14;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.ForeColor = SystemColors.ActiveCaptionText;
            phoneLabel.Location = new Point(307, 127);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(52, 17);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Ph.No";
            // 
            // mailIdLabel
            // 
            mailIdLabel.AutoSize = true;
            mailIdLabel.ForeColor = SystemColors.ActiveCaptionText;
            mailIdLabel.Location = new Point(307, 96);
            mailIdLabel.Name = "mailIdLabel";
            mailIdLabel.Size = new Size(55, 17);
            mailIdLabel.TabIndex = 12;
            mailIdLabel.Text = "Mail Id";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = SystemColors.ActiveCaptionText;
            nameLabel.Location = new Point(307, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 17);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name";
            // 
            // profitTextBox
            // 
            profitTextBox.Location = new Point(160, 186);
            profitTextBox.Name = "profitTextBox";
            profitTextBox.Size = new Size(125, 25);
            profitTextBox.TabIndex = 10;
            // 
            // iRTextBox
            // 
            iRTextBox.Location = new Point(160, 155);
            iRTextBox.Name = "iRTextBox";
            iRTextBox.Size = new Size(125, 25);
            iRTextBox.TabIndex = 9;
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(160, 124);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(125, 25);
            durationTextBox.TabIndex = 8;
            // 
            // investAmountTextBox
            // 
            investAmountTextBox.Location = new Point(160, 93);
            investAmountTextBox.Name = "investAmountTextBox";
            investAmountTextBox.Size = new Size(125, 25);
            investAmountTextBox.TabIndex = 7;
            // 
            // transIdTextBox
            // 
            transIdTextBox.Location = new Point(160, 62);
            transIdTextBox.Name = "transIdTextBox";
            transIdTextBox.Size = new Size(125, 25);
            transIdTextBox.TabIndex = 6;
            // 
            // profitLabel
            // 
            profitLabel.AutoSize = true;
            profitLabel.ForeColor = SystemColors.ActiveCaptionText;
            profitLabel.Location = new Point(6, 194);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new Size(48, 17);
            profitLabel.TabIndex = 5;
            profitLabel.Text = "Profit";
            // 
            // iRLabel
            // 
            iRLabel.AutoSize = true;
            iRLabel.ForeColor = SystemColors.ActiveCaptionText;
            iRLabel.Location = new Point(6, 160);
            iRLabel.Name = "iRLabel";
            iRLabel.Size = new Size(103, 17);
            iRLabel.TabIndex = 4;
            iRLabel.Text = "Interest Rate";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.ForeColor = SystemColors.ActiveCaptionText;
            durationLabel.Location = new Point(6, 127);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(138, 17);
            durationLabel.TabIndex = 3;
            durationLabel.Text = "Duration (months)";
            // 
            // investAmountLabel
            // 
            investAmountLabel.AutoSize = true;
            investAmountLabel.ForeColor = SystemColors.ActiveCaptionText;
            investAmountLabel.Location = new Point(6, 96);
            investAmountLabel.Name = "investAmountLabel";
            investAmountLabel.Size = new Size(148, 17);
            investAmountLabel.TabIndex = 2;
            investAmountLabel.Text = "Investment Amount";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.ForeColor = Color.Black;
            dateLabel.Location = new Point(6, 32);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(42, 17);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date";
            // 
            // transactionIdLabel
            // 
            transactionIdLabel.AutoSize = true;
            transactionIdLabel.ForeColor = SystemColors.ActiveCaptionText;
            transactionIdLabel.Location = new Point(6, 65);
            transactionIdLabel.Name = "transactionIdLabel";
            transactionIdLabel.Size = new Size(115, 17);
            transactionIdLabel.TabIndex = 0;
            transactionIdLabel.Text = "Transaction ID";
            // 
            // searchResultListBox
            // 
            searchResultListBox.FormattingEnabled = true;
            searchResultListBox.HorizontalScrollbar = true;
            searchResultListBox.ItemHeight = 20;
            searchResultListBox.Location = new Point(684, 391);
            searchResultListBox.Name = "searchResultListBox";
            searchResultListBox.ScrollAlwaysVisible = true;
            searchResultListBox.Size = new Size(369, 344);
            searchResultListBox.TabIndex = 24;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(75, 64);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 22;
            searchButton.Text = "&Search";
            searchToolTip.SetToolTip(searchButton, "Search Transactions");
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(58, 20);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(125, 27);
            searchTextBox.TabIndex = 21;
            // 
            // summaryListBox
            // 
            summaryListBox.FormattingEnabled = true;
            summaryListBox.HorizontalScrollbar = true;
            summaryListBox.ItemHeight = 20;
            summaryListBox.Location = new Point(684, 88);
            summaryListBox.Name = "summaryListBox";
            summaryListBox.ScrollAlwaysVisible = true;
            summaryListBox.Size = new Size(369, 244);
            summaryListBox.TabIndex = 23;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.Salmon;
            searchPanel.Controls.Add(searchTextBox);
            searchPanel.Controls.Add(searchButton);
            searchPanel.Location = new Point(414, 634);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(238, 108);
            searchPanel.TabIndex = 10;
            // 
            // investmentSummaryLabel
            // 
            investmentSummaryLabel.AutoSize = true;
            investmentSummaryLabel.BackColor = SystemColors.Control;
            investmentSummaryLabel.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            investmentSummaryLabel.Location = new Point(774, 65);
            investmentSummaryLabel.Name = "investmentSummaryLabel";
            investmentSummaryLabel.Size = new Size(180, 20);
            investmentSummaryLabel.TabIndex = 11;
            investmentSummaryLabel.Text = "Investment Summary";
            // 
            // searchByTransIdRadioButton
            // 
            searchByTransIdRadioButton.AutoSize = true;
            searchByTransIdRadioButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchByTransIdRadioButton.Location = new Point(164, 646);
            searchByTransIdRadioButton.Name = "searchByTransIdRadioButton";
            searchByTransIdRadioButton.Size = new Size(216, 21);
            searchByTransIdRadioButton.TabIndex = 18;
            searchByTransIdRadioButton.TabStop = true;
            searchByTransIdRadioButton.Text = "Search By Transaction ID";
            searchByTransIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchEmailIdRadioButton
            // 
            searchEmailIdRadioButton.AutoSize = true;
            searchEmailIdRadioButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchEmailIdRadioButton.Location = new Point(164, 673);
            searchEmailIdRadioButton.Name = "searchEmailIdRadioButton";
            searchEmailIdRadioButton.Size = new Size(169, 21);
            searchEmailIdRadioButton.TabIndex = 19;
            searchEmailIdRadioButton.TabStop = true;
            searchEmailIdRadioButton.Text = "Search By Email ID";
            searchEmailIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchDateRadioButton
            // 
            searchDateRadioButton.AutoSize = true;
            searchDateRadioButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchDateRadioButton.Location = new Point(164, 702);
            searchDateRadioButton.Name = "searchDateRadioButton";
            searchDateRadioButton.Size = new Size(143, 21);
            searchDateRadioButton.TabIndex = 20;
            searchDateRadioButton.TabStop = true;
            searchDateRadioButton.Text = "Search By Date";
            searchDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchResultLabel
            // 
            searchResultLabel.AutoSize = true;
            searchResultLabel.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            searchResultLabel.Location = new Point(811, 368);
            searchResultLabel.Name = "searchResultLabel";
            searchResultLabel.Size = new Size(123, 20);
            searchResultLabel.TabIndex = 16;
            searchResultLabel.Text = "Search Result";
            // 
            // displayToolTip1
            // 
            displayToolTip1.BackColor = Color.Salmon;
            displayToolTip1.IsBalloon = true;
            displayToolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // proceedToolTip
            // 
            proceedToolTip.BackColor = Color.Salmon;
            proceedToolTip.IsBalloon = true;
            proceedToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // clearToolTip
            // 
            clearToolTip.BackColor = Color.Salmon;
            clearToolTip.IsBalloon = true;
            clearToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // summaryToolTip
            // 
            summaryToolTip.BackColor = Color.Salmon;
            summaryToolTip.IsBalloon = true;
            summaryToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // searchToolTip
            // 
            searchToolTip.BackColor = Color.Salmon;
            searchToolTip.IsBalloon = true;
            searchToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 788);
            Controls.Add(searchResultLabel);
            Controls.Add(searchResultListBox);
            Controls.Add(searchDateRadioButton);
            Controls.Add(searchEmailIdRadioButton);
            Controls.Add(searchByTransIdRadioButton);
            Controls.Add(investmentSummaryLabel);
            Controls.Add(searchPanel);
            Controls.Add(summaryListBox);
            Controls.Add(investmentOptionsGroupBox);
            Controls.Add(investmentDetailsGroupBox);
            Controls.Add(passwordPanel);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Invest4u";
            Load += Form1_Load;
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)investPictureBox).EndInit();
            investmentOptionsGroupBox.ResumeLayout(false);
            investmentOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)invest4uPictureBox1).EndInit();
            maturityAmountPanel.ResumeLayout(false);
            maturityAmountPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            investmentDetailsGroupBox.ResumeLayout(false);
            investmentDetailsGroupBox.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel passwordPanel;
        private PictureBox investPictureBox;
        private MaskedTextBox passwordMaskedTextBox;
        private Button loginButton;
        private Label passwordIncorrectLabel;
        private GroupBox investmentOptionsGroupBox;
        private Label investmentPrincipalLabel;
        private TextBox investmentPrincipalTextBox;
        private Label termLabel;
        private Label interestRateLabel;
        private ListBox smallIvestlentListBox;
        private Panel panel1;
        private Button displayButton;
        private Label maturityLabel;
        private Label oneYearLabel;
        private Panel maturityAmountPanel;
        private Label tenYearLabel;
        private Label fiveYearLabel;
        private Label threeYearLabel;
        private ListBox largeInvestListBox;
        private Label noteLabel;
        private Button proceedButton;
        private Button clearButton;
        private PictureBox invest4uPictureBox1;
        private GroupBox investmentDetailsGroupBox;
        private Label transactionIdLabel;
        private Label dateLabel;
        private Label investAmountLabel;
        private Label durationLabel;
        private Label iRLabel;
        private Label profitLabel;
        private TextBox profitTextBox;
        private TextBox iRTextBox;
        private TextBox durationTextBox;
        private TextBox investAmountTextBox;
        private TextBox transIdTextBox;
        private Label phoneLabel;
        private Label mailIdLabel;
        private Label nameLabel;
        private TextBox phonTextBox;
        private TextBox mailIdTextBox;
        private TextBox nameTextBox;
        private Button submitButton;
        private Button summaryButton;
        private Button searchButton;
        private TextBox searchTextBox;
        private ListBox summaryListBox;
        private Panel searchPanel;
        private Label investmentSummaryLabel;
        private RadioButton searchByTransIdRadioButton;
        private RadioButton searchEmailIdRadioButton;
        private RadioButton searchDateRadioButton;
        private ListBox searchResultListBox;
        private Label searchResultLabel;
        private Button exitButton;
        private ToolTip displayToolTip1;
        private ToolTip proceedToolTip;
        private ToolTip clearToolTip;
        private ToolTip summaryToolTip;
        private ToolTip searchToolTip;
    }
}