using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaCalculator
{
    public class Weapon
    {
        private string weaponType = "";
        public string Type
        {
            get => weaponType;
            set => weaponType = value;
        }

        private string weaponName = "";
        public string Apelative
        {
            get => weaponName;
            set => weaponName = value;
        }

        private string weaponModifier = "";
        public string Modifier
        {
            get => weaponModifier;
            set => weaponModifier = value;
        }

        private string weaponDamage = "";
        public string Damage
        {
            get => weaponDamage;
            set => weaponDamage = value;
        }

        private string weaponCritChance = "";
        public string CritChance
        {
            get => weaponCritChance;
            set => weaponCritChance = value;
        }

        private string weaponSpeed = "";
        public string Speed
        {
            get => weaponSpeed;
            set => weaponSpeed = value;
        }
        private string weaponDelay = "";
        public string Delay
        {
            get => weaponDelay;
            set => weaponDelay = value;
        }
        private Form1 _parentForm;
        public Weapon(Form1 form)
        {
            _parentForm = form;
        }
        public void WeaponTypeChanged(string type)
        {
            this.Type = type;
        }
        public void WeaponNameChanged(TextBox NameBox)
        {
            this.Apelative = NameBox.Text;
            _parentForm.ChangeOutputName(this);
        }
        public void WeaponBaseDamageChanged(StatBox stat)
        {
            this.Damage = stat.GetInput();
            _parentForm.CalculateDamageOutput(this);
        }
        public void WeaponModifierChanged(StatBox stat)
        {
            this.Modifier = stat.InputBox.Text;
            float.TryParse(Damage, out float dmg);
            if (dmg != _parentForm.ApplyDamageModifierBuff(this))
                _parentForm.CalculateDamageOutput(this);
            float.TryParse(Speed, out float spd);
            if (spd != _parentForm.ApplySpeedModifierBuff(this))
                _parentForm.CalculateSpeedOutput(this);
            float.TryParse(CritChance, out float crit);
            if(crit != _parentForm.ApplyCritModifierBuff(this))
                _parentForm.CalculateCritChanceOutput(this);
        }
        public void WeaponCritChanceChanged(StatBox stat)
        {
            this.CritChance = stat.GetInput();
            _parentForm.CalculateCritChanceOutput(this);
        }
        public void WeaponSpeedChanged(StatBox stat)
        {
            this.Speed = stat.GetInput();
            _parentForm.CalculateSpeedOutput(this);
        }
        public void WeaponDelayChanged(StatBox stat)
        {
            this.Delay = stat.GetInput();
            _parentForm.CalculateSpeedOutput(this);
        }
    }
}
