using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Console_Rpg_v2._0
{
    class Save
    {
        // Save Directory Location
        private static string _dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ConsoleRpgSave\\";

        // Create Save Directory
        public static void CreateSaveDir()
        {
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ConsoleRpgSave"));
        }
        // Save File Length
        // private const int _saveL = 17;
        //public static int FileLength(string saveFile)
        //{
        //    StreamReader saveR = new StreamReader(_dirPath + "\\" + saveFile + ".txt");
        //    saveR.BaseStream.Seek(0, SeekOrigin.Begin);
        //    string value = saveR.ReadLine();
        //    int length = 0;

        //    while (value != null)
        //    {
        //        length++;
        //        value = saveR.ReadLine();
        //    }
        //    saveR.Close();
        //    return length;
        //}

        const int swichesLenght = 6;
        const int saveLength = 16;

        // Delete Save
        public static void DeleteSave(int saveN)
        {
            if (saveN == 1 && ReadSave("switches", "save1") == "true")
            {
                Console.WriteLine("Are You sure ?\n-1- Delete\n -2- Cancel");
                int selection;
                selection = Combat.ActionHandler(2);

                if (selection == 1)
                {
                    File.Delete(_dirPath + "crsave1.txt");
                    WriteSave("switches", "save1", "false");
                    Console.WriteLine("Save 1 succesfully deleted !");
                    Functions.skip();
                }
                else
                    Functions.skip();
            }

            else if (saveN == 2 && ReadSave("switches", "save2") == "true")
            {
                Console.WriteLine("Are You sure ?\n-1- Delete\n -2- Cancel");
                int selection;
                selection = Combat.ActionHandler(2);

                if (selection == 1)
                {
                    File.Delete(_dirPath + "crsave2.txt");
                    WriteSave("switches", "save2", "false");
                    Console.WriteLine("Save 2 succesfully deleted !");
                    Functions.skip();
                }
                else
                    Functions.skip();
            }

            else if (saveN == 3 && ReadSave("switches", "save3") == "true")
            {
                Console.WriteLine("Are You sure ?\n-1- Delete\n -2- Cancel");
                int selection;
                selection = Combat.ActionHandler(2);

                if (selection == 1)
                {
                    File.Delete(_dirPath + "crsave3.txt");
                    WriteSave("switches", "save3", "false");
                    Console.WriteLine("Save 3 succesfully deleted !");
                    Functions.skip();
                }
                else
                    Functions.skip();

            }
        }


        // Reset Save
        public static void ResetSave(string saveFile)
        {
            int selection = new int();
            Console.WriteLine("Are You Sure ?");
            if (selection == 1)
            {
                StreamWriter sw = new StreamWriter(_dirPath + "\\" + saveFile + "txt");
                string defaultSave = "PlayerName=null\nPlayerHp=null\nPlayerPower=null\nPlayerAgility=null\n" +
                    "PlayerActionPoint=null\nPlayerWp=null\nInventory1=null\nInventory2=null\nInventory3=null" +
                    "\nInventory4=null\nInventory5=null\nWpDurability1=null\nWpDurability2=null\nWpDurability3=null\n" +
                    "WpDurability4=null\nWpDurability5=null";
                sw.WriteLine(defaultSave);
                sw.Flush();
                sw.Close();
            }
            else
                Functions.skip();
        }


        // Create Save file
        public static void CreateSave(int saveN)
        {
            if (saveN == 1)
            {
                StreamWriter sw = new StreamWriter(_dirPath + "crsave1.txt");
                string defaultSave = "PlayerName=null\nPlayerHp=null\nPlayerPower=null\nPlayerAgility=null\n" +
                    "PlayerActionPoint=null\nPlayerWp=null\nInventory1=null\nInventory2=null\nInventory3=null" +
                    "\nInventory4=null\nInventory5=null\nWpDurability1=null\nWpDurability2=null\nWpDurability3=null\n" +
                    "WpDurability4=null\nWpDurability5=null";
                sw.WriteLine(defaultSave);
                sw.Flush();
                sw.Close();
                WriteSave("switches", "save1", "true");
                WriteSave("switches", "save1date", DateTime.Now.ToString("yyyy-MM-dd"));
            }

            else if (saveN == 2)
            {
                StreamWriter sw = new StreamWriter(_dirPath + "crsave2.txt");
                string defaultSave = "PlayerName=null\nPlayerHp=null\nPlayerPower=null\nPlayerAgility=null\n" +
                    "PlayerActionPoint=null\nPlayerWp=null\nInventory1=null\nInventory2=null\nInventory3=null" +
                    "\nInventory4=null\nInventory5=null\nWpDurability1=null\nWpDurability2=null\nWpDurability3=null\n" +
                    "WpDurability4=null\nWpDurability5=null";
                sw.WriteLine(defaultSave);
                sw.Flush();
                sw.Close();
                WriteSave("switches", "save2", "true");
                WriteSave("switches", "save2date", DateTime.Now.ToString("yyyy-MM-dd"));
            }

            else if (saveN == 3)
            {
                StreamWriter sw = new StreamWriter(_dirPath + "crsave3.txt");
                string defaultSave = "PlayerName=null\nPlayerHp=null\nPlayerPower=null\nPlayerAgility=null\n" +
                    "PlayerActionPoint=null\nPlayerWp=null\nInventory1=null\nInventory2=null\nInventory3=null" +
                    "\nInventory4=null\nInventory5=null\nWpDurability1=null\nWpDurability2=null\nWpDurability3=null\n" +
                    "WpDurability4=null\nWpDurability5=null";
                sw.WriteLine(defaultSave);
                sw.Flush();
                sw.Close();
                WriteSave("switches", "save3", "true");
                WriteSave("switches", "save3date", DateTime.Now.ToString("yyyy-MM-dd"));
            }
        }


        // Read Specific Line Of Save File 
        public static string ReadSave(string saveFile, string save)
        {
            StreamReader saveR = new StreamReader(_dirPath + "\\" + saveFile + ".txt");
            saveR.BaseStream.Seek(0, SeekOrigin.Begin);
            string value = saveR.ReadLine();

            while (value != null)
            {
                string temp = "";
                int counter = 0;

                foreach (char i in value)
                {
                    counter++;
                    if (i == '=')
                        break;
                }
                for (int i = 0; i < counter - 1; i++)
                {
                    temp += value[i];
                }

                if (temp == save)
                {
                    temp = "";
                    for (int i = 0; i < value.Length - counter; i++)
                    {
                        temp += value[counter + i];
                    }
                    saveR.Close();
                    return temp;
                }


                value = saveR.ReadLine();
            }
            saveR.Close();
            return "null";
        }

        // Write Specific Line Of Save File
        public static void WriteSave(string saveFile,string save, string val)
        {
            int length;
            if (saveFile == "switches")
                length = swichesLenght;
            else
                length = saveLength;

            string path = _dirPath + "\\" + saveFile + ".txt";
            StreamReader saveR = new StreamReader(path);
            saveR.BaseStream.Seek(0, SeekOrigin.Begin);
            string value = saveR.ReadLine();



            string[] tempSave = new string[length];
            int counter = 0;



            for (int i = 0; i < length ; i++)
            {
                tempSave[i] = value;
                value = saveR.ReadLine();
            }

            saveR.Close();



            for (int i = 0; i < length; i++)
            {
                counter = 0;
                string temp = "";
                string str = "";
                foreach (char j in tempSave[i])
                {
                    counter++;
                    if (j == '=')
                        break;
                }

                str = tempSave[i];
                for (int k = 0; k < counter - 1; k++)
                {
                    temp += str[k];
                }

                if (temp == save)
                {
                    tempSave[i] = save + '=' + val;
                    break;
                }
            }

            StreamWriter saveW = new StreamWriter(path);
            string tempW = "";
            // Write to save file
            for (int i = 0; i < length; i++)
            {
                tempW += tempSave[i] + "\n";
            }
            saveW.WriteLine(tempW);
            saveW.Flush();

            saveW.Close();
        }

        // Save Weapon Returner
        public static Weaponary TakeSaveWp(string wp)
        {
            for (int i = 0; i < 6; i++)
            {
                if (wp == Imp.GetWeapon(i).WpName)
                    return Imp.GetWeapon(i);
            }
            return Imp.GetWeapon(0);
        }

        // Take Save
        public static void TakeSave(string saveFile)
        {
            ResetSave(saveFile);
            WriteSave(saveFile, "PlayerName", Imp.GetPlayer().PlayerName);
            WriteSave(saveFile, "PlayerHp", Convert.ToString(Imp.GetPlayer().PlayerHp));
            WriteSave(saveFile, "PlayerPower", Convert.ToString(Imp.GetPlayer().PlayerPower));
            WriteSave(saveFile, "PlayerAgility", Convert.ToString(Imp.GetPlayer().PlayerAgilitiy));
            WriteSave(saveFile, "PlayerActionPoint", Convert.ToString(Imp.GetPlayer().PlayerActionP));
            WriteSave(saveFile, "PlayerWp", Imp.GetPlayer().PlayerWp.WpName);
            WriteSave(saveFile, "PlayerWpDurability", Convert.ToString(Imp.GetPlayer().PlayerWp.WpDurability));
            for (int i = 1; i <= Imp.GetInventory().Isize(); i++)
            {
                string temp = "Inventory";
                temp += i;
                WriteSave(saveFile, temp, Imp.GetInventory().IgetWeapon(i).WpName);
            }

            for (int i = 1; i <= Imp.GetInventory().Isize(); i++)
            {
                string temp = "WpDurability";
                temp += i;
                WriteSave(saveFile, temp, Convert.ToString(Imp.GetInventory().IgetWeapon(i).WpDurability));
            }
        }

        public static void LoadSave(string saveFile)
        {
            Imp.GetPlayer().PlayerName = ReadSave(saveFile, "PlayerName");
            Imp.GetPlayer().PlayerHp = Convert.ToInt32(ReadSave(saveFile, "PlayerHp"));
            Imp.GetPlayer().PlayerPower = Convert.ToInt32(ReadSave(saveFile, "PlayerPower"));
            Imp.GetPlayer().PlayerAgilitiy = Convert.ToInt32(ReadSave(saveFile, "PlayerAgility"));
            Imp.GetPlayer().PlayerActionP = Convert.ToInt32(ReadSave(saveFile, "PlayerActionPoint"));
            Imp.GetPlayer().PlayerWp = TakeSaveWp(ReadSave(saveFile, "PlayerWp"));
            for (int i = 0; i < 5; i++)
            {
                string index = "Inventory" + (i + 1);
                if (ReadSave(saveFile, index) != "null")
                {
                    Imp.GetInventory().AddInventory(TakeSaveWp(ReadSave(saveFile,index)));
                }
            }
            for (int i = 0; i < 5; i++)
            {
                string index = "WpDurability" + (i + 1);
                if (ReadSave(saveFile, index) != "null")
                {
                    Imp.GetInventory().IgetWeapon(i + 1).WpDurability = Convert.ToInt32(ReadSave(saveFile, index));
                }
            }
        }
    }
}

