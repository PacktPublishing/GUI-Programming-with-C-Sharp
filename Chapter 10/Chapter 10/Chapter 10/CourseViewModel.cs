using System.ComponentModel;

namespace Chapter_10;
public class CourseViewModel : INotifyPropertyChanged
{
    private Course _course;

    public CourseViewModel()
    {
        _course = new Course();
    }

    public string CourseName
    {
        get => _course.CourseName;
        set
        {
            if (_course.CourseName != value)
            {
                _course.CourseName = value;
                OnPropertyChanged(nameof(CourseName));
            }
        }
    }

    public string CourseDescription
    {
        get => _course.CourseDescription;
        set
        {
            if (_course.CourseDescription != value)
            {
                _course.CourseDescription = value;
                OnPropertyChanged(nameof(CourseDescription));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
