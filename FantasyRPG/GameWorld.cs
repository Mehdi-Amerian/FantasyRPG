using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    public class GameWorld
    {
        private static GameWorld _instance = new GameWorld();
        static GameWorld()
        {

        }

        private GameWorld() 
        {
        
        }

        public static GameWorld Instance 
        {
            get
            {
                return _instance;
            }
        }
    }
}
