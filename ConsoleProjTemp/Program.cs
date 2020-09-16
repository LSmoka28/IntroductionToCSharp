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
        // TODO: remove unused classes
        static public int weaponNumber = 0;
        static public int armorNumber = 0;






        static void Main(string[] args)
        {
            Weapon.WeaponStruct[] shopWeapInv;
            Armor.ArmorStruct[] shopArmorInv;

            // create an empty list to add armor and weapons from shop
            List<Weapon.WeaponStruct> myWeaps = new List<Weapon.WeaponStruct>();
            List<Armor.ArmorStruct> myArmors = new List<Armor.ArmorStruct>();
            

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
            Prompt("Welcome to Fantasy Fanatics!");
            Prompt("What would you like to do?");
            

            while (gameRunning)
            {
                Prompt("Please make a selection...");
                string input = Console.ReadLine();

                // input command cases
                switch (input)
                {
                    // shop and show weapons
                    case "show weap":
                    case "weapons":
                    case "weap":
                        ShowWeapons(weaponList);
                        break;

                    case "inv":
                        PlayerArmorInv(myArmors);
                        PlayerWeaponInv(myWeaps);
                        break;
                         
                    #region ViewAndBuyWeapon Cases
                    case "w1":
                        //view weapon 1 and all its details 

                        ViewAndBuyWeapon(weaponList, myWeaps, 1);
                        break;
                    case "w2":
                        //view weapon 2 and all its details 
                        ViewAndBuyWeapon(weaponList, myWeaps, 2);
                        break;
                    case "w3":
                        //view weapon 3 and all its details 
                        ViewAndBuyWeapon(weaponList, myWeaps, 3);
                        break;
                    case "w4":
                        //view weapon 4 and all its details 
                        ViewAndBuyWeapon(weaponList, myWeaps, 4);
                        break;
                    case "w5":
                        //view weapon 5 and all its details 
                        ViewAndBuyWeapon(weaponList, myWeaps, 5);
                        break;
                    case "w6":
                        //view weapon 6 and all its details 
                        ViewAndBuyWeapon(weaponList, myWeaps,6);
                        break;
                    case "w7":
                        //view weapon 7 and all its details 
                        ViewAndBuyWeapon(weaponList, myWeaps,7);
                        break;
                    case "w8":
                        //view weapon 8 and all its details 
                        ViewAndBuyWeapon(weaponList, myWeaps,8);
                        break;
                    case "w9":
                        //view weapon 9 and all its details 
                        ViewAndBuyWeapon(weaponList, myWeaps,9);
                        break;
                    case "w10":
                        //view weapon 10 and all its details 
                        ViewAndBuyWeapon(weaponList, myWeaps,10);
                        break;
                    #endregion

                    #region SellWeapon Cases
                    case "sell w1":
                        SellWeap(myWeaps, weaponList, 1);
                        break;
                    case "sell w2":
                        SellWeap(myWeaps, weaponList, 2);
                        break;
                    case "sell w3":
                        SellWeap(myWeaps, weaponList, 3);
                        break;
                    case "sell w4":
                        SellWeap(myWeaps, weaponList, 4);
                        break;
                    case "sell w5":
                        SellWeap(myWeaps, weaponList, 5);
                        break;
                    case "sell w6":
                        SellWeap(myWeaps, weaponList, 6);
                        break;
                    case "sell w7":
                        SellWeap(myWeaps, weaponList, 7);
                        break;
                    case "sell w8":
                        SellWeap(myWeaps, weaponList, 8);
                        break;
                    case "sell w9":
                        SellWeap(myWeaps, weaponList, 9);
                        break;
                    case "sell w10":
                        SellWeap(myWeaps, weaponList, 10);
                        break;

                    #endregion


                    // shop and show armor
                    case "armor":
                    case "shield":
                    case "defense":
                        ShowArmor(armorList);
                        break;

                    #region ViewAndBuyArmor Cases
                    case "a1":
                        //view armor 1 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 1);
                        break;
                    case "a2":
                        //view armor 2 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 2);
                        break;
                    case "a3":
                        //view armor 3 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 3);
                        break;
                    case "a4":
                        //view armor 4 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 4);
                        break;
                    case "a5":
                        //view armor 5 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 5);
                        break;
                    case "a6":
                        //view armor 6 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 6);
                        break;
                    case "a7":
                        //view armor 7 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 7);
                        break;
                    case "a8":
                        //view armor 8 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 8);
                        break;
                    case "a9":
                        //view armor 9 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 9);
                        break;
                    case "a10":
                        //view armor 10 and all its details 
                        ViewAndBuyArmor(armorList, myArmors, 10);
                        break;
                    #endregion

                    #region SellArmor cases


                    case "sell a1":                       
                        SellArmor(myArmors, armorList, 1);
                        break;
                    case "sell a2":
                        SellArmor(myArmors, armorList, 2);
                        break;
                    case "sell a3":
                        SellArmor(myArmors, armorList, 3);
                        break;
                    case "sell a4":
                        SellArmor(myArmors, armorList, 4);
                        break;
                    case "sell a5":
                        SellArmor(myArmors, armorList, 5);
                        break;
                    case "sell a6":
                        SellArmor(myArmors, armorList, 6);
                        break;
                    case "sell a7":
                        SellArmor(myArmors, armorList, 7);
                        break;
                    case "sell a8":
                        SellArmor(myArmors, armorList, 8);
                        break;
                    case "sell a9":
                        SellArmor(myArmors, armorList, 9);
                        break;
                    case "sell a10":
                        SellArmor(myArmors, armorList, 10);
                        break;

                    #endregion

                    //full shop inventory, no buying
                    case "shop":
                        ShowWeapons(weaponList);
                        ShowArmor(armorList);
                        break;
                    
                    // help commands and instructions 
                    // TODO: add instructions 
                    case "help":
                    case "commands":
                    case "inputs":
                        Prompt($"__________________\nThe current valid commands you can type in are:\n" +
                            $"-armor, shield, defense - shows current shop armor inventory \n" +
                            $"-bag, i, inv, inventory, - shows current player inventory \n" +
                            $"-weapons, show weap, weap - shows current shop weapon inventory \n" +
                            $"-shop, buy, purchase - shows the full available inventory \n" +
                            $"-help, h, instruction - shows the help screen \n" +
                            $"-esc, quit, leave, bye - closes the shop and window \n");
                        break;

                    // quit and esc commands
                    case "esc":
                    case "quit":
                    case "leave":
                    case "bye":
                        Prompt($"Thanks for shopping with us! Please come again.");
                        gameRunning = false;
                        break;
                }
               
            }
            Console.ReadKey();
        }


        // shows all weapon names and numbers
        static public void ShowWeapons(List<Weapon.WeaponStruct> weaponList)
        {

            Prompt($"\n");
            Prompt($"\n----WEAPONS----\n     vvvvv    \n");
            foreach (Weapon.WeaponStruct tmpWeap in weaponList)
            {

                weaponNumber++;
                Prompt($"-{tmpWeap.Name}- w{weaponNumber}\n_______________");

            }
            weaponNumber = 0;
            Prompt($"\n     ^^^^^    \n----WEAPONS----\n");

            if (playerBank <= 0)
            {
                playerBank = 0;
                Prompt($"Uh oh! You don't have any units left..\nPlease sell something or come back when you have some more units!");
                
            }
        }

        //shows all armor names and numbers
        static public void ShowArmor(List<Armor.ArmorStruct> armorList)
        {
            Prompt($"\n");
            Prompt($"\n----ARMOR----\n     vvv    \n");
            foreach (Armor.ArmorStruct tmpArmor in armorList)
            {
                armorNumber++;
                Prompt($"-{tmpArmor.Name}- a{armorNumber}\n_______________");

            }
            armorNumber = 0;
            Prompt($"\n     ^^^    \n----ARMOR----\n");

            if (playerBank <= 0)
            {
                playerBank = 0;
                Prompt($"Uh oh! You don't have any units left..\nPlease sell something or come back when you have some more units!");
                
            }
        }

        // shows all information of weapons in player inv
        static public void PlayerWeaponInv(List<Weapon.WeaponStruct> myWeaps)
        {
            Prompt($"\n----MY WEAPONS----\n     vvvvvvvv    \n");
            foreach (Weapon.WeaponStruct myInv in myWeaps)
            {
                Prompt($"____________________\n- {myInv.Name} -\n" +
                        $"Type: {myInv.Type}\n" +
                        $"Description:\n{myInv.Info}\n" +
                        $"Damage: {myInv.AttackPwr} pts\n" +
                        $"Rarity: {myInv.Rarity}\n" +
                        $"Cost: {myInv.Price} units");
            }
            Prompt($"\n     ^^^^^^^^    \n----MY WEAPONS----\n");
        }

        // shows all information of armor in player inv
        static public void PlayerArmorInv(List<Armor.ArmorStruct> myArmors)
        {
            int numOfArmor = 0;
            Prompt($"\n----MY ARMOR----\n     vvvvvvvv    \n");
            foreach (Armor.ArmorStruct myInv in myArmors)
            {
                numOfArmor++;
                Prompt($"____________________\n- {myInv.Name} - a{numOfArmor}\n" +
                        $"Type: {myInv.Type}\n" +
                        $"Description:\n{myInv.Info}\n" +
                        $"Defense: {myInv.Defense} pts\n" +
                        $"Rarity: {myInv.Rarity}\n" +
                        $"Cost: {myInv.Price} units");
            }
            numOfArmor = 0;
            Prompt($"\n     ^^^^^^^^    \n----MY ARMOR----\n");
        }

        // method to view a speciic weapon and asks to purchase
        static public void ViewAndBuyWeapon(List<Weapon.WeaponStruct> weaponList, List<Weapon.WeaponStruct> myWeaps, int indexNum)
        {
            Weapon.WeaponStruct tmpWeap = weaponList[indexNum -1];


            Prompt($"____________________\n- {tmpWeap.Name} -\n" +
                $"Type: {tmpWeap.Type}\n" +
                $"Description:\n{tmpWeap.Info}\n" +
                $"Damage: {tmpWeap.AttackPwr} pts\n" +
                $"Rarity: {tmpWeap.Rarity}\n" +
                $"Cost: {tmpWeap.Price} units\n");
            
            if (playerBank <= 0)
            {
                playerBank = 0;
                Prompt($"Uh oh! You don't have any units left..\nPlease sell something or come back when you have some more units!");
                return;
            }
            Prompt("Would you like to buy this weapon?");
            string input = Console.ReadLine();
            if (input == "n" || input == "N")
            {
                return;
            }
            if (input != "y")
            {
                Prompt($"Oops! Looks like you entered and invalid response. \nPlease select your desired weapon and try again\n" +
                    $"*Remember*: \nenter 'y' or 'Y' to buy item\nenter 'n' or 'N' to decline\n___________________");
                return;
            }
            if (input == "y" || input == "Y")
            {
                if (playerBank < tmpWeap.Price)
                {

                    Prompt($"Hey! You dont have any enough units left to purchase that!");
                    Prompt($"You have {playerBank} units and this item is {tmpWeap.Price}");
                    return;
                }
                else
                {
                    weaponList.Remove(tmpWeap);
                    myWeaps.Add(tmpWeap);

                    playerBank -= tmpWeap.Price;
                    shopBank += tmpWeap.Price;


                    Prompt($"You now own {tmpWeap.Name}!\n" +
                        $"You currently have {playerBank} units left in your bank\n________________");
                    return;
                }
            }
            
                
            

            
        }

        // method to view a speciic armor and asks to purchase
        static public void ViewAndBuyArmor(List<Armor.ArmorStruct> armorList, List<Armor.ArmorStruct> myArmors, int indexNum)
        {
            Armor.ArmorStruct tmpArmor = armorList[indexNum-1];
            Prompt($"____________________\n- {tmpArmor.Name} -\n" +
                $"Type: {tmpArmor.Type}\n" +
                $"Description:\n{tmpArmor.Info}\n" +
                $"Defense: {tmpArmor.Defense} pts\n" +
                $"Rarity: {tmpArmor.Rarity}\n" +
                $"Cost: {tmpArmor.Price} units\n");
            
            if (playerBank <= 0)
            {
                playerBank = 0;
                Prompt($"Uh oh! You don't have any units left..\nPlease sell something or come back when you have some more units!");
                return;
            }

            Prompt("Would you like to buy this for protection?");
            string input = Console.ReadLine();
            if (input == "n" || input == "N")
            {
                return;
            }
            if (input != "y")
            {
                Prompt($"Oops! Looks like you entered and invalid response. \nPlease select your desired method of defense and try again\n" +
                       $"*Remember*: \nenter 'y' or 'Y' to buy item\nenter 'n' or 'N' to decline\n___________________\n");
                return;
            }
            if (input == "y" || input == "Y")
            {
                if (playerBank < tmpArmor.Price)
                {

                    Prompt($"Hey! You dont have any enough units left to purchase that!");
                    Prompt($"You have {playerBank} units and this item is {tmpArmor.Price}");
                    return;
                }
                else
                {
                    armorList.Remove(tmpArmor);
                    myArmors.Add(tmpArmor);

                    playerBank -= tmpArmor.Price;
                    shopBank += tmpArmor.Price;


                    Prompt($"You now own {tmpArmor.Name}!\n" +
                        $"You currently have {playerBank} units left in your bank\n___________________\n");
                    return;
                }
            }

        }

        // simple method for console.writeline
        static public void Prompt(string prompt)
        {                      
            Console.WriteLine(prompt);    
        }
        
        // method to sell a specific armor
        // TODO: Error handling for no armor to sell
        
        static public void SellArmor(List<Armor.ArmorStruct> myArmorInv,List<Armor.ArmorStruct> armorList, int indexNum)
        {
            Armor.ArmorStruct tmpArmor = myArmorInv[indexNum - 1];
            
            Prompt($"____________________\n- {tmpArmor.Name} -\n" +
                $"Type: {tmpArmor.Type}\n" +
                $"Description:\n{tmpArmor.Info}\n" +
                $"Defense: {tmpArmor.Defense} pts\n" +
                $"Rarity: {tmpArmor.Rarity}\n" +
                $"Cost: {tmpArmor.Price} units\n");

            Prompt($"Would you like to sell this item?");
            string input = Console.ReadLine();
            if (input == "n" || input == "N")
            {
                return;
            }
            if (input != "y")
            {
                Prompt($"Oops! Looks like you entered and invalid response. \nPlease try again\n" +
                       $"*Remember*: \nenter 'y' or 'Y' to sell selected item\nenter 'n' or 'N' to decline\n___________________\n");
                return;
            }
            if (input == "y" || input == "Y")
            {
                if (shopBank < tmpArmor.Price)
                {

                    Prompt($"Yikes. I dont have enough units to buy that back.");
                    Prompt($"The item is {tmpArmor.Price} units and I have only have {shopBank} ");
                    return;
                }
                else
                {
                    myArmorInv.Remove(tmpArmor);
                    armorList.Add(tmpArmor);

                    playerBank += tmpArmor.Price;
                    shopBank -= tmpArmor.Price;

                    Prompt($"You sold {tmpArmor.Name} for {tmpArmor.Price} units!\n" +
                        $"You now have {playerBank} units in your bank\n___________________\n");
                    Prompt($"The shop bank is now at {shopBank}");
                    return;
                }
            }
        }

        // method to sell a weapon
        // TODO: Error handling for no weap to sell
        static public void SellWeap(List<Weapon.WeaponStruct> myWeapInv, List<Weapon.WeaponStruct> weaponList, int indexNum)
        {
            Weapon.WeaponStruct tmpWeap = weaponList[indexNum - 1];

            Prompt($"____________________\n- {tmpWeap.Name} -\n" +
                $"Type: {tmpWeap.Type}\n" +
                $"Description:\n{tmpWeap.Info}\n" +
                $"Damage: {tmpWeap.AttackPwr} pts\n" +
                $"Rarity: {tmpWeap.Rarity}\n" +
                $"Cost: {tmpWeap.Price} units\n");

            Prompt($"Would you like to sell this item?");
            string input = Console.ReadLine();

            if (input == "n" || input == "N")
            {
                return;
            }
            if (input != "y")
            {
                Prompt($"Oops! Looks like you entered and invalid response. \nPlease try again\n" +
                       $"*Remember*: \nenter 'y' or 'Y' to sell selected item\nenter 'n' or 'N' to decline\n___________________\n");
                return;
            }
            if (input == "y" || input == "Y")
            {
                if ( shopBank < tmpWeap.Price)
                {
                    Prompt($"Yikes. I dont have enough units to buy that back.");
                    Prompt($"The item is {tmpWeap.Price} units and I have only have {shopBank} units");
                    Prompt($"Sorry! Maybe if you buy something from me, I will have enough units then");
                    return;
                }
                else
                {
                    myWeapInv.Remove(tmpWeap);
                    weaponList.Add(tmpWeap);

                    playerBank += tmpWeap.Price;
                    shopBank -= tmpWeap.Price;

                    Prompt($"You sold {tmpWeap.Name} for {tmpWeap.Price} units!\n" +
                        $"You now have {playerBank} units in your bank\n___________________\n");
                    Prompt($"The shop bank is now at {shopBank}");
                }
            }
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
