using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyClassSolution
{
    class DummyClass
    {
        public DummyClass()
        {
            Game MB = new Game(80, "Counter-Strike: Condition Zero", "MMORPG", "Action", "Fantasy", "Multiplayer", "Free To Play");
            Game SuperSheep = new Game(150, "Counter-Strike: Condition Zero", "Action", "Animal", "Singleplayer", "Open World", "Sandbox");
            Game LostManIsLost = new Game(240, "Counter-Strike: Source", "Horror", "Funny", "Fantasy", "Co-op", "Sandbox", "Moddability");
            Game DakkeDakMusic = new Game(280, "Half-Life: Source", "Funny", "Dark", "Singleplayer", "Free To Play");
            Game RaidThePlayStore = new Game(340, "Half-Life 2: Lost Coast", "Gore", "Horror", "Dark", "Action","Singleplayer","Multiplayer", "Co-op", "Open World");
            Game District42 = new Game(400, "Portal", "Space", "Action", "Multiplayer", "Moddability");
            Game SailToTheMoon = new Game(440, "Team Fortress 2", "Space", "Animal", "Multiplayer", "Moddability");
            Game BrotherIsADuckling = new Game(500, "Left 4 Dead", "Animal", "Dark", "Singleplayer", "Free To Play");
            Game ProtonSimulator = new Game(570, "Dota 2", "Boring", "MMORPG", "Multiplayer", "Sandbox", "Open World");
            Game NiceCakeMrRobinson = new Game(300, "Day of Defeat: Source", "Space", "Fantasy", "Action", "Singleplayer", "Co-op", "Moddability");
            
            GameList.Add(MB);
            GameList.Add(SuperSheep);
            GameList.Add(LostManIsLost);
            GameList.Add(DakkeDakMusic);
            GameList.Add(RaidThePlayStore);
            GameList.Add(District42);
            GameList.Add(SailToTheMoon);
            GameList.Add(BrotherIsADuckling);
            GameList.Add(ProtonSimulator);
            GameList.Add(NiceCakeMrRobinson);




            NameList.Add("gustav");
            NameList.Add("julius");
            NameList.Add("ronja");
            NameList.Add("aleksander");
            NameList.Add("petter");
            NameList.Add("peter");
            NameList.Add("jeppe");
            NameList.Add("jacob");
            NameList.Add("niclas");
            NameList.Add("pubaaah");
            NameList.Add("aleqsander");
            NameList.Add("aleqxander");
            NameList.Add("morty");
        }
        List<string> NameList = new List<string>();

        List<Game> GameList = new List<Game>();

        public List<Game> GetGameListByName(string SteamID)
        {
            if (IDCompare(SteamID))
            {
                string steamID = SteamID;
                return GameList;
            } else
            {
                return null;
            }
        }

        public List<Game> GetList(string Name)
        {
            return GameList;
        }

        private bool IDCompare(string ID)
        {
            bool result = false;

            foreach (string item in NameList)
            {
                bool match = ((string.Compare(ID, item)) == 0);
                result |= match; // Mindst en compare returnerer true
            }

            return result;
        }
    }


        public class Game
        {
            private static int ID = 0;
            public Game(int _appId, string _name, params string[] _genre)
            {
                this.Name = _name;
                this.Genre = _genre;
                this.GameID = ID++;
                this.AppId = _appId;
            }

            public int AppId { get; private set; }

            public string Name { get; private set; }

            public int GameID { get; private set; }

            public string[] Genre { get; private set; }

            public string[] Tags { get; private set; }

        }
}
