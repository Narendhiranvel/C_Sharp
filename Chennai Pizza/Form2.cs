using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chennai_Pizza
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void SetInventoryQuantities(int texasBbqQty, int vegSuperemeQty, int americanHotQty, int farmhouseQty,
        int hotAndSpicyQty, int tandooriChickenQty, int chickenTikkaQty, int cheezePizzaQty, int cheeseAndCornQty,
        int madrasSpecialQty, int mumbaiSpecialQty, int andraSpiceQty, int keralaSupremeQty, int delhiSpecialQty,
        int fishAndPrawnQty)
        {
            // Set the inventory quantities in the textboxes

            texasBbqTextBox.Text = texasBbqQty.ToString();
            vegSuperemeTextBox.Text = vegSuperemeQty.ToString();
            americanHotTextBox.Text = americanHotQty.ToString();
            farmhouseTextBox.Text = farmhouseQty.ToString();
            hotAndSpicyTextBox.Text = hotAndSpicyQty.ToString();
            tandooriChickenTextBox.Text = tandooriChickenQty.ToString();
            chickenTikkaTextBox.Text = chickenTikkaQty.ToString();
            cheesePizzaTextBox.Text = cheezePizzaQty.ToString();
            cheeseAndCornTextBox.Text = cheeseAndCornQty.ToString();
            madrasSpecialTextBox.Text = madrasSpecialQty.ToString();
            mumbaiSpecialTextBox.Text = mumbaiSpecialQty.ToString();
            andraSpiceTextBox.Text = andraSpiceQty.ToString();
            keralaSupremeTextBox.Text = keralaSupremeQty.ToString();
            delhiSpecialTextBox.Text = delhiSpecialQty.ToString();
            fishAndPrawnTextBox.Text = fishAndPrawnQty.ToString();

        }
    }
}
