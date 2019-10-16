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
    public partial class mainForm : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;UID=roshan;PWD=roshan;Database=roshan;";

        /* -----------FUNCTIONS---------- */
        public void getRemFromDat()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand();

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT reminderSubject, DATE_FORMAT(eventDate, '%m/%d/%Y') AS eventDate, eventTime FROM remindertable WHERE (eventDate >='"+ DateTime.Now.ToString("yyyy/MM/dd")+"') ORDER BY eventDate, eventTime;";
                MySqlDataReader reader = command.ExecuteReader();

                List<string> displayList = new List<string>();
                while (reader.Read())
                {
                    string subj = reader["reminderSubject"].ToString();
                    string date = reader["eventDate"].ToString();
                    string time = reader["eventTime"].ToString();
                    DateTime j = new DateTime();
                    j = DateTime.Parse(time);
                    time = j.ToString("hh:mm:ss tt");
                    string x = subj + " | " + date + " | " + time;

                    displayList.Add(x);
                }
                remListbox.DataSource = displayList;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex);
            }
        }
        /* -----------END FUNCTIONS---------- */

        public mainForm()
        {
            InitializeComponent();
        }

        /* Triggered when the form loads, retreives reminders from database*/
        private void mainForm_Load(object sender, EventArgs e)
        { 
            getRemFromDat();
        }

        /* invokes another form that adds a new reminder*/
        private void launchAdd_btn_Click(object sender, EventArgs e)
        {
            addForm nwAddform = new addForm();
            nwAddform.Show();
        }

        /* Refresh The listbox if there has been some adding, deleting, or editing */
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            getRemFromDat();
        }

        /* Display the selected Reminder Text*/
        private void launchOpen_btn_Click(object sender, EventArgs e)
        {
            string reminderBody = "";
            string text = remListbox.GetItemText(remListbox.SelectedItem); // get listbox selection
            string[] words = text.Split(new string[] { " | " }, StringSplitOptions.None); // get diiferent strings thprugh parsing for getting reminder text
            string reminderSubj = words[0];
            string eventDate = words[1];
            string eventTime = words[2];

            DateTime a = new DateTime(); // create datetime objects to format our dates and times into mysql format
            DateTime b = new DateTime();

            a = DateTime.Parse(eventDate);
            b = DateTime.Parse(eventTime);

            eventDate = a.ToString("yyyy-MM-dd");
            eventTime = b.ToString("HH:mm:ss");

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand();

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT reminderBody from reminderTable WHERE ((reminderSubject='" + reminderSubj + "' AND eventDate='" + eventDate + "') AND eventTime='" + eventTime + "');";
                MySqlDataReader reader = command.ExecuteReader();

               
                while (reader.Read())
                {
                    reminderBody = reader["reminderBody"].ToString(); // get the reminder text result
                }
                MessageBox.Show(reminderBody); // display the reminder text result for the user
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex);
            }
        }

        /* Searches the listbox live with whatever the user entered*/
        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBar.Text;
            bool found = false;

            for (int i = 0; i <= remListbox.Items.Count - 1; i++)
            {
                if (remListbox.Items[i].ToString().Contains(searchText))
                {
                    remListbox.SetSelected(i, true);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Item Not Found!");
            }
        }

        private void editRem_btn_Click(object sender, EventArgs e)
        {
            editForm nweditform = new editForm(remListbox.GetItemText(remListbox.SelectedItem));
            nweditform.Show();
        }

        private void delRem_btn_Click(object sender, EventArgs e)
        {
            string text = remListbox.GetItemText(remListbox.SelectedItem); // get listbox selection
            string[] words = text.Split(new string[] { " | " }, StringSplitOptions.None); // get diiferent strings thprugh parsing for getting reminder text
            string reminderSubj = words[0];
            string eventDate = words[1];
            string eventTime = words[2];
            string sqleventDate = DateTime.Parse(eventDate).ToString("yyyy-MM-dd");
            string sqleventTime = DateTime.Parse(eventTime).ToString("HH:mm:ss");

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand();

                connection.Open();

                command.Connection = connection;
                command.CommandText = "DELETE from reminderTable WHERE ((reminderSubject='" + reminderSubj + "' AND eventDate='" + sqleventDate + "') AND eventTime='" + sqleventTime + "');";
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Please Refresh your Reminders");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex);
            }
        }
    }
}
