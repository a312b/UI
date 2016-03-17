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
            Game CSCZ = new Game(80, "Counter-Strike: Condition Zero", "MMORPG", "Action", "Fantasy", "Multiplayer", "Free To Play");
            Game CSCZBeta = new Game(150, "Counter-Strike: CZ Beta", "Action", "Animal", "Singleplayer", "Open World", "Sandbox");
            Game CSS = new Game(240, "Counter-Strike: Source", "Horror", "Funny", "Fantasy", "Co-op", "Sandbox", "Moddability");
            Game HLS = new Game(280, "Half-Life: Source", "Funny", "Dark", "Singleplayer", "Free To Play");
            Game HL2LC = new Game(340, "Half-Life 2: Lost Coast", "Gore", "Horror", "Dark", "Action","Singleplayer","Multiplayer", "Co-op", "Open World");
            Game POR = new Game(400, "Portal", "Space", "Action", "Multiplayer", "Moddability");
            Game TF2 = new Game(440, "Team Fortress 2", "Space", "Animal", "Multiplayer", "Moddability");
            Game L4D = new Game(500, "Left 4 Dead", "Animal", "Dark", "Singleplayer", "Free To Play");
            Game DOTA = new Game(570, "Dota 2", "Boring", "MMORPG", "Multiplayer", "Sandbox", "Open World");
            Game DODS = new Game(300, "Day of Defeat: Source", "Funny", "Space", "Fantasy", "Action", "Singleplayer", "Co-op", "Moddability");
            
            GameList.Add(CSCZ);
            GameList.Add(CSCZBeta);
            GameList.Add(CSS);
            GameList.Add(HLS);
            GameList.Add(HL2LC);
            GameList.Add(POR);
            GameList.Add(TF2);
            GameList.Add(L4D);
            GameList.Add(DOTA);
            GameList.Add(DODS);




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
            NameList.Add("acceptableuser");
            NameList.Add("user");
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
