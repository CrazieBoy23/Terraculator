using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaCalculator
{
    public class WeaponStats
    {
        public int BaseDamage { get; set; }
        public float Speed { get; set; }
        public float CritChance { get; set; }
        public float Delay { get; set; }
        public WeaponStats Clone()
        {
            return new WeaponStats
            {
                BaseDamage = this.BaseDamage,
                CritChance = this.CritChance,
                Speed = this.Speed,
                Delay = this.Delay
            };
        }

        public WeaponStats ApplyModifier(StatModifier modifier)
        {
            var result = this.Clone();
            modifier.ApplyTo(result);
            return result;
        }
    }
}
