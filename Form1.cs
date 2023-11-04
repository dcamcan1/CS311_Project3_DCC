namespace CS311_Project3_DCC
{
    public partial class frmMain : Form
    {
        private float subTotal;
        private String pizzaSize;

        public frmMain()
        {
            InitializeComponent();
        }

        private void summarize()
        {
            subTotal = 0;
            rtfOrderSummary.Text = "";
            pizzaSize = cboSize.GetItemText(cboSize.SelectedItem);
            switch (pizzaSize)
            {
                case "Small":
                    subTotal += 2;
                    break;
                case "Medium":
                    subTotal += 5;
                    break;
                case "Large":
                    subTotal += 10;
                    break;
                case "X-Large":
                    subTotal += 15;
                    break;
                case "Ginormous":
                    subTotal += 20;
                    break;
                default:
                    MessageBox.Show("Use the dropdown menu to select a valid pizza size.");
                    return;
            }//end switch

            if (cboSize.Text == "")
            {
                MessageBox.Show("You must select a pizza size.");
            }
            else if (rdoThin.Checked == false && rdoThick.Checked == false && rdoRegular.Checked == false)
            {
                MessageBox.Show("You must select a crust type.");
            }
            else
            {
                String crustType = "";
                if (rdoThin.Checked)
                    crustType = "Thin";
                else if (rdoThick.Checked)
                    crustType = "Thick";
                else if (rdoRegular.Checked)
                    crustType = "Regular";
                rtfOrderSummary.SelectedText = "You ordered a " + pizzaSize + " pizza with " + crustType + " crust and the following toppings:\n";

                rtfOrderSummary.SelectionBullet = true;
                if (ckbPepperoni.Checked)
                {
                    rtfOrderSummary.SelectedText = "Pepperoni\n";
                    subTotal += 2;
                }
                if (ckbSausage.Checked)
                {
                    rtfOrderSummary.SelectedText = "Sausage\n";
                    subTotal += 2;
                }
                if (ckbCanadianBacon.Checked)
                {
                    rtfOrderSummary.SelectedText = "Canadian Bacon\n";
                    subTotal += 2;
                }
                if (ckbItalianSausage.Checked)
                {
                    rtfOrderSummary.SelectedText = "Spicy Italian Sausage\n";
                    subTotal += 2;
                }
                if (ckbGreenOlives.Checked)
                {
                    rtfOrderSummary.SelectedText = "Green Olives\n";
                    subTotal += 1;
                }
                if (ckbBlackOlives.Checked)
                {
                    rtfOrderSummary.SelectedText = "Black Olives\n";
                    subTotal += 1;
                }
                if (ckbGreenPepper.Checked)
                {
                    rtfOrderSummary.SelectedText = "Green Pepper\n";
                    subTotal += 1;
                }
                if (ckbOnion.Checked)
                {
                    rtfOrderSummary.SelectedText = "Onion\n";
                    subTotal += 1;
                }
                if (ckbBananaPeppers.Checked)
                {
                    rtfOrderSummary.SelectedText = "Banana Peppers\n";
                    subTotal += 1;
                }
                if (ckbJalapeño.Checked)
                {
                    rtfOrderSummary.SelectedText = "Jalapeño\n";
                    subTotal += 1;
                }
                if (ckbExtraCheese.Checked)
                {
                    rtfOrderSummary.SelectedText = "Extra Cheese\n";
                    subTotal += 1;
                }
                if (ckbMushroom.Checked)
                {
                    rtfOrderSummary.SelectedText = "Mushroom\n";
                    subTotal += 1;
                }
                rtfOrderSummary.SelectionBullet = false;

                txtSubTotal.Text = subTotal.ToString("C");
                double tax = Math.Round(subTotal * 0.06, 2);
                txtTax.Text = tax.ToString("C");
                double total = (double)subTotal + tax;
                txtTotal.Text = total.ToString("C");
            }
        }//end summarize

        private void clear()
        {
            ckbPepperoni.Checked = false;
            ckbSausage.Checked = false;
            ckbCanadianBacon.Checked = false;
            ckbItalianSausage.Checked = false;
            ckbGreenOlives.Checked = false;
            ckbBlackOlives.Checked = false;
            ckbGreenPepper.Checked = false;
            ckbOnion.Checked = false;
            ckbBananaPeppers.Checked = false;
            ckbJalapeño.Checked = false;
            ckbExtraCheese.Checked = false;
            ckbMushroom.Checked = false;
            subTotal = 0;
            rtfOrderSummary.Text = "";
            txtSubTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            rdoThin.Checked = false;
            rdoThick.Checked = false;
            rdoRegular.Checked = false;
            cboSize.Text = "";
            pizzaSize = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            summarize();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}