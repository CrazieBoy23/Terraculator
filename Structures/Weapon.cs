namespace TerrariaCalculator
{
    public class Weapon
    {
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public string Modifier { get; set; } = "";
        public WeaponStats Stats { get; set; } = new WeaponStats();

        public void ApplyBaseDamage(string input)
        {
            if (int.TryParse(input, out int damage))
                Stats.BaseDamage = damage;
        }

        public void ApplyCritChance(string input)
        {
            if (float.TryParse(input, out float crit))
                Stats.CritChance = crit;
        }

        public void ApplySpeed(string input)
        {
            if (float.TryParse(input, out float speed))
                Stats.Speed = speed;
        }

        public void ApplyDelay(string input)
        {
            if (float.TryParse(input, out float delay))
                Stats.Delay = delay;
        }

        public void Reset()
        {
            Stats = new WeaponStats();
        }
    }
}
