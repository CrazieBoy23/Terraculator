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
            weaponName = new Label();
            label1 = new Label();
            damageOutput = new Label();
            speedOutput = new Label();
            label4 = new Label();
            label5 = new Label();
            critChanceOutput = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            avgDamageOutput = new Label();
            SuspendLayout();
            // 
            // WeaponName
            // 
            weaponName.AutoEllipsis = true;
            weaponName.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weaponName.Location = new Point(0, 75);
            weaponName.Name = "WeaponName";
            weaponName.Size = new Size(356, 50);
            weaponName.TabIndex = 0;
            weaponName.Text = "label1";
            weaponName.TextAlign = ContentAlignment.MiddleCenter;
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
            damageOutput.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            damageOutput.Location = new Point(360, 100);
            damageOutput.Name = "DamageOutput";
            damageOutput.Size = new Size(270, 50);
            damageOutput.TabIndex = 2;
            damageOutput.Text = "label1";
            damageOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SpeedOutput
            // 
            speedOutput.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            speedOutput.Location = new Point(750, 100);
            speedOutput.Name = "SpeedOutput";
            speedOutput.Size = new Size(305, 50);
            speedOutput.TabIndex = 4;
            speedOutput.Text = "label1";
            speedOutput.TextAlign = ContentAlignment.MiddleCenter;
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
            critChanceOutput.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            critChanceOutput.Location = new Point(1159, 100);
            critChanceOutput.Name = "CritChanceOutput";
            critChanceOutput.Size = new Size(136, 50);
            critChanceOutput.TabIndex = 7;
            critChanceOutput.Text = "label1";
            critChanceOutput.TextAlign = ContentAlignment.MiddleCenter;
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
            avgDamageOutput.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            avgDamageOutput.Location = new Point(1450, 100);
            avgDamageOutput.Name = "AvgDamageOutput";
            avgDamageOutput.Size = new Size(196, 50);
            avgDamageOutput.TabIndex = 11;
            avgDamageOutput.Text = "label1";
            avgDamageOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Output
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(avgDamageOutput);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(critChanceOutput);
            Controls.Add(label7);
            Controls.Add(speedOutput);
            Controls.Add(label4);
            Controls.Add(damageOutput);
            Controls.Add(label1);
            Controls.Add(weaponName);
            Controls.Add(label5);
            Margin = new Padding(0);
            Name = "Output";
            Padding = new Padding(50);
            Size = new Size(1699, 200);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label weaponName;
        public Label label1;
        public Label damageOutput;
        public Label speedOutput;
        public Label label4;
        public Label label5;
        public Label critChanceOutput;
        public Label label7;
        public Label label8;
        public Label label9;
        public Label label10;
        public Label avgDamageOutput;
    }
}
