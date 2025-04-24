using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;
using Invoice_Master.BLL;
using Invoice_Master.DAL;

namespace Invoice_Master.UI
{
    public partial class frmPurchasesAndSales : Form
    {
        public frmPurchasesAndSales()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        DeaCustDAL dcDAL = new DeaCustDAL();
        ProductsDAL pDAL = new ProductsDAL();
        UserDAL uDAL = new UserDAL();
        TransactionDAL tDAL = new TransactionDAL();
        TransactionDetailDAL tdDAL = new TransactionDetailDAL();

        DataTable transactionDT = new DataTable();

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPurchasesAndSales_Load(object sender, EventArgs e)
        {
            // Get the transactionType value from frmUserDashboard
            string type = frmUserDashboard.transactionType;

            // Set the value on lblTop
            lblTop.Text = type;

            // Sets the columns for the Transactions DataTable
            transactionDT.Columns.Add("Nom du produit");
            transactionDT.Columns.Add("Prix");
            transactionDT.Columns.Add("Quantité");
            transactionDT.Columns.Add("Nom du total");

        }

        private void txtDeaCustSearch_TextChanged(object sender, EventArgs e)
        {
            // Getting the search text
            string keywords = txtDeaCustSearch.Text;

            // Checking if the search text is not empty
            if (keywords == "")
            {
                // Clear all the textboxes
                txtDeaCustName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }

            DeaCustBLL dc = dcDAL.SearchDealerCustomerTransaction(keywords);

            // Display or set the value from DeaCustBLL to textboxes
            txtDeaCustName.Text = dc.name;
            txtEmail.Text = dc.email;
            txtContact.Text = dc.contact;
            txtAddress.Text = dc.address;
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            // Getting the search text
            string keywords = txtProductSearch.Text;

            // Checking if the search text is not empty
            if (keywords == "")
            {
                // Clear all the textboxes
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";
                return;
            }

            ProductsBLL p = pDAL.SearchProductTransaction(keywords);

            // Display or set the value from ProductBLL to textboxes
            txtProductName.Text = p.name;
            txtInventory.Text = p.qty.ToString();
            txtRate.Text = p.rate.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Getting data from UI
            string productName = txtProductName.Text;

            if (!decimal.TryParse(txtRate.Text, out decimal rate))
            {
                MessageBox.Show("Prix invalide : entrer un nombre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtQty.Text, out decimal qty))
            {
                MessageBox.Show("Quantité invalide : entrer un nombre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = rate * qty;

            // Display the subtotal in the textbox
            // Get the total value from the textbox
            decimal subTotal;
            // Parse attemps, stays 0.00 if fails
            decimal.TryParse(txtSubTotal.Text, out subTotal);
            subTotal = subTotal + total;

            // Checks if the product is selected
            if (productName == "")
            {
                // No product inserted
                MessageBox.Show("Sélectionner un produit et réessayer.");
            }
            else
            {
                // Display products successfully inserted into the Added Products Display Grid View
                transactionDT.Rows.Add(productName, rate, qty, total);
                dgvAddedProducts.DataSource = transactionDT;

                // Display the data in the Calculation Details panel 
                txtSubTotal.Text = subTotal.ToString();

                // Clear de text boxes
                txtProductSearch.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "0";
                txtRate.Text = "0.00";
                txtQty.Text = "0";
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            // Getting the discount value from the text box
            string value = txtDiscount.Text;

            if (value == "")
            {
                MessageBox.Show("Saisir une remise (0 si pas de remise).");
            }
            else
            {
                decimal discount;
                decimal.TryParse(txtDiscount.Text, out discount);

                decimal subTotal;
                decimal.TryParse(txtSubTotal.Text, out subTotal);

                // Calculate the Grand Total based on Discount
                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                // Display the Grand Total in its text box
                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            // Check if the Grand Total has a value, if not, calculate the discount first
            string check = txtGrandTotal.Text;
            if (check == "")
            {
                MessageBox.Show("Calculer d'abord la remise pour définir le total");
            }
            else
            {
                // Calculate VAT
                decimal previousGT = decimal.Parse(txtGrandTotal.Text);
                decimal vat;
                decimal.TryParse(txtVAT.Text, out vat);
                decimal grandTotalWithVAT = ((100 + vat ) / 100 ) * previousGT;

                // Display new Grand Total with VAT
                txtGrandTotal.Text = grandTotalWithVAT.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            // Get the Paid Amount and Grand Total
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);

            decimal paidAmount;
            decimal.TryParse(txtPaidAmount.Text, out paidAmount);

            // Display the return amount
            decimal returnAmount = paidAmount - grandTotal;
            txtReturnAmount.Text = returnAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the values from PurchaseSales form
            TransactionsBLL transaction = new TransactionsBLL();

            transaction.type = lblTop.Text;

            // Get the Dealer or Customer ID and name
            string deaCustName = txtDeaCustName.Text;
            DeaCustBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);

            transaction.dea_cust_id = dc.id;
            transaction.grand_total = Math.Round(decimal.Parse(txtGrandTotal.Text), 2);
            transaction.transaction_date = DateTime.Now;
            transaction.vat = decimal.Parse(txtVAT.Text);
            transaction.discount = decimal.Parse(txtDiscount.Text);

            // Get the username of logged in user
            string username = frmLogin.loggedIn;
            UserBLL u = uDAL.GetIDFromUsername(username);

            transaction.added_by = u.id;
            transaction.TransactionDetails = transactionDT;

            // Check if the data was inserted successfully
            bool isSuccess = false;

            // Insert transaction and transaction details
            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;

                // Insert transaction
                bool w = tDAL.InsertTransaction(transaction, out transactionID);

                //Loop to insert transaction details
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    //Get all the products details
                    TransactionDetailBLL transactionDetail = new TransactionDetailBLL();
                    string ProductName = transactionDT.Rows[i][0].ToString();
                    ProductsBLL p = pDAL.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;

                    // Insert Transaction Detail into the database
                    bool y = tdDAL.InsertTransactionDetail(transactionDetail, out _);
                    isSuccess = w && y;
                }

                // Complete transaction and clear form
                if (isSuccess == true)
                {
                    // Transaction complete
                    scope.Complete();
                    MessageBox.Show("Transaction réalisée avec succès !");

                    // Clear the Added Products Data Grid View
                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();

                    // Clear the Dealer and Customer text boxes
                    txtDeaCustName.Text = "";
                    txtEmail.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";

                    // Clear the Products text boxes
                    txtProductSearch.Text = "";
                    txtProductName.Text = "";
                    txtInventory.Text = "0";
                    txtRate.Text = "0";
                    txtQty.Text = "0";

                    // Clear the Calculation Details text boxes
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtVAT.Text = "0";
                    txtGrandTotal.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";
                }
                else
                {
                    MessageBox.Show("Échec, la transaction n'a pas abouti.");
                }
            }
        }
    }
}
