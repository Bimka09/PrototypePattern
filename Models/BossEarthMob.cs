using PrototypePattern.Interfaces;
using System;

namespace PrototypePattern.Models
{
    public class BossEarthMob : SupremeEarthMob, IMyCloneable<BossEarthMob>, ICloneable
    {
        public int Ultimate { get; set; } = default;

        public BossEarthMob() { }

        public BossEarthMob(BossEarthMob monster)
            : base(monster.Name, monster.Damage, monster.Defence, monster.Health, monster.MoneyDrop, monster.StoneDamage, monster.Artefact)
        {
            Ultimate = monster.Ultimate;
        }

        public BossEarthMob(string name, int damage, int defence, int health, int moneyDrop, int stoneDamage, string artefact, int ultimate)
            : base(name, damage, defence, health, moneyDrop, stoneDamage, artefact)
        {
            Ultimate = ultimate;
        }

        public override BossEarthMob Copy()
        {
            return new BossEarthMob(this);
        }

    }
}
