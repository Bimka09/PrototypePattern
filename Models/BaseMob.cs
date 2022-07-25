using PrototypePattern.Interfaces;
using System;

namespace PrototypePattern.Models
{
    public class BaseMob: IMyCloneable<BaseMob>, ICloneable
    {
        public string Name { get; set; } = "Default Name";
        public int Damage { get; set; }
        public int Defence { get; set; }
        public int Health { get; set; }
        public int MoneyDrop { get; set; }

        public BaseMob() { }

        public BaseMob(BaseMob monster)
        {
            Name = monster.Name;
            Damage = monster.Damage;
            Defence = monster.Defence;
            Health = monster.Health;
            MoneyDrop = monster.MoneyDrop;
        }

        public BaseMob(string name, int damage, int defence, int health, int moneyDrop)
        {
            Name = name;
            Damage = damage;
            Defence = defence;
            Health = health;
            MoneyDrop = moneyDrop;
        }

        public virtual int Attack()
        {
            return Damage;
        }

        public virtual BaseMob Copy()
        {
            return new BaseMob(this);
        }

        public object Clone()
        {
            return Copy();
        }
    }
}
