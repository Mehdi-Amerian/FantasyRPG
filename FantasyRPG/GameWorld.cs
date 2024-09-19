using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    public class GameWorld
    {
        private static GameWorld instance = null;
        private static readonly object padlock = new object();

        private GameWorld() 
        {
        
        }

        public static GameWorld Instance 
        {
            get
            {
                if (instance == null) 
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new GameWorld();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
