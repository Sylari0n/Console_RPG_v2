using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Rpg_v2._0
{

    // Skip
    static class Functions
    {
        public static void skip()
        {
            while (true)
            {
                Console.WriteLine("\b\bPress enter to continue");
                string key = Console.ReadKey().Key.ToString();
                if (key.ToUpper() == "ENTER")
                    break;
            }
        }

        // Script Player
        public static int ScriptP(string sc, int s, int e)
        {
            while (true)
            {
                Console.WriteLine(sc);
                Console.Write(">>> ");
                int temp;
                try
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("This not an option!");
                    skip();
                    Console.Clear();
                    continue;
                }
                for (int i = s; i <= e; i++)
                {
                    if (i == temp)
                    {
                        return temp;
                    }
                }
                Console.WriteLine("This is not an option");
                skip();
                Console.Clear();
            }
        }

        // Script Inventory Adder
        public static void ScriptA(int res, Weaponary wp)
        {
            if (res == 1)
            {
                Imp.GetInventory().AddInventory(wp);
                Console.WriteLine("You added " + wp.WpName + " to your inventory");
                skip();
            }

        }
    }
}
