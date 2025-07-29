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

namespace Chapter_10
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DisplayCourseContent();
        }

        private void DisplayCourseContent()
        {
            TreeViewNode oop = new TreeViewNode { Content = "Object Oriented Programming" };
            oop.Children.Add(new TreeViewNode { Content = "Constructors and Destructors" });
            oop.Children.Add(new TreeViewNode { Content = "Inheritance" });
            oop.Children.Add(new TreeViewNode { Content = "Polymorphism" });
            oop.Children.Add(new TreeViewNode { Content = "Composition" });
            oop.Children.Add(new TreeViewNode { Content = "Aggregation" });

            TreeViewNode dsa = new TreeViewNode { Content = "Data Structures" };
            dsa.Children.Add(new TreeViewNode { Content = "Linked List" });
            dsa.Children.Add(new TreeViewNode { Content = "Queue" });
            dsa.Children.Add(new TreeViewNode { Content = "Stack" });

            TreeViewNode desktopApps = new TreeViewNode { Content = "Desktop Applications" };
            desktopApps.Children.Add(new TreeViewNode { Content = "C#" });
            desktopApps.Children.Add(new TreeViewNode { Content = "WinUI 3" });
            desktopApps.Children.Add(new TreeViewNode { Content = ".NET" });

            CourseContentTree.RootNodes.Add(oop);
            CourseContentTree.RootNodes.Add(dsa);
            CourseContentTree.RootNodes.Add(desktopApps);
        }

    }
}
