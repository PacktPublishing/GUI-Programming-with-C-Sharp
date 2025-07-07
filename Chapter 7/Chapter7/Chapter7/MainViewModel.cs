using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter7;

public class MainViewModel : INotifyPropertyChanged
{
    private string _userName;
    public string UserName
    {
        get => _userName;
        set
        {
            if (_userName == value) return;
            _userName = value;
            OnPropertyChanged();
        }
    }
    private string _title;
    public string Title
    {
        get => _title;
        set
        {
            if (_title == value) return;
            _title = value;
            OnPropertyChanged();
        }
    }
    private bool _isItemActive = false;
    public bool IsItemActive
    {
        get => _isItemActive;
        set
        {
            if (_isItemActive == value) return;
            _isItemActive = value;
            OnPropertyChanged();
        }
    }
    public ObservableCollection<Book> Books { get; set; }

    // Add this event implementation
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public MainViewModel()
    {
        Title = "Hello, .NET MAUI!";
        Books = new ObservableCollection<Book>
        {
            new Book { Title = "The Lost Algorithm", Author = "Ada Lovelace" },
            new Book { Title = "Journey to the Cloud", Author = "Linus Skywalker" },
            new Book { Title = "Secrets of the Stack", Author = "Grace Hopper" },
            new Book { Title = "The Last Commit", Author = "Alan Turing" },
            new Book { Title = "Refactor's Quest", Author = "Margaret Hamilton" }
        };
    }
}
