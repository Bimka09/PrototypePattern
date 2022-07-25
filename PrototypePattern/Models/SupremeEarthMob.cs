using PrototypePattern.Interfaces;
using System;

namespace PrototypePattern.Models
{
    public class SupremeEarthMob : EarthMob, IMyCloneable<SupremeEarthMob>, ICloneable
    {
        public string Artefact { get; set; } = "Default Ring";

        public SupremeEarthMob() { }

        public SupremeEarthMob(SupremeEarthMob monster)
            : base(monster.Name, monster.Damage, monster.Defence, monster.Health, monster.MoneyDrop, monster.StoneDamage)
        {
            Artefact = monster.Artefact;
        }

        public SupremeEarthMob(string name, int damage, int defence, int health, int moneyDrop, int stoneDamage, string artefact)
            : base(name, damage, defence, health, moneyDrop, stoneDamage)
        {
            Artefact = artefact;
        }

        public override SupremeEarthMob Copy()
        {
            return new SupremeEarthMob(this);
        }
    }
}
