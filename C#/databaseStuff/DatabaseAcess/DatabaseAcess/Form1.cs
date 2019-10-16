using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DatabaseAcess
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection(); // this creates a connection object used to get the data,available only to Form1
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Roshan\Desktop\AllGUIs\databaseStuff\TestPasswd.accdb;Persist Security Info=False;"; // assign the connection a string that contains info for connection
        }

        private void Form1_Load(object sender, EventArgs e) // this is triggered when the app loads to check the connection
        {
            try
            {
                connection.Open();
                connectionStatus.Text = "Succesful Connection";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: "+ ex);
            }
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string DB_Username = "";
            string DB_Password = "";

            connection.Open();
            OleDbCommand command = new OleDbCommand(); // create a command object to make a sql query
            command.Connection = connection; // assign the command to a connection
            command.CommandText = "SELECT Username, Password FROM passwdTable WHERE Username='" + userBox.Text + "' AND Password='" + passBox.Text + "'";
            OleDbDataReader reader = command.ExecuteReader(); // create a reader object&attach it to command, use it to read values
            while (reader.Read())
            {
                DB_Username = reader["Username"].ToString(); // give reader the parameter for the columns that need searching
                DB_Password= reader["Password"].ToString();
               
            }

            if (DB_Username == "" && DB_Password == "")
            {
                MessageBox.Show("Acess Denied", "Password Invalid");
            }
            else
            {
                MessageBox.Show("Acess Granted", "Password Valid");
            }
            
            connection.Close();
        }
    }
}
