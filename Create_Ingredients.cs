using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecipeApplicationPOE
{
    public partial class Create_Ingredients : Form
    {
        public Create_Ingredients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecipeSteps x = new RecipeSteps();
            x.Visible = true;
            this.Close();
        }
    }
}
