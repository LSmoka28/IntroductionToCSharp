using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using CsvHelper;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleProjTemp
{
    class Program
    {
        // set the player and shop bank amount
        static public int shopBank = 1000;
        static public int playerBank = 1000;

        // TODO: set up player array 
        // TODO: create method transfer data between player and shop 
        static public int weaponNumber = 0;
        static public int armorNumber = 0;







        static void Main(string[] args)
        {
            
            Weapon.WeaponStruct[] shopWeapInv;
            Armor.ArmorStruct[] shopArmorInv;

            // create an empty list to add armor and weapons from shop
            List<Player.WeaponInv> myWeaps = new List<Player.WeaponInv>();
            List<Player.ArmorInv> myArmors = new List<Player.ArmorInv>();



            using (var reader = new StreamReader("WeaponsSpread1.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    IEnumerable<Weapon.WeaponStruct> weaps = csv.GetRecords<Weapon.WeaponStruct>();
                    shopWeapInv = weaps.ToArray<Weapon.WeaponStruct>();
                }
            }
            using (var reader = new StreamReader("armor.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    IEnumerable<Armor.ArmorStruct> suits = csv.GetRecords<Armor.ArmorStruct>();
                    shopArmorInv = suits.ToArray<Armor.ArmorStruct>();
                }
            }

            //convert weapon and armor array to list
            List<Weapon.WeaponStruct> weaponList = shopWeapInv.ToList<Weapon.WeaponStruct>();
            List<Armor.ArmorStruct> armorList = shopArmorInv.ToList<Armor.ArmorStruct>();
            


            //load csvs of inventory
            //Weapon[] shopWeapons = LoadWeapon("WeaponsSpread1.csv");
            //Armor[] shopArmor = LoadArmor("armor.csv");
           
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
                        Console.WriteLine($"\n");
                        Console.WriteLine($"\n----WEAPONS----\n     vvvvv    \n");
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            Console.WriteLine($"-{tmpWeap.Name}- {weaponNumber}\n_______________");

                        }
                        weaponNumber = 0;
                        Console.WriteLine($"\n     ^^^^^    \n----WEAPONS----\n");
                        break;

                    #region weaponNumber Cases
                    case "w1":
                        //view weapon 1 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 1)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                Console.WriteLine("Would you like to buy this weapon?");
                                input = Console.ReadLine();
                                if (input == "y" || input == "Y")
                                {
                                    weaponList.Remove(tmpWeap);

                                                                      
                                    playerBank -= tmpWeap.Price;
                                    shopBank += tmpWeap.Price;
                                    
                                    Console.WriteLine($"You now own {tmpWeap.Name}\nYou currently have {playerBank} unit left in your bank\n");
                                    
                                }
                                if (input == "n" || input == "N")
                                {
                                    break;
                                }
                                break;
                            }                          
                        }
                        break;
                    case "w2":
                        //view weapon 2 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 2)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                break;
                            }

                        }
                        break;
                    case "w3":
                        //view weapon 3 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 3)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                break;
                            }
                            

                        }
                        break;
                    case "w4":
                        //view weapon 4 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 4)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "w5":
                        //view weapon 5 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 5)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "w6":
                        //view weapon 6 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 6)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "w7":
                        //view weapon 7 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 7)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "w8":
                        //view weapon 8 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 8)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "w9":
                        //view weapon 9 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 9)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "w10":
                        //view weapon 10 and all its details 
                        foreach (Weapon.WeaponStruct tmpWeap in weaponList)
                        {
                            weaponNumber++;
                            if (weaponNumber == 10)
                            {
                                Console.WriteLine($"____________________\n- {tmpWeap.Name} -\n" +
                                    $"Type: {tmpWeap.Type}\n" +
                                    $"Description:\n{tmpWeap.Info}\n" +
                                    $"Damage: {tmpWeap.AttackPwr} pts\n" +
                                    $"Rarity: {tmpWeap.Rarity}\n" +
                                    $"Cost: {tmpWeap.Price} units\n");
                                weaponNumber = 0;
                                break;
                            }
                        }
                        break;
                    #endregion

                    // shop and show armor
                    case "armor":
                    case "shield":
                    case "defense":
                        Console.WriteLine($"\n");
                        Console.WriteLine($"\n----ARMOR----\n     vvv    \n");
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            Console.WriteLine($"-{tmpArmor.Name}- {armorNumber}\n_______________");

                        }
                        armorNumber = 0;
                        Console.WriteLine($"\n     ^^^    \n----ARMOR----\n");
                        break;

                    #region armorNumber Cases
                    case "a1":
                        //view armor 1 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {                                                
                            armorNumber++;
                            if (armorNumber == 1)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "a2":
                        //view armor 2 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            if (armorNumber == 2)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "a3":
                        //view armor 3 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            if (armorNumber == 3)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "a4":
                        //view armor 4 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            if (armorNumber == 4)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "a5":
                        //view armor 5 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            if (armorNumber == 5)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "a6":
                        //view armor 6 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            if (armorNumber == 6)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "a7":
                        //view armor 7 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            if (armorNumber == 7)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "a8":
                        //view armor 8 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            if (armorNumber == 8)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "a9":
                        //view armor 9 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            if (armorNumber == 9)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    case "a10":
                        //view armor 10 and all its details 
                        foreach (Armor.ArmorStruct tmpArmor in armorList)
                        {
                            armorNumber++;
                            if (armorNumber == 10)
                            {
                                Console.WriteLine($"____________________\n- {tmpArmor.Name} -\n" +
                                    $"Type: {tmpArmor.Type}\n" +
                                    $"Description:\n{tmpArmor.Info}\n" +
                                    $"Defense: {tmpArmor.Defense} pts\n" +
                                    $"Rarity: {tmpArmor.Rarity}\n" +
                                    $"Cost: {tmpArmor.Price} units\n");
                                armorNumber = 0;
                                break;
                            }
                        }
                        break;
                    #endregion

                    //full shop inventory, no buying
                    case "shop":
                        Console.WriteLine($"\n");
                        Console.WriteLine($"\n----WEAPONS----\n     vvvvv    \n");
                        foreach (Weapon.WeaponStruct tmpWeap in shopWeapInv)
                        {

                            Console.WriteLine($"-{tmpWeap.Name}-\n_______________");

                        }
                        Console.WriteLine($"\n     ^^^^^    \n----WEAPONS----\n");
                        Console.WriteLine($"\n");
                        Console.WriteLine($"\n----ARMOR----\n     vvv    \n");
                        foreach (Armor.ArmorStruct tmpArmor in shopArmorInv)
                        {

                            Console.WriteLine($"-{tmpArmor.Name}-\n_______________");

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
        //private static Weapon[] LoadWeapon(string filename)
        //{
        //    Weapon[] tmpArr;

        //    string[] lines = File.ReadAllLines(filename);

        //    tmpArr = new Weapon[lines.Length - 1];
        //    for (int i = 1; i < lines.Length; i++)
        //    {
        //        string[] lineValues = lines[i].Split(',');

        //        if (lineValues[1] == "Melee")
        //        {
        //            //Create melee weapon

        //            Melee tmpMelee = new Melee();
        //            tmpMelee.name = lineValues[0];
        //            tmpMelee.type = lineValues[1];
        //            tmpMelee.info = lineValues[2];
        //            tmpMelee.rarity = lineValues[4];

        //            if (lineValues[3] != "")
        //            {
        //                int.TryParse(lineValues[3], out tmpMelee.attackPwr);
        //            }
        //            if (lineValues[5] != "")
        //            {
        //                int.TryParse(lineValues[5], out tmpMelee.price);
        //            }
        //            tmpArr[i - 1] = tmpMelee;

        //        }
        //        else
        //        {
        //            //ranged if not melee
        //            Ranged tmpRanged = new Ranged();
        //            tmpRanged.name = lineValues[0];
        //            tmpRanged.type = lineValues[1];
        //            tmpRanged.info = lineValues[2];
        //            tmpRanged.rarity = lineValues[4];

        //            if (lineValues[3] != "")
        //            {
        //                int.TryParse(lineValues[3], out tmpRanged.attackPwr);
        //            }
        //            if (lineValues[5] != "")
        //            {
        //                int.TryParse(lineValues[5], out tmpRanged.price);
        //            }
        //            tmpArr[i - 1] = tmpRanged;
        //        }

        //    }
        //    return tmpArr;
        //}


        //private static Armor[] LoadArmor(string filename)
        //{
        //    Armor[] tmpArr;

        //    string[] lines = File.ReadAllLines(filename);

        //    tmpArr = new Armor[lines.Length - 1];
        //    for (int i =1; i < lines.Length; i++)
        //    {
        //        string[] lineVal = lines[i].Split(',');
        //        if (lineVal[1] == "Body")
        //        {
        //            BodySuit tmpBody = new BodySuit();
        //            tmpBody.name = lineVal[0];
        //            tmpBody.type = lineVal[1];
        //            tmpBody.info = lineVal[2];
        //            tmpBody.rarity = lineVal[4];

        //            if (lineVal[3] != "")
        //            {
        //                int.TryParse(lineVal[3], out tmpBody.defense);
        //            }
        //            if (lineVal[5] != "")
        //            {
        //                int.TryParse(lineVal[5], out tmpBody.price);
        //            }
        //            tmpArr[i - 1] = tmpBody;
        //        }

        //        else
        //        {
        //            Shield tmpShield = new Shield();
        //            tmpShield.name = lineVal[0];
        //            tmpShield.type = lineVal[1];
        //            tmpShield.info = lineVal[2];
        //            tmpShield.rarity = lineVal[4];

        //            if (lineVal[3] != "")
        //            {
        //                int.TryParse(lineVal[3], out tmpShield.defense);
        //            }
        //            if (lineVal[5] != "")
        //            {
        //                int.TryParse(lineVal[5], out tmpShield.price);
        //            }
        //            tmpArr[i - 1] = tmpShield;

        //        }
                
        //    }
        //    return tmpArr;
        //}



    }


}
