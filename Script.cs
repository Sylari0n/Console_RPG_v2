using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Rpg_v2._0
{
    class Script
    {
        static Random rnd = new Random();

        // Title Screen
        public static void TitleScreen()
        {
            Console.WriteLine("Escape the Dungeon v2.0");
            Console.WriteLine("-1- Play");
            Console.WriteLine("-2- Exit");
        }

        public static void LoadScreen()
        {
            if (Save.ReadSave("switches", "save1") == "true")
                Console.WriteLine("-1- Save " + Save.ReadSave("switches", "save1date"));
            else
                Console.WriteLine("-1- Empty");

            if (Save.ReadSave("switches", "save2") == "true")
                Console.WriteLine("-2- Save " + Save.ReadSave("switches", "save2date"));
            else
                Console.WriteLine("-2- Empty");

            if (Save.ReadSave("switches", "save3") == "true")
                Console.WriteLine("-3- Save " + Save.ReadSave("switches", "save3date"));
            else
                Console.WriteLine("-3- Empty");

            Console.WriteLine("\n-4- Delete Save");
            Console.WriteLine("-5- Reset save");
        }

        // Take Save Screen
        public static void TakeSaveScreen()
        {
            Console.WriteLine();
        }

        // Scripts
        public static string s1 = "You woke up in a dungeon. All you need to know you must escape this dungeon";
        public static string s2 = "you found a Knife\n-1- Keep it\n-2- Continue";
        public static string s3 = "You found a Club\n-1- Keep it\n-2- Continue";
        public static string s4 = "After your first kill in this hell you heard a laugh insade from darknes";

        // Combat screen incorrect input
        private static string _f1 = "During the fight you started to doing push-ups";
        private static string _f2 = "during the fight you started catching butterflies. Why would someone do this!";
        private static string _f3 = "You trying to understand is chicken come from egg or egg come from chicken";
        private static string _f4 = "you just entered an action not included in the list. Well done!";

        static string[] IncorrectInput = new string[] { _f1, _f2, _f3, _f4 };

        // Random Picker
        public static void IIPicker()
        {
            Console.WriteLine(IncorrectInput[rnd.Next(0, 3)]);
        }


    }
}
