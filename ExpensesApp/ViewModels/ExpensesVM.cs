using System.Collections.ObjectModel;
using ExpensesApp.Interfaces;
using ExpensesApp.Models;
using ExpensesApp.Views;
using Xamarin.Forms;

namespace ExpensesApp.ViewModels
{
    public class ExpensesVM
    {
        public ObservableCollection<Expense> Expenses { get; set; }
        public Command AddExpenseCommand { get; set; }
        

        public ExpensesVM()
        {
            Expenses = new ObservableCollection<Expense>();
            AddExpenseCommand = new Command(NavigateToExpense);
            GetExpenses();
        }

        public void GetExpenses()
        {
            var expenses = Expense.GetExpenses();
            Expenses.Clear();
            foreach (var expense in expenses)
            {
                Expenses.Add(expense);
            }
        }
        
       


        public void NavigateToExpense()
        {
            Application.Current.MainPage.Navigation.PushAsync(new NewExpensePage());
        }

      
        
    }
}