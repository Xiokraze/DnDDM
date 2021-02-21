using DnDDM.Classes;
using DnDDM.Controls;
using System.Windows;

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
    }
}
