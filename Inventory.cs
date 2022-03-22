using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Console_Rpg_v2._0
{
    class Inventory
    {
        private Weaponary[] _wpList = new Weaponary[5];

        // Constructor
        // Main
        public Inventory()
        {
            for (int i = 0; i < _wpList.Length; i++)
            {
                _wpList[i] = Imp.GetWeapon(0);
            }
        }

        // Inventory Functions
        // Adder Getter
        public void AddInventory(Weaponary wp)
        {
            if (Isize() < _wpList.Length)
            {
                _wpList[Isize()] = wp;
            }
            else
                Console.WriteLine("Inventory is full !");
        }

        // Get Weapon
        public Weaponary IgetWeapon(int index)
        {
            int temp;
            temp = --index;
            return _wpList[index];
        }

        // Inventory Drop
        public void IDrop(int index)
        {
            _wpList[index] = Imp.GetWeapon(0);
        }

        // Inventory (Must use after making changes to inventory)
        public void IDesigner()
        {
            Weaponary temp;
            for (int i = 0; i < _wpList.Length - 1; i++)
            {
                if (_wpList[i].WpName == "Holder")
                {
                    temp = _wpList[i];
                    _wpList[i] = _wpList[i + 1];
                    _wpList[i + 1] = temp;
                }
            }
        }

        // Show Inventory
        public void Ishow()
        {
            if (Isize() > 0)
            {
                Console.WriteLine("-----Weapons-----");
                for (int i = 0; i < Isize(); i++)
                {
                    Console.Write("-" + (i + 1) + "-" + _wpList[i].WpName);
                    if (IndexWp(Imp.GetPlayer().PlayerWp) == i)
                        Console.Write(" [Equiped]");
                    Console.Write("  Durability: " + _wpList[i].WpDurability);
                    Console.Write("\n");
                }
            }
            else if (Isize() == 0)
            {
                Console.WriteLine("Inventory is empty!");
            }
        }

        // Inventory Size 
        public int Isize()
        {
            int index = 0;
            for (int i = 0; i < _wpList.Length; i++)
            {
                if (_wpList[i].WpName != "Holder")
                    index++;
            }
            return index;
        }

        // Get Weapon's Index
        public int IndexWp(Weaponary wp)
        {
            int index = 0;
            for (int i = 0; i < Isize(); i++)
            {
                if (_wpList[i].WpName == wp.WpName)
                    break;
                index++;
            }
            return index;
        }
    }
}
