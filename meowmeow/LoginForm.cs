using meow11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zalupka3d
{
    public partial class LoginForm : Form
    {
        private SqlConnection connection;
        
        public LoginForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=adclg1;Initial Catalog=Praktika_filimonov;Integrated Security=True;Encrypt=False");
            connection.Open();
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.FlatAppearance.BorderSize = 0;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public void buttonLogin_Click(object sender, EventArgs e)
        {
            // Код для авторизации
            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", textBoxLogin.Text);
            command.Parameters.AddWithValue("@Password", textBoxPassword.Text);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Авторизация успешна
                MessageBox.Show("Авторизация успешна");

                string Role = reader["Role"].ToString();
                MessageBox.Show("Добро пожаловать, " + Role);

                Form1 form1 = new Form1(Role);
                form1.Show();
                this.Hide();

            }
            else
            {
                // Авторизация неуспешна
                throw new Exception("Неправильный логин или пароль");
            }
        }
        public string LoginText
        {
            get { return textBoxLogin.Text; }
            set { textBoxLogin.Text = value; }
        }

        public string PasswordText
        {
            get { return textBoxPassword.Text; }
            set { textBoxPassword.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonLogin_Click(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
    }

