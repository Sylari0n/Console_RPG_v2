using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Rpg_v2._0
{
    class Display
    {


        static void Main(string[] args)
        {
            Save.CreateSaveDir();
            int selection = 0;
            int saveH = new int();
            string temp;
            while (true)
            {
                // Title Screen
                Script.TitleScreen();
                selection = Combat.ActionHandler(2);

                if (selection == 1)
                {
                    while (true)
                    {
                        Script.LoadScreen();
                        selection = Combat.ActionHandler(5);
                        if (selection == 1)
                        {
                            saveH = 1;
                            if (Save.ReadSave("switches", "save1") == "false")
                            {
                                Save.CreateSave(1);
                                break;
                            }
                            else if (Save.ReadSave("switches", "save1") == "true")
                            {
                                Save.LoadSave("crsave1");
                                goto flag1;
                            }
                            
                        }

                        else if (selection == 2)
                        {
                            saveH = 2;
                            if (Save.ReadSave("switches", "save2") == "false")
                            {
                                Save.CreateSave(2);
                                break;
                            }
                            else if (Save.ReadSave("switches", "save2") == "true")
                            {
                                Save.LoadSave("crsave2");
                                goto flag1;
                            }
                            
                        }

                        else if (selection == 3)
                        {
                            saveH = 3;
                            if (Save.ReadSave("switches", "save3") == "false")
                            {
                                Save.CreateSave(3);
                                break;
                            }
                            else if (Save.ReadSave("switches", "save3") == "true")
                            {
                                Save.LoadSave("crsave3");
                                goto flag1;
                            }
                        }
                        else if (selection == 4)
                        {
                            if (Save.ReadSave("switches", "save1") == "false" && Save.ReadSave("switches", "save2") == "false" && Save.ReadSave("switches", "save3") == "false")
                            {
                                Console.WriteLine("There is no save");
                                Functions.skip();
                                Console.Clear();
                                continue;
                            }
                            if (Save.ReadSave("switches", "save1") == "true")
                                Console.WriteLine("-1- Save1" + " " + Save.ReadSave("switches", "save1date") + " " + Save.ReadSave("crsave1", "PlayerName"));
                            if (Save.ReadSave("switches", "save2") == "true")
                                Console.WriteLine("-2- save2" + " " + Save.ReadSave("switches", "save2date") + " " + Save.ReadSave("crsave2", "PlayerName"));
                            if (Save.ReadSave("switches", "save3") == "true")
                                Console.WriteLine("-3- save3" + " " + Save.ReadSave("switches", "save3date") + " " + Save.ReadSave("crsave3", "PlayerName"));
                            Console.WriteLine("-0- Return save menu");
                            selection = Combat.ActionHandler(3);
                            if (selection == 0)
                            {
                                Console.Clear();
                                continue;
                            }
                            Save.DeleteSave(selection);
                        }

                        Console.Clear();
                    }

                    Console.Clear();
                    Console.WriteLine("Who will you be ?");
                    Console.Write(">>> ");
                    temp = Console.ReadLine();
                    Imp.GetPlayer().PlayerName = temp;
                    Console.Clear();

                    // arc 1
                    Console.WriteLine(Script.s1);
                    Functions.skip();
                    Console.Clear();

                    // wp 
                    selection = Functions.ScriptP(Script.s2, 1, 2);
                    Functions.ScriptA(selection, Imp.GetWeapon(2));
                    Console.Clear();

                    // wp
                    selection = Functions.ScriptP(Script.s3, 1, 2);
                    Functions.ScriptA(selection, Imp.GetWeapon(3));
                    Console.Clear();

                    // combat
                    Combat.CombatScreen(Imp.GetMobs(1));
                    Console.Clear();

                    Console.WriteLine(Script.s4);
                    Functions.skip();
                    Console.Clear();

                    // deneme //////////////////////
                    Console.WriteLine("Do you wanna take save\n-1- Yes\n-2- continue");
                    selection = Combat.ActionHandler(2);
                    if (selection == 1)
                    {
                        Save.TakeSave("crsave" + saveH);
                    }

                    ////////////////////////////////

                    flag1:
                    Console.Clear();
                    Combat.CombatScreen(Imp.GetMobs(2));
                    break;
                }

                else if (selection == 2)
                {
                    Environment.Exit(0);

                }


                else
                {
                    Console.WriteLine("This is not an option!\n");
                    Functions.skip();
                }
                ////////////////////
                Console.Clear();
            }


        }
    }
}


