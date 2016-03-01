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
            Game MB = new Game(120, "Monster Bruterrr", "MMORPG", "Action", "Fantasy");
            Game SuperSheep = new Game(110, "Super Sheep", "Action", "Animal");
            Game LostManIsLost = new Game(102, "Lost Man Is Lost", "Horror", "Funny", "Fantasy");
            Game DakkeDakMusic = new Game(96, "Dakke Dak Music Simulator", "Funny", "Dark");
            Game RaidThePlayStore = new Game(95, "Raid The Play Store", "Gore", "Horror", "Dark", "Action");
            Game District42 = new Game(82, "District 42", "Science Fiction", "Space", "Action");
            Game SailToTheMoon = new Game(56, "Sail To The Moon", "Space", "Animal");
            Game BrotherIsADuckling = new Game(51, "Brother Is A Duckling", "Animal", "Dark");
            Game ProtonSimulator = new Game(39, "Proton Simulator", "Boring", "MMORPG");
            Game NiceCakeMrRobinson = new Game(20, "Nice Cake Mr Robinson", "Space", "Fantasy", "Action");

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
        }

        List<Game> GameList = new List<Game>();

        public List<Game> GetList(string Name)
        {
            return GameList;
        }



        public class Game
        {
            private static int ID = 0;
            public Game(int _point, string _name, params string[] _genre)
            {
                this.Name = _name;
                this.Genre = _genre;
                this.GameID = ID++;
                this.RCPoint = _point;
            }

            public int RCPoint { get; private set; }

            public string Name { get; private set; }

            public int GameID { get; private set; }

            public string[] Genre { get; private set; }

            public string[] Tags { get; private set; }

        }
    }
}
