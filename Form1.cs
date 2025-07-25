using System.Windows.Forms;

namespace TerrariaCalculator
{
    public partial class Form1 : Form
    {
        private int StatBoxCount = 0;
        private int FlowContainerCount = 0;
        private int weaponCount = 0;
        private float relDamageMult = 0f;
        private float absDamageMult = 1f;
        private float relSpeedMult = 0f;
        private float absSpeedMult = 1f;
        private float relCritMult = 0f;
        private Weapon[] weapons = new Weapon[1000];
        private int accesoryCount = 0;
        private Accesory[] accessories = new Accesory[1000];
        private int outputCount = 0;
        private Output[] outputs = new Output[1000];
        private Label[] LabelBoxes;
        private FlowLayoutPanel[] panels;
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form_Resize;

            LabelBoxes = new Label[100];
            panels = new FlowLayoutPanel[100];

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
                    LabelBoxes[StatBoxCount++] = label;
                    label.Padding = new Padding(0, 25, 0, 25);
                }

                else if (control is Button button)
                {
                    button.FlatAppearance.BorderSize = 0;
                    button.Margin = new Padding(0, 25, 0, 25);
                }

                else if (control is FlowLayoutPanel flowLayoutPanel)
                {
                    panels[FlowContainerCount++] = flowLayoutPanel;
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
        private void table_Paint(object sender, PaintEventArgs e)
        {
            // Define border color and thickness
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
            WeaponBox weaponBox = new WeaponBox(this);
            InsertRow(table, table.GetRow(WeaponButton), weaponBox);
            weapons[weaponCount++] = weaponBox.weapon;

            Output output = new Output(this);
            InsertRow(table, table.RowCount - 1, output);
            outputs[outputCount++] = output;
            outputs[weaponCount - 1].WeaponName.Text = "Weapon " + (weaponCount);
        }

        private void AccSlot_Click(object sender, EventArgs e)
        {
            AccSlot accSlot = new AccSlot(this);
            InsertRow(table, table.GetRow(AccSlotButton), accSlot);
            accessories[accesoryCount++] = accSlot.accesory;
        }

        public void ChangeOutputName(Weapon weapon)
        {
            int id = Array.IndexOf(weapons, weapon);
            if (weapon.Apelative == "")
                outputs[id].WeaponName.Text = "Weapon " + (id + 1);
            else
                outputs[id].WeaponName.Text = weapon.Apelative;
        }

        public void CalculateDamageOutput(Weapon weapon)
        {
            float base_damage = 0;
            int id = Array.IndexOf(weapons, weapon);
            if (!string.IsNullOrEmpty(weapon.Damage))
            {
                float.TryParse(weapon.Damage, out float parsedBaseDamage);
                base_damage = (int)parsedBaseDamage;
            }
            if (base_damage == 0)
            {
                outputs[id].DamageOutput.Text = "0";
                return;
            }
            base_damage = ApplyDamageModifierBuff(weapon);

            float totalDamage = (int)(base_damage * (1 + relDamageMult / 100));
            totalDamage *= absDamageMult;
            totalDamage = (int)totalDamage;
            outputs[id].DamageOutput.Text = totalDamage.ToString("0");
            outputs[id].TryCalculateAvg();
        }
        public void CalculateDamageMult()
        {
            float damage_multiplier_rel = 0, damage_multiplier_abs = 1;
            if (accessories.Length != 0)
                for (int i = 0; i < accesoryCount; i++)
                    if (float.TryParse(accessories[i].Damage, out float parsedDamage))
                        if (!accessories[i].DamageRelative)
                            damage_multiplier_rel += parsedDamage;
                        else
                            damage_multiplier_abs *= parsedDamage;
                    else
                        continue;
            relDamageMult = damage_multiplier_rel;
            absDamageMult = damage_multiplier_abs;
            for (int i = 0; i < weaponCount; i++)
                CalculateDamageOutput(weapons[i]);
        }
        public float ApplyDamageModifierBuff(Weapon weapon)
        {
            string modifier = weapon.Modifier;
            float.TryParse(weapon.Damage, out float dmg);
            switch (modifier)
            {
                // Universal (melee-focus)
                case "Dangerous": dmg *= 1.05f; break;
                case "Savage": dmg *= 1.10f; break;
                case "Sharp": dmg *= 1.15f; break;
                case "Pointy": dmg *= 1.10f; break;
                case "Broken": dmg *= 0.70f; break;
                case "Damaged": dmg *= 0.85f; break;
                case "Shoddy": dmg *= 0.90f; break;

                // Speed-focused
                case "Bulky": dmg *= 1.05f; break;
                case "Awful": dmg *= 0.85f; break;

                case "Deadly": dmg *= 1.10f; break;
                case "Staunch": dmg *= 1.10f; break;

                case "Powerful": dmg *= 1.15f; break;
                case "Mystic": dmg *= 1.10f; break;
                case "Masterful": dmg *= 1.15f; break;

                // Major universal
                case "Godly":
                case "Demonic": dmg *= 1.15f; break;

                case "Legendary":
                case "Unreal": dmg *= 1.15f; break;

                case "Mythical": dmg *= 1.15f; break;

                // Negative modifiers
                case "Tiny":
                case "Small":
                case "Slow":
                case "Sluggish":
                case "Lazy": dmg *= 0.85f; break;

                case "Terrible": dmg *= 0.85f; break;

                case "Dull":
                case "Inept":
                case "Ignorant": dmg *= 0.90f; break;

                case "Unhappy":
                case "Awkward": dmg *= 0.90f; break;

                case "Annoying": dmg *= 0.80f; break;

                case "Manic": dmg *= 0.90f; break;

                case "Shameful": dmg *= 0.90f; break;

                case "Hurtful": dmg *= 1.10f; break;

                case "Unpleasant": dmg *= 1.05f; break;

                case "Weak": dmg *= 0.80f; break;

                case "Ruthless": dmg *= 1.18f; break;

                case "Frenzying": dmg *= 0.85f; break;

                // Fallback for unknown mods
                default:
                    break;
            }

            return dmg;
        }
        public void CalculateSpeedOutput(Weapon weapon)
        {
            float useTime = 0;
            int id = Array.IndexOf(weapons, weapon);
            if (!string.IsNullOrEmpty(weapon.Speed))
            {
                float.TryParse(weapon.Speed, out float speed);
                useTime = ApplySpeedModifierBuff(weapon);
            }
            if (useTime == 0)
            {
                outputs[id].SpeedOutput.Text = "-";
                outputs[id].AvgDamageOutput.Text = "-";
                return;
            }
            useTime = (int)Math.Round(useTime);
            float delay = float.TryParse(weapon.Delay, out float parsedDelay) ? parsedDelay : 0f;
            float totalSpeed = 60 / (((useTime / (1 + relSpeedMult / 100)) * absSpeedMult) + delay);
            outputs[id].SpeedOutput.Text = totalSpeed.ToString("0.###");
            outputs[id].TryCalculateAvg();
        }
        public void CalculateSpeedMult()
        {
            float speed_multiplier_rel = 0, speed_multiplier_abs = 1;
            if (accessories.Length != 0)
                for (int i = 0; i < accesoryCount; i++)
                    if (float.TryParse(accessories[i].Speed, out float parsedSpeed))
                        if (!accessories[i].SpeedRelative)
                            speed_multiplier_rel += parsedSpeed;
                        else
                            speed_multiplier_abs *= parsedSpeed;
                    else
                        continue;
            relSpeedMult = speed_multiplier_rel;
            absSpeedMult = speed_multiplier_abs;
            for (int i = 0; i < weaponCount; i++)
                CalculateSpeedOutput(weapons[i]);
        }
        public float ApplySpeedModifierBuff(Weapon weapon)
        {
            string modifier = weapon.Modifier;
            float.TryParse(weapon.Speed, out float useTime);
            switch (modifier)
            {
                // Universal (melee-focus)
                case "Heavy": useTime *= 1.05f; break;
                default:
                    break;
            }
            return useTime;
        }
        public void CalculateCritChanceOutput(Weapon weapon)
        {
            float critChance = 0;
            int id = Array.IndexOf(weapons, weapon);
            if (!string.IsNullOrEmpty(weapon.CritChance))
            {
                critChance = float.TryParse(weapon.CritChance, out float parsedCrit) ? parsedCrit : 0f;
            }

            critChance += relCritMult;
            outputs[id].CritChanceOutput.Text = critChance.ToString("0.##");
            outputs[id].TryCalculateAvg();
        }
        public float ApplyCritModifierBuff(Weapon weapon)
        {
            string modifier = weapon.Modifier;
            float.TryParse(weapon.CritChance, out float critChance);
            switch (modifier)
            {
                // Universal (melee-focus)
                case "Deadly": critChance += 5f; break;
                case "Unreal": critChance += 15f; break;
                case "Mythical": critChance += 20f; break;
                // Negative modifiers
                case "Unhappy": critChance -= 5f; break;
                case "Weak": critChance -= 10f; break;
                default:
                    break;
            }
            return critChance;
        }
        public void CalculateCritChanceMult()
        {
            float crit_multiplier = 0;
            if (accessories.Length != 0)
                for (int i = 0; i < accesoryCount; i++)
                    if (float.TryParse(accessories[i].CritChance, out float parsedCrit))
                        crit_multiplier += parsedCrit;
                    else
                        continue;
            relCritMult = crit_multiplier;
            for (int i = 0; i < weaponCount; i++)
                CalculateCritChanceOutput(weapons[i]);
        }
    }
}
