using SearchbarIssue.ViewModels;
using Xamarin.Forms;

namespace SearchbarIssue
{
    public class Page1 : ContentPage
    {
        public Page1()
        {           
            SearchBar searchbar = new SearchBar
            {
                BackgroundColor = Color.Red
            };

            StackLayout layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { searchbar }
            };
            layout.SetBinding(StackLayout.IsVisibleProperty, Page1ViewModel.IsLoadedPropertyName);

            this.BindingContext = new Page1ViewModel();
            this.Content = layout;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            Page1ViewModel vm = this.BindingContext as Page1ViewModel;
            await vm.LoadData();
        }
    }
}
