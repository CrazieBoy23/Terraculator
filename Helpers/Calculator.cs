using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaCalculator
{
    public static class DpsCalculator
    {
        public static float CalculateDps(WeaponStats stats)
        {
            return stats.BaseDamage * (1 + stats.CritChance / 100f) * stats.Speed;
        }
        public static StatModifier GetModifierFromAccessory(Accesory acc)
        {
            var mod = new StatModifier();

            if (float.TryParse(acc.Damage, out float dmg))
            {
                if (acc.DamageRelative)
                    mod.DamageMultiplier += dmg / 100f;
                else
                    mod.DamageFlat += dmg;
            }

            if (float.TryParse(acc.CritChance, out float crit))
                mod.CritChanceFlat += crit;

            if (float.TryParse(acc.Speed, out float spd))
            {
                if (acc.SpeedRelative)
                    mod.SpeedMultiplier += spd / 100f;
                else
                    mod.SpeedFlat += spd;
            }

            return mod;
        }

        public static StatModifier GetModifierFromWeapon(Weapon weapon)
        {
            var mod = new StatModifier();
            string name = weapon.Modifier?.Trim() ?? "";

            switch (name)
            {
                case "Savage":
                    mod.DamageMultiplier += 0.10f;
                    break;
                case "Godly":
                case "Demonic":
                case "Legendary":
                case "Unreal":
                case "Mythical":
                    mod.DamageMultiplier += 0.15f;
                    break;
                case "Weak":
                    mod.DamageMultiplier -= 0.20f;
                    break;
                case "Deadly":
                    mod.CritChanceFlat += 5f;
                    break;
                case "Heavy":
                    mod.SpeedMultiplier -= 0.05f;
                    break;
                // Add more based on Terraria modifier list
                default:
                    break;
            }

            return mod;
        }
    }
}
