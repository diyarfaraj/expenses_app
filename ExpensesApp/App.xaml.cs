using System;
using ExpensesApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ExpensesApp
{
    public partial class App : Application
    {
        public static string DatebasePath;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

        }
        public App(string datebasePath)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            DatebasePath = datebasePath;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}