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
        public MainWindow()
        {
            this.InitializeComponent();

        }

        private void B1Click(object sender, RoutedEventArgs e)
        {
            Create_Recipe nextPage = new Create_Recipe();
            this.Visibility = Visibility.Hidden;
            nextPage.Show();
        }
        private void B2_Click(object sender, RoutedEventArgs e)
        {
            RecipeSteps step = new RecipeSteps();
            step.Visible = true;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            this.Visibility = Visibility.Hidden;
        }
    }
}
