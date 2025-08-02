namespace TerrariaCalculator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            table = new TableLayoutPanel();
            WeaponButton = new Button();
            WeaponLabel = new Label();
            ArmorAndAccesoriesLabel = new Label();
            OutputLabel = new Label();
            AccSlotButton = new Button();
            panel1 = new Panel();
            table.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // table
            // 
            table.Anchor = AnchorStyles.None;
            table.AutoSize = true;
            table.BackColor = Color.Transparent;
            table.ColumnCount = 1;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table.Controls.Add(WeaponButton, 0, 1);
            table.Controls.Add(WeaponLabel, 0, 0);
            table.Controls.Add(ArmorAndAccesoriesLabel, 0, 2);
            table.Controls.Add(OutputLabel, 0, 4);
            table.Controls.Add(AccSlotButton, 0, 3);
            table.ForeColor = Color.Black;
            table.Location = new Point(0, -3);
            table.Name = "table";
            table.RowCount = 6;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            table.Size = new Size(827, 497);
            table.TabIndex = 0;
            table.Paint += table_Paint;
            // 
            // WeaponButton
            // 
            WeaponButton.Anchor = AnchorStyles.Top;
            WeaponButton.Image = (Image)resources.GetObject("WeaponButton.Image");
            WeaponButton.Location = new Point(336, 74);
            WeaponButton.Margin = new Padding(0);
            WeaponButton.MaximumSize = new Size(155, 155);
            WeaponButton.MinimumSize = new Size(155, 155);
            WeaponButton.Name = "WeaponButton";
            WeaponButton.Size = new Size(155, 155);
            WeaponButton.TabIndex = 1;
            WeaponButton.UseVisualStyleBackColor = true;
            WeaponButton.Click += WeaponButton_Click;
            // 
            // WeaponLabel
            // 
            WeaponLabel.Anchor = AnchorStyles.Top;
            WeaponLabel.AutoSize = true;
            WeaponLabel.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeaponLabel.Location = new Point(257, 0);
            WeaponLabel.Name = "WeaponLabel";
            WeaponLabel.Size = new Size(313, 74);
            WeaponLabel.TabIndex = 3;
            WeaponLabel.Text = "Weapons";
            WeaponLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ArmorAndAccesoriesLabel
            // 
            ArmorAndAccesoriesLabel.Anchor = AnchorStyles.Top;
            ArmorAndAccesoriesLabel.AutoSize = true;
            ArmorAndAccesoriesLabel.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ArmorAndAccesoriesLabel.Location = new Point(53, 168);
            ArmorAndAccesoriesLabel.Name = "ArmorAndAccesoriesLabel";
            ArmorAndAccesoriesLabel.Size = new Size(721, 74);
            ArmorAndAccesoriesLabel.TabIndex = 1;
            ArmorAndAccesoriesLabel.Text = "Armor and Accesories";
            ArmorAndAccesoriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OutputLabel
            // 
            OutputLabel.Anchor = AnchorStyles.Top;
            OutputLabel.AutoSize = true;
            OutputLabel.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutputLabel.Location = new Point(277, 342);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(273, 74);
            OutputLabel.TabIndex = 2;
            OutputLabel.Text = "Output";
            OutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AccSlotButton
            // 
            AccSlotButton.Anchor = AnchorStyles.Top;
            AccSlotButton.Image = (Image)resources.GetObject("AccSlotButton.Image");
            AccSlotButton.Location = new Point(336, 275);
            AccSlotButton.Margin = new Padding(0);
            AccSlotButton.MaximumSize = new Size(155, 155);
            AccSlotButton.MinimumSize = new Size(155, 155);
            AccSlotButton.Name = "AccSlotButton";
            AccSlotButton.Size = new Size(155, 155);
            AccSlotButton.TabIndex = 4;
            AccSlotButton.UseVisualStyleBackColor = true;
            AccSlotButton.Click += AccSlot_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(table);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 515);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 518);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            table.ResumeLayout(false);
            table.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel table;
        private Label ArmorAndAccesoriesLabel;
        private Label OutputLabel;
        private Label WeaponLabel;
        private Button WeaponButton;
        private Button AccSlotButton;
        private Panel panel1;
    }
}