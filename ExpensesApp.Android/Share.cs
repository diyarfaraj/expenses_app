using System.Threading.Tasks;
using Android.Content;
using AndroidX.Core.Content;
using ExpensesApp.Android;
using ExpensesApp.Interfaces;
using Xamarin.Forms;

[assembly:Dependency(typeof(Share))]
namespace ExpensesApp.Android
{
    public class Share : IShare
    {
        public async Task Show(string title, string message, string filePath)
        {
            var intent = new Intent(Intent.ActionSend);
            intent.SetType("");
            var documentUri = FileProvider.GetUriForFile(Forms.Context.)
            
        }
    }
}