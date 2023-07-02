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

namespace MyRecipeApplicationPOE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance;
        public MainWindow()
        {
            this.InitializeComponent();
            instance = this;
        }

        private void B1Click(object sender, RoutedEventArgs e)
        {
            Create_Recipe nextPage = new Create_Recipe();
            this.Visibility = Visibility.Hidden;
            nextPage.Show();
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            this.Visibility = Visibility.Hidden;
        }
    }
}
