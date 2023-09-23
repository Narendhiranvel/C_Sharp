namespace Calculator
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int add;

            num1 = int.Parse(firstNumberTest.Text);
            num2 = int.Parse(secondNumberText.Text);
            add = num1 + num2;

            MessageBox.Show("The Added Value of " + num1 + " + " + num2 + " is " + add);

        }

        private void subButton_Click(object sender, EventArgs e)
        {
            int sub;

            num1 = int.Parse(firstNumberTest.Text);
            num2 = int.Parse(secondNumberText.Text);
            sub = num1 - num2;

            MessageBox.Show("The Subracted Value is " + sub);

        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            int mul=0;

            num1 = int.Parse(firstNumberTest.Text);
            num2 = int.Parse(secondNumberText.Text);
            mul = num1 * num2;

            MessageBox.Show("The Added Value is " + mul);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            int div;

            num1 = int.Parse(firstNumberTest.Text);
            num2 = int.Parse(secondNumberText.Text);
            div = num1 / num2;

            MessageBox.Show("The Added Value is " + div);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            firstNumberTest.Clear();
            secondNumberText.Clear();
            firstNumberTest.Focus();
        }
    }
}