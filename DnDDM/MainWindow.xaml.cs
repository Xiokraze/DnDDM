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

        private void ShowArmorControl(object sender, RoutedEventArgs e) { this.contentControl.Content = new StandardItemControl(DefaultValues.Armor); }
        private void ShowArtControl(object sender, RoutedEventArgs e){ this.contentControl.Content = new StandardItemControl(DefaultValues.Art); }
        private void ShowGemsControl(object sender, RoutedEventArgs e) { this.contentControl.Content = new StandardItemControl(DefaultValues.Gem); }
        private void ShowGoodsControl(object sender, RoutedEventArgs e) { this.contentControl.Content = new StandardItemControl(DefaultValues.Good); }
        private void ShowWeaponsControl(object sender, RoutedEventArgs e) { this.contentControl.Content = new StandardItemControl(DefaultValues.Weapon); }
        private void ShowTrinektsControl(object sender, RoutedEventArgs e) { this.contentControl.Content = new StandardItemControl(DefaultValues.Trinket); }


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
    }
}
