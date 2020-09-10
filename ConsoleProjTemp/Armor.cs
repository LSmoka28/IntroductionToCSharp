using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleProjTemp
{
    class Armor
    {
        public string name;
        public string type;
        public string info;
        public int defense;
        public string rarity;
        public int price;


        public override string ToString()
        {
            return $"____________________\n- {name} -\nType: {type}\nDescription:\n{info}\nDefense: {defense} pts\nRarity: {rarity}\nCost: {price} units\n";
        }
        
    }
}
