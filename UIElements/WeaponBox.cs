using System;
using System.Drawing;
using System.Windows.Forms;

namespace TerrariaCalculator
{
    public partial class WeaponBox : UserControl
    {
        private readonly Form1 _parentForm;
        private string _weaponType = string.Empty;
        private StatBox[] _statBoxes = Array.Empty<StatBox>();
        private Weapon weapon;
        public Weapon Weapon => weapon;
        public string WeaponNameText => NameBox.Text;

        public WeaponStats WeaponStats { get; private set; } = new WeaponStats();

        public WeaponBox(Form1 form)
        {
            InitializeComponent();
            _parentForm = form;
            weapon = new Weapon();

            InitializeWeaponTypeDropdown();
            NameBox.TextChanged += (sender, e) => {
                weapon.Name = NameBox.Text;
                NotifyOutputUpdate();
            };
        }

        private void InitializeWeaponTypeDropdown()
        {
            comboBox1.Items.AddRange(new string[] { "Melee", "Ranged", "Magic", "Summoner" });
            comboBox1.SelectedIndexChanged += WeaponTypeChanged;
            comboBox1.TextChanged += WeaponTypeChanged;
        }

        private void WeaponTypeChanged(object? sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            _weaponType = comboBox1.SelectedItem?.ToString() ?? comboBox1.Text;
            WeaponStats = new WeaponStats(); // reset

            if (_weaponType == "Melee")
                BuildMeleeInputs();
            // Add other weapon types later
        }

        private void BuildMeleeInputs()
        {
            _statBoxes = new StatBox[5];
            splitContainer1.Size = new Size(1385, 300);

            for (int i = 0; i < _statBoxes.Length; i++)
            {
                var statBox = new StatBox { Location = new Point(250 * i + 25, 0) };
                _statBoxes[i] = statBox;
                splitContainer1.Panel2.Controls.Add(statBox);
            }

            _statBoxes[0].LabelText = "Weapon Base Damage";
            _statBoxes[0].InputBox.TextChanged += (s, e) => {
                weapon.ApplyBaseDamage(_statBoxes[0].GetInput());
                NotifyOutputUpdate();
            };

            _statBoxes[1].LabelText = "Weapon Modifier";
            _statBoxes[1].WarningText.Dispose();
            _statBoxes[1].InputBox.TextChanged += (s, e) => {
                weapon.Modifier = _statBoxes[1].GetInput();
                NotifyOutputUpdate();
            };

            _statBoxes[2].LabelText = "Weapon Crit Chance";
            _statBoxes[2].InputBox.TextChanged += (s, e) => {
                weapon.ApplyCritChance(_statBoxes[2].GetInput());
                NotifyOutputUpdate();
            };

            _statBoxes[3].LabelText = "Weapon Base Use Time";
            _statBoxes[3].InputBox.TextChanged += (s, e) => {
                weapon.ApplySpeed(_statBoxes[3].GetInput());
                NotifyOutputUpdate();
            };

            _statBoxes[4].LabelText = "Weapon Use Delay";
            _statBoxes[4].InputBox.TextChanged += (s, e) => {
                weapon.ApplyDelay(_statBoxes[4].GetInput());
                NotifyOutputUpdate();
            };
        }

        private void NotifyOutputUpdate()
        {
            weapon.Name = NameBox.Text;
            weapon.Type = _weaponType;

            WeaponStats.BaseDamage = weapon.Stats.BaseDamage;
            WeaponStats.Speed = weapon.Stats.Speed;
            WeaponStats.CritChance = weapon.Stats.CritChance;
            WeaponStats.Delay = weapon.Stats.Delay;

            _parentForm?.UpdateAllOutputs();
        }

    }
}
