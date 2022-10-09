using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class frmLunchOrder : Form
    {
        private double hamBurger = 6.95;
        private double pizza = 5.95;
        private double salad = 4.95;
        private double hamBurgerGroup = 0.75;
        private double pizzaGroup = 0.85;
        private double saladGroup = 0.65;
        private double subTotal = 0.0;
        private double finalPrice = 0.0;
        private double tax;


        public frmLunchOrder()
        {
            InitializeComponent();
            radioBtnHamBurger.Checked = true; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //Calculate the tax and final price 
            subTotal = CalculateSubTotal();           
            tax = subTotal * (13.0 / 100.0);
            finalPrice = subTotal + tax;
            //Rounding the Result upto 2 digits
            subTotal = Math.Round(subTotal, 2);
            tax = Math.Round(tax, 2);
            finalPrice = Math.Round(finalPrice,2);
            //Display the output in the textBoxes
            lblSalesTax.Text = tax.ToString();
            lblSubtotal.Text = subTotal.ToString();
            lblOrderTotal.Text = finalPrice.ToString();

        }

        //Method to calculate the Price before tax based on user choice 
        private double CalculateSubTotal()

        {
            if (radioBtnHamBurger.Checked == true)
            {
                subTotal = hamBurger;
                if (checkBox1.Checked == true)
                {
                    subTotal += hamBurgerGroup;
                }
                if (checkBox2.Checked == true)
                {
                    subTotal += pizzaGroup;
                }
                if (checkBox3.Checked == true)
                {
                    subTotal += saladGroup;
                }


            }
            else if (radioBtnPizza.Checked == true)
            {
                subTotal = pizza;
                if (checkBox1.Checked == true)
                {
                    subTotal += hamBurgerGroup;
                }
                if (checkBox2.Checked == true)
                {
                    subTotal += pizzaGroup;
                }
                if (checkBox3.Checked == true)
                {
                    subTotal += saladGroup;
                }


            }
            else
            {
                subTotal = salad;
                if (checkBox1.Checked == true)
                {
                    subTotal += hamBurgerGroup;
                }
                if (checkBox2.Checked == true)
                {
                    subTotal += pizzaGroup;
                }
                if (checkBox3.Checked == true)
                {
                    subTotal += saladGroup;
                }

            }
            return subTotal;
        }

          

          
     
        //Display toppings related to the Hamburger after checking the hamburger radio button

        private void radioBtnHamBurger_CheckedChanged(object sender, EventArgs e)
        {
            //Reset the Value
            lblOrderTotal.Text = "";
            lblSalesTax.Text = "";
            lblSubtotal.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            //Topping details to add on list
            gpxAddOnItem.Text = "Add-on Items ($.75/each)";
            checkBox1.Text = "Lettuce, tomato, and oninons";
            checkBox2.Text = "Ketchup, mustard, and mayo";
            checkBox3.Text = "French fries";

        }
        //Display toppings related to the Pizza after checking the Pizza radio button

        private void radioBtnPizza_CheckedChanged(object sender, EventArgs e)
        {
            //Reset the Value
            lblOrderTotal.Text = "";
            lblSalesTax.Text = "";
            lblSubtotal.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            //Topping details to add on list
            gpxAddOnItem.Text = "Add-on Items ($.85/each)";
            checkBox1.Text = "Pepperoni";
            checkBox2.Text = "Sausage";
            checkBox3.Text = "Olives";

        }
        //Display toppings related to the Salad after checking the Salad radio button

        private void radioBtnSalad_CheckedChanged(object sender, EventArgs e)
        {
            //Reset the Value
            lblOrderTotal.Text = "";
            lblSalesTax.Text = "";
            lblSubtotal.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            //Topping details to add on list
            gpxAddOnItem.Text = "Add-on Items ($.65/each)";
            checkBox1.Text = "Croutons";
            checkBox2.Text = "Bacon bits";
            checkBox3.Text = "Bread sticks";
        }
    }
}