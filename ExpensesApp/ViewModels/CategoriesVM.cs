using System.Collections.ObjectModel;

namespace ExpensesApp.ViewModels
{
    public class CategoriesVM
    {
        public ObservableCollection<string> Categories { get; set; }

        public CategoriesVM()
        {
            Categories = new ObservableCollection<string>();
            AddCategories();
            
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