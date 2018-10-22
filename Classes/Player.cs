using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    
    
    Taken from http://rbwhitaker.wikidot.com/c-sharp-creating-classes
     
    The purpose of this program is to learn more about classes.


 */



namespace Classes
{
    class Player
    {
        private string name;
        private int score;
        private int livesLeft;

        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }

        public Player(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }

        public int AddPoints (int totalPoints)
        {
            return score += totalPoints;
        }

        public void Kill()
        {
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        }

        public int GetLivesLeft()
        {
            return livesLeft;
        }
          
    }
}
