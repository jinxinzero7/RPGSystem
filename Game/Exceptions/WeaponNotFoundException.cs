using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class WeaponNotFoundException : Exception
    {
        public WeaponNotFoundException(string weaponName)
            : base($"Оружие с именем '{weaponName}' не найдено.")
        {

        }
    }
}
