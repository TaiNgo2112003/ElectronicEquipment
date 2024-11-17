using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeChainManagement
{
	public partial class customerForm : Form
	{
		public customerForm()
		{
			InitializeComponent();
		}

		private void customerForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'coffeChainManagementDBDataSet5.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.coffeChainManagementDBDataSet5.Customer);

        }

		private void button1_Click(object sender, EventArgs e)
		{

		}

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
