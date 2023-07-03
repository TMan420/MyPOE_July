namespace MyRecipeApplicationPOE
{
    partial class RecipeSteps
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
            this.Label1 = new System.Windows.Forms.Label();
            this.StepsTextBox = new System.Windows.Forms.RichTextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.AddStep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(76, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(145, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Add A Recipe Step";
            // 
            // StepsTextBox
            // 
            this.StepsTextBox.Location = new System.Drawing.Point(80, 138);
            this.StepsTextBox.Name = "StepsTextBox";
            this.StepsTextBox.Size = new System.Drawing.Size(639, 127);
            this.StepsTextBox.TabIndex = 3;
            this.StepsTextBox.Text = "";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(619, 318);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(169, 33);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Finished";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // AddStep
            // 
            this.AddStep.Location = new System.Drawing.Point(281, 31);
            this.AddStep.Name = "AddStep";
            this.AddStep.Size = new System.Drawing.Size(97, 34);
            this.AddStep.TabIndex = 5;
            this.AddStep.Text = "Add";
            this.AddStep.UseVisualStyleBackColor = true;
            this.AddStep.Click += new System.EventHandler(this.AddStep_Click);
            // 
            // RecipeSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.AddStep);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.StepsTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "RecipeSteps";
            this.Text = "Recipe Steps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.RichTextBox StepsTextBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button AddStep;
    }
}