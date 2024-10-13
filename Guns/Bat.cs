using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVers.Guns
{
    internal class Bat(int id, int price, string name, int damage=10,string type="Cold Weapon") : Weapon(id, price, name, type, damage)
    {

        public readonly int damage = damage;

    }
}
