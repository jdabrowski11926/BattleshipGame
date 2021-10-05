using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipGame
{
    class BattleshipsBoard
    {
        private int boardSize = 10;
        private string[,] board;
        private string[] orientations = { "left", "right", "down", "up" };
        private int numberOfCarriers = 1;
        private int numberOfBattleships = 1;
        private int numberOfCruisers = 1;
        private int numberOfDestroyers = 2;
        private int numberOfSubmarines = 2;
        private int numberOfShipTiles;

        public BattleshipsBoard()
        {
            initializeBoard();
            placeBattleships();
        }

        public void resetBoard()
        {
            initializeBoard();
            placeBattleships();
        }

        public void initializeBoard()
        {
            board = new string[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                    board[i, j] = "empty";
            }
        }

        public void placeBattleships()
        {
            for(int i=0; i<numberOfCarriers;i++)
                placeBattleship(5);
            for (int i = 0; i < numberOfBattleships; i++)
                placeBattleship(4);
            for (int i = 0; i < numberOfCruisers; i++)
                placeBattleship(3);
            for (int i = 0; i < numberOfDestroyers; i++)
                placeBattleship(2);
            for (int i = 0; i < numberOfSubmarines; i++)
                placeBattleship(1);
            numberOfShipTiles = numberOfCarriers * 5 + numberOfBattleships * 4 + numberOfCruisers * 3 + numberOfDestroyers * 2 + numberOfSubmarines;
        }

        public void placeBattleship(int shipSize)
        {
            Random random = new Random();
            bool isShipPlacementPossible;
            do
            {
                int randomX = random.Next(0, boardSize - 1);
                int randomY = random.Next(0, boardSize - 1);
                string orientation = orientations[random.Next(0, 3)];
                isShipPlacementPossible = isPlacementPossible(randomX, randomY, shipSize, orientation);
                if (isShipPlacementPossible)
                    markBattleshipOnBoard(randomX, randomY, shipSize, orientation);
            } while (!isShipPlacementPossible);
        }

        public bool isPlacementPossible(int x, int y, int shipSize, string orientation)
        {
            switch (orientation)
            {
                case "right":
                    if (x + shipSize > boardSize) return false;
                    for(int i=0; i<shipSize; i++)
                        if (board[x + i, y].Equals("ship")) return false;
                    break;
                case "left":
                    if (shipSize - x >= 0) return false;
                    for (int i = 0; i < shipSize; i++)
                    {
                        Console.WriteLine("x = " + x + " i=" + i);
                        if (board[x - i, y].Equals("ship")) return false;
                    }
                    break;
                case "down":
                    if (y + shipSize > boardSize) return false;
                    for (int i = 0; i < shipSize; i++)
                        if (board[x, y + i].Equals("ship")) return false;
                    break;
                case "up":
                    if (shipSize - y >= 0) return false;
                    for (int i = 0; i < shipSize; i++)
                        if (board[x, y - i].Equals("ship")) return false;
                    break;
            }
            return true;
        }

        public void markBattleshipOnBoard(int x, int y, int shipSize, string orientation)
        {
            switch (orientation)
            {
                case "right":
                    for (int i = 0; i < shipSize; i++)
                        board[x + i, y] = "ship";
                    break;
                case "left":
                    for (int i = 0; i < shipSize; i++)
                        board[x - i, y] = "ship";
                    break;
                case "down":
                    for (int i = 0; i < shipSize; i++)
                        board[x, y + i] = "ship";
                    break;
                case "up":
                    for (int i = 0; i < shipSize; i++)
                        board[x, y - i] = "ship";
                    break;
            }
        }

        public string getBoardState(int i, int j)
        {
            return board[i, j];
        }

        public int getBoardSize()
        {
            return boardSize;
        }

        public int getShipTiles()
        {
            return numberOfShipTiles;
        }

        public bool markHit(int x, int y)
        {
            if (board[x, y] == "ship")
            { 
                board[x, y] = "shipHit";
                numberOfShipTiles--;
                return true;
            }
            if(board[x,y] == "empty")
            {
                board[x, y] = "emptyHit";
                return false;
            }
            return false;
        }
    }
}
