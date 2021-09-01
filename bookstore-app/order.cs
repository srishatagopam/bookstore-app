using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace compe561_project1
{
   
    public partial class orderForm : Form
    {
        /*  Create an array and arraylist of book and customer objects  
         */
        ArrayList bookList = new ArrayList();
        Book[] bookArr = new Book[100];

        ArrayList custList = new ArrayList();
        Customer[] custArr = new Customer[100];


        public orderForm()
        {
            InitializeComponent();


            /*  Create connection to database. Use select command to recieve the cust_pid & book_pid of the last row of
             *  the bs_cust & bs_books table. From 1 to maxID (since it is autoincremented), select the first name, last name,
             *  address, city, state, zip, phone number, and email from each row, and create a new Customer using 
             *  those string values, and put them in the book array, and add them to the cust & book comboboxes. Then close 
             *  the database. 
             */
            try
            {
                int count;
               // string firstString, lastString, addressString, cityString, stateString, zipString, phoneString, emailString;
                string first, last, address, city, state, zip, phone, email;

                string database = "db_bookstore";
                string table = "bs_customer";
                string connectString = "server = localhost; database = " + database + "; uid = root; password =;";
                MySqlConnection databaseConnect = new MySqlConnection(connectString);
                databaseConnect.Open();

                string maxIDString = "SELECT MAX(cust_pid) FROM " + database + "." + table;
                MySqlCommand maxIDCmd = new MySqlCommand(maxIDString, databaseConnect);
                int maxID = int.Parse(maxIDCmd.ExecuteScalar() + "");

                databaseConnect.Close();


                for (count = 1; count <= maxID; count++)
                {
                    first = selectVal(count, "first_name", table, "cust_pid");
                    last = selectVal(count, "last_name", table, "cust_pid");
                    address = selectVal(count, "address", table, "cust_pid");
                    city = selectVal(count, "city", table, "cust_pid");
                    state = selectVal(count, "state", table, "cust_pid");
                    zip = selectVal(count, "zip", table, "cust_pid");
                    phone = selectVal(count, "phone", table, "cust_pid");
                    email = selectVal(count, "email", table, "cust_pid");


                    custArr[count - 1] = new Customer(first, last, address, city, state, zip, phone, email);
                    custComboBox.Items.Add(custArr[count - 1].First + " " + custArr[count - 1].Last);
                }

               // string titleString, authorString, isbnString, priceString;
                string title, author, isbn, price;


                table = "bs_books";
                databaseConnect.Open();

                maxIDString = "SELECT MAX(book_pid) FROM " + database + "." + table;
                maxIDCmd = new MySqlCommand(maxIDString, databaseConnect);
                maxID = int.Parse(maxIDCmd.ExecuteScalar() + "");

                databaseConnect.Close();

                for (count = 1; count <= maxID; count++)
                {
                    title = selectVal(count, "title", table, "book_pid");
                    author = selectVal(count, "author", table, "book_pid");
                    isbn = selectVal(count, "isbn", table, "book_pid");
                    price = selectVal(count, "price", table, "book_pid");

                    bookArr[count - 1] = new Book(title, author, isbn, price);
                    bookList.Add(bookArr[count - 1]);
                    bookComboBox.Items.Add(bookArr[count - 1].Title);
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("No connection.");
            }

            dataGridView1.RowCount = 3;
        }

        /*   Create a array of book objects; for each book in the array, if the string
         *   in the combobox selection matches the title of one of the books, then
         *   fill the author, ISBN, and price text boxes with the corresponding fields
         *   from the book object.  
         */
        private void bookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookComboBox.SelectedIndex != -1)
            {
                int temp = bookComboBox.SelectedIndex;

                //Loads selected book information into textboxes.
                authorText.Text = bookArr[temp].Author;
                isbnText.Text = bookArr[temp].ISBN;
                priceText.Text = bookArr[temp].Price;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /*   Displays messageboxes for errors: when the user does not select a book from 
         *   the combobox, and when the quantity field is null or not numerical. Else, 
         *   will add each selected book and quantity to the datagridview, and calculate
         *   the subtotal, tax, and total of the order. 
         */
        private void addTitle_Click(object sender, EventArgs e)
        {
            /*   If no title is selected to the combobox, display error message and
             *   add focus/select to combobox. If the quantity is set to 0, display
             *   error message and add focus/select to quantity textbox.
             *   *For the dropdownlist style, focus is not visible; the dropdownlist 
             *   style was necessary because otherwise the user would be able to type 
             *   into the combobox.  
             */
            if (bookComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please add a book to your order.");
                bookComboBox.Select();
            }

            else if (quantityText.Text == "0")
            {
                MessageBox.Show("Please select a nonzero quantity.");
                quantityText.Select();
            }

            else
            {
                /*   Calculates the new line total and checks whether any datagridview
                 *   row is empty, or if the title field of a row matches the title 
                 *   selected in the combobox, and acts as shown below. 
                 */
                try
                {

                    string modPrice = priceText.Text.Replace("$", "");
                    double price = Convert.ToDouble(modPrice);
                    int qty = Convert.ToInt32(quantityText.Text);
                    string lineTotalText = Convert.ToString(qty * price);

                    
                    for (int i = 0; i < 3; i++)
                    {
                        /*   For each datagridview row, check if the row is empty; if so, 
                        *   fill with title, price, quantity, and line total fields.   
                        */
                        if (dataGridView1.Rows[i].Cells[0].Value == null)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = bookComboBox.SelectedItem.ToString();
                            dataGridView1.Rows[i].Cells[1].Value = priceText.Text;
                            dataGridView1.Rows[i].Cells[2].Value = quantityText.Text;
                            dataGridView1.Rows[i].Cells[3].Value = "$" + lineTotalText;
                            break;
                        }

                        /*   If a datagridview row has the same title as the one selected in
                         *   combobox, then add their quantities and recalculate the line total.    
                         */
                        else if (bookComboBox.SelectedItem.ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString())
                        {
                            qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString())
                                + Convert.ToInt32(quantityText.Text);
                            lineTotalText = Convert.ToString(qty * price);

                            dataGridView1.Rows[i].Cells[2].Value = qty.ToString();
                            dataGridView1.Rows[i].Cells[3].Value = "$" + lineTotalText;
                            break;
                        }
                    }

                    /*   Calculates the subtotal by adding the line total for each book. 
                     *   If there is an empty row in the datagridview, then exit the loop.  
                     */
                    double subtotalPrice = 0.0;
                    for (int j = 0; j < 3; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[0].Value == null)
                        {
                            break;
                        }
                        string tempPrice = dataGridView1.Rows[j].Cells[3].Value.ToString().Replace("$", "");
                        subtotalPrice += Convert.ToDouble(tempPrice);
                    }

                    /*   Calculates the tax and total of the order and enters them into
                     *   their respective textboxes.    
                     */
                    double tax = subtotalPrice * 0.1;
                    double total = subtotalPrice + tax;

                    subtotalText.Text = subtotalPrice.ToString("0.##");
                    taxText.Text = tax.ToString("0.##");
                    totalText.Text = total.ToString("0.##");
                }

                /*   Display error message for non-numerical input and focus the quantity
                 *   text box.  
                 */
                catch (Exception ae)
                {
                    MessageBox.Show("Please enter a numerical quantity.");
                    quantityText.Focus();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void authorText_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool exitValue { get; set; }

        private void Form1_Closing(object sender, EventArgs e)
        {
            //Once user closes the form, the exit value is defined.
            this.exitValue = true;
        }

        /*   If the order is valid, i.e. a book is successfully added to the 
         *   datagridview, then creates a file with the title(s), quantity, and
         *   total of the order. Otherwise, an error message is shown.  
         */
        private void confirmButton_Click(object sender, EventArgs e)
        {
            /*   Open the database and insert rows pertaining to the relevant information of the order
             *   into the bs_orders and bs_orderdetails tables, then create an orderdetails form that
             *   confirms the order to the user and shows their reciept. Then clear the textboxes.
             */
            if (subtotalText.Text.Length > 1)
            {
                string database = "db_bookstore";
                string table = "bs_orders";
                string connectString = "server = localhost; database = " + database + "; uid = root; password =;";
                MySqlConnection databaseConnect = new MySqlConnection(connectString);
                databaseConnect.Open();

                //Insert new row into bs_orders table with new order details for order.
                string insertString = "INSERT INTO " + table + "(cust_fid, sub_total, tax, total, order_date) VALUES('"
                                + (custComboBox.SelectedIndex+1).ToString() + "', '" + subtotalText.Text + "', '" + taxText.Text 
                                + "', '" + totalText.Text + "', '" + "2020/04/26" + "')";
                MySqlCommand insertCmd = new MySqlCommand(insertString, databaseConnect);
                insertCmd.ExecuteNonQuery();

                string maxIDString = "SELECT MAX(order_pid) FROM " + database + "." + table;
                MySqlCommand maxIDCmd = new MySqlCommand(maxIDString, databaseConnect);
                int maxID = int.Parse(maxIDCmd.ExecuteScalar() + "");

                //Insert new row into bs_orderdetails table with new order details for order.
                table = "bs_orderdetails";
                insertString = "INSERT INTO " + table + "(order_fid, book_fid, quantity, lines_total) VALUES('"
                                + maxID.ToString() + "', '" + (bookComboBox.SelectedIndex - 1).ToString() + "', '" + quantityText.Text
                                + "', '" + "12345" + "')";
                insertCmd = new MySqlCommand(insertString, databaseConnect);
                insertCmd.ExecuteNonQuery();

                databaseConnect.Close();


                //Generates an orderdetails form with the information pertaining to the order.
                orderdetails od = new orderdetails(custComboBox.Text, bookComboBox.Text, authorText.Text, isbnText.Text, 
                    priceText.Text, quantityText.Text, subtotalText.Text, taxText.Text, totalText.Text);
                od.ShowDialog();



                //After order is confirmed, clear textboxes for new order.
                authorText.Clear();
                priceText.Clear();
                quantityText.Clear();
                isbnText.Clear();

                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = 3;

                subtotalText.Clear();
                taxText.Clear();
                totalText.Clear();

                custComboBox.SelectedIndex = -1;
                custComboBox.Enabled = false;

                bookComboBox.SelectedIndex = -1;
                bookComboBox.Enabled = false;

            }

            /*   If no books have been added, displays error message and focuses on the
             *   quantity text box.     
             */
            else
            {
                MessageBox.Show("Please add a book to the order.");
                quantityText.Focus();
            }
            
        }

        //If the user decides to cancel the order, clear the textboxes and comboboxes.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Are you sure you want to cancel your order?", "Cancel Order", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(decision == DialogResult.Yes)
            {
                authorText.Clear();
                priceText.Clear();
                quantityText.Clear();
                isbnText.Clear();

                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = 3;

                subtotalText.Clear();
                taxText.Clear();
                totalText.Clear();

                custComboBox.SelectedIndex = -1;

                bookComboBox.SelectedIndex = -1;
            }
        }

        private void custCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*  Opens the database and selects string from specified row. Modified for different primary ID's.
        */
        private string selectVal(int temp, string val, string table, string id)
        {
            string database = "db_bookstore";
            string connectString = "server = localhost; database = " + database + "; uid = root; password =;";
            MySqlConnection databaseConnect = new MySqlConnection(connectString);
            databaseConnect.Open();

            string select = "SELECT " + val + " FROM " + database + "." + table + " WHERE " + id + " =" + temp.ToString();
            MySqlCommand selectCmd = new MySqlCommand(select, databaseConnect);
            string str = (string)selectCmd.ExecuteScalar();

            databaseConnect.Close();

            return str;
        }
    }
}


/*   Book class: has fields for author, ISBN, price, and title, with appropriate
 *   get/set public methods for each field, and a constructor for instantiating
 *   book objects.    
 */
class Book
{
    private string author, isbn, price, title;

    public Book(string title, string author, string isbn, string price)
    {
        this.author = author;
        this.isbn = isbn;
        this.price = price;
        this.title = title;

        Author = author;
        ISBN = isbn;
        Price = price;
        Title = title;
    }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Price { get; set; }
    public string Title { get; set; }
}