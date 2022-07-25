using PrototypePattern.Interfaces;
using System;

namespace PrototypePattern.Models
{
    public class EarthMob : BaseMob, IMyCloneable<EarthMob>, ICloneable
    {
        public int StoneDamage { get; set; }
        public int TotalDamage { get; private set; }

        public EarthMob() { }

        public EarthMob(EarthMob monster)
            : base(monster.Name, monster.Damage, monster.Defence, monster.Health, monster.MoneyDrop)
        {
            StoneDamage = monster.StoneDamage;
            TotalDamage = Damage + StoneDamage;
        }

        public EarthMob(string name, int damage, int defence, int health, int moneyDrop, int stoneDamage)
            : base(name, damage, defence, health, moneyDrop)
        {
            StoneDamage = stoneDamage;
            TotalDamage = Damage + StoneDamage;
        }

        public override int Attack()
        {
            return TotalDamage;
        }

        public override EarthMob Copy()
        {
            return new EarthMob(this);
        }
    }}
