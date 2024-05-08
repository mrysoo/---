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


namespace Finance_Manager
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=(local);Initial Catalog=Operations;Integrated Security=True";
        public delegate void DataUpdatedEventHandler(object sender, EventArgs e);
        public event DataUpdatedEventHandler DataUpdated;
        private System.Windows.Forms.Timer dataRefreshTimer;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            DataUpdated += (sender, e) => UpdateDataGrid();

            // Инициализация таймера
            dataRefreshTimer = new System.Windows.Forms.Timer();
            dataRefreshTimer.Interval = 1000; 
            dataRefreshTimer.Tick += new EventHandler(dataRefreshTimer_Tick);
            dataRefreshTimer.Start();
        }

        private void dataRefreshTimer_Tick(object sender, EventArgs e)
        {
            FillDataGrid(); 
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FillDataGrid(); // Вызов при загрузке формы
        }

        public void AddIncomeToDatabase(decimal amount)
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();  
                
                string sqlQuery = "INSERT INTO Incomes (amount) VALUES (@Amount)";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            OnDataUpdated();
        }

        public void AddExpenseToDatabase(decimal expense, int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "INSERT INTO Expenses (expense, ID_category) VALUES (@Expense, @CategoryId)";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Expense", expense);
                    command.Parameters.AddWithValue("@CategoryId", categoryId);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            OnDataUpdated();
        }

        public void AddSavingsToDatabase(decimal savings, int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "INSERT INTO Savings (savings, ID_category) VALUES (@Savings, @CategoryId)";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Savings", savings);
                    command.Parameters.AddWithValue("@CategoryId", categoryId);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            OnDataUpdated();
        }

        protected virtual void OnDataUpdated()
        {
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateDataGrid()
        {
            FillDataGrid();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(txtIncomeAmount.Text);

            using (SqlCommand cmd = new SqlCommand("INSERT INTO Incomes (amount) VALUES (@amount)", connection))
            {
                cmd.Parameters.AddWithValue("@amount", amount);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show($"Доход добавлен: +{amount}");
        }


        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string expense = txtExpenseName.Text;
            decimal amount = decimal.Parse(txtExpenseAmount.Text);

            // Проверка, существует ли категория сбережений
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Categories WHERE category_name = @category_name", connection))
                {
                    cmd.Parameters.AddWithValue("@category_name", expense);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            // Создание категории сбережений
                            using (SqlCommand cmd2 = new SqlCommand("INSERT INTO Categories (category_name) VALUES (@category_name)", connection))
                            {
                                cmd2.Parameters.AddWithValue("@category_name", expense);
                                reader.Close(); 
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            // Получение ID категории расходов
            int categoryId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ID_category FROM Categories WHERE category_name = @category_name", connection))
                {
                    cmd.Parameters.AddWithValue("@category_name", expense);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoryId = reader.GetInt32(0);
                        }
                    }
                }
            }

            // Добавление расходов
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Expenses (amount, ID_category) VALUES (@amount, @ID_category)", connection))
                {
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@ID_category", categoryId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show($"Расходы добавлены:  -{amount}");
        }

        private void btnAddSavings_Click(object sender, EventArgs e)
        {
            string savings = txtSavingsName.Text;
            decimal amount = decimal.Parse(txtSavingsAmount.Text);

            // Проверка, существует ли категория сбережений
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Categories WHERE category_name = @category_name", connection))
                {
                    cmd.Parameters.AddWithValue("@category_name", savings);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            // Создание категории сбережений
                            using (SqlCommand cmd2 = new SqlCommand("INSERT INTO Categories (category_name) VALUES (@category_name)", connection))
                            {
                                cmd2.Parameters.AddWithValue("@category_name", savings);
                                reader.Close(); 
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            // Получение ID категории сбережений
            int categoryId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ID_category FROM Categories WHERE category_name = @category_name", connection))
                {
                    cmd.Parameters.AddWithValue("@category_name", savings);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoryId = reader.GetInt32(0);
                        }
                    }
                }
            }

            // Добавление сбережений
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Savings (amount, ID_category) VALUES (@amount, @ID_category)", connection))
                {
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@ID_category", categoryId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show($"Сбережения добавлены: +{amount}");
        }

        private void btnShowTotalExpense_Click(object sender, EventArgs e)
        {
            // Получение общих расходов по категориям
            Dictionary<string, decimal> totalExpensesByCategory = new Dictionary<string, decimal>();

            using (SqlCommand cmd = new SqlCommand("SELECT category_name, SUM(amount) FROM Expenses INNER JOIN Categories ON Expenses.ID_category = Categories.ID_category GROUP BY category_name", connection))
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string categoryName = reader.GetString(0);
                    decimal totalExpense = reader.GetDecimal(1);
                    totalExpensesByCategory.Add(categoryName, totalExpense);
                }
                connection.Close();
            }

            // Отображение общих расходов по категориям
            string expensesMessage = "Общие расходы по категориям:\n";
            foreach (var item in totalExpensesByCategory)
            {
                expensesMessage += $"{item.Key}: {item.Value}\n";
            }
            MessageBox.Show(expensesMessage);
        }

        private void btnShowTotalSavings_Click(object sender, EventArgs e)
        {
            // Получение общих сбережений по категориям
            Dictionary<string, decimal> totalSavingsByCategory = new Dictionary<string, decimal>();

            using (SqlCommand cmd = new SqlCommand("SELECT category_name, SUM(amount) FROM Savings INNER JOIN Categories ON Savings.ID_category = Categories.ID_category GROUP BY category_name", connection))
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string categoryName = reader.GetString(0);
                    decimal totalSavings = reader.GetDecimal(1);
                    totalSavingsByCategory.Add(categoryName, totalSavings);
                }
                connection.Close();
            }

            // Отображение общих сбережений по категориям
            string savingsMessage = "Общие сбережения по категориям:\n";
            foreach (var item in totalSavingsByCategory)
            {
                savingsMessage += $"{item.Key}: {item.Value}\n";
            }
            MessageBox.Show(savingsMessage);
        }

        private void FillDataGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Создание DataTable
                DataTable financialTable = new DataTable();
                financialTable.Columns.Add("Общие доходы");
                financialTable.Columns.Add("Общие расходы");
                financialTable.Columns.Add("Общие сбережения");
                financialTable.Columns.Add("Общий баланс");

                // Получение данных
                connection.Open();

                decimal totalIncome = 0;
                decimal totalExpenses = 0;
                decimal totalSavings = 0;

                // Доходы
                using (SqlCommand cmd = new SqlCommand("SELECT SUM(amount) FROM Incomes", connection))
                {
                    object result = cmd.ExecuteScalar();
                    totalIncome = (result != null && result != DBNull.Value) ? (decimal)result : 0;
                }

                // Расходы
                using (SqlCommand cmd = new SqlCommand("SELECT SUM(amount) FROM Expenses", connection))
                {
                    object result = cmd.ExecuteScalar();
                    totalExpenses = (result != null && result != DBNull.Value) ? (decimal)result : 0;
                }

                // Сбережения
                using (SqlCommand cmd = new SqlCommand("SELECT SUM(amount) FROM Savings", connection))
                {
                    object result = cmd.ExecuteScalar();
                    totalSavings = (result != null && result != DBNull.Value) ? (decimal)result : 0;
                }

                // Расчет общего баланса
                decimal totalBalance = totalIncome - totalExpenses - totalSavings;

                // Добавление строки в DataTable
                financialTable.Rows.Add(totalIncome, totalExpenses, totalSavings, totalBalance);

                connection.Close();

                // Привязка DataTable к DataGridView
                dataGridView.DataSource = financialTable;
                dataGridView.Refresh();
                dataGridView.AutoGenerateColumns = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (dataRefreshTimer != null)
            {
                dataRefreshTimer.Stop(); // Остановка таймера
            }
        }
    }
}