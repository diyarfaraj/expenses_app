using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ExpensesApp.Models;
using Xamarin.Forms;

namespace ExpensesApp.ViewModels
{
    public class NewExpensesVM : INotifyPropertyChanged
    {
        private string expenseName;
        public ObservableCollection<string> Categories { get; set; }

        public NewExpensesVM()
        {
            Categories = new ObservableCollection<string>();
            expenseDate = DateTime.Today;
            SaveExpenseCommand = new Command(InsertExpense);
            AddCategories();
        }
        public string ExpenseName
        {
            get { return expenseName; }
            set { expenseName = value; OnPropertyChanged("ExpenseName"); }
        }
        
        private float expenseAmount;

        public float ExpenseAmount
        {
            get { return expenseAmount; }
            set { expenseAmount = value; OnPropertyChanged("ExpenseAmount"); }
        }
        
        private DateTime expenseDate;

        public DateTime ExpenseDateTime
        {
            get { return expenseDate; }
            set { expenseDate = value; OnPropertyChanged("ExpenseDate"); }
        }
        
        private string expenseCategory;

        public string ExpenseCategory
        {
            get
            {
                return expenseCategory;
            }
            set { expenseCategory = value; OnPropertyChanged("ExpenseCategory"); }
        }

        private string expenseDescription;

        public string ExpenseDescription
        {
            get { return expenseDescription; }
            set { expenseDescription = value; OnPropertyChanged("expenseDescription"); }
        }

        public Command SaveExpenseCommand { get; set; }

      

        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void InsertExpense()
        {
            Expense expense = new Expense()
            {
                Name = ExpenseName,
                Amount = ExpenseAmount,
                Category = ExpenseCategory,
                Description = ExpenseDescription
            };

            int response = Expense.InsertExpense(expense);
            if (response > 0)
                Application.Current.MainPage.Navigation.PopAsync();
            else
                Application.Current.MainPage.DisplayAlert("Error", "Can't save the expense", "Ok");



        }
        
        private void AddCategories()
        {
            Categories.Clear();
            Categories.Add("housing");
            Categories.Add("debt");
            Categories.Add("health");
            Categories.Add("personal");
            Categories.Add("travel");

        }
        
    }
}