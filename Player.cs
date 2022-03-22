using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Rpg_v2._0
{
    class Player
    {
        private string _playerName;
        private int _playerHp;
        private int _playerPower;
        private int _playerAgility;
        private int _playerActionP;
        private Weaponary _playerWp;


        // Player Constructor
        // Main
        public Player(string Player_Name, int Player_Hp, int Player_Power, int Player_Agility, int Player_ActionP, Weaponary Player_Wp)
        {
            PlayerName = Player_Name;
            PlayerHp = Player_Hp;
            PlayerPower = Player_Power;
            PlayerAgilitiy = Player_Agility;
            PlayerActionP = Player_ActionP;
            PlayerWp = Player_Wp;
        }


        // Player Name
        // Setter Getter
        public string PlayerName
        {
            set { _playerName = value; }
            get { return _playerName; }
        }

        // Player HP
        // Setter Getter
        public int PlayerHp
        {
            set { _playerHp = value; }
            get { return _playerHp; }
        }

        // Player Power
        // Setter Getter
        public int PlayerPower
        {
            set { _playerPower = value; }
            get { return _playerPower; }
        }

        // Player Agility
        // Setter Getter
        public int PlayerAgilitiy
        {
            set { _playerAgility = value; }
            get { return _playerAgility; }
        }

        // Player Action Point
        // Setter Getter
        public int PlayerActionP
        {
            set { _playerActionP = value; }
            get { return _playerActionP; }
        }


        // Player Weapon
        // Setter Getter
        public Weaponary PlayerWp
        {
            set { _playerWp = value; }
            get { return _playerWp; }
        }
    }
}
