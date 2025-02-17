using System.Collections.ObjectModel;

namespace Chapter5
{
    public class Item
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
    }

    public class ViewModel
    {
        public ObservableCollection<Item> Items { get; set; }

        public ViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Item 1", Description = "Description 1" },
                new Item { Name = "Item 2", Description = "Description 2" }
            };
        }
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            DisplayAlert("Button Clicked", "You clicked the button!", "OK");
        }
    }
}
