using System;
using System.Collections.Generic;
using SQLite;

namespace ExpensesApp.Models
{
    public class Expense
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }

        public static int InsertExpense(Expense expense)
        {
            using (SQLite.SQLiteConnection connection = new SQLiteConnection(App.DatebasePath))
            {
                connection.CreateTable<Expense>();
                return connection.Insert(expense);
            }
        }

        public static List<Expense> GetExpenses()
        {
            using (var connection = new SQLiteConnection(App.DatebasePath))
            {
                connection.CreateTable<Expense>();
                return connection.Table<Expense>().ToList();
            }
        }
        
        public static object GetExpensesCategory(string category)
        {
            using (var connection = new SQLiteConnection(App.DatebasePath))
            {
                connection.CreateTable<Expense>();
                return connection.Table<Expense>().Where(e => e.Category == category).ToList();
            }
        }
    }
}