using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

/*  Sriharsha Shatagopam
 *  820860749
 *  Lab 5
 *  This lab is the project submitted for lab 1, 2 & 4, but modified for lab 5.
 *  
 *  MENU FORM
 *  
 *  NOTE: in Program.cs I have changed the code to make sure the menu form runs.
 */

namespace compe561_project1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }


        private void menu_FormClosed(object sender, EventArgs e)
        {
           

        }

        /*  Open new forms as modal dialog boxes so that the user needs to interact with
         *  them first before going back to the menu. Keeps menu visible so that user
         *  has to close it to to exit, ensuring it isn't still consuming memory after
         *  user closes one of the new forms.
         */
        private void custButton_Click(object sender, EventArgs e)
        {
            custForm c = new custForm();
            c.ShowDialog();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            book b = new book();
            b.ShowDialog();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            orderForm o = new orderForm();
            o.ShowDialog();
        }
    }
}
