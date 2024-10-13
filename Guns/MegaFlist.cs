using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVers.Guns
{
    internal class MegaFlist(int id, int price, string name, string type="Flist", int damage=70) : Weapon(id, price, name, type, damage)
    {
    }
}
