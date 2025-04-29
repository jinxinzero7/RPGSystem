using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    internal class Arsenal
    {
        public List<Weapon> Weapons { get; set; }

        public Arsenal() 
        {
            Weapons = new List<Weapon>
            {
            new Weapon("Меч", 10, 1.6f),
            new Weapon("Лук", 25, 0.6f),
            new Weapon("Топор", 14, 1.3f)
            };
        }

        public Weapon GetWeapon(string name)
        {
            var weapon = Weapons.FirstOrDefault(w => w.Name == name);
            return weapon ?? throw new WeaponNotFoundException(name);
        }
    }
}
