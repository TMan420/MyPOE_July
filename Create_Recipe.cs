using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;

namespace MyRecipeApplicationPOE
{
    public partial class Create_Recipe : Form
    {
        public Create_Recipe()
        {
            InitializeComponent();
        }

        private void Create_Recipe_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow x = new MainWindow();
            x.Show();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var xx = RecipeName.Text.ToString();

            if (xx.Length.Equals(0))
            {
                RecipeNameLabel.Text = "Please Enter A name!";
            }

            else
            {                
                for (int i = 0; i < IngNumber.Value; i++)
                {
                    Create_Ingredients x = new Create_Ingredients();
                    this.Close();
                    x.Show();
                }
            }
        }
    }
}
