using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public interface IFightable
    {
        int HealthPoints { get; set; }
        int AttackDamage { get; set; }
        void Fight(IFightable target);
    }
}
