using ListViewGrouping.Model;
using Xamarin.Forms;

namespace ListViewGrouping
{
    public partial class PersonDetailPage : ContentPage
    {
        public PersonDetailPage(Person selectedItem)
        {
            InitializeComponent();

            BindingContext = selectedItem;
        }
    }
}
