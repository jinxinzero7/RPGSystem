using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    internal class Human : Entity, IFigthable
    {
        public string Name { get; set; }
        public Weapon? Weapon { get; set; }

        public Human(string name, Weapon? weapon, int hp, int atck) 
            : base (hp, atck)
        {
            Name = name;
            Weapon = weapon;
            HealthPoints = hp;
            if (weapon != null)
            {
                AttackDamage = atck + (weapon.AttackBuff * weapon.AttackSpeed);
            }
            else
            {
                AttackDamage = atck;
            }
        }
    }
}
