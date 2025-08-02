using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaCalculator
{
    public partial class AccSlot : UserControl
    {
        private string accesoryType = "";
        private CheckBox[] damageRelativityCheckBox = new CheckBox[10];
        private StatBox[] statBoxes = new StatBox[16];
        public Accesory accesory;

        public AccSlot(Form1 form)
        {
            InitializeComponent();
            splitContainer1.Size = new Size(1385, 110);
            accesory = new Accesory(form);

            comboBox1.Items.Add("Accesory");
            comboBox1.Items.Add("Armor");
            comboBox1.Items.Add("Buff");

            comboBox1.SelectedIndexChanged += AccesoryTypeChanged;
            comboBox1.TextChanged += AccesoryTypeChanged;
        }
        private void AccesoryTypeChanged(object? sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            if (comboBox1.SelectedItem == null)
                accesoryType = comboBox1.Text;
            else
                accesoryType = comboBox1.SelectedItem.ToString() ?? "";

            int count = 6;
            switch (accesoryType)
            {
                case "Accesory":
                    count = 4;
                    splitContainer1.Size = new Size(1385, 300);

                    for (int i = 0; i < count; i++)
                    {
                        statBoxes[i] = new StatBox();
                        splitContainer1.Panel2.Controls.Add(statBoxes[i]);
                        statBoxes[i].Location = new Point(250 * i + 25, 0);
                    }
                    statBoxes[0].LabelText = "Accesory Modifier";
                    statBoxes[0].InputBox.TextChanged += (s, e) => accesory.AccesoryModifierChanged(statBoxes[0]);

                    statBoxes[1].LabelText = "Accesory Damage Multiplier";
                    statBoxes[1].InputBox.TextChanged += (s, e) => accesory.AccesoryDamageMultiplierChanged(statBoxes[1]);

                    statBoxes[2].LabelText = "Accesory Crit% Multiplier";
                    statBoxes[2].InputBox.TextChanged += (s, e) => accesory.AccesoryCritChanceMultiplierChanged(statBoxes[2]);

                    statBoxes[3].LabelText = "Accesory Speed Multiplier";
                    statBoxes[3].InputBox.TextChanged += (s, e) => accesory.AccesorySpeedMultiplierChanged(statBoxes[3]);

                    damageRelativityCheckBox[0] = new CheckBox
                    {
                        Text = "Is Damage Absolute?",
                        AutoSize = true,
                        Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Location = new Point(250 * 4 + 25, 33),
                        Checked = false
                    };
                    damageRelativityCheckBox[0].CheckedChanged += (s, e) => accesory.DamageRelativityChanged(damageRelativityCheckBox[0]);
                    splitContainer1.Panel2.Controls.Add(damageRelativityCheckBox[0]);

                    damageRelativityCheckBox[1] = new CheckBox
                    {
                        Text = "Is Speed Absolute?",
                        AutoSize = true,
                        Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Location = new Point(250 * 4 + 25, 66),
                        Checked = false
                    };
                    damageRelativityCheckBox[1].CheckedChanged += (s, e) => accesory.SpeedRelativityChangedd(damageRelativityCheckBox[1]);
                    splitContainer1.Panel2.Controls.Add(damageRelativityCheckBox[1]);
                    break;
                case "Armor":
                    {
                        int armorCount = 4;
                        int totalArmorBoxes = armorCount * 5;
                        statBoxes = new StatBox[totalArmorBoxes];

                        splitContainer1.Size = new Size(1385, 1100);

                        for (int j = 0; j < 5; j++)
                        {
                            for (int i = 0; i < armorCount; i++)
                            {
                                int index = armorCount * j + i;
                                statBoxes[index] = new StatBox();
                                splitContainer1.Panel2.Controls.Add(statBoxes[index]);
                                statBoxes[index].Location = new Point(250 * i + 25, j * 200);
                            }

                            int baseIndex = armorCount * j;

                            statBoxes[baseIndex + 0].LabelText = "Accesory Modifier";
                            statBoxes[baseIndex + 0].InputBox.TextChanged += (s, e) => accesory.AccesoryModifierChanged(statBoxes[baseIndex + 0]);

                            statBoxes[baseIndex + 1].LabelText = "Accesory Damage Multiplier";
                            statBoxes[baseIndex + 1].InputBox.TextChanged += (s, e) => accesory.AccesoryDamageMultiplierChanged(statBoxes[baseIndex + 1]);

                            statBoxes[baseIndex + 2].LabelText = "Accesory Crit% Multiplier";
                            statBoxes[baseIndex + 2].InputBox.TextChanged += (s, e) => accesory.AccesoryCritChanceMultiplierChanged(statBoxes[baseIndex + 2]);

                            statBoxes[baseIndex + 3].LabelText = "Accesory Speed Multiplier";
                            statBoxes[baseIndex + 3].InputBox.TextChanged += (s, e) => accesory.AccesorySpeedMultiplierChanged(statBoxes[baseIndex + 3]);

                            damageRelativityCheckBox[2 * j + 0] = new CheckBox
                            {
                                Text = "Is Damage Absolute?",
                                AutoSize = true,
                                Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                                Location = new Point(250 * 4 + 25, 33 + j * 200),
                                Checked = false
                            };
                            damageRelativityCheckBox[2 * j + 0].CheckedChanged += (s, e) => accesory.DamageRelativityChanged(damageRelativityCheckBox[2 * j + 0]);
                            splitContainer1.Panel2.Controls.Add(damageRelativityCheckBox[2 * j + 0]);

                            damageRelativityCheckBox[2 * j + 1] = new CheckBox
                            {
                                Text = "Is Speed Absolute?",
                                AutoSize = true,
                                Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                                Location = new Point(250 * 4 + 25, 66 + j * 200),
                                Checked = false
                            };
                            damageRelativityCheckBox[2 * j + 1].CheckedChanged += (s, e) => accesory.SpeedRelativityChangedd(damageRelativityCheckBox[2 * j + 1]);
                            splitContainer1.Panel2.Controls.Add(damageRelativityCheckBox[2 * j + 1]);
                        }
                        break;
                    }
                case "Buff":
                    count = 6;
                    splitContainer1.Size = new Size(1385, 300);
                    break;
                default:
                    accesoryType = "";
                    splitContainer1.Size = new Size(1385, 110);
                    break;
            }
        }
    }
}
