using Notes.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}