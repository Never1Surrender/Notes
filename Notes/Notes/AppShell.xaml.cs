using Notes.View;
using Xamarin.Forms;

namespace Notes
{
    public partial class AppShell : Shell
    {
        public  AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NoteEntryPage), typeof(NoteEntryPage));
        }
    }
}