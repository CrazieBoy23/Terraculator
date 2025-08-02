namespace TerrariaCalculator
{
    partial class StatBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StatDescription = new Label();
            InputBox = new TextBox();
            WarningText = new Label();
            SuspendLayout();
            // 
            // StatDescription
            // 
            StatDescription.AutoSize = true;
            StatDescription.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatDescription.Location = new Point(0, 0);
            StatDescription.MaximumSize = new Size(200, 0);
            StatDescription.MinimumSize = new Size(200, 0);
            StatDescription.Name = "StatDescription";
            StatDescription.Size = new Size(200, 62);
            StatDescription.TabIndex = 0;
            StatDescription.Text = "Stat description HERE";
            StatDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(0, 96);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(200, 27);
            InputBox.TabIndex = 1;
            // 
            // WarningText
            // 
            WarningText.AutoSize = true;
            WarningText.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WarningText.ForeColor = Color.Red;
            WarningText.Location = new Point(3, 126);
            WarningText.MaximumSize = new Size(200, 0);
            WarningText.Name = "WarningText";
            WarningText.Size = new Size(194, 40);
            WarningText.TabIndex = 2;
            WarningText.Text = "Invalid input";
            WarningText.Visible = false;
            // 
            // StatBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(WarningText);
            Controls.Add(InputBox);
            Controls.Add(StatDescription);
            Name = "StatBox";
            Size = new Size(208, 173);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StatDescription;
        public TextBox InputBox;
        public Label WarningText;
    }
}
