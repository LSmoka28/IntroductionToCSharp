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
        // set the player and shop bank amount
        public int shopBank;
        public int playerBank;

        // TODO: set up player array 
        // TODO: create method transfer data between player and shop 




        static void Main(string[] args)
        {
            //load csvs of inventory
            Weapon[] shopInventory = LoadWeapon("WeaponsSpread1.csv");
            Armor[] shopArmor = LoadArmor("armor.csv");
           
            bool gameRunning = true;

            //store intro message
            Console.WriteLine("Welcome to Fantasy Fanatics!");
            Console.WriteLine("What would you like to do?");

           while (gameRunning)
            {
                Console.WriteLine("Please make a selection...");
                string input = Console.ReadLine();

                // input command cases
                switch (input)
                {
                    // shop and show weapons
                    case "show weap":
                    case "weapons":
                    case "weap":
                        Console.WriteLine($"\n----WEAPONS----\n     vvvvv    ");
                        foreach (Weapon weap in shopInventory)
                        {
                            Console.WriteLine(weap);
                        }
                        Console.WriteLine($"\n     ^^^^^    \n----WEAPONS----\n");
                        break;

                    // shop and show armor
                    case "armor":
                    case "shield":
                    case "defense":
                        Console.WriteLine($"\n----ARMOR----\n     vvv    ");
                        foreach (Armor suit in shopArmor)
                        {
                            Console.WriteLine(suit);
                        }
                        Console.WriteLine($"\n     ^^^    \n----ARMOR----\n");
                        break;

                    //full shop inventory
                    case "shop":
                        Console.WriteLine($"\n----WEAPONS----\n     vvvvv    ");
                        foreach (Weapon weap in shopInventory)
                        {
                            Console.WriteLine(weap);
                        }
                        Console.WriteLine($"\n     ^^^^^    \n----WEAPONS----\n");
                        Console.WriteLine($"\n----ARMOR----\n     vvv    ");
                        foreach (Armor suit in shopArmor)
                        {
                            Console.WriteLine(suit);
                        }
                        Console.WriteLine($"\n     ^^^    \n----ARMOR----\n");
                        break;


                    // help commands and instructions 
                    // TODO: add instructions 
                    case "help":
                    case "commands":
                    case "inputs":
                        Console.WriteLine($"__________________\nThe current valid commands you can type in are:\n" +
                            $"-armor, shield, defense - shows current shop armor inventory \n" +
                            $"-bag, i, inv, inventory, - shows current player inventory \n" +
                            $"-weapons, show weap - shows current shop weapon inventory \n" +
                            $"-shop, buy, purchase - shows the full available inventory \n" +
                            $"-help, commands, inputs - shows the help screen \n" +
                            $"-quit, leave, bye - closes the shop and window \n");
                        break;

                    // quit and esc commands
                    case "esc":
                    case "quit":
                    case "leave":
                    case "bye":
                        Console.WriteLine($"Thanks for shopping with us! Please come again.");
                        gameRunning = false;
                        break;




                }
            }

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

        private static Armor[] LoadArmor(string filename)
        {
            Armor[] tmpArr;

            string[] lines = File.ReadAllLines(filename);

            tmpArr = new Armor[lines.Length - 1];
            for (int i =1; i < lines.Length; i++)
            {
                string[] lineVal = lines[i].Split(',');
                if (lineVal[1] == "Body")
                {
                    BodySuit tmpBody = new BodySuit();
                    tmpBody.name = lineVal[0];
                    tmpBody.type = lineVal[1];
                    tmpBody.info = lineVal[2];
                    tmpBody.rarity = lineVal[4];

                    if (lineVal[3] != "")
                    {
                        int.TryParse(lineVal[3], out tmpBody.defense);
                    }
                    if (lineVal[5] != "")
                    {
                        int.TryParse(lineVal[5], out tmpBody.price);
                    }
                    tmpArr[i - 1] = tmpBody;
                }

                else
                {
                    Shield tmpShield = new Shield();
                    tmpShield.name = lineVal[0];
                    tmpShield.type = lineVal[1];
                    tmpShield.info = lineVal[2];
                    tmpShield.rarity = lineVal[4];

                    if (lineVal[3] != "")
                    {
                        int.TryParse(lineVal[3], out tmpShield.defense);
                    }
                    if (lineVal[5] != "")
                    {
                        int.TryParse(lineVal[5], out tmpShield.price);
                    }
                    tmpArr[i - 1] = tmpShield;

                }
                
            }
            return tmpArr;
        }



    }


}
