using Android.Content;
using Android.Views;
using ExpensesApp.Android.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;

[assembly:ExportRenderer(typeof(TextCellRenderer), typeof(CustomTextCellRenderer))]

namespace ExpensesApp.Android.CustomRenderer
{
    
    public class CustomTextCellRenderer : TextCellRenderer
    {
        protected override View GetCellCore(Cell item, View convertView, ViewGroup parent, Context context)
        {
            var cell = base.GetCellCore(item, convertView, parent, context);
            switch (item.StyleId)
            {
                case "none":
                    cell.Activated
                    
            }
        }
    }
}