using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace remindMe
{
    public partial class addForm : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;UID=roshan;PWD=roshan;Database=roshan;";

        public addForm()
        {
            InitializeComponent();
        }

        private void addRem_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand();

            string remSubj = subjectEntry.Text;
            string remBody = remEntry.Text;
            string dateOfRem = datePicker.Value.Date.ToString("yyyy-MM-dd");
            string timeOfRem = timePicker.Value.ToString("HH:mm:ss");
            try
            {
                connection.Open();
               
                command.Connection = connection;
                command.CommandText = "INSERT INTO remindertable ( eventDate, eventTime, reminderBody, reminderSubject ) VALUES ('"+dateOfRem+"', '"+timeOfRem+"', '"+remBody+"', '"+remSubj+"');";
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
