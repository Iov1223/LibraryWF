using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryWF
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string _SqlExpression = "USE [Library] SELECT * FROM [BookCard]";
            SqlCommand command = new SqlCommand(_SqlExpression, connection);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                object id = reader.GetValue(0);
                object name = reader.GetValue(1);
                object age = reader.GetValue(2);
                object rt = reader.GetValue(3);
                comboBoxBooks.Items.Add($"{id}) [№{name}] {age} \"{rt}\"");
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string _SqlExpression = $"USE [Library] INSERT INTO [BookCard] ([PlaceNumber], [Author], [Title]) VALUES ({textBoxPlaceNumber.Text}, N'{textBoxAuthor.Text}', N'{textBoxTitle.Text}')";
                SqlCommand command = new SqlCommand(_SqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();
                Application.Restart();
            }
            catch 
            {
                MessageBox.Show("Есть пустые поля.");
                Application.Restart();
            }

        }

        private void textBoxAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '' | e.KeyChar == '-' | e.KeyChar == ' ')
            {
                return;
            }

            e.Handled = true;
        }

        private void textBoxPlaceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '')
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод только для чисел!");
                e.Handled = true;
            }
        }

        private void comboBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]+[)]");
            MatchCollection matches = regex.Matches(comboBoxBooks.Text);
            string _tmp = matches[0].Value.Remove(matches[0].Value.IndexOf(')'));
            MessageBox.Show(_tmp);
            int _id = Convert.ToInt32(_tmp);
            connection.Open();
            string _SqlExpression = $"USE [Library] DELETE  FROM BookCard WHERE Id={_id}";
            SqlCommand command = new SqlCommand(_SqlExpression, connection);
            command.ExecuteNonQuery();
            connection.Close();
            Application.Restart();

        }
    }
}
