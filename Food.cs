using FinalVers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameeE
{
    internal class Food(int id, int price, string name, int healingPoint, string type="Food", bool useable = true) : Item(id, price, name, type, useable)
    {
        public string Name = name;
        public int HealingPoints = healingPoint;
        public bool Useable = useable;


    }
}
