using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ListViewGrouping.Model;
using ListViewGrouping.Utils;
using Xamarin.Forms;

namespace ListViewGrouping
{
    public partial class PersonOverviewPage : ContentPage
    {
        public PersonOverviewPage()
        {
            InitializeComponent();

            var data = new List<Person>();

            for (var i = 0; i < 50; ++i)
            {
                data.Add(new Person(NameGenerator.GenRandomFirstName(), NameGenerator.GenRandomLastName(), "ID " + i));
            }

            var groupedData =
                data.OrderBy(p => p.Lastname)
                    .GroupBy(p => p.Lastname[0].ToString())
                    .Select(p => new ObservableGroupCollection<string, Person>(p))
                    .ToList();

            BindingContext = new ObservableCollection<ObservableGroupCollection<string, Person>>(groupedData);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            TheListView.SelectedItem = null;
        }

        private void TheListViewOnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (TheListView.SelectedItem == null) return;

            Navigation.PushAsync(new PersonDetailPage((Person)TheListView.SelectedItem));
        }

    }


}
