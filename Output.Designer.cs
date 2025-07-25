namespace TerrariaCalculator
{
    public partial class Output
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
            WeaponName = new Label();
            label1 = new Label();
            DamageOutput = new Label();
            SpeedOutput = new Label();
            label4 = new Label();
            label5 = new Label();
            CritChanceOutput = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            AvgDamageOutput = new Label();
            SuspendLayout();
            // 
            // WeaponName
            // 
            WeaponName.AutoEllipsis = true;
            WeaponName.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeaponName.Location = new Point(0, 75);
            WeaponName.Name = "WeaponName";
            WeaponName.Size = new Size(356, 50);
            WeaponName.TabIndex = 0;
            WeaponName.Text = "label1";
            WeaponName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 50);
            label1.Name = "label1";
            label1.Size = new Size(270, 50);
            label1.TabIndex = 1;
            label1.Text = "Damage/Hit";
            // 
            // DamageOutput
            // 
            DamageOutput.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DamageOutput.Location = new Point(360, 100);
            DamageOutput.Name = "DamageOutput";
            DamageOutput.Size = new Size(270, 50);
            DamageOutput.TabIndex = 2;
            DamageOutput.Text = "label1";
            DamageOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SpeedOutput
            // 
            SpeedOutput.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SpeedOutput.Location = new Point(750, 100);
            SpeedOutput.Name = "SpeedOutput";
            SpeedOutput.Size = new Size(305, 50);
            SpeedOutput.TabIndex = 4;
            SpeedOutput.Text = "label1";
            SpeedOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(750, 50);
            label4.Name = "label4";
            label4.Size = new Size(305, 50);
            label4.TabIndex = 3;
            label4.Text = "Attack Speed";
            // 
            // label5
            // 
            label5.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(636, 100);
            label5.Name = "label5";
            label5.Size = new Size(108, 50);
            label5.TabIndex = 5;
            label5.Text = "X";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CritChanceOutput
            // 
            CritChanceOutput.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CritChanceOutput.Location = new Point(1159, 100);
            CritChanceOutput.Name = "CritChanceOutput";
            CritChanceOutput.Size = new Size(136, 50);
            CritChanceOutput.TabIndex = 7;
            CritChanceOutput.Text = "label1";
            CritChanceOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1150, 50);
            label7.Name = "label7";
            label7.Size = new Size(145, 50);
            label7.TabIndex = 6;
            label7.Text = "Crit%";
            // 
            // label8
            // 
            label8.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1061, 100);
            label8.Name = "label8";
            label8.Size = new Size(83, 50);
            label8.TabIndex = 8;
            label8.Text = "X";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(1301, 100);
            label9.Name = "label9";
            label9.Size = new Size(143, 50);
            label9.TabIndex = 9;
            label9.Text = "=";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(1450, 50);
            label10.Name = "label10";
            label10.Size = new Size(196, 50);
            label10.TabIndex = 10;
            label10.Text = "Avg. DpS";
            // 
            // AvgDamageOutput
            // 
            AvgDamageOutput.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvgDamageOutput.Location = new Point(1450, 100);
            AvgDamageOutput.Name = "AvgDamageOutput";
            AvgDamageOutput.Size = new Size(196, 50);
            AvgDamageOutput.TabIndex = 11;
            AvgDamageOutput.Text = "label1";
            AvgDamageOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Output
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(AvgDamageOutput);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(CritChanceOutput);
            Controls.Add(label7);
            Controls.Add(SpeedOutput);
            Controls.Add(label4);
            Controls.Add(DamageOutput);
            Controls.Add(label1);
            Controls.Add(WeaponName);
            Controls.Add(label5);
            Margin = new Padding(0);
            Name = "Output";
            Padding = new Padding(50);
            Size = new Size(1699, 200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label WeaponName;
        public Label label1;
        public Label DamageOutput;
        public Label SpeedOutput;
        public Label label4;
        public Label label5;
        public Label CritChanceOutput;
        public Label label7;
        public Label label8;
        public Label label9;
        public Label label10;
        public Label AvgDamageOutput;
    }
}
