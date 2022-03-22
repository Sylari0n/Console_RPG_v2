using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Rpg_v2._0
{

    static class Combat
    {
        public static int ActionHandler(int n)
        {
            while (true)
            {
                int temp;
                Console.Write(">>> ");
                try
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    return 999;
                }
                return temp;

            }
        }


        // Combat Screen
        public static void CombatScreen(Mobs mob)
        {
            // Fields
            int range = 1;
            int action;
            int temp;
            int actionP = Imp.GetPlayer().PlayerActionP;
            while (true)
            {

                Console.WriteLine(Imp.GetPlayer().PlayerName + "                                     " + mob.MobName);
                Console.WriteLine("Hp: " + Imp.GetPlayer().PlayerHp + "                                   " + "Hp: " + mob.MobHp);
                Console.WriteLine("Power: " + (Imp.GetPlayer().PlayerPower + Imp.GetPlayer().PlayerWp.WpPower) + "                                  " + "Power: " + mob.MobPower);
                Console.WriteLine("Weapon: " + Imp.GetPlayer().PlayerWp.WpName + "                           " + "Weapon: " + mob.MobWp.WpName);
                Console.WriteLine("Range: " + range);
                Console.WriteLine("Action Point: " + actionP);
                Console.WriteLine("-1- Attack\n" +
                                  "-2- Move Back\n" +
                                  "-3- Move Forward\n" +
                                  "-4- Open Inventory\n" +
                                  "-5- Idle");
                // action = Convert.ToInt32(Console.ReadLine());
                action = ActionHandler(5);


                // Attack
                if (action == 1)
                {
                    if (Imp.GetPlayer().PlayerWp.WpRange >= range)
                    {
                        temp = Imp.GetPlayer().PlayerWp.WpPower + Imp.GetPlayer().PlayerPower;
                        mob.MobHp -= temp;
                        Console.WriteLine("You deal " + temp + " damage to " + mob.MobName);
                        temp = Imp.GetPlayer().PlayerWp.WpDurability;
                        Imp.GetPlayer().PlayerWp.WpDurability = --temp;
                        if (Imp.GetPlayer().PlayerWp.WpName != "Unarmed" && Imp.GetPlayer().PlayerWp.WpDurability != 0)
                        {
                            Console.WriteLine("Remian " + Imp.GetPlayer().PlayerWp.WpName + " Durability " + Imp.GetPlayer().PlayerWp.WpDurability);
                        }
                        if (Imp.GetPlayer().PlayerWp.WpDurability == 0)
                        {
                            Console.WriteLine(Imp.GetPlayer().PlayerWp.WpName + " has been broken!");
                            Imp.GetInventory().IDrop(Imp.GetInventory().IndexWp(Imp.GetPlayer().PlayerWp));
                            Imp.GetPlayer().PlayerWp = Imp.GetWeapon(1);
                            Imp.GetInventory().IDesigner();
                        }
                        if (mob.MobHp <= 0)
                        {
                            Console.WriteLine($"You killed {mob.MobName}");
                            Functions.skip();
                            break;
                        }
                        Functions.skip();
                    }
                }

                // Move Back
                else if (action == 2)
                {
                    if (range <= 5)
                    {
                        range += 1;
                        Console.WriteLine("Your getting away from enemy");
                        Functions.skip();
                    }
                    else
                    {
                        Console.WriteLine("You can't go back any further !");
                        Functions.skip();
                    }
                }

                // Move Forward
                else if (action == 3)
                {
                    if (range >= 1)
                    {
                        range -= 1;
                        Console.WriteLine("Your getting closer to enemy");
                        Functions.skip();
                    }
                    else
                    {
                        Console.WriteLine("You can't go any further !");
                        Functions.skip();
                    }
                }


                // Inventory
                else if (action == 4)
                {

                    Imp.GetInventory().Ishow();
                    if (Imp.GetInventory().Isize() > 0)
                    {
                        Console.WriteLine("Enter item's number for equip");
                        Console.WriteLine("-0- Quit");
                        Console.Write(">>> ");
                        temp = Convert.ToInt32(Console.ReadLine());
                        if (temp != 0)
                        {
                            // Set Player Weapon
                            if (Imp.GetInventory().Isize() > 0)
                            {
                                Imp.GetPlayer().PlayerWp = (Imp.GetInventory().IgetWeapon(temp));
                                // Setting player power
                            }
                        }
                        else if (temp == 0)
                        {
                            Functions.skip();
                        }
                    }
                    else
                    {
                        Functions.skip();
                    }
                }
                else if (action == 5)
                {
                    Console.WriteLine("You did nothing");
                    Functions.skip();
                }
                else
                {
                    Console.Write("\b");
                    Script.IIPicker();
                    Console.Write("\n");
                    Functions.skip();
                }

                // action point
                if (actionP != 0)
                    --actionP;

                // Temporary mob AI
                if (actionP == 0)
                {
                    if (range == 1)
                    {
                        int mobD = mob.MobPower + mob.MobWp.WpPower;
                        temp = Imp.GetPlayer().PlayerHp - mobD;
                        Imp.GetPlayer().PlayerHp = temp;
                        Console.WriteLine("You recieve " + mobD + " from " + mob.MobName);
                        Functions.skip();
                        actionP = Imp.GetPlayer().PlayerActionP;
                    }
                    else
                    {
                        Console.WriteLine(mob.MobName + " couldn't hit you");
                        Functions.skip();
                    }
                }

                Console.Clear();
            }
        }
    }
}
