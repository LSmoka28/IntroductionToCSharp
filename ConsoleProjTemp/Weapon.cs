using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleProjTemp
{
    class Weapon
    {
        //-------weapon - displays name, type, info, attack power, rarity, and cost
        public string name;
        public string type;
        public string info;
        public int attackPwr;
        public string rarity;
        public int price;


        public override string ToString()
        {
            return $"____________________\n- {name} -\nType: {type}\nDescription:\n{info}\nDamage: {attackPwr} pts\nRarity: {rarity}\nCost: {price} units\n";
        }

    }
}
