using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MyRecipeApplicationPOE
{
    public partial class RecipeSteps : Form
    {
        private List<string> recipeList;

        public RecipeSteps()
        {
            InitializeComponent();
            recipeList = new List<string>();
        }

        private void AddStep_Click(object sender, EventArgs e)
        {
            string step = StepsTextBox.Text;
            recipeList.Add(step);
            StepsTextBox.Clear();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
