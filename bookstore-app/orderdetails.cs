using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bookstore_app
{
    public partial class orderdetails : Form
    {   //Get values of order from intstantiation of orderdetails form. I got the idea from here:
        //https://stackoverflow.com/questions/1559770/send-values-from-one-form-to-another-form
        public orderdetails(string cust, string title, string author, string isbn, string price, string qty, string sub, string tax, string total)
        {
            InitializeComponent();
            custText.Text = cust;
            titleText.Text = title;
            authorText.Text = author;
            isbnText.Text = isbn;
            priceText.Text = "$" + price;
            qtyText.Text = qty;
            subtotalText.Text = "$" + sub;
            taxText.Text = "$" + tax;
            totalText.Text = "$" + total;
        }

        private void custText_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderdetails_Load(object sender, EventArgs e)
        {

        }
    }
}
