using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment1
{
    public partial class Assignment1 : Form
    {
        private double basePrice, accessoriesPrice, subtotal, tax, tradeIn, total;
        const double Iphone6_16 = 749;
        const double Iphone6_64 = 859;
        const double Iphone6_128 = 969;
        const double Iphone6S_16 = 969;
        const double Iphone6S_64 = 1099;
        const double Iphone6S_128 = 1229;
        const double ProtectionPlan = 99;
        const double LeatherCase = 49;
        const double ScreenProtector = 29;
        private const int TEXTBOX_MAX_LENGTH = 12;
        private Boolean greaterThanZero = true;

        RadioButton btn_model,btn_color,btn_capacity;
        CheckBox chekBox;
        public Assignment1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // set auto check to false to prevent default radiobutton checked
            radioButtonIP6.TabStop = false;
            radioButtonIP6s.TabStop = false;
            radioButtonGold.TabStop = false;
            radioButtonGrey.TabStop = false;
            radioButtonSilver.TabStop = false;
            radioButtonSmall.TabStop = false;
            radioButtonMed.TabStop = false;
            radioButtonLarge.TabStop = false;
            //disable textbox,prevent them from editing
            textBoxBP.Enabled = false;
            textBoxAccessory.Enabled = false;
            textBoxTax.Enabled = false;
            textBoxSubtotal.Enabled = false;
            textBoxTotal.Enabled = false;
            // uncheck every check box
            checkBoxAPP.Checked = false;
            checkBoxLC.Checked = false;
            checkBoxSP.Checked = false;
            tradeIn = 0;
            textBoxTrade.Text = tradeIn.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        // when calculation button been clicked 
        private void buttonCal_Click(object sender, EventArgs e)
        {
            // we have already get the base price and accessory price before, so we get tax, subtotal
            subtotal = basePrice + accessoriesPrice;
            tax = subtotal * 0.13;
            // show number in currency format in textbox
     /*       textBoxBP.Text = basePrice.ToString("c2");
            textBoxAccessory.Text = accessoriesPrice.ToString("c2");         
            textBoxSubtotal.Text = subtotal.ToString("c2");         
            textBoxTax.Text = tax.ToString("c2");*/
            //validation for radio buttons

            if (radioButtonIP6.Checked == false && radioButtonIP6s.Checked == false)
            {
                MessageBox.Show("You have to choose a model!");
            }
            else if (radioButtonGold.Checked == false && radioButtonGrey.Checked == false && radioButtonSilver.Checked == false)
            {
                MessageBox.Show("You have to pick a color!");
            }
            else if (radioButtonMed.Checked == false && radioButtonLarge.Checked == false && radioButtonSmall.Checked == false)
            {
                MessageBox.Show("You have to choose a capacity!");
            }
            else if (textBoxTrade.Text.Length > TEXTBOX_MAX_LENGTH) { MessageBox.Show("Your input for trade in is too big!"); }
            else
            {
               /* textBoxBP.Text = basePrice.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                textBoxAccessory.Text = accessoriesPrice.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                textBoxSubtotal.Text = subtotal.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                textBoxTax.Text = tax.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));*/


                 // deal with trade in  by using try catch
                try
                {
                    if (textBoxTrade.Text == "")
                    { tradeIn = 0; greaterThanZero = true; }
                    if (textBoxTrade.Text != "$0.00"&&textBoxTrade.Text !="")
                    {
                        if (textBoxTrade.Text.IndexOf("$") == 0) { textBoxTrade.Text = textBoxTrade.Text.Substring(1); }
                        if (Double.Parse(textBoxTrade.Text) < 0) { MessageBox.Show("Trade in must be greater than zero!"); greaterThanZero = false; }
                        else
                        {
                            tradeIn = Convert.ToDouble(textBoxTrade.Text);
                            textBoxTrade.Text = tradeIn.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                            greaterThanZero = true;
                        }
                  }

                  //  tradeIn = Convert.ToDouble(textBoxTrade.Text);
                    // calculate total
                    total = subtotal - tradeIn + tax;
                    if (greaterThanZero)
                    {
                        textBoxBP.Text = basePrice.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                        textBoxAccessory.Text = accessoriesPrice.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                        textBoxSubtotal.Text = subtotal.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                        textBoxTax.Text = tax.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                        textBoxTotal.Text = total.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    }
                }
                catch (FormatException FE)
                {
                    MessageBox.Show(FE.Message);
                    // back the focus 
                }
                catch(OverflowException OF)
                {
                    MessageBox.Show(OF.Message);
                }
                catch(Exception er)
                {
                    MessageBox.Show("there is an error, your input was invalid!");
                }
            }
           
        }

        // when exit button click, exit application.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonModel_CheckedChanged(object sender, EventArgs e)
        {
            btn_model = (RadioButton)sender;
            if (btn_color != null)
            {
                this.getPicture(btn_model, btn_color);
                this.getPrice(btn_model, btn_capacity);
            }

        }
        private void radioButtonColor_CheckedChanged(object sender,EventArgs e)
        {
            btn_color = (RadioButton)sender;
            if (btn_model != null)
            {
                this.getPicture(btn_model, btn_color);
            }

        }
        private void radioButtonCapacity_CheckedChanged(object sender,EventArgs e)
        {
            btn_capacity = (RadioButton)sender;
            if (btn_color != null&&btn_model!=null)
            {
                this.getPrice(btn_model,btn_capacity);
            }
        }




        /* 
         *   this method will analysis the results in radiobutton groups 
         *   and choose the picture for different situation.    
         */

        private void getPicture(RadioButton a,RadioButton b)
        {
            if (a.Text.Equals(radioButtonIP6.Text))
            {
                switch (b.Text)
                {
                    case "G&old":
                        pictureBox.Image = COMP1004_Assignment1.Properties.Resources.iphone6gold;                       
                    break;
                    case "Space &Grey":
                        pictureBox.Image = COMP1004_Assignment1.Properties.Resources.iphone6grey;
                    break;
                    case "Silve&r":
                        pictureBox.Image = COMP1004_Assignment1.Properties.Resources.iphone6silver;
                    break;                
                }
                
            }
            else if (a.Text.Equals(radioButtonIP6s.Text))
            {               
                switch (b.Text)
                {
                    case "G&old":
                        pictureBox.Image = COMP1004_Assignment1.Properties.Resources.iphone6sgold;
                        break;
                    case "Space &Grey":
                        pictureBox.Image = COMP1004_Assignment1.Properties.Resources.iphone6sgrey;
                        break;
                    case "Silve&r":
                        pictureBox.Image = COMP1004_Assignment1.Properties.Resources.iphone6ssilver;
                        break;
                }
            }
            else
            {
                //do nothing
            }
        }
        /* 
         *   this method will analysis the results in radiobutton groups 
         *   and choose the price for different situation.    
         */
        private void getPrice(RadioButton a,RadioButton b)
        {
            if (a.Text.Equals(radioButtonIP6.Text))
            {
                if (b.Text.Equals(radioButtonSmall.Text))
                {
                    this.basePrice = Iphone6_16;
                }
                else if (b.Text.Equals(radioButtonMed.Text))
                {
                    this.basePrice = Iphone6_64;
                }
                else if(b.Text.Equals(radioButtonLarge.Text))
                {
                    this.basePrice = Iphone6_128;
                }
                else
                {
                    //do nothing
                }
            }
            else if (a.Text.Equals(radioButtonIP6s.Text))
            {
                if (b.Text.Equals(radioButtonSmall.Text))
                {
                    this.basePrice = Iphone6S_16; 
                }
                else if (b.Text.Equals(radioButtonMed.Text))
                {
                    this.basePrice = Iphone6S_64;
                }
                else if (b.Text.Equals(radioButtonLarge.Text))
                {
                    this.basePrice = Iphone6S_128;
                }
                else
                {
                   //do nothing
                }
            }
            else
            {
                //do nothing
            }
        }

        /* 
         *   this method will analysis the results in check box groups 
         *   and do ccessory calculation for different situation.    
         */
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            chekBox = (CheckBox)sender;
            if (chekBox.Equals(checkBoxAPP))
            {
                if (checkBoxAPP.Checked)
                    accessoriesPrice += ProtectionPlan;
                else
                {
                    accessoriesPrice -= ProtectionPlan;
                }
            }
            else if (chekBox.Equals(checkBoxSP))
            {
                if (checkBoxSP.Checked)
                {
                    accessoriesPrice += ScreenProtector;
                }
                else
                {
                    accessoriesPrice -= ScreenProtector;
                }
            }
            else if (chekBox.Equals(checkBoxLC))
            {
                if (checkBoxLC.Checked)
                {
                    accessoriesPrice += LeatherCase;
                }
                else
                {
                    accessoriesPrice -= LeatherCase;
                }
            }
            else
            {
                // do nothing
            }

        }

    }
}
