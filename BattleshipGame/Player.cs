using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipGame
{
    class Player
    {
        struct Coordinates { public int x, y; }
        private List<Coordinates> possibleNextGuesses;

        public void studyEnemyBoard(BattleshipsBoard enemyBoard)
        {
            possibleNextGuesses = new List<Coordinates>();
            for(int i=0; i < enemyBoard.getBoardSize(); i++)
            {
                for(int j=0; j < enemyBoard.getBoardSize(); j++)
                {
                    Coordinates coordinates;
                    coordinates.x = i;
                    coordinates.y = j;
                    possibleNextGuesses.Add(coordinates);
                }
            }
        }

        public void randomGuess(BattleshipsBoard enemyBoard)
        {
            Random random = new Random();
            int randomGuessNr = random.Next(0, possibleNextGuesses.Count - 1);
            int x = possibleNextGuesses[randomGuessNr].x;
            int y = possibleNextGuesses[randomGuessNr].y;
            enemyBoard.markHit(x, y);
            possibleNextGuesses.RemoveAt(randomGuessNr);
        }

    }
}
