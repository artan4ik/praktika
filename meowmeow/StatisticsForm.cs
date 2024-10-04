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
    public partial class StatisticsForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;
        private string Role;

        public StatisticsForm()
        {
           
            InitializeComponent();
            this.Load += new EventHandler(StatisticsForm_Load);
            connection = new SqlConnection("Data Source=adclg1;Initial Catalog=Praktika_filimonov;Integrated Security=True;Encrypt=False");
            connection.Open();

            adapter = new SqlDataAdapter("SELECT * FROM Operations", connection);
            table = new DataTable();
            adapter.Fill(table);

            // Количество обработанных операций
            int countOperations = table.Rows.Count;
            labelCountOperations.Text = "Количество обработанных операций: " + countOperations.ToString();

            // Среднее время обработки операций
            DateTime startTime = DateTime.Now;
            DateTime endTime = DateTime.Now;
            long totalTicks = 0;
            foreach (DataRow row in table.Rows)
            {
                startTime = Convert.ToDateTime(row["OperationDate"]);
                endTime = Convert.ToDateTime(row["OperationDate"]);
                totalTicks += (endTime - startTime).Ticks;
            }
            TimeSpan averageTime = TimeSpan.FromTicks(totalTicks / table.Rows.Count);
            labelAverageTime.Text = "Среднее время обработки операций: " + averageTime.ToString();

            // Статистика по типам залоговых предметов
            SqlDataAdapter adapterItems = new SqlDataAdapter("SELECT ItemType, COUNT(*) AS Count FROM Items GROUP BY ItemType", connection);
            DataTable tableItems = new DataTable();
            adapterItems.Fill(tableItems);
            dataGridViewStatistics.DataSource = tableItems;
        }
        private void StatisticsForm_Load(object sender, EventArgs e)
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