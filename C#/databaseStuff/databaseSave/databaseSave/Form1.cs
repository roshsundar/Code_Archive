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

namespace databaseSave
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection(); // this creates a connection object used to get the data,available only to Form1
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Roshan\Desktop\AllGUIs\databaseStuff\TestPasswd.accdb;Persist Security Info=False;"; // assign the connection a string that contains info for connection
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into passwdTable([Username],[Password]) values('" +userBox.Text + "','" + passBox.Text + "')";
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
    }
}
