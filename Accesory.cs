using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaCalculator
{
    public class Accesory
    {
        private string accesoryModifier = "";
        public string Modifier
        {
            get => accesoryModifier;
            set => accesoryModifier = value;
        }

        private string accesoryDamageMultiplier = "";
        public string Damage
        {
            get => accesoryDamageMultiplier;
            set => accesoryDamageMultiplier = value;
        }
        private bool damageMultiplierRelative = true;
        public bool DamageRelative
        {
            get => damageMultiplierRelative;
            set => damageMultiplierRelative = value;
        }

        private string accesoryCritChanceMultiplier = "";
        public string CritChance
        {
            get => accesoryCritChanceMultiplier;
            set => accesoryCritChanceMultiplier = value;
        }

        private string accesorySpeedMultiplier = "";
        public string Speed
        {
            get => accesorySpeedMultiplier;
            set => accesorySpeedMultiplier = value;
        }
        private bool speedRelative = true;
        public bool SpeedRelative
        {
            get => speedRelative;
            set => speedRelative = value;
        }
        private Form1 _parentForm;
        public Accesory(Form1 form)
        {
            _parentForm = form;
        }
        public void AccesoryModifierChanged(StatBox stat)
        {
            this.Modifier = stat.GetInput();
        }
        public void AccesoryDamageMultiplierChanged(StatBox stat)
        {
            this.Damage = stat.GetInput();
            _parentForm.CalculateDamageMult();
        }
        public void DamageRelativityChanged(CheckBox stat)
        {
            this.DamageRelative = !stat.Checked;
            _parentForm.CalculateDamageMult();
        }
        public void AccesoryCritChanceMultiplierChanged(StatBox stat)
        {
            this.CritChance = stat.GetInput();
            _parentForm.CalculateCritChanceMult();
        }
        public void AccesorySpeedMultiplierChanged(StatBox stat)
        {
            this.Speed = stat.GetInput();
            _parentForm.CalculateSpeedMult();
        }
        public void SpeedRelativityChangedd(CheckBox stat)
        {
            this.speedRelative = !stat.Checked;
            _parentForm.CalculateSpeedMult();
        }
    }
}
