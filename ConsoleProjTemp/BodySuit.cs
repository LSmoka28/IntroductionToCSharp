using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjTemp
{
    class BodySuit : Armor
    {
        public BodySuit(string _name, string _type, string _info, int _defense, string _rarity, int _price)
        {
            this.name = _name;
            this.type = _type;
            this.info = _info;
            this.defense = _defense;
            this.rarity = _rarity;
            this.price = _price;
        }

        public BodySuit()
        {

        }

    }
}
