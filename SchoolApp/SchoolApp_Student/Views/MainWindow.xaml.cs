using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolApp_Student
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

        private void ShutDown(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            //check if the current screen has any unsaved data -> output message to save or not?
        }

        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            // Begin dragging the window
            DragMove();
        }

        private void DisplayPersonalInformationView(object sender, RoutedEventArgs e)
        {
            tmp.Visibility = Visibility.Visible;
        }
        
        private void DisplayUsernamePasswordView(object sender, RoutedEventArgs e)
        {
            tmp2.Visibility = Visibility.Visible;
        }
    }
}
