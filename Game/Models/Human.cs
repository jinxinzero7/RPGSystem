using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Human : Entity, IFightable
    {
        public string Name { get; set; }
        public Weapon? Weapon { get; set; }

        public Human(string name, int hp, int atck, Weapon? weapon) 
            : base (hp, atck)
        {
            Name = name;
            Weapon = weapon;
            if (weapon != null)
            {
                AttackDamage = (int)Math.Round(atck + (weapon.AttackBuff * weapon.AttackSpeed));
            }
            else
            {
                AttackDamage = atck;
            }
        }
        public override string ToString()
        {
            string weaponInfo = Weapon != null ? Weapon.ToString() : "Безоружный";
            return base.ToString() + $", Имя: {Name}, Оружие: {Weapon.Name}";
        }
    }
}
