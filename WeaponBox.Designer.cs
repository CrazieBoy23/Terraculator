namespace TerrariaCalculator
{
    partial class WeaponBox
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            WeaponName = new Label();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            NameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WeaponName
            // 
            WeaponName.AutoSize = true;
            WeaponName.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeaponName.Location = new Point(3, 0);
            WeaponName.Name = "WeaponName";
            WeaponName.Size = new Size(329, 50);
            WeaponName.TabIndex = 0;
            WeaponName.Text = "Weapon Name -";
            // 
            // splitContainer1
            // 
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Padding = new Padding(20, 0, 0, 0);
            splitContainer1.Size = new Size(1385, 270);
            splitContainer1.SplitterDistance = 112;
            splitContainer1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(604, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 50);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(327, 50);
            label1.TabIndex = 6;
            label1.Text = "Weapon Type -";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(333, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(WeaponName);
            panel1.Controls.Add(NameBox);
            panel1.Location = new Point(21, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 50);
            panel1.TabIndex = 2;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(328, 14);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(200, 27);
            NameBox.TabIndex = 1;
            // 
            // WeaponBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(splitContainer1);
            Name = "WeaponBox";
            Size = new Size(1388, 520);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label WeaponName;
        private TextBox NameBox;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private ComboBox comboBox1;
        private Panel panel2;
        private Label label1;
    }
}
