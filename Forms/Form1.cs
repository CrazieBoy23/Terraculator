using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TerrariaCalculator
{
    public partial class Form1 : Form
    {
        private int weaponCount = 0;
        private int accessoryCount = 0;

        private List<WeaponBox> weaponBoxes = new();
        private List<Accesory> accessories = new();
        private List<Output> outputs = new();

        private void AccSlot_Click(object sender, EventArgs e)
        {
            var acc = new Accesory(this);
            acc.OnAccessoryChanged = UpdateAllOutputs;
            accessories.Add(acc);

            var slot = new AccSlot(this) { accesory = acc };
            InsertRow(table, table.GetRow(AccSlotButton), slot);
            accessoryCount++;
        }
        private void table_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Blue;
            int borderWidth = 5;
            int offset = 50;

            int width = table.Width;
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                int rows = table.RowCount;
                int[] rowHeights = new int[rows];
                for (int i = 0; i < rows; i++)
                    rowHeights[i] = table.GetRowHeights()[i];

                // Draw horizontal lines (row separators)
                int y = 0;
                for (int i = 0; i < rows - 1; i++)
                {
                    y += rowHeights[i];
                    e.Graphics.DrawLine(pen, offset, y, width - offset, y);
                }
            }
        }
        private void InsertRow(TableLayoutPanel panel, int insertIndex, Control weaponBox)
        {
            panel.RowCount++;

            for (int row = panel.RowCount - 2; row >= insertIndex; row--)
            {
                Control? ctrl = panel.GetControlFromPosition(0, row);
                if (ctrl != null)
                    panel.SetRow(ctrl, row + 1);
            }
            panel.RowStyles.Insert(insertIndex, new RowStyle(SizeType.AutoSize));
            panel.Controls.Add(weaponBox, 0, insertIndex);
        }
        private void WeaponButton_Click(object sender, EventArgs e)
        {
            var weaponBox = new WeaponBox(this);
            weaponBoxes.Add(weaponBox);

            InsertRow(table, table.GetRow(WeaponButton), weaponBox);

            var output = new Output();
            outputs.Add(output);
            InsertRow(table, table.RowCount - 1, output);

            output.SetWeaponName($"Weapon {weaponCount + 1}");
            weaponCount++;

            UpdateAllOutputs();
        }

        public Form1()
        {
            InitializeComponent();
            this.Resize += Form_Resize;

            table.Dock = DockStyle.Top;
            table.AutoSize = true;
            table.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            foreach (RowStyle rowStyle in table.RowStyles)
            {
                rowStyle.SizeType = SizeType.AutoSize;
            }

            foreach (Control control in this.table.Controls)
            {
                if (control is Label label)
                {
                    label.Padding = new Padding(0, 25, 0, 25);
                }

                else if (control is Button button)
                {
                    button.FlatAppearance.BorderSize = 0;
                    button.Margin = new Padding(0, 25, 0, 25);
                }

                else if (control is FlowLayoutPanel flowLayoutPanel)
                {
                    flowLayoutPanel.Dock = DockStyle.Fill;
                }
            }
        }
        
        private void Form_Resize(object? sender, EventArgs e)
        {
            panel1.Width = this.ClientSize.Width;
            panel1.Height = this.ClientSize.Height;
            table.Width = this.ClientSize.Width;
        }

        public void UpdateAllOutputs()
        {
            var mod = new StatModifier();

            // Combine accessory modifiers
            foreach (var acc in accessories)
                mod.Combine(DpsCalculator.GetModifierFromAccessory(acc));

            for (int i = 0; i < weaponBoxes.Count; i++)
            {
                var baseStats = weaponBoxes[i].WeaponStats;

                // Add weapon modifier
                mod.Combine(DpsCalculator.GetModifierFromWeapon(weaponBoxes[i].Weapon));

                var finalStats = baseStats.ApplyModifier(mod);
                outputs[i].DisplayStats(finalStats);

                if (string.IsNullOrEmpty(weaponBoxes[i].WeaponNameText))
                    outputs[i].SetWeaponName($"Weapon {i + 1}");
                else
                    outputs[i].SetWeaponName(weaponBoxes[i].WeaponNameText);
            }
        }
    }
}
