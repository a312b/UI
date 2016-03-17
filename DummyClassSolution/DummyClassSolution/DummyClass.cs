using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyClassSolution
{
    class DummyClass
    {
        public DummyClass()//i appid, s name, s dev, i releae, s desc, params
        {
            Game CSCZ = new Game(80, "Counter-Strike: Condition Zero","Valve",2004, "With its extensive Tour of Duty campaign, a near-limitless number of skirmish modes, updates and new content for Counter-Strike's award-winning multiplayer game play, plus over 12 bonus single player missions, Counter-Strike: Condition Zero is a tremendous offering of single and multiplayer content. ", "MMORPG", "Action", "Fantasy", "Multiplayer", "Free To Play");
            Game CSCZBeta = new Game(150, "Counter-Strike: CZ Beta", "Valve", 2004,"Description of the game", "Action", "Animal", "Singleplayer", "Open World", "Sandbox");
            Game CSS = new Game(240, "Counter-Strike: Source", "Valve", 2004, "Description of the game", "Horror", "Funny", "Fantasy", "Co-op", "Sandbox", "Moddability");
            Game HLS = new Game(280, "Half-Life: Source", "Valve", 2004, "Description of the game", "Funny", "Dark", "Singleplayer", "Free To Play");
            Game HL2LC = new Game(340, "Half-Life 2: Lost Coast", "Valve", 2004, "Description of the game", "Gore", "Horror", "Dark", "Action","Singleplayer","Multiplayer", "Co-op", "Open World");
            Game POR = new Game(400, "Portal", "Valve", 2004, "Description of the game", "Space", "Action", "Multiplayer", "Moddability");
            Game TF2 = new Game(440, "Team Fortress 2", "Valve", 2004, "Description of the game", "Space", "Animal", "Multiplayer", "Moddability");
            Game L4D = new Game(500, "Left 4 Dead", "Valve", 2004, "Description of the game", "Animal", "Dark", "Singleplayer", "Free To Play");
            Game DOTA = new Game(570, "Dota 2", "Valve", 2004, "Description of the game", "Boring", "MMORPG", "Multiplayer", "Sandbox", "Open World");
            Game DODS = new Game(300, "Day of Defeat: Source", "Valve", 2004, "Description of the game", "Funny", "Space", "Fantasy", "Action", "Singleplayer", "Co-op", "Moddability");
            Game COD4 = new Game(7940, "Call of Duty 4: MW", "Valve", 2004, "Description of the game", "", "Action", "Multiplayer", "Moddability", "Co-op");
            Game CODMW2 = new Game(10180, "Call of Duty: MW 2", "Valve", 2004, "Description of the game", "Space", "Action", "Multiplayer", "Moddability");
            Game FLLNW = new Game(22380, "Fallout: New Vegas", "Valve", 2004, "Description of the game", "Space", "Fantasy", "Action", "Singleplayer", "Moddability");
            Game FLL4 = new Game(377160, "Fallout 4", "Valve", 2004, "Description of the game", "Space", "Action", "Singleplayer");

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
            GameList.Add(COD4);
            GameList.Add(CODMW2);
            GameList.Add(FLLNW);
            GameList.Add(FLL4);

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

        public List<Game> GetList()
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
            public Game(int _appId, string _name, string _dev, int _releaseYear, string _description, params string[] _genre)
            {
                this.Name = _name;
                this.Genre = _genre;
                this.GameID = ID++;
                this.AppId = _appId;
                this.Developer = _dev;
                this.ReleaseYear = _releaseYear;
                this.Description = _description;

            }

            public int AppId { get; private set; }

            public string Name { get; private set; }

            public int GameID { get; private set; }
            public string Developer { get; set; }
            public int ReleaseYear { get; set; }
            public string Description { get; set; }

            public string[] Genre { get; private set; }

            public string[] Tags { get; private set; }

        }
}
