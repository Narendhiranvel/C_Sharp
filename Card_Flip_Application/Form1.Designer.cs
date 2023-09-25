namespace Card_Flip_Application
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
            CardBack = new PictureBox();
            CardFront = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)CardBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CardFront).BeginInit();
            SuspendLayout();
            // 
            // CardBack
            // 
            CardBack.BackgroundImage = (Image)resources.GetObject("CardBack.BackgroundImage");
            CardBack.Image = (Image)resources.GetObject("CardBack.Image");
            CardBack.Location = new Point(100, 70);
            CardBack.Name = "CardBack";
            CardBack.Size = new Size(140, 205);
            CardBack.SizeMode = PictureBoxSizeMode.Zoom;
            CardBack.TabIndex = 0;
            CardBack.TabStop = false;
            CardBack.Visible = false;
            //CardBack.Click += CardBack_Click;
            // 
            // CardFront
            // 
            CardFront.Image = (Image)resources.GetObject("CardFront.Image");
            CardFront.Location = new Point(277, 70);
            CardFront.Name = "CardFront";
            CardFront.Size = new Size(142, 205);
            CardFront.SizeMode = PictureBoxSizeMode.Zoom;
            CardFront.TabIndex = 1;
            CardFront.TabStop = false;
            CardFront.Visible = false;
           // CardFront.Click += CardFront_Click;
            // 
            // button1
            // 
            button1.Location = new Point(100, 322);
            button1.Name = "button1";
            button1.Size = new Size(140, 64);
            button1.TabIndex = 2;
            button1.Text = "FlipToFront";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 322);
            button2.Name = "button2";
            button2.Size = new Size(142, 64);
            button2.TabIndex = 3;
            button2.Text = "FlipToBack";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 464);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CardFront);
            Controls.Add(CardBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CardBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)CardFront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CardBack;
        private PictureBox CardFront;
        private Button button1;
        private Button button2;
    }
}