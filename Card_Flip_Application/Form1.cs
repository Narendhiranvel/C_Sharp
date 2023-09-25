namespace Card_Flip_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Show Front
        private void button1_Click(object sender, EventArgs e)
        {
            CardFront.Visible = true;
            CardBack.Visible = false;
        }

        // Show Back
        private void button2_Click(object sender, EventArgs e)
        {
            CardFront.Visible = false;
            CardBack.Visible = true;
        }
    }
}