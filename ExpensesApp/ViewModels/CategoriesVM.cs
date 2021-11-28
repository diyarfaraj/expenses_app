using System.Collections.ObjectModel;

namespace ExpensesApp.ViewModels
{
    public class CategoriesVM
    {
        public ObservableCollection<string> Categories { get; set; }

        public CategoriesVM()
        {
            GetCategories();
        }

        private void GetCategories()
        {
            Categories = new ObservableCollection<string>();
            Categories.Add("housing");
            Categories.Add("debt");
            Categories.Add("health");
            Categories.Add("personal");
            Categories.Add("travel");

        }
    }
}