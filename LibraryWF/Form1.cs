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
            try
            {
                string _SqlExpression = "USE [Library] SELECT * FROM [BookCard]";
                SqlCommand command = new SqlCommand(_SqlExpression, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object _id = reader.GetValue(0);
                    object _placeNumber = reader.GetValue(1);
                    object _author = reader.GetValue(2);
                    object _title = reader.GetValue(3);
                    comboBoxBooks.Items.Add($"\"{_title}\"    {_author}    №{_placeNumber}");
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось подключится к базе данных!");
            }
        }

        private void textBoxAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '' | e.KeyChar == '-' | e.KeyChar == ' ')
            {
                return;
            }
            else
            {
                MessageBox.Show("В имени не может быть чисел и символов!");
                e.Handled = true;
            }
        }

        private void textBoxPlaceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '')
            {
                return;
            }
            else
            {
                MessageBox.Show("Только числовой ввод!");
                e.Handled = true;
            }
        }

        private void comboBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show($"Вы уверны, что хотите удалить это произведение:\n\n{comboBoxBooks.Text}", "",  MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Regex regex = new Regex("[№][0-9]+");
                MatchCollection matches = regex.Matches(comboBoxBooks.Text);
                string _tmp = matches[0].Value.Remove(0, 1);
                int _num = Convert.ToInt32(_tmp);
                connection.Open();
                string _SqlExpression = $"USE [Library] DELETE  FROM BookCard WHERE PlaceNumber={_num}";
                SqlCommand command = new SqlCommand(_SqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();
                Application.Restart();
            }

        }

        private void buttonAddToLibrary_Click(object sender, EventArgs e)
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
    }
}
