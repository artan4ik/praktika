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
    public partial class ItemsForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;
        private string Role;
        public ItemsForm(string Role)
        {
            InitializeComponent();

            
            connection = new SqlConnection("Data Source=adclg1;Initial Catalog=Praktika_filimonov;Integrated Security=True;Encrypt=False");
            connection.Open();

           
            adapter = new SqlDataAdapter("SELECT * FROM Items", connection);
            table = new DataTable();
            adapter.Fill(table);

            
            dataGridViewItems.DataSource = table;

           
            SqlDataAdapter adapterSearchItemType = new SqlDataAdapter("SELECT DISTINCT ItemType FROM Items", connection);
            DataTable tableSearchItemType = new DataTable();
            adapterSearchItemType.Fill(tableSearchItemType);
            comboBoxSearchItemType.DataSource = tableSearchItemType;
            comboBoxSearchItemType.DisplayMember = "ItemType";
            comboBoxSearchItemType.ValueMember = "ItemType";

         
            SqlDataAdapter adapterItems = new SqlDataAdapter("SELECT ItemID, ItemType, ItemDescription, EstimatedValue FROM Items", connection);
            DataTable tableItems = new DataTable();
            adapterItems.Fill(tableItems);
            textBoxItemType.DataBindings.Add("Text", tableItems, "ItemType");
            textBoxItemDescription.DataBindings.Add("Text", tableItems, "ItemDescription");
            textBoxEstimatedValue.DataBindings.Add("Text", tableItems, "EstimatedValue");

            SqlDataAdapter adapterSearchItemDescription = new SqlDataAdapter("SELECT DISTINCT ItemDescription FROM Items", connection);
            DataTable tableSearchItemDescription = new DataTable();
            adapterSearchItemDescription.Fill(tableSearchItemDescription);
            comboBoxSearchItemDescription.DataSource = tableSearchItemDescription;
            comboBoxSearchItemDescription.DisplayMember = "ItemDescription";
            comboBoxSearchItemDescription.ValueMember = "ItemDescription";
            buttonAddOperation.FlatStyle = FlatStyle.Flat;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonDeleteOperation.FlatStyle = FlatStyle.Flat;
            button1.FlatStyle = FlatStyle.Flat;


        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Items (ItemType, ItemDescription, EstimatedValue) VALUES (@ItemType, @ItemDescription, @EstimatedValue)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemType", textBoxItemType.Text);
            command.Parameters.AddWithValue("@ItemDescription", textBoxItemDescription.Text);
            command.Parameters.AddWithValue("@EstimatedValue", decimal.Parse(textBoxEstimatedValue.Text));
            command.ExecuteNonQuery();

            // Update the table
            table.Clear();
            adapter.Fill(table);
            dataGridViewItems.DataSource = table;
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Items WHERE (ItemType = @ItemType OR @ItemType IS NULL) AND (ItemDescription = @ItemDescription OR @ItemDescription IS NULL)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemType", comboBoxSearchItemType.SelectedValue == null ? (object)DBNull.Value : comboBoxSearchItemType.SelectedValue);
            command.Parameters.AddWithValue("@ItemDescription", comboBoxSearchItemDescription.SelectedValue == null ? (object)DBNull.Value : comboBoxSearchItemDescription.SelectedValue);

            SqlDataReader reader = command.ExecuteReader();

            DataTable tableSearch = new DataTable();
            tableSearch.Load(reader);
            reader.Close();

            dataGridViewItems.DataSource = tableSearch;
        }

        private void buttonDeleteOperation_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Items WHERE ItemID = @ItemID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ItemID", dataGridViewItems.SelectedRows[0].Cells["ItemID"].Value);
            command.ExecuteNonQuery();

            // Update the table
            table.Clear();
            adapter.Fill(table);
            dataGridViewItems.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(Role);
            form1.Show();
            this.Close();
        }
    }
}