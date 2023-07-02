namespace MyRecipeApplicationPOE
{
    partial class Create_Recipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecipeNameLabel = new System.Windows.Forms.Label();
            this.RecipeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IngAmount = new System.Windows.Forms.Label();
            this.IngNumber = new System.Windows.Forms.NumericUpDown();
            this.BackButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IngNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeNameLabel
            // 
            this.RecipeNameLabel.AutoSize = true;
            this.RecipeNameLabel.ForeColor = System.Drawing.Color.Black;
            this.RecipeNameLabel.Location = new System.Drawing.Point(41, 36);
            this.RecipeNameLabel.Name = "RecipeNameLabel";
            this.RecipeNameLabel.Size = new System.Drawing.Size(126, 20);
            this.RecipeNameLabel.TabIndex = 0;
            this.RecipeNameLabel.Text = "Name Of Recipe";
            // 
            // RecipeName
            // 
            this.RecipeName.Location = new System.Drawing.Point(227, 36);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(279, 26);
            this.RecipeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name Of Recipe";
            // 
            // IngAmount
            // 
            this.IngAmount.Location = new System.Drawing.Point(0, 0);
            this.IngAmount.Name = "IngAmount";
            this.IngAmount.Size = new System.Drawing.Size(100, 23);
            this.IngAmount.TabIndex = 9;
            // 
            // IngNumber
            // 
            this.IngNumber.Location = new System.Drawing.Point(227, 97);
            this.IngNumber.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.IngNumber.Name = "IngNumber";
            this.IngNumber.Size = new System.Drawing.Size(85, 26);
            this.IngNumber.TabIndex = 6;
            this.IngNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Red;
            this.BackButton.Location = new System.Drawing.Point(348, 172);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 42);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Green;
            this.EnterButton.Location = new System.Drawing.Point(429, 172);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 42);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Create_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(559, 226);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.IngNumber);
            this.Controls.Add(this.IngAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.RecipeNameLabel);
            this.Name = "Create_Recipe";
            this.Text = "Create A Recipe";
            this.Load += new System.EventHandler(this.Create_Recipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IngNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecipeNameLabel;
        private System.Windows.Forms.TextBox RecipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IngAmount;
        private System.Windows.Forms.NumericUpDown IngNumber;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EnterButton;
    }
}