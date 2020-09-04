using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace ConsoleProjTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon[] shopInventory = LoadWeapon("WeaponsSpread1.csv");
            bool gameRunning = true;


            Console.WriteLine("Welcome to Fantasy Fanatics!");
            Console.WriteLine("Please make a selection...");

           while (gameRunning)
            {
                Console.WriteLine("What would you like to do?");
                string input = Console.ReadLine();

                switch (input)
                {

                    case "show bag":
                    case "show inv":
                    case "bag":
                    case "inv":
                        foreach (Weapon weap in shopInventory)
                        {
                            Console.WriteLine(weap);
                        }
                        break;

                }
            }



            // selelction options: 
            //shop- show inv of shop keeper and prompt player to view or buy
            //---- view- shows weapon/armor stats
            //-------weapon - displays name, type, attack power, rarity, and cost
            //-------armor  - displays name, type, shield power, rarity, and cost
            //inv- show inventory and wallet of player
            //sell- show current inv and prompt player for a selection
            //

            Console.ReadKey();
        }
        private static Weapon[] LoadWeapon(string filename)
        {
            Weapon[] tmpArr;

            string[] lines = File.ReadAllLines(filename);

            tmpArr = new Weapon[lines.Length - 1];
            for (int i = 1; i < lines.Length; i++)
            {
                string[] lineValues = lines[i].Split(',');

                if (lineValues[1] == "Melee")
                {
                    //Create melee weapon

                    Melee tmpMelee = new Melee();
                    tmpMelee.name = lineValues[0];
                    tmpMelee.type = lineValues[1];
                    tmpMelee.info = lineValues[2];
                    tmpMelee.rarity = lineValues[4];

                    if (lineValues[3] != "")
                    {
                        int.TryParse(lineValues[3], out tmpMelee.attackPwr);
                    }
                    if (lineValues[5] != "")
                    {
                        int.TryParse(lineValues[5], out tmpMelee.price);
                    }
                    tmpArr[i - 1] = tmpMelee;

                }
                else
                {
                    //ranged if not melee
                    Ranged tmpRanged = new Ranged();
                    tmpRanged.name = lineValues[0];
                    tmpRanged.type = lineValues[1];
                    tmpRanged.info = lineValues[2];
                    tmpRanged.rarity = lineValues[4];

                    if (lineValues[3] != "")
                    {
                        int.TryParse(lineValues[3], out tmpRanged.attackPwr);
                    }
                    if (lineValues[5] != "")
                    {
                        int.TryParse(lineValues[5], out tmpRanged.price);
                    }
                    tmpArr[i - 1] = tmpRanged;
                }

            }
            return tmpArr;
        }



    }


}
