using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaCalculator
{
    public partial class WeaponBox : UserControl
    {
        private Form1 _parentForm;
        private string weaponType = "";
        private StatBox[] statBoxes = new StatBox[10];
        public Weapon weapon;
        public WeaponBox(Form1 form)
        {
            InitializeComponent();
            splitContainer1.Size = new Size(1385, 110);
            _parentForm = form;
            weapon = new Weapon(_parentForm);

            comboBox1.Items.Add("Melee");
            comboBox1.Items.Add("Ranged");
            comboBox1.Items.Add("Magic");
            comboBox1.Items.Add("Summoner");

            comboBox1.SelectedIndexChanged += WeaponTypeChanged;
            comboBox1.TextChanged += WeaponTypeChanged;

            NameBox.TextChanged += (sender, e) => weapon.WeaponNameChanged(NameBox);
        }
        private void WeaponTypeChanged(object? sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            if (comboBox1.SelectedItem == null)
                weaponType = comboBox1.Text;
            else
                weaponType = comboBox1.SelectedItem.ToString() ?? "";
            weapon.Type = weaponType;

            int? count;
            switch (weaponType)
            {
                case "Melee":
                    count = 5;
                    splitContainer1.Size = new Size(1385, 300);

                    statBoxes = new StatBox[count.Value];
                    for (int i = 0; i < count; i++)
                    {
                        statBoxes[i] = new StatBox();
                        splitContainer1.Panel2.Controls.Add(statBoxes[i]);
                        statBoxes[i].Location = new Point(250 * i + 25, 0);
                    }
                    statBoxes[0].LabelText = "Weapon Base Damage";
                    statBoxes[0].InputBox.TextChanged += (sender, e) => weapon.WeaponBaseDamageChanged(statBoxes[0]);

                    statBoxes[1].LabelText = "Weapon Modifier";
                    statBoxes[1].WarningText.Dispose();
                    statBoxes[1].InputBox.TextChanged += (sender, e) => weapon.WeaponModifierChanged(statBoxes[1]);

                    statBoxes[2].LabelText = "Weapon Crit Chance";
                    statBoxes[2].InputBox.TextChanged += (sender, e) => weapon.WeaponCritChanceChanged(statBoxes[2]);

                    statBoxes[3].LabelText = "Weapon Base Use Time";
                    statBoxes[3].InputBox.TextChanged += (sender, e) => weapon.WeaponSpeedChanged(statBoxes[3]);

                    statBoxes[4].LabelText = "Weapon Use Delay";
                    statBoxes[4].InputBox.TextChanged += (sender, e) => weapon.WeaponDelayChanged(statBoxes[4]);
                    break;
                case "Ranged":
                    count = 6;
                    splitContainer1.Size = new Size(1385, 300);
                    break;
                case "Magic":
                    count = 6;
                    splitContainer1.Size = new Size(1385, 300);
                    break;
                case "Summoner":
                    count = 6;
                    splitContainer1.Size = new Size(1385, 300);
                    break;
                default:
                    weaponType = "";
                    splitContainer1.Size = new Size(1385, 110);
                    break;
            }
        }
    }
}
