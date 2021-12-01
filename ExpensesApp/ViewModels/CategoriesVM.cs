using System.Collections.ObjectModel;
using System.Reflection;
using ExpensesApp.Models;
using System.Linq;
using ExpensesApp.Interfaces;
using Xamarin.Forms;

namespace ExpensesApp.ViewModels
{
    public class CategoriesVM
    {
        public ObservableCollection<string> Categories { get; set; }
        public ObservableCollection<CategoryExpenses> CategoryExpensesCollecion { get; set; }

        public CategoriesVM()
        {
            Categories = new ObservableCollection<string>();
            CategoryExpensesCollecion = new ObservableCollection<CategoryExpenses>();
            AddCategories();
            GetExpensesPerCategory();

        }

        public void GetExpensesPerCategory()
        {
            CategoryExpensesCollecion.Clear();
            float totalExpensesAmount = Expense.TotalExpensesAmount();
            foreach (var category in Categories)
            {
                var expenses = Expense.GetExpensesCategory(category);
                float expensesAmountInCategory = expenses.Sum(e => e.Amount);
                CategoryExpenses ce = new CategoryExpenses()
                {
                    Category = category,
                    ExpensesPercentage = expensesAmountInCategory / totalExpensesAmount
                };
                CategoryExpensesCollecion.Add(ce);
            }
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
        
        public void ShareReport()
        {
            IShare shareDependency = DependencyService.Get<IShare>();
            shareDependency.Show(" "," "," ");

        }
        
        public class CategoryExpenses
        {
            public string Category { get; set; }
            public float ExpensesPercentage { get; set; }
        }
        
    
    }
}