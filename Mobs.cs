using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Rpg_v2._0
{
    class Mobs
    {
        private string _mobName;
        private int _mobHp;
        private int _mobPower;
        private int _mobAgility;
        private Weaponary _mobWp;


        // Constructor
        // Main
        public Mobs(string Mob_Name, int Mob_Hp, int Mob_Power, int Mob_Agility, Weaponary Mob_Wp)
        {
            MobName = Mob_Name;
            MobHp = Mob_Hp;
            MobPower = Mob_Power;
            MobAgility = Mob_Agility;
            MobWp = Mob_Wp;
        }

        // MOb Agility
        // Setter Getter
        public string MobName
        {
            set { _mobName = value; }
            get { return _mobName; }
        }

        // Mob Hp
        // Setter Getter
        public int MobHp
        {
            set { _mobHp = value; }
            get { return _mobHp; }
        }

        // Mob Power
        // Setter Getter
        public int MobPower
        {
            set { _mobPower = value; }
            get { return _mobPower; }
        }

        // Mob Agility
        // Setter Getter
        public int MobAgility
        {
            set { _mobAgility = value; }
            get { return _mobAgility; }
        }

        // Mob Weapon
        // Setter Getter
        public Weaponary MobWp
        {
            set { _mobWp = value; }
            get { return _mobWp; }
        }

    }
}
