namespace HelloWorldMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnGreetButtonClicked(object sender, EventArgs e)
        {
            GreetingLabel.Text = $"Hello {NameEntry.Text}";
        }
    }
}
