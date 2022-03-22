using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Rpg_v2._0
{
    class Weaponary
    {
        private string _wpName;
        private int _wpPower;
        private int _wpDurability;
        private int _wpRange;


        // Weponary Constructor
        // Main
        public Weaponary(string Wp_Name, int Wp_Power, int Wp_Durability, int Wp_Range)
        {
            WpName = Wp_Name;
            WpPower = Wp_Power;
            WpDurability = Wp_Durability;
            WpRange = Wp_Range;
        }

        // Default
        public Weaponary() { }


        // Weapon Name
        // Setter Getter
        public string WpName
        {
            set { _wpName = value; }
            get { return _wpName; }
        }

        // weaphon Power
        // Setter Getter
        public int WpPower
        {
            set { _wpPower = value; }
            get { return _wpPower; }
        }

        // Weaphon Durability
        // Setter Getter
        public int WpDurability
        {
            set { _wpDurability = value; }
            get { return _wpDurability; }
        }

        // Weaphon Range
        // Setter Getter
        public int WpRange
        {
            set { _wpRange = value; }
            get { return _wpRange; }
        }

    }
}
