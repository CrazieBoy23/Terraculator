using System;
using System.Drawing;
using System.Windows.Forms;
using TerrariaCalculator.Helpers;

namespace TerrariaCalculator
{
    public partial class Output : UserControl
    {
        public Output()
        {
            InitializeComponent();
        }

        public void DisplayStats(WeaponStats stats)
        {
            damageOutput.Text = stats.BaseDamage.ToString();
            speedOutput.Text = stats.Speed.ToString("0.##");
            critChanceOutput.Text = stats.CritChance.ToString("0.#");

            if (stats.Speed > 0)
                avgDamageOutput.Text = DpsCalculator.CalculateDps(stats).ToString("0.###");
            else
                avgDamageOutput.Text = "-";
        }

        public void SetWeaponName(string name)
        {
            if (string.IsNullOrEmpty(name))
                name = "Weapon";
            weaponName.Text = name;
        }
    }
}
