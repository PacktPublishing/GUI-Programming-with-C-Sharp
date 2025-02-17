using System.ComponentModel;

namespace Chapter6
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private string _displayedUsername;
        private string _displayedPassword;

        public string Username
        {
            get => _displayedUsername;
            set
            {
                if (_displayedUsername != value)
                {
                    _displayedUsername = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get => _displayedPassword;
            set
            {
                if (_displayedPassword != value)
                {
                    _displayedPassword = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}