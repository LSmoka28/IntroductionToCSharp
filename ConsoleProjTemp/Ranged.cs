using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleProjTemp
{
    class Ranged : Weapon
    {
        public Ranged(string _name, string _type, string _info, int _pwr, string _rarity, int _price)
        {
            this.name = _name;
            this.type = _type;
            this.info = _info;
            this.attackPwr = _pwr;
            this.rarity = _rarity;
            this.price = _price;
        }
        public Ranged()
        {

        }
    }
}
