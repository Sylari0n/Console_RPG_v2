using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Rpg_v2._0
{
    class Imp
    {


        // Weapons Implementation
        static Weaponary wp0 = new Weaponary("Holder", 0, 0, 0);
        static Weaponary wp1 = new Weaponary("Unarmed", 0, 999, 1);
        static Weaponary wp2 = new Weaponary("Knife", 5, 3, 1);
        static Weaponary wp3 = new Weaponary("Club", 3, 2, 1);
        static Weaponary wp4 = new Weaponary("Axe", 8, 3, 1);
        static Weaponary wp5 = new Weaponary("Spear", 5, 2, 2);
        // Weapon Getter
        public static Weaponary GetWeapon(int wp)
        {
            switch (wp)
            {
                case 0:
                    return wp0;
                case 1:
                    return wp1;
                case 2:
                    return wp2;
                case 3:
                    return wp3;
                case 4:
                    return wp4;
                case 5:
                    return wp5;
                default:
                    return wp0;
            }
        }

        // Mobs
        static Mobs mob1 = new Mobs("Skeleton", 20, 4, 1, wp1);
        static Mobs mob2 = new Mobs("Prisoner", 30, 5, 1, wp3);
        static Mobs mob3 = new Mobs("Giant Rat", 15, 4, 2, wp1);
        static Mobs mob4 = new Mobs("Sleepy Guard", 40, 6, 1, wp5);
        // Mob getter
        public static Mobs GetMobs(int mob)
        {
            switch (mob)
            {
                case 1:
                    return mob1;
                case 2:
                    return mob2;
                case 3:
                    return mob3;
                case 4:
                    return mob4;
                default:
                    return null;
            }
        }

        // Charachter Creation
        static Player player = new Player("Nameless", 100, 5, 1, 2, wp1);
        // player Getter
        public static Player GetPlayer()
        {
            return player;
        }


        // inventory Implementation
        static Inventory inventory = new Inventory();
        // inventory Getter
        public static Inventory GetInventory()
        {
            return inventory;
        }
    }
}
