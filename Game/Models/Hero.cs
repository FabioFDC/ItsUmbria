using Game.Config;

namespace Game.Models
{
    public class Hero
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Inventory Inventory { get; set; }
        public int ActionPerTurn { get; set; }
        public int Health { get; set; }
        public HeroClass Class { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public double Speed { get; set; }
        public int MaxHealth { get; set; }
    }

    public class Inventory
    {
        public Weapon Gun { get; set; }
        public Weapon Melee { get; set; }
    }

    public class Weapon
    {
        public int MaxAmmo { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public int Range { get; set; }
        public int AmmoConsumption { get; set; }
        public int AccuracyPercentage { get; set; }
        public int Ammo { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public WeaponType WeaponType { get; set; }

    }

    public class HeroCreation
    {
        public string HeroName { get; set; }
        public HeroClass HeroClass { get; set; }
        public TeamColor HeroColor { get; set; }
    }
}

