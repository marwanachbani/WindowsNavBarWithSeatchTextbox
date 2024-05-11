using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            menuToggleButton.IsChecked = false;// Handle menu item click
            menuToggleButton.Width = 35;                                  // You can close the menu here if needed

        }

        private void MenuToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (menuToggleButton.IsChecked == true)
            {
                menuToggleButton.Width = 200;
                // Toggle button is checked, open the menu
                menuPopup.IsOpen = true;

            }
            else
            {
               
                // Toggle button is unchecked, close the menu
                menuPopup.IsOpen = false;
            }
        }

        private void menuToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            menuToggleButton.Width = 35;
        }

        private void search_LostFocus(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(search.Text))
            {
                searchholder.Visibility = Visibility.Visible;
            }
            else
            {
                searchholder.Visibility = Visibility.Collapsed;
            }
        }

        private void search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(search.Text))
            {
                searchholder.Visibility = Visibility.Visible;
            }
            else
            {
                searchholder.Visibility = Visibility.Collapsed;
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(search.Text))
            {
                searchholder.Visibility = Visibility.Visible;
                searchbutton.Visibility = Visibility.Collapsed;
            }
            else
            {
                searchholder.Visibility = Visibility.Collapsed;
                searchbutton.Visibility = Visibility.Visible;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            searchbutton.Visibility = Visibility.Collapsed;// Create a storyboard for all rectangles
            
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }



    }
}