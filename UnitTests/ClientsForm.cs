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
using System.Windows.Forms.VisualStyles;
using System.Net.NetworkInformation;

namespace meow11
{
    public partial class ClientsForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;
        private string Role;
        public ClientsForm(string Role)
        {
            InitializeComponent();
            this.Role = Role;
            connection = new SqlConnection("Data Source=adclg1;Initial Catalog=Praktika_filimonov;Integrated Security=True;Encrypt=False");
            connection.Open();

            adapter = new SqlDataAdapter("SELECT * FROM Clients", connection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridViewClients.DataSource = table;

            // Заполнить comboBox для поиска по клиенту
            SqlDataAdapter adapterSearchClientsFirstName = new SqlDataAdapter("SELECT ClientID, FirstName FROM Clients", connection);
            DataTable tableSearchClientsFirstName = new DataTable();
            adapterSearchClientsFirstName.Fill(tableSearchClientsFirstName);
            comboBoxSearchFirstName.DataSource = tableSearchClientsFirstName;
            comboBoxSearchFirstName.DisplayMember = "FirstName";
            comboBoxSearchFirstName.ValueMember = "ClientID";

            SqlDataAdapter adapterSearchClientsLastName = new SqlDataAdapter("SELECT ClientID, LastName FROM Clients", connection);
            DataTable tableSearchClientsLastName = new DataTable();
            adapterSearchClientsLastName.Fill(tableSearchClientsLastName);
            comboBoxSearchLastName.DataSource = tableSearchClientsLastName;
            comboBoxSearchLastName.DisplayMember = "LastName";
            comboBoxSearchLastName.ValueMember = "ClientID";

            SqlDataAdapter adapterSearchClientsPhoneNumber = new SqlDataAdapter("SELECT ClientID, PhoneNumber FROM Clients", connection);
            DataTable tableSearchClientsPhoneNumber = new DataTable();
            adapterSearchClientsPhoneNumber.Fill(tableSearchClientsPhoneNumber);
            comboBoxSearchPhoneNumber.DataSource = tableSearchClientsPhoneNumber;
            comboBoxSearchPhoneNumber.DisplayMember = "PhoneNumber";
            comboBoxSearchPhoneNumber.ValueMember = "ClientID";

           
            buttonDeleteOperation.FlatStyle = FlatStyle.Flat;
            buttonAddOperation.FlatStyle = FlatStyle.Flat;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditOperation_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDeleteOperation_Click(object sender, EventArgs e)
        {
            // Код для удаления клиента из базы данных
            string query = "DELETE FROM Clients WHERE ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", dataGridViewClients.SelectedRows[0].Cells["ClientID"].Value);
            command.ExecuteNonQuery();

            // Заполнить comboBox для поиска по клиенту
            SqlDataAdapter adapterSearchClients = new SqlDataAdapter("SELECT ClientID, FirstName, LastName, PhoneNumber FROM Clients", connection);
            DataTable tableSearchClients = new DataTable();
            adapterSearchClients.Fill(tableSearchClients);
            comboBoxSearchFirstName.DataSource = tableSearchClients;
            comboBoxSearchFirstName.DisplayMember = "FirstName";
            comboBoxSearchFirstName.ValueMember = "ClientID";

            comboBoxSearchLastName.DataSource = tableSearchClients;
            comboBoxSearchLastName.DisplayMember = "LastName";
            comboBoxSearchLastName.ValueMember = "ClientID";

            comboBoxSearchPhoneNumber.DataSource = tableSearchClients;
            comboBoxSearchPhoneNumber.DisplayMember = "PhoneNumber";
            comboBoxSearchPhoneNumber.ValueMember = "ClientID";
            // Обновить таблицу
            table.Clear();
            adapter.Fill(table);
            dataGridViewClients.DataSource = table;
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Clients (FirstName, LastName, PhoneNumber) VALUES (@FirstName, @LastName, @PhoneNumber)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
            command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
            command.Parameters.AddWithValue("@PhoneNumber", textBoxPhoneNumber.Text);
            command.ExecuteNonQuery();
            table.Clear();
            adapter.Fill(table);
            dataGridViewClients.DataSource = table;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Clients WHERE (FirstName = @FirstName OR @FirstName IS NULL) AND (LastName = @LastName OR @LastName IS NULL) AND (PhoneNumber = @PhoneNumber OR @PhoneNumber IS NULL)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", comboBoxSearchFirstName.SelectedItem == null ? (object)DBNull.Value : comboBoxSearchFirstName.SelectedItem.ToString());
            command.Parameters.AddWithValue("@LastName", comboBoxSearchLastName.SelectedItem == null ? (object)DBNull.Value : comboBoxSearchLastName.SelectedItem.ToString());
            command.Parameters.AddWithValue("@PhoneNumber", comboBoxSearchPhoneNumber.SelectedItem == null ? (object)DBNull.Value : comboBoxSearchPhoneNumber.SelectedItem.ToString());
            SqlDataReader reader = command.ExecuteReader();

            DataTable tableSearch = new DataTable();
            tableSearch.Load(reader);

            dataGridViewClients.DataSource = tableSearch;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(Role);
            form1.Show();
            this.Close();
        }
    }
}
