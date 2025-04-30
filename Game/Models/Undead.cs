using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Undead : Entity
    {
        public string? Name { get; set; }

        public Undead(int hp, int atck, string? name)
            : base(hp, atck)
        {
            if (name != null)
                Name = name;
            AttackDamage = atck;
            HealthPoints = hp;
        }
    }
}
