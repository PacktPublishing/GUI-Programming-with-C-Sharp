namespace Chapter6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private UserViewModel _user;
        private void OnSubmitClicked(object sender, EventArgs e) 
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;
            DisplayAlert("Login", $"Username: {username}\nPassword: {password}", "OK");

            var viewModel = BindingContext as UserViewModel;
            if (viewModel != null)
            {
                viewModel.Username = usernameEntry.Text;
                viewModel.Password = passwordEntry.Text;
            }
        }
    }
}
