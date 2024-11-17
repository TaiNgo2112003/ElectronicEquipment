using CoffeChainManagement.Views;
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
	public partial class Main_Form_User : Form
	{
		public Main_Form_User()
		{
			InitializeComponent();
		}
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Product_CLient());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadform(new ShoppingCart());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new shippingForm());
        }
    }
}
