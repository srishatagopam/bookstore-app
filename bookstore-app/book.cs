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
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace compe561_project1
{
    public partial class book : Form
    {
        ArrayList bookList = new ArrayList();
        Book[] bookArr = new Book[100];
        public book()
        {
            InitializeComponent();

            try
            {
                int count;
                string title, author, isbn, price;

                /*  Create connection to database. Use select command to recieve the book_pid of the last row of
                 *  the bs_books table. From 1 to maxID (since it is autoincremented), select the title, author,
                 *  isbn, and price from each row, and create a new Book using those string values, and put them
                 *  in the book array, and add them to the book combobox. Then close the database. 
                 */
                string database = "db_bookstore";
                string table = "bs_books";
                string connectString = "server = localhost; database = " + database + "; uid = root; password =;";
                MySqlConnection databaseConnect = new MySqlConnection(connectString);
                databaseConnect.Open();

                string maxIDString = "SELECT MAX(book_pid) FROM " + database + "." + table;
                MySqlCommand maxIDCmd = new MySqlCommand(maxIDString, databaseConnect);
                int maxID = int.Parse(maxIDCmd.ExecuteScalar() + "");

                databaseConnect.Close();


                for (count = 1; count <= maxID; count++)
                {
                    title = selectVal_book(count, "title", table);
                    author = selectVal_book(count, "author", table);
                    isbn = selectVal_book(count, "isbn", table);
                    price = selectVal_book(count, "price", table);

                    bookArr[count - 1] = new Book(title, author, isbn, price);
                    bookComboBox.Items.Add(bookArr[count - 1].Title);
                }
            }
            catch(Exception ae)
            {
                MessageBox.Show("No connection.");
            }
        }

        private void book_Load(object sender, EventArgs e)
        {

        }

        /*  Create dialog button to go back and close the current form.
         */
        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Are you sure you want to go back?", "Go back",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)  { this.Close(); }
        }

        /*  Clear textboxes and combobox, lock combobox, and focus on title textbox.
         */
        private void newButton_Click(object sender, EventArgs e)
        {
            titleText.Clear();
            authorText.Clear();
            isbnText.Clear();
            priceText.Clear();

            bookComboBox.SelectedIndex = -1;
            bookComboBox.Enabled = false;
            titleText.Select();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string database = "db_bookstore";
                string table = "bs_books";
                string connectString = "server = localhost; database = " + database + "; uid = root; password =;";
                MySqlConnection databaseConnect = new MySqlConnection(connectString);
                databaseConnect.Open();

                //Regular expressions for each of the textboxes. Tested using
                //www.regex101.com.

                //Allows for any reasonable text to be in the title.
                Regex titleRgx = new Regex(@"^[a-zA-Z0-9!?,.:;#$%() ]+$");
                Match titleMatch = titleRgx.Match(titleText.Text);

                //Allows lowercase and uppercase letters, as well as spaces and periods.
                Regex authorRgx = new Regex(@"[a-zA-Z. ]+$");
                Match authorMatch = authorRgx.Match(authorText.Text);

                //Only takes numbers as input.
                Regex isbnRgx = new Regex(@"^[[0-9]+$");
                Match isbnMatch = isbnRgx.Match(isbnText.Text);

                //Only takes prices as input.
                Regex priceRgx = new Regex(@"[0-9.]+$");
                Match priceMatch = priceRgx.Match(priceText.Text);


                //Check to see if any fields are empty and display appropriate error message and
                //select focus to appropriate textbox.
                if (titleText.Text == null ||
                   authorText.Text == null ||
                   isbnText.Text == null ||
                   priceText.Text == null)
                {
                    MessageBox.Show("Please fill all fields.");

                    //If only the first name textbox is empty or if all textboxes are empty,
                    //focus the first name textbox.
                    if (titleText.Text == null ||
                        (titleText.Text == null &&
                        authorText.Text == null &&
                        isbnText.Text == null &&
                        priceText.Text == null)
                        )
                    {
                        titleText.Select();
                    }
                    if (authorText.Text == null)
                    {
                        authorText.Select();
                    }
                    if (isbnText.Text == null)
                    {
                        isbnText.Select();
                    }
                    if (priceText.Text == null)
                    {
                        priceText.Select();
                    }
                }

                //Check if there are any non-matches and display the error message and focus.
                else if (!titleMatch.Success ||
                        !authorMatch.Success ||
                        !isbnMatch.Success ||
                        !priceMatch.Success)
                {
                    if (!titleMatch.Success)
                    {
                        MessageBox.Show("Please enter a proper title.");
                        titleText.Select();
                    }


                    if (!authorMatch.Success)
                    {
                        MessageBox.Show("Please enter a proper name.");
                        authorText.Select();
                    }


                    if (!isbnMatch.Success)
                    {
                        MessageBox.Show("Please enter a proper ISBN.");
                        isbnText.Select();
                    }


                    if (!priceMatch.Success)
                    {
                        MessageBox.Show("Please enter a proper price.");
                        priceText.Select();
                    }
                }


                else
                {
                    //Check that both the book name doesn't exist in the combobox AND that no book is 
                    //selected in the combobox, meaning we are creating a new book. Add the new book
                    //to the combobox, and then find the next empty index in the customer array and fill it
                    //with a new Customer object with all of the input values. 
                    if (bookComboBox.FindString(titleText.Text) == -1
                    && bookComboBox.SelectedIndex == -1)
                    {
                        DialogResult decision = MessageBox.Show("You are adding a new book.\nDo you still want to save?", "New Book",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (decision == DialogResult.No) 
                        {
                            databaseConnect.Close();
                        }
                        else
                        {
                            bookComboBox.Items.Add(titleText.Text);
                            int count = 0;
                            while (bookArr[count] != null) { count++; }
                            bookArr[count] = new Book(titleText.Text, authorText.Text, isbnText.Text, priceText.Text);


                            /*  Create an insert command with no field for book_pid since it is created automatically;
                             *  insert values of textboxes to create a new book row and execute the command.
                             */
                            string insertString = "INSERT INTO " + table + "(`title`, `author`, `isbn`, `price`) VALUES('"
                                + titleText.Text + "', '" + authorText.Text + "', '" + isbnText.Text + "', '" + priceText.Text + "')";

                            MySqlCommand insertCmd = new MySqlCommand(insertString, databaseConnect);
                            insertCmd.ExecuteNonQuery();


                            /*  Get updated values from database and compare with textbox values to ensure they are correct.
                             *  Show a message to confirm the new book is saved.
                             */
                            string maxIDString = "SELECT MAX(book_pid) FROM " + database + "." + table;
                            MySqlCommand maxIDCmd = new MySqlCommand(maxIDString, databaseConnect);
                            int temp = int.Parse(maxIDCmd.ExecuteScalar() + "");


                            databaseConnect.Close();

                            string title = selectVal_book(temp, "title", table);
                            string author = selectVal_book(temp, "author", table);
                            string isbn = selectVal_book(temp, "isbn", table);
                            string price = selectVal_book(temp, "price", table);


                            if (title == titleText.Text &&
                                author == authorText.Text &&
                                isbn == isbnText.Text &&
                                price == priceText.Text
                                )
                            {
                                MessageBox.Show("New book saved!");
                            }
                        }
                    }

                    //Otherwise, this means that the book already exists and is being edited. The index of the 
                    //combobox is the index of the book array (since they are being added sequentially). Edit
                    //the existing book.
                    else
                    {
                        DialogResult decision = MessageBox.Show("You are editing a book that already exists.\nDo you still want to save?", "Editing Book",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (decision == DialogResult.No)
                        {
                            databaseConnect.Close();
                        }
                        else
                        {
                            int temp = bookComboBox.SelectedIndex;

                            /*  Create temp strings for the textboxes so that when checking the textbox values against
                             *  the database values, they aren't changed by the book array.
                             */
                            string titleTemp = titleText.Text;
                            string authorTemp = authorText.Text;
                            string isbnTemp = isbnText.Text;
                            string priceTemp = priceText.Text;

                            //If the book exists but didn't select it form the combobox, then show error and focus.
                            if (temp == -1)
                            {
                                MessageBox.Show("Error: Book already exists and you did not select them.");
                                bookComboBox.Focus();
                            }
                            else
                            {
                                string updateString = "UPDATE " + table + " SET title ='" + titleText.Text + "', author = '" + authorText.Text
                                    + "', isbn = '" + isbnText.Text + "', price = '" + priceText.Text + "' WHERE book_pid = " + (temp + 1).ToString();
                                MySqlCommand updateCmd = new MySqlCommand(updateString, databaseConnect);
                                updateCmd.ExecuteNonQuery();

                                databaseConnect.Close();

                                /*  Get values from database and compare with textbox values. If they are the same,
                                 *  then show success message.
                                 */
                                string title = selectVal_book(temp + 1, "title", table);
                                string author = selectVal_book(temp + 1, "author", table);
                                string isbn = selectVal_book(temp + 1, "isbn", table);
                                string price = selectVal_book(temp + 1, "price", table);

                                //In case the book's name was edited.
                                bookComboBox.Items[temp] = titleText.Text;

                                //Load temp variables to textboxes.
                                titleText.Text = titleTemp;
                                authorText.Text = authorTemp;
                                isbnText.Text = isbnTemp;
                                priceText.Text = priceTemp;

                                //Update the book array (this will be updated if you restart the form, 
                                //but needs to be done if you are creating/editing multiple customers in the same instance).
                                bookArr[temp].Title = titleText.Text;
                                bookArr[temp].Author = authorText.Text;
                                bookArr[temp].ISBN = isbnText.Text;
                                bookArr[temp].Price = priceText.Text;


                                if (title == titleText.Text   &&
                                    author == authorText.Text &&
                                    isbn == isbnText.Text     &&
                                    price == priceText.Text
                                    )
                                {
                                    MessageBox.Show("Book edited!");
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception ea)
            {
                MessageBox.Show("No connection.");
            }
        }

        //If the user decides to cancel saving a book, the texboxes and combobox is cleared and
        //the focus is put oon the title textbox.
        private void cancelButton_Click(object sender, EventArgs e)
        {

            DialogResult decision = MessageBox.Show("Are you sure you want to cancel?", "Cancel?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes) 
            {

                titleText.Clear();
                authorText.Clear();
                isbnText.Clear();
                priceText.Clear();

                bookComboBox.SelectedIndex = -1;
                titleText.Select();
            }
        }

        private void bookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bookComboBox.SelectedIndex != -1)
            {
                int temp = bookComboBox.SelectedIndex;

                //Loads selected book information into textboxes.
                titleText.Text = bookArr[temp].Title;
                authorText.Text = bookArr[temp].Author;
                isbnText.Text = bookArr[temp].ISBN;
                priceText.Text = bookArr[temp].Price;
            }
        }

        /*  Opens the database and selects string from specified row.
         */
        private string selectVal_book(int temp, string val, string table)
        {
            string database = "db_bookstore";
            string connectString = "server = localhost; database = " + database + "; uid = root; password =;";
            MySqlConnection databaseConnect = new MySqlConnection(connectString);
            databaseConnect.Open();

            string select = "SELECT " + val + " FROM " + database + "." + table + " WHERE book_pid =" + temp.ToString();
            MySqlCommand selectCmd = new MySqlCommand(select, databaseConnect);
            string str = (string)selectCmd.ExecuteScalar();

            databaseConnect.Close();

            return str;
        }
    }
}


