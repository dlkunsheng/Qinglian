using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Configuration;

namespace Qinglian.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetTheme();
        }

        private void SetTheme()
        {
            // Set light mode at the application-level
            Application.Current.ThemeMode = ThemeMode.Light;

            // Set dark mode on the current window
            this.ThemeMode = ThemeMode.Dark;

            //string theme = ConfigurationManager.AppSettings["Theme"]!.ToString();
            //if (theme == "Dark")
            //{
            //    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            //    {
            //        Source = new Uri("Themes/DarkTheme.xaml", UriKind.Relative)
            //    });
            //}
            //else
            //{
            //    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            //    {
            //        Source = new Uri("Themes/LightTheme.xaml", UriKind.Relative)
            //    });
            //}
        }
    }
}