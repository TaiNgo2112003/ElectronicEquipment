using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeChainManagement.Views
{
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet22.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter1.Fill(this.coffeChainManagementDBDataSet22.Cart);
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet21.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.coffeChainManagementDBDataSet21.Cart);

        }
    }
}
