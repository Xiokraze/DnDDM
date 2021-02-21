using DnDDM.Classes;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace DnDDM.Controls
{
    /// <summary>
    /// Interaction logic for SplashControl.xaml
    /// </summary>
    public partial class SplashControl : UserControl
    {
        public SplashControl()
        {
            InitializeComponent();
        }

        private void ConfirmClicked(object sender, RoutedEventArgs e)
        {
            DefaultValues.mainWindow.mainMenu.Visibility = Visibility.Visible;
            DefaultValues.mainWindow.contentControl.Content = new HomeControl();
        }

        private void MouseCursorEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#030303"));
        }

        private void MouseCursorLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F7CE65"));
        }
    }
}
