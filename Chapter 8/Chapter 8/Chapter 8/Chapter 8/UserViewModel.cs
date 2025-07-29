using System.ComponentModel;

namespace Chapter_8;
public class UserViewModel : INotifyPropertyChanged
{
    private User user;

    public UserViewModel()
    {
        user = new User { Name = "John Doe", Age = 30 };
    }

    public string Name
    {
        get => user.Name;
        set
        {
            if (user.Name != value)
            {
                user.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
