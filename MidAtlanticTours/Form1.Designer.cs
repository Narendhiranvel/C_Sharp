namespace MidAtlanticTours
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
            driverDetailsPanel = new Panel();
            proceedButton = new Button();
            busIdTextBox = new TextBox();
            busIdLabel = new Label();
            driverNameTextBox = new TextBox();
            driverNameLabel = new Label();
            driverSummaryGroupBox = new GroupBox();
            totalDriversTextBox = new TextBox();
            totaDriversLabelBox = new Label();
            childFarePercentageTextBox = new TextBox();
            childFareReceiptsTextBox = new TextBox();
            studentFarePercentageTextBox = new TextBox();
            studentFareReciptsTextBox = new TextBox();
            fullFarePercentageTextBox = new TextBox();
            fullFareReciptsTextBox = new TextBox();
            totalDriverReceiptsTextBox = new TextBox();
            totalPassengerTextBox = new TextBox();
            childFareReceiptsLabel = new Label();
            studentFareReceiptsLabel = new Label();
            fullFareReceiptsLabel = new Label();
            totalDriverReceiptsLabel = new Label();
            totalPassengerLabel = new Label();
            driverPassengerGroupBox1 = new GroupBox();
            childFareTextBox = new TextBox();
            studentFareTextBox = new TextBox();
            fullFareTextBox = new TextBox();
            childFareLabel = new Label();
            studentFareLabel = new Label();
            fullFareLabel = new Label();
            busPicture1 = new PictureBox();
            processPanel = new Panel();
            exirButton = new Button();
            summaryButton = new Button();
            clearButton = new Button();
            processButton = new Button();
            clearToolTip = new ToolTip(components);
            exitToolTip = new ToolTip(components);
            processToolTip = new ToolTip(components);
            summaryToolTip = new ToolTip(components);
            driverDetailsPanel.SuspendLayout();
            driverSummaryGroupBox.SuspendLayout();
            driverPassengerGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)busPicture1).BeginInit();
            processPanel.SuspendLayout();
            SuspendLayout();
            // 
            // driverDetailsPanel
            // 
            driverDetailsPanel.BackColor = SystemColors.ControlLightLight;
            driverDetailsPanel.Controls.Add(proceedButton);
            driverDetailsPanel.Controls.Add(busIdTextBox);
            driverDetailsPanel.Controls.Add(busIdLabel);
            driverDetailsPanel.Controls.Add(driverNameTextBox);
            driverDetailsPanel.Controls.Add(driverNameLabel);
            driverDetailsPanel.Location = new Point(67, 51);
            driverDetailsPanel.Name = "driverDetailsPanel";
            driverDetailsPanel.Size = new Size(749, 119);
            driverDetailsPanel.TabIndex = 0;
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.Aquamarine;
            proceedButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            proceedButton.Location = new Point(593, 35);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(109, 45);
            proceedButton.TabIndex = 4;
            proceedButton.Text = "Proceed";
            proceedButton.UseVisualStyleBackColor = false;
            proceedButton.Click += proceedButton_Click;
            // 
            // busIdTextBox
            // 
            busIdTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            busIdTextBox.Location = new Point(435, 40);
            busIdTextBox.Name = "busIdTextBox";
            busIdTextBox.Size = new Size(83, 34);
            busIdTextBox.TabIndex = 3;
            busIdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // busIdLabel
            // 
            busIdLabel.AutoSize = true;
            busIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            busIdLabel.Location = new Point(330, 43);
            busIdLabel.Name = "busIdLabel";
            busIdLabel.Size = new Size(78, 28);
            busIdLabel.TabIndex = 2;
            busIdLabel.Text = "Bus ID:";
            // 
            // driverNameTextBox
            // 
            driverNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            driverNameTextBox.Location = new Point(162, 37);
            driverNameTextBox.Name = "driverNameTextBox";
            driverNameTextBox.Size = new Size(125, 34);
            driverNameTextBox.TabIndex = 1;
            driverNameTextBox.TextAlign = HorizontalAlignment.Center;
            driverNameTextBox.KeyPress += driverNameTextBox_KeyPress;
            // 
            // driverNameLabel
            // 
            driverNameLabel.AutoSize = true;
            driverNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            driverNameLabel.Location = new Point(14, 40);
            driverNameLabel.Name = "driverNameLabel";
            driverNameLabel.Size = new Size(138, 28);
            driverNameLabel.TabIndex = 0;
            driverNameLabel.Text = "Driver Name:";
            // 
            // driverSummaryGroupBox
            // 
            driverSummaryGroupBox.BackColor = SystemColors.ControlLightLight;
            driverSummaryGroupBox.Controls.Add(totalDriversTextBox);
            driverSummaryGroupBox.Controls.Add(totaDriversLabelBox);
            driverSummaryGroupBox.Controls.Add(childFarePercentageTextBox);
            driverSummaryGroupBox.Controls.Add(childFareReceiptsTextBox);
            driverSummaryGroupBox.Controls.Add(studentFarePercentageTextBox);
            driverSummaryGroupBox.Controls.Add(studentFareReciptsTextBox);
            driverSummaryGroupBox.Controls.Add(fullFarePercentageTextBox);
            driverSummaryGroupBox.Controls.Add(fullFareReciptsTextBox);
            driverSummaryGroupBox.Controls.Add(totalDriverReceiptsTextBox);
            driverSummaryGroupBox.Controls.Add(totalPassengerTextBox);
            driverSummaryGroupBox.Controls.Add(childFareReceiptsLabel);
            driverSummaryGroupBox.Controls.Add(studentFareReceiptsLabel);
            driverSummaryGroupBox.Controls.Add(fullFareReceiptsLabel);
            driverSummaryGroupBox.Controls.Add(totalDriverReceiptsLabel);
            driverSummaryGroupBox.Controls.Add(totalPassengerLabel);
            driverSummaryGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            driverSummaryGroupBox.Location = new Point(173, 717);
            driverSummaryGroupBox.Name = "driverSummaryGroupBox";
            driverSummaryGroupBox.Size = new Size(557, 365);
            driverSummaryGroupBox.TabIndex = 4;
            driverSummaryGroupBox.TabStop = false;
            driverSummaryGroupBox.Text = "Driver Summary";
            // 
            // totalDriversTextBox
            // 
            totalDriversTextBox.BorderStyle = BorderStyle.FixedSingle;
            totalDriversTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalDriversTextBox.Location = new Point(325, 37);
            totalDriversTextBox.Name = "totalDriversTextBox";
            totalDriversTextBox.Size = new Size(168, 32);
            totalDriversTextBox.TabIndex = 14;
            totalDriversTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // totaDriversLabelBox
            // 
            totaDriversLabelBox.AutoSize = true;
            totaDriversLabelBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            totaDriversLabelBox.Location = new Point(29, 37);
            totaDriversLabelBox.Name = "totaDriversLabelBox";
            totaDriversLabelBox.Size = new Size(216, 25);
            totaDriversLabelBox.TabIndex = 13;
            totaDriversLabelBox.Text = "Total Number of Drivers";
            // 
            // childFarePercentageTextBox
            // 
            childFarePercentageTextBox.BorderStyle = BorderStyle.FixedSingle;
            childFarePercentageTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            childFarePercentageTextBox.Location = new Point(428, 254);
            childFarePercentageTextBox.Name = "childFarePercentageTextBox";
            childFarePercentageTextBox.Size = new Size(65, 32);
            childFarePercentageTextBox.TabIndex = 12;
            childFarePercentageTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // childFareReceiptsTextBox
            // 
            childFareReceiptsTextBox.BorderStyle = BorderStyle.FixedSingle;
            childFareReceiptsTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            childFareReceiptsTextBox.Location = new Point(324, 254);
            childFareReceiptsTextBox.Name = "childFareReceiptsTextBox";
            childFareReceiptsTextBox.Size = new Size(98, 32);
            childFareReceiptsTextBox.TabIndex = 11;
            childFareReceiptsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // studentFarePercentageTextBox
            // 
            studentFarePercentageTextBox.BorderStyle = BorderStyle.FixedSingle;
            studentFarePercentageTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            studentFarePercentageTextBox.Location = new Point(428, 208);
            studentFarePercentageTextBox.Name = "studentFarePercentageTextBox";
            studentFarePercentageTextBox.Size = new Size(65, 32);
            studentFarePercentageTextBox.TabIndex = 10;
            studentFarePercentageTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // studentFareReciptsTextBox
            // 
            studentFareReciptsTextBox.BorderStyle = BorderStyle.FixedSingle;
            studentFareReciptsTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            studentFareReciptsTextBox.Location = new Point(325, 208);
            studentFareReciptsTextBox.Name = "studentFareReciptsTextBox";
            studentFareReciptsTextBox.Size = new Size(97, 32);
            studentFareReciptsTextBox.TabIndex = 9;
            studentFareReciptsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // fullFarePercentageTextBox
            // 
            fullFarePercentageTextBox.BorderStyle = BorderStyle.FixedSingle;
            fullFarePercentageTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            fullFarePercentageTextBox.Location = new Point(428, 164);
            fullFarePercentageTextBox.Name = "fullFarePercentageTextBox";
            fullFarePercentageTextBox.Size = new Size(65, 32);
            fullFarePercentageTextBox.TabIndex = 8;
            fullFarePercentageTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // fullFareReciptsTextBox
            // 
            fullFareReciptsTextBox.BorderStyle = BorderStyle.FixedSingle;
            fullFareReciptsTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            fullFareReciptsTextBox.Location = new Point(325, 164);
            fullFareReciptsTextBox.Name = "fullFareReciptsTextBox";
            fullFareReciptsTextBox.Size = new Size(97, 32);
            fullFareReciptsTextBox.TabIndex = 7;
            fullFareReciptsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // totalDriverReceiptsTextBox
            // 
            totalDriverReceiptsTextBox.BorderStyle = BorderStyle.FixedSingle;
            totalDriverReceiptsTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalDriverReceiptsTextBox.Location = new Point(325, 121);
            totalDriverReceiptsTextBox.Name = "totalDriverReceiptsTextBox";
            totalDriverReceiptsTextBox.Size = new Size(168, 32);
            totalDriverReceiptsTextBox.TabIndex = 6;
            totalDriverReceiptsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // totalPassengerTextBox
            // 
            totalPassengerTextBox.BorderStyle = BorderStyle.FixedSingle;
            totalPassengerTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalPassengerTextBox.Location = new Point(325, 79);
            totalPassengerTextBox.Name = "totalPassengerTextBox";
            totalPassengerTextBox.Size = new Size(168, 32);
            totalPassengerTextBox.TabIndex = 5;
            totalPassengerTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // childFareReceiptsLabel
            // 
            childFareReceiptsLabel.AutoSize = true;
            childFareReceiptsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            childFareReceiptsLabel.Location = new Point(92, 256);
            childFareReceiptsLabel.Name = "childFareReceiptsLabel";
            childFareReceiptsLabel.Size = new Size(172, 25);
            childFareReceiptsLabel.TabIndex = 4;
            childFareReceiptsLabel.Text = "Child Fare Receipts";
            // 
            // studentFareReceiptsLabel
            // 
            studentFareReceiptsLabel.AutoSize = true;
            studentFareReceiptsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            studentFareReceiptsLabel.Location = new Point(92, 208);
            studentFareReceiptsLabel.Name = "studentFareReceiptsLabel";
            studentFareReceiptsLabel.Size = new Size(196, 25);
            studentFareReceiptsLabel.TabIndex = 3;
            studentFareReceiptsLabel.Text = "Student Fare Receipts";
            // 
            // fullFareReceiptsLabel
            // 
            fullFareReceiptsLabel.AutoSize = true;
            fullFareReceiptsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            fullFareReceiptsLabel.Location = new Point(92, 166);
            fullFareReceiptsLabel.Name = "fullFareReceiptsLabel";
            fullFareReceiptsLabel.Size = new Size(159, 25);
            fullFareReceiptsLabel.TabIndex = 2;
            fullFareReceiptsLabel.Text = "Full Fare Receipts";
            // 
            // totalDriverReceiptsLabel
            // 
            totalDriverReceiptsLabel.AutoSize = true;
            totalDriverReceiptsLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalDriverReceiptsLabel.Location = new Point(29, 121);
            totalDriverReceiptsLabel.Name = "totalDriverReceiptsLabel";
            totalDriverReceiptsLabel.Size = new Size(188, 25);
            totalDriverReceiptsLabel.TabIndex = 1;
            totalDriverReceiptsLabel.Text = "Total Driver Receipts";
            // 
            // totalPassengerLabel
            // 
            totalPassengerLabel.AutoSize = true;
            totalPassengerLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            totalPassengerLabel.Location = new Point(29, 79);
            totalPassengerLabel.Name = "totalPassengerLabel";
            totalPassengerLabel.Size = new Size(250, 25);
            totalPassengerLabel.TabIndex = 0;
            totalPassengerLabel.Text = "Total Number of Passengers";
            // 
            // driverPassengerGroupBox1
            // 
            driverPassengerGroupBox1.BackColor = SystemColors.ControlLightLight;
            driverPassengerGroupBox1.BackgroundImageLayout = ImageLayout.Center;
            driverPassengerGroupBox1.Controls.Add(childFareTextBox);
            driverPassengerGroupBox1.Controls.Add(studentFareTextBox);
            driverPassengerGroupBox1.Controls.Add(fullFareTextBox);
            driverPassengerGroupBox1.Controls.Add(childFareLabel);
            driverPassengerGroupBox1.Controls.Add(studentFareLabel);
            driverPassengerGroupBox1.Controls.Add(fullFareLabel);
            driverPassengerGroupBox1.Location = new Point(173, 405);
            driverPassengerGroupBox1.Name = "driverPassengerGroupBox1";
            driverPassengerGroupBox1.Size = new Size(557, 203);
            driverPassengerGroupBox1.TabIndex = 2;
            driverPassengerGroupBox1.TabStop = false;
            driverPassengerGroupBox1.Text = "Driver Daily Passengers";
            // 
            // childFareTextBox
            // 
            childFareTextBox.BorderStyle = BorderStyle.FixedSingle;
            childFareTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            childFareTextBox.Location = new Point(342, 133);
            childFareTextBox.Name = "childFareTextBox";
            childFareTextBox.Size = new Size(77, 30);
            childFareTextBox.TabIndex = 5;
            childFareTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // studentFareTextBox
            // 
            studentFareTextBox.BorderStyle = BorderStyle.FixedSingle;
            studentFareTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            studentFareTextBox.Location = new Point(342, 84);
            studentFareTextBox.Name = "studentFareTextBox";
            studentFareTextBox.Size = new Size(77, 30);
            studentFareTextBox.TabIndex = 4;
            studentFareTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // fullFareTextBox
            // 
            fullFareTextBox.BorderStyle = BorderStyle.FixedSingle;
            fullFareTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            fullFareTextBox.Location = new Point(342, 36);
            fullFareTextBox.Name = "fullFareTextBox";
            fullFareTextBox.Size = new Size(77, 30);
            fullFareTextBox.TabIndex = 3;
            fullFareTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // childFareLabel
            // 
            childFareLabel.AutoSize = true;
            childFareLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            childFareLabel.Location = new Point(97, 139);
            childFareLabel.Name = "childFareLabel";
            childFareLabel.Size = new Size(97, 23);
            childFareLabel.TabIndex = 2;
            childFareLabel.Text = "Child Fares";
            // 
            // studentFareLabel
            // 
            studentFareLabel.AutoSize = true;
            studentFareLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            studentFareLabel.Location = new Point(97, 88);
            studentFareLabel.Name = "studentFareLabel";
            studentFareLabel.Size = new Size(119, 23);
            studentFareLabel.TabIndex = 1;
            studentFareLabel.Text = "Student Fares";
            // 
            // fullFareLabel
            // 
            fullFareLabel.AutoSize = true;
            fullFareLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            fullFareLabel.Location = new Point(97, 40);
            fullFareLabel.Name = "fullFareLabel";
            fullFareLabel.Size = new Size(84, 23);
            fullFareLabel.TabIndex = 0;
            fullFareLabel.Text = "Full Fares";
            // 
            // busPicture1
            // 
            busPicture1.Image = (Image)resources.GetObject("busPicture1.Image");
            busPicture1.Location = new Point(283, 197);
            busPicture1.Name = "busPicture1";
            busPicture1.Size = new Size(343, 193);
            busPicture1.SizeMode = PictureBoxSizeMode.Zoom;
            busPicture1.TabIndex = 1;
            busPicture1.TabStop = false;
            // 
            // processPanel
            // 
            processPanel.BackColor = SystemColors.ButtonHighlight;
            processPanel.Controls.Add(exirButton);
            processPanel.Controls.Add(summaryButton);
            processPanel.Controls.Add(clearButton);
            processPanel.Controls.Add(processButton);
            processPanel.Location = new Point(173, 629);
            processPanel.Name = "processPanel";
            processPanel.Size = new Size(557, 73);
            processPanel.TabIndex = 3;
            // 
            // exirButton
            // 
            exirButton.BackColor = Color.Aquamarine;
            exirButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exirButton.Location = new Point(433, 21);
            exirButton.Name = "exirButton";
            exirButton.Size = new Size(94, 29);
            exirButton.TabIndex = 3;
            exirButton.Text = "Exit";
            exitToolTip.SetToolTip(exirButton, "Press to Exit Application");
            exirButton.UseVisualStyleBackColor = false;
            exirButton.Click += exirButton_Click;
            // 
            // summaryButton
            // 
            summaryButton.BackColor = Color.Aquamarine;
            summaryButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            summaryButton.Location = new Point(301, 21);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(94, 29);
            summaryButton.TabIndex = 2;
            summaryButton.Text = "Summary";
            summaryToolTip.SetToolTip(summaryButton, "Press to View Company Summary");
            summaryButton.UseVisualStyleBackColor = false;
            summaryButton.Click += summaryButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Aquamarine;
            clearButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Location = new Point(150, 21);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearToolTip.SetToolTip(clearButton, "Press to Clear Form for New Data Entry");
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // processButton
            // 
            processButton.BackColor = Color.Aquamarine;
            processButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            processButton.Location = new Point(23, 21);
            processButton.Name = "processButton";
            processButton.Size = new Size(94, 29);
            processButton.TabIndex = 0;
            processButton.Text = "Process";
            processToolTip.SetToolTip(processButton, "Press to View Driver Summary");
            processButton.UseVisualStyleBackColor = false;
            processButton.Click += processButton_Click;
            // 
            // clearToolTip
            // 
            clearToolTip.IsBalloon = true;
            clearToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // exitToolTip
            // 
            exitToolTip.IsBalloon = true;
            exitToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // processToolTip
            // 
            processToolTip.IsBalloon = true;
            processToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // summaryToolTip
            // 
            summaryToolTip.IsBalloon = true;
            summaryToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(894, 932);
            Controls.Add(driverSummaryGroupBox);
            Controls.Add(processPanel);
            Controls.Add(driverPassengerGroupBox1);
            Controls.Add(busPicture1);
            Controls.Add(driverDetailsPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Welcome To MAT Driver Portal";
            driverDetailsPanel.ResumeLayout(false);
            driverDetailsPanel.PerformLayout();
            driverSummaryGroupBox.ResumeLayout(false);
            driverSummaryGroupBox.PerformLayout();
            driverPassengerGroupBox1.ResumeLayout(false);
            driverPassengerGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)busPicture1).EndInit();
            processPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel driverDetailsPanel;
        private Label driverNameLabel;
        private Label busIdLabel;
        private TextBox driverNameTextBox;
        private TextBox busIdTextBox;
        private Button proceedButton;
        private PictureBox busPicture1;
        private GroupBox driverPassengerGroupBox1;
        private Label childFareLabel;
        private Label studentFareLabel;
        private Label fullFareLabel;
        private TextBox childFareTextBox;
        private TextBox studentFareTextBox;
        private TextBox fullFareTextBox;
        private Panel processPanel;
        private Button processButton;
        private Button clearButton;
        private Button summaryButton;
        private Button exirButton;
        private GroupBox driverSummaryGroupBox;
        private Label childFareReceiptsLabel;
        private Label studentFareReceiptsLabel;
        private Label fullFareReceiptsLabel;
        private Label totalDriverReceiptsLabel;
        private Label totalPassengerLabel;
        private TextBox totalPassengerTextBox;
        private TextBox childFareReceiptsTextBox;
        private TextBox studentFarePercentageTextBox;
        private TextBox studentFareReciptsTextBox;
        private TextBox fullFarePercentageTextBox;
        private TextBox fullFareReciptsTextBox;
        private TextBox totalDriverReceiptsTextBox;
        private TextBox childFarePercentageTextBox;
        private TextBox totalDriversTextBox;
        private Label totaDriversLabelBox;
        private ToolTip clearToolTip;
        private ToolTip exitToolTip;
        private ToolTip processToolTip;
        private ToolTip summaryToolTip;
    }
}