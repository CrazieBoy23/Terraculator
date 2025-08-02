using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaCalculator
{
    public class StatModifier
    {
        public float DamageFlat { get; set; } = 0;
        public float DamageMultiplier { get; set; } = 1;

        public float CritChanceFlat { get; set; } = 0;
        public float CritChanceMultiplier { get; set; } = 1;

        public float SpeedFlat { get; set; } = 0;
        public float SpeedMultiplier { get; set; } = 1;

        public void ApplyTo(WeaponStats stats)
        {
            stats.BaseDamage = (int)((stats.BaseDamage + DamageFlat) * DamageMultiplier);
            stats.CritChance = (stats.CritChance + CritChanceFlat) * CritChanceMultiplier;
            stats.Speed = (stats.Speed + SpeedFlat) * SpeedMultiplier;
        }

        public void Combine(StatModifier other)
        {
            DamageFlat += other.DamageFlat;
            DamageMultiplier *= other.DamageMultiplier;

            CritChanceFlat += other.CritChanceFlat;
            CritChanceMultiplier *= other.CritChanceMultiplier;

            SpeedFlat += other.SpeedFlat;
            SpeedMultiplier *= other.SpeedMultiplier;
        }
        public StatModifier GetModifierFromAccessory(Accesory accessory)
        {
            var mod = new StatModifier();

            if (float.TryParse(accessory.Damage, out float dmg))
            {
                if (accessory.DamageRelative)
                    mod.DamageMultiplier += dmg / 100f;
                else
                    mod.DamageFlat += dmg;
            }

            if (float.TryParse(accessory.CritChance, out float crit))
                mod.CritChanceFlat += crit;

            if (float.TryParse(accessory.Speed, out float spd))
            {
                if (accessory.SpeedRelative)
                    mod.SpeedMultiplier += spd / 100f;
                else
                    mod.SpeedFlat += spd;
            }

            return mod;
        }
    }
}
