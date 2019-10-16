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
    public partial class editForm : Form
    {
        string[] words;
        int dbid;
        string connectionString = "Server=127.0.0.1;Port=3306;UID=roshan;PWD=roshan;Database=roshan;";

        public editForm(string x)
        {
            InitializeComponent();
            words = x.Split(new string[] { " | " }, StringSplitOptions.None);

        }

        private void editForm_Load(object sender, EventArgs e)
        {
            string reminderBody = "";
            string reminderSubj = words[0];
            string eventDate = words[1];
            string eventTime = words[2];
            string sqleventDate;
            string sqleventTime;

            DateTime a = new DateTime(); // create datetime objects to format our dates and times into mysql format
            DateTime b = new DateTime();

            a = DateTime.Parse(eventDate);
            b = DateTime.Parse(eventTime);

            sqleventDate = a.ToString("yyyy-MM-dd");
            sqleventTime = b.ToString("HH:mm:ss");

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand();

                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ID,reminderBody from reminderTable WHERE ((reminderSubject='" + reminderSubj + "' AND eventDate='" + sqleventDate + "') AND eventTime='" + sqleventTime + "');";
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    reminderBody = reader["reminderBody"].ToString(); // get the reminder text result
                    dbid = Convert.ToInt32(reader["ID"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex);
            }

            // set all the widgets to the retrieved info
            subjectEntry.Text = reminderSubj;
            remEntry.Text = reminderBody;

            
           
            DateTime dt = Convert.ToDateTime(eventDate);
            DateTime mydt = Convert.ToDateTime(eventTime);
            datePicker.Value = new DateTime(dt.Year, dt.Month, dt.Day);
            timePicker.Value = new DateTime(dt.Year, dt.Month, dt.Day, mydt.Hour, mydt.Minute, mydt.Second);
            

        }

        private void saveRem_btn_Click(object sender, EventArgs e)
        {
            string subj = subjectEntry.Text;
            string body = remEntry.Text;
            string sqleventDate = datePicker.Value.ToString("yyyy-MM-dd");
            string sqleventTime = timePicker.Value.ToString("HH:mm:ss");

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand();

            try
            {
                connection.Open();

                command.Connection = connection;
                command.CommandText = "UPDATE reminderTable set reminderSubject='" + subj + "', reminderBody='" + body + "', eventDate='" + sqleventDate + "', eventTime='" + sqleventTime + "' WHERE ID=" + dbid + ";";
                command.ExecuteNonQuery();
 
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
            Close();
        }
    }
}
