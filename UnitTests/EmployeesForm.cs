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

namespace meow11
{
    public partial class EmployeesForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;
        private string Role;
        public EmployeesForm(string Role)
        {

            InitializeComponent();
            connection = new SqlConnection("Data Source=adclg1;Initial Catalog=Praktika_filimonov;Integrated Security=True;Encrypt=False");
            connection.Open();

            adapter = new SqlDataAdapter("SELECT * FROM Employees", connection);
            table = new DataTable();
            adapter.Fill(table);

            dataGridViewEmployees.DataSource = table;

            // Заполнить comboBox для поиска по работнику
            SqlDataAdapter adapterSearchEmployeesFirstName = new SqlDataAdapter("SELECT EmployeeID, FirstName FROM Employees", connection);
            DataTable tableSearchEmployeesFirstName = new DataTable();
            adapterSearchEmployeesFirstName.Fill(tableSearchEmployeesFirstName);
            comboBoxSearchFirstName.DataSource = tableSearchEmployeesFirstName;
            comboBoxSearchFirstName.DisplayMember = "FirstName";
            comboBoxSearchFirstName.ValueMember = "EmployeeID";

            SqlDataAdapter adapterSearchEmployeesLastName = new SqlDataAdapter("SELECT EmployeeID, LastName FROM Employees", connection);
            DataTable tableSearchEmployeesLastName = new DataTable();
            adapterSearchEmployeesLastName.Fill(tableSearchEmployeesLastName);
            comboBoxSearchLastName.DataSource = tableSearchEmployeesLastName;
            comboBoxSearchLastName.DisplayMember = "LastName";
            comboBoxSearchLastName.ValueMember = "EmployeeID";

            SqlDataAdapter adapterSearchEmployeesPosition = new SqlDataAdapter("SELECT EmployeeID, Position FROM Employees", connection);
            DataTable tableSearchEmployeesPosition = new DataTable();
            adapterSearchEmployeesPosition.Fill(tableSearchEmployeesPosition);
            comboBoxSearchPosition.DataSource = tableSearchEmployeesPosition;
            comboBoxSearchPosition.DisplayMember = "Position";
            comboBoxSearchPosition.ValueMember = "EmployeeID";
            buttonDeleteOperation.FlatStyle = FlatStyle.Flat;
            buttonAddOperation.FlatStyle = FlatStyle.Flat;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeleteOperation_Click(object sender, EventArgs e)
        {
            // Код для удаления работника из базы данных
            string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", dataGridViewEmployees.SelectedRows[0].Cells["EmployeeID"].Value);
            command.ExecuteNonQuery();

            // Обновить таблицу
            table.Clear();
            adapter.Fill(table);
            dataGridViewEmployees.DataSource = table;
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employees (FirstName, LastName, Position) VALUES (@FirstName, @LastName, @Position)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
            command.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
            command.Parameters.AddWithValue("@Position", textBoxPosition.Text);
            command.ExecuteNonQuery();
            table.Clear();
            adapter.Fill(table);
            dataGridViewEmployees.DataSource = table;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Employees WHERE (FirstName = @FirstName OR @FirstName IS NULL) AND (LastName = @LastName OR @LastName IS NULL) AND (Position = @Position OR @Position IS NULL)";
            SqlCommand command = new SqlCommand(query, connection);

            if (comboBoxSearchFirstName.SelectedIndex != -1)
            {
                command.Parameters.AddWithValue("@FirstName", comboBoxSearchFirstName.DisplayMember);
            }
            else
            {
                command.Parameters.AddWithValue("@FirstName", DBNull.Value);
            }

            if (comboBoxSearchLastName.SelectedIndex != -1)
            {
                command.Parameters.AddWithValue("@LastName", comboBoxSearchLastName.DisplayMember);
            }
            else
            {
                command.Parameters.AddWithValue("@LastName", DBNull.Value);
            }

            if (comboBoxSearchPosition.SelectedIndex != -1)
            {
                command.Parameters.AddWithValue("@Position", comboBoxSearchPosition.DisplayMember);
            }
            else
            {
                command.Parameters.AddWithValue("@Position", DBNull.Value);
            }

            SqlDataReader reader = command.ExecuteReader();

            DataTable tableSearch = new DataTable();
            tableSearch.Load(reader);

            dataGridViewEmployees.DataSource = tableSearch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(Role);
            form1.Show();
            this.Close();
        }
    }
}
