using DnDDM.Classes;
using DnDDM.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DnDDM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowSplashControl();
        }


        private void ShowSplashControl()
        {
            DefaultValues.mainWindow = this;
            this.mainMenu.Visibility = Visibility.Collapsed;
            this.contentControl.Content = new SplashControl();
        }

        private void ShowArmorControl(object sender, RoutedEventArgs e)
        {

        }

        private void ShowArtControl(object sender, RoutedEventArgs e)
        {

        }

        private void ShowGemsControl(object sender, RoutedEventArgs e)
        {

        }

        private void ShowGoodsControl(object sender, RoutedEventArgs e)
        {

        }

        private void ShowWeaponsControl(object sender, RoutedEventArgs e)
        {

        }

        private void ShowTrinektsControl(object sender, RoutedEventArgs e)
        {

        }

        private void MouseEnterMenuItem(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var item = sender as MenuItem;
            item.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#930C10"));
            item.IsSubmenuOpen = true;
        }

        private void MouseLeaveMenuItem(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var item = sender as MenuItem;
            item.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F7CE65"));
            item.IsSubmenuOpen = false;
        }

        private void MenuItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }
    }
}
