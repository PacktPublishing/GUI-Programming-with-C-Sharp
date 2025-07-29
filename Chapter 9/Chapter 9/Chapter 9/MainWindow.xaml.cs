using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Chapter_9
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyNavigationView.SelectionChanged += MyNavigationView_SelectionChanged;
            ShowFavoriteCourses();
        }

        // Handle NavigationView selection changes
        private void MyNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var selectedTag = (args.SelectedItem as NavigationViewItem).Tag.ToString();

            if (selectedTag == "courses")
            {
                ShowFavoriteCourses();
            }
            else
            {
                HideAllPanels();
            }
        }

        // Display the Favorite Courses section
        private void ShowFavoriteCourses()
        {
            HideAllPanels();  // Ensure other panels are hidden
            FavoriteCoursesPanel.Visibility = Visibility.Visible;
            var courses = new[] { "OOP", "Data Structures", "Operating Systems", "App Development", "Database" };
            FavoriteCoursesList.ItemsSource = courses;
        }

        // Hide all content panels
        private void HideAllPanels()
        {
            FavoriteCoursesPanel.Visibility = Visibility.Collapsed;
        }
    }
}
