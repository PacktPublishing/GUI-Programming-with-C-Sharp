using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Controls;
using Windows.Storage;
using Windows.Storage.Pickers;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Chapter_8
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RootGrid.DataContext = new UserViewModel();
        }

        private void OnGreetButtonClick(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            GreetingTextBlock.Text = $"Hello, {name}!";
        }

        private void OnAnimateButtonClick(object sender, RoutedEventArgs e)
        {
            if (RootGrid.Resources.TryGetValue("RectangleAnimation", out var resource) && resource is Storyboard storyboard)
            {
                storyboard.Begin();
            }
        }

        private async void OnOpenFileButtonClick(object sender, RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");

            // Initialize with current window handle (required for WinUI 3)
            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WinRT.Interop.InitializeWithWindow.Initialize(picker, hwnd);

            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                using var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                var bitmapImage = new Microsoft.UI.Xaml.Media.Imaging.BitmapImage();
                await bitmapImage.SetSourceAsync(stream);
                SelectedImage.Source = bitmapImage;
            }
            else
            {
                // Optionally clear the image or show a message
                SelectedImage.Source = null;
            }
        }
    }
}
