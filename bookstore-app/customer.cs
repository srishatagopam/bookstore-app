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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace bookstore_app
{
    public partial class custForm : Form
    {
        //Define arraylist and array to hold Customer objects.
        //The arraylist is used for the file-writing code, and
        //the array is used to check if a Customer exists with
        //the given information in the textboxes.
        ArrayList custList = new ArrayList();
        Customer[] custArr = new Customer[100];
        
        public custForm()
        {
            InitializeComponent();

            /*  Create connection to database. Use select command to recieve the cust_pid of the last row of
             *  the bs_cust table. From 1 to maxID (since it is autoincremented), select the first name, last name,
             *  address, city, state, zip, phone number, and email from each row, and create a new Customer using 
             *  those string values, and put them in the book array, and add them to the cust combobox. Then close 
             *  the database. 
             */
            try
            {
                int count;
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
                    first = selectVal_cust(count, "first_name", table);
                    last = selectVal_cust(count, "last_name", table);
                    address = selectVal_cust(count, "address", table);
                    city = selectVal_cust(count, "city", table);
                    state = selectVal_cust(count, "state", table);
                    zip = selectVal_cust(count, "zip", table);
                    phone = selectVal_cust(count, "phone", table);
                    email = selectVal_cust(count, "email", table);

                    custArr[count - 1] = new Customer(first, last, address, city, state, zip, phone, email);
                    custComboBox.Items.Add(custArr[count - 1].First + " " + custArr[count - 1].Last);
                }
            }
            catch (Exception ae)
            {
                MessageBox.Show("No connection.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstText_TextChanged(object sender, EventArgs e)
        {

        }

        private void custComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (custComboBox.SelectedIndex != -1)
            {
                int temp = custComboBox.SelectedIndex;

                //Loads selected customer information into textboxes.
                firstText.Text = custArr[temp].First;
                lastText.Text = custArr[temp].Last;
                addressText.Text = custArr[temp].Address;
                cityText.Text = custArr[temp].City;
                stateText.Text = custArr[temp].State;
                zipText.Text = custArr[temp].Zip;
                phoneText.Text = custArr[temp].Phone;
                emailText.Text = custArr[temp].Email;
            }
        }

        private void custComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string database = "db_bookstore";
            string table = "bs_customer";
            string connectString = "server = localhost; database = " + database + "; uid = root; password =;";
            MySqlConnection databaseConnect = new MySqlConnection(connectString);
            databaseConnect.Open();

            //Regular expressions for each of the textboxes. Tested using
            //www.regex101.com.

            //Searches for the first character to be an uppercase letter, and the
            //rest to be lowercase with spaces allowed.
            Regex firstRgx = new Regex(@"^[a-zA-Z ]+$");
            Match firstMatch = firstRgx.Match(firstText.Text);

            //Searches for the first character to be an uppercase letter, and the
            //rest to be lowercase.
            Regex lastRgx = new Regex(@"^[a-zA-Z]+$");
            Match lastMatch = lastRgx.Match(lastText.Text);

            //Searches for address that starts with a number, and allows letters and spaces, mandatory at
            //the end of the string.
            Regex addressRgx = new Regex(@"^[[0-9][\w ]+$");
            Match addressMatch = addressRgx.Match(phoneText.Text);

            //Searches for capitalized city name with spaces allowed, mandatory at the end of the string.
            Regex cityRgx = new Regex(@"[A-Z][a-z ]+$");
            Match cityMatch = cityRgx.Match(cityText.Text);

            //Searches for two-letter uppercase state name.
            Regex stateRgx = new Regex(@"^[A-Z]{2}$");
            Match stateMatch = stateRgx.Match(stateText.Text);

            //Searches for digits 0-9 from the begininning and end of input, with the input only allowed
            //to be 5 digits long.
            Regex zipRgx = new Regex(@"^([0-9]{5})$");
            Match zipMatch = zipRgx.Match(zipText.Text);

            //Searches for digits 0-9 from the begininning and end of input, with the input only allowed
            //to be 10 digits long.
            Regex phoneRgx = new Regex(@"^([0-9]{10})$");
            Match phoneMatch = phoneRgx.Match(phoneText.Text);

            //Searches for uppercase/lowercase letters, digits, !@#$%^&*()-+{}|~,.?= symbols, 
            //the '@' symbol, and a list of domains: .com, .net, .edu, and .org.
            Regex emailRgx = new Regex(@"[a-zA-Z0-9!@#$%^&*()-+{}|~,.?=](.com)|(.net)|(.edu)|(.org)[@]");
            Match emailMatch = emailRgx.Match(emailText.Text);

            //Check to see if any fields are empty and display appropriate error message and
            //select focus to appropriate textbox.
            if (firstText.Text  == null ||
               lastText.Text    == null ||
               addressText.Text == null ||
               cityText.Text    == null ||
               stateText.Text   == null ||
               zipText.Text     == null ||
               phoneText.Text   == null ||
               emailText.Text   == null   )
            {
                MessageBox.Show("Please fill all fields.");

                //If only the first name textbox is empty or if all textboxes are empty,
                //focus the first name textbox.
                if (firstText.Text   == null ||
                    (firstText.Text  == null &&
                    lastText.Text    == null &&
                    addressText.Text == null &&
                    cityText.Text    == null &&
                    stateText.Text   == null &&
                    zipText.Text     == null &&
                    phoneText.Text   == null &&
                    emailText.Text   == null))
                {
                    firstText.Select();
                }
                if (lastText.Text == null)
                {
                    lastText.Select();
                }
                if (addressText.Text == null)
                {
                    addressText.Select();
                }
                if (cityText.Text == null)
                {
                    cityText.Select();
                }
                if (stateText.Text == null)
                {
                    stateText.Select();
                }
                if (zipText.Text == null)
                {
                    zipText.Select();
                }
                if (phoneText.Text == null)
                {
                    phoneText.Select();
                }
                if (emailText.Text == null)
                {
                    emailText.Select();
                }
            }

            //Check if there are any non-matches and display the error message and focus.
            else if (!firstMatch.Success  ||
                    !lastMatch.Success    ||
                    !addressMatch.Success ||
                    !cityMatch.Success    ||
                    !stateMatch.Success   ||
                    !zipMatch.Success     ||
                    !phoneMatch.Success   ||
                    !emailMatch.Success)
            {
                if (!firstMatch.Success)
                {
                    MessageBox.Show("Please enter a proper capitalized first name.");
                    firstText.Select();
                }


                if (!lastMatch.Success)
                {
                    MessageBox.Show("Please enter a proper capitalized last name.");
                    lastText.Select();
                }


                if (!addressMatch.Success)
                {
                    MessageBox.Show("Please enter a proper address.");
                    addressText.Select();
                }


                if (!cityMatch.Success)
                {
                    MessageBox.Show("Please enter a proper city name.");
                    cityText.Select();
                }


                if (!stateMatch.Success)
                {
                    MessageBox.Show("Please enter a correct state.");
                    stateText.Select();
                }


                if (!zipMatch.Success)
                {
                    MessageBox.Show("Please enter a proper zip code.");
                    zipText.Select();
                }


                if (!phoneMatch.Success)
                {
                    MessageBox.Show("Please enter a proper phone number.");
                    phoneText.Select();
                }


                if (!emailMatch.Success)
                {
                    MessageBox.Show("Please enter a proper email.");
                    emailText.Select();
                }
            }

            
            else
            {
                //Check that both the customer name doesn't exist in the combobox AND that no customer is 
                //selected in the combobox, meaning we are creating a new customer. Add the new customer
                //to the combobox, and then find the next empty index in the customer array and fill it
                //with a new Customer object with all of the input valuues. Then, add the customer to
                //the customer arraylist.
                if (custComboBox.FindString(firstText.Text + " " + lastText.Text) == -1
                && custComboBox.SelectedIndex == -1)
                {
                    DialogResult decision = MessageBox.Show("You are adding a new customer.\nDo you still want to save?", "New Customer",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (decision == DialogResult.No)
                    {
                        databaseConnect.Close();
                    }
                    else
                    {
                        custComboBox.Items.Add(firstText.Text + " " + lastText.Text);
                        int count = 0;
                        while (custArr[count] != null) { count++; }
                        custArr[count] = new Customer(firstText.Text, lastText.Text, addressText.Text, cityText.Text,
                                                  stateText.Text, zipText.Text, phoneText.Text, emailText.Text);
                        custList.Add(custArr[count]);

                        string insertString = "INSERT INTO " + table + "(first_name, last_name, address, city, state, zip, phone, email) VALUES('"
                                + firstText.Text + "', '" + lastText.Text + "', '" + addressText.Text + "', '" + cityText.Text + "', '" + stateText.Text
                                + "', '" + zipText.Text + "', '" + phoneText.Text + "', '" + emailText.Text + "')";

                        MySqlCommand insertCmd = new MySqlCommand(insertString, databaseConnect);
                        insertCmd.ExecuteNonQuery();


                        /*  Get the values for the last row in the table and compare with the textbox values. If
                         *  they're the same, then the new customer has been saved and a success messagebox appears.
                         */

                        string maxIDString = "SELECT MAX(cust_pid) FROM " + database + "." + table;
                        MySqlCommand maxIDCmd = new MySqlCommand(maxIDString, databaseConnect);
                        int temp = int.Parse(maxIDCmd.ExecuteScalar() + "");

                        databaseConnect.Close();


                        string first, last, address, city, state, zip, phone, email;

                        first = selectVal_cust(temp, "first_name", table);
                        last = selectVal_cust(temp, "last_name", table);
                        address = selectVal_cust(temp, "address", table);
                        city = selectVal_cust(temp, "city", table);
                        state = selectVal_cust(temp, "state", table);
                        zip = selectVal_cust(temp, "zip", table);
                        phone = selectVal_cust(temp, "phone", table);
                        email = selectVal_cust(temp, "email", table);


                        databaseConnect.Close();


                        if (first == firstText.Text &&
                            last == lastText.Text &&
                            address == addressText.Text &&
                            city == cityText.Text &&
                            state == stateText.Text &&
                            zip == zipText.Text &&
                            phone == phoneText.Text &&
                            email == emailText.Text 
                            )
                        {
                            MessageBox.Show("New customer saved!");

                        }
                    }
                }

                //Otherwise, this means that the customer already exists and is being edited. The index of the 
                //combobox is the index of the customer array (since they are being added sequentially). Edit
                //the existing customer.
                else
                {
                    DialogResult decision = MessageBox.Show("You are editing a customer that already exists.\nDo you still want to save?", "Editing Customer",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (decision == DialogResult.No)
                    {
                        databaseConnect.Close();
                    }
                    else
                    {
                        int temp = custComboBox.SelectedIndex;

                        //Store temp variables for textboxes for the same reason as in the book form.
                        string firstTemp = firstText.Text;
                        string lastTemp = lastText.Text;
                        string addressTemp = addressText.Text;
                        string cityTemp = cityText.Text;
                        string stateTemp = stateText.Text;
                        string zipTemp = zipText.Text;
                        string phoneTemp = phoneText.Text;
                        string emailTemp = emailText.Text;

                        //If the customer exists but didn't select it form the combobox, then show error and focus.
                        if (temp == -1)
                        {
                            MessageBox.Show("Error: Customer already exists and you did not select them.");
                            custComboBox.Focus();
                        }
                        else
                        {
                            //Execute update command to edit an existing customer with the information written into the textboxes.
                            string updateString = "UPDATE " + table + " SET first_name ='" + firstText.Text + "', last_name = '" + lastText.Text
                                    + "', address = '" + addressText.Text + "', city = '" + cityText.Text + "' WHERE cust_pid = " + (temp + 1).ToString();
                            MySqlCommand updateCmd = new MySqlCommand(updateString, databaseConnect);
                            updateCmd.ExecuteNonQuery();

                            databaseConnect.Close();

                            //Compare the customer's values in the database with the textbox values; if they're the same, then
                            //display a success message.
                            string first, last, address, city, state, zip, phone, email;

                            first = selectVal_cust(temp+1, "first_name", table);
                            last = selectVal_cust(temp+1, "last_name", table);
                            address = selectVal_cust(temp+1, "address", table);
                            city = selectVal_cust(temp+1, "city", table);
                            state = selectVal_cust(temp+1, "state", table);
                            zip = selectVal_cust(temp+1, "zip", table);
                            phone = selectVal_cust(temp+1, "phone", table);
                            email = selectVal_cust(temp+1, "email", table);


                            //In case the customer's name was edited.
                            custComboBox.Items[temp] = firstText.Text + " " + lastText.Text;

                            //Load temp variables to textboxes.
                            firstText.Text = firstTemp;
                            lastText.Text = lastTemp;
                            addressText.Text = addressTemp;
                            cityText.Text = cityTemp;
                            stateText.Text = stateTemp;
                            zipText.Text = zipTemp;
                            phoneText.Text = phoneTemp;
                            emailText.Text = emailTemp;

                            //Update the customer array (this will be updated if you restart the form, 
                            //but needs to be done if you are creating/editing multiple customers in the same instance).
                            custArr[temp].First = firstText.Text;
                            custArr[temp].Last = lastText.Text;
                            custArr[temp].Address = addressText.Text;
                            custArr[temp].City = cityText.Text;
                            custArr[temp].State = stateText.Text;
                            custArr[temp].Zip = zipText.Text;
                            custArr[temp].Phone = phoneText.Text;
                            custArr[temp].Email = emailText.Text;

                            if (first == firstText.Text &&
                             last == lastText.Text &&
                             address == addressText.Text &&
                             city == cityText.Text &&
                             state == stateText.Text &&
                             zip == zipText.Text &&
                             phone == phoneText.Text &&
                             email == emailText.Text
                             )
                            {
                                MessageBox.Show("Customer edited!");
                            }
                        }
                    }
                }
                //Clear the textboxes.
                firstText.Clear();
                lastText.Clear();
                addressText.Clear();
                cityText.Clear();
                stateText.Clear();
                zipText.Clear();
                phoneText.Clear();
                emailText.Clear();
            }
        }

        
        //Creating a new customer will clear all textboxes, clear & lock the combobox, and focus on the first name.
        public void newCustButton_Click(object sender, EventArgs e)
        {
            firstText.Clear();
            lastText.Clear();
            addressText.Clear();
            cityText.Clear();
            stateText.Clear();
            zipText.Clear();
            phoneText.Clear();
            emailText.Clear();

            custComboBox.SelectedIndex = -1;
            custComboBox.Enabled = false;
            firstText.Select();
        }


        private void custForm_Load(object sender, EventArgs e)
        {

        }


        //If the user decides to back out, close the form and go back to menu.
        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Are you sure you want to go back?", "Go back",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes) { this.Close(); }

        }

        private void custForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void custForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        //If the user decides to cancel saving a customer, the textboxes clear and the combobox is locked,
        //with the focus put on the first name textbox.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Are you sure you want to cancel?", "Cancel?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes) 
            {
                firstText.Clear();
                lastText.Clear();
                addressText.Clear();
                cityText.Clear();
                stateText.Clear();
                zipText.Clear();
                phoneText.Clear();
                emailText.Clear();

                custComboBox.SelectedIndex = -1;
                firstText.Select();

            }
        }

        /*  Opens the database and selects string from specified row.
        */
        private string selectVal_cust(int temp, string val, string table)
        {
            string database = "db_bookstore";
            string connectString = "server = localhost; database = " + database + "; uid = root; password =;";
            MySqlConnection databaseConnect = new MySqlConnection(connectString);
            databaseConnect.Open();

            string select = "SELECT " + val + " FROM " + database + "." + table + " WHERE cust_pid =" + temp.ToString();
            MySqlCommand selectCmd = new MySqlCommand(select, databaseConnect);
            string str = (string)selectCmd.ExecuteScalar();

            databaseConnect.Close();

            return str;
        }
    }
}

//Customer class: a modified version of the book class from Lab 1 with appropriate
//get and set functions for each of the string values.
class Customer
{
    private string first, last, address, city, state, zip, phone, email;

    public Customer(string first, string last, string address, string city,
                    string state, string zip, string phone, string email)
    {
        this.first = first;
        this.last = last;
        this.address = address;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.phone = phone;
        this.email = email;

        First = first;
        Last = last;
        Address = address;
        City = city;
        State = state;
        Zip = zip;
        Phone = phone;
        Email = email;
    }
    public string First { get; set; }
    public string Last { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
