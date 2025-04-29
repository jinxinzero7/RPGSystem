using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    internal interface IFigthable
    {
        public void Fight(IFightable target);
    }
}
