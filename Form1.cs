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

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
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

            MessageBox.Show("Доход добавлен");
        }


        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string expense = txtExpenseName.Text;
            decimal amount = decimal.Parse(txtExpenseAmount.Text);

            // Проверить, существует ли категория сбережений
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
                            // Создать категорию сбережений
                            using (SqlCommand cmd2 = new SqlCommand("INSERT INTO Categories (category_name) VALUES (@category_name)", connection))
                            {
                                cmd2.Parameters.AddWithValue("@category_name", expense);
                                reader.Close(); // Закрыть DataReader
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            // Получить ID категории расходов
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

            // Добавить расходы
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

            MessageBox.Show("Расходы добавлены");
        }

        private void btnAddSavings_Click(object sender, EventArgs e)
        {
            string savings = txtSavingsName.Text;
            decimal amount = decimal.Parse(txtSavingsAmount.Text);

            // Проверить, существует ли категория сбережений
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
                            // Создать категорию сбережений
                            using (SqlCommand cmd2 = new SqlCommand("INSERT INTO Categories (category_name) VALUES (@category_name)", connection))
                            {
                                cmd2.Parameters.AddWithValue("@category_name", savings);
                                reader.Close(); // Закрыть DataReader
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            // Получить ID категории сбережений
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

            // Добавить сбережения
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

            MessageBox.Show("Сбережения добавлены");
        }

        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            decimal income = 0;
            decimal expense = 0;
            decimal savings = 0;

            // Получить общий доход
            using (SqlCommand cmd = new SqlCommand("SELECT SUM(amount) FROM Incomes", connection))
            {
                connection.Open();
                income = (decimal)cmd.ExecuteScalar();
                connection.Close();
            }

            // Получить общие расходы
            using (SqlCommand cmd = new SqlCommand("SELECT SUM(amount) FROM Expenses", connection))
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    expense = (decimal)result;
                }
                connection.Close();
            }

            // Получить общие сбережения
            using (SqlCommand cmd = new SqlCommand("SELECT SUM(amount) FROM Savings", connection))
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    savings = (decimal)result;
                }
                connection.Close();
            }

            // Вычислить оставшиеся средства
            decimal balance = income - expense - savings;

            MessageBox.Show($"Оставшиеся средства: {balance}");
        }


        private void btnShowTotalIncome_Click_1(object sender, EventArgs e)
        {
            // Получить общий доход
            decimal totalIncome = 0;
            using (SqlCommand cmd = new SqlCommand("SELECT SUM(amount) FROM Incomes", connection))
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    totalIncome = (decimal)result;
                }
                connection.Close();
            }
            MessageBox.Show($"Общий доход: {totalIncome}");
        }

        private void btnShowTotalExpense_Click(object sender, EventArgs e)
        {
            // Получить общие расходы по категориям
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

            // Отобразить общие расходы по категориям
            string expensesMessage = "Общие расходы по категориям:\n";
            foreach (var item in totalExpensesByCategory)
            {
                expensesMessage += $"{item.Key}: {item.Value}\n";
            }
            MessageBox.Show(expensesMessage);
        }

        private void btnShowTotalSavings_Click(object sender, EventArgs e)
        {
            // Получить общие сбережения по категориям
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

            // Отобразить общие сбережения по категориям
            string savingsMessage = "Общие сбережения по категориям:\n";
            foreach (var item in totalSavingsByCategory)
            {
                savingsMessage += $"{item.Key}: {item.Value}\n";
            }
            MessageBox.Show(savingsMessage);
        }
    }
}



