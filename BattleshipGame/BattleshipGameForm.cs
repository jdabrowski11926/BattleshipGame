using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BattleshipGame
{
    public partial class BattleshipGameForm : Form
    {
        private BattleshipsBoard battleshipBoardPlayer1 = new BattleshipsBoard();
        private BattleshipsBoard battleshipBoardPlayer2 = new BattleshipsBoard();
        private Player player1 = new Player();
        private Player player2 = new Player();
        private int tileSize = 30;
        private Pen borderPen = new Pen(Color.FromArgb(255, 255, 255));
        private Brush waterBrush = new SolidBrush(Color.FromArgb(50, 50, 255));
        private Brush shipBrush = new SolidBrush(Color.FromArgb(50, 50, 50));
        private Brush shipHitBrush = new SolidBrush(Color.FromArgb(255, 0, 0));
        private Brush emptyHitBrush = new SolidBrush(Color.FromArgb(255, 255, 255));
        Graphics graphics;
        private bool isGameStarted = false;
        private bool isGameFinished = false;
        private int timeBetweenMoves = 500;
        private Thread gameThread;
        private bool isPlayer1Turn;

        public BattleshipGameForm()
        {
            InitializeComponent();
        }

        public void runGame()
        {
            Thread.CurrentThread.IsBackground = true;
            isGameFinished = false;
            player1.studyEnemyBoard(battleshipBoardPlayer2);
            player2.studyEnemyBoard(battleshipBoardPlayer1);
            while (!isGameFinished)
            {
                if (isGameStarted == true)
                {
                    if (isPlayer1Turn) playOneTurn(player1);
                    else playOneTurn(player2);
                }
            }
        }

        private void playOneTurn(Player player)
        {
            Thread.Sleep(timeBetweenMoves);
            player.randomGuess(getEnemyBattleshipBoard(player));
            updateBoards();
            BeginInvoke(new Action(() => updateLabels()));
            if (getEnemyBattleshipBoard(player).getShipTiles() == 0)
            {
                isGameFinished = true;
                MessageBox.Show("Koniec gry", "Battleship game", MessageBoxButtons.OK);
            }
            isPlayer1Turn = !isPlayer1Turn;
        }

        public void updateBoards()
        {
            for(int i=0; i < battleshipBoardPlayer1.getBoardSize(); i++)
            {
                for(int j=0; j< battleshipBoardPlayer1.getBoardSize(); j++)
                {
                    drawTile(i * tileSize, j * tileSize, battleshipBoardPlayer1.getBoardState(i,j), player1BoardPanel);
                    drawTile(i * tileSize, j * tileSize, battleshipBoardPlayer2.getBoardState(i,j), player2BoardPanel);
                }
            }
        }

        public void updateLabels()
        {
            player1shipTilesLabel.Text = "Player 1 ship tiles : " + battleshipBoardPlayer1.getShipTiles();
            player2shipTilesLabel.Text = "Player 2 ship tiles : " + battleshipBoardPlayer2.getShipTiles();
            player1shipTilesLabel.Refresh();
            player2shipTilesLabel.Refresh();
        }

        public void drawTile(int x, int y, string state, Panel playerPanel)
        {
            graphics = playerPanel.CreateGraphics();
            Rectangle rectangle = new Rectangle(x, y, tileSize, tileSize);
            switch (state)
            {
                case "empty":
                    graphics.FillRectangle(waterBrush, rectangle);
                    break;
                case "ship":
                    graphics.FillRectangle(shipBrush, rectangle);
                    break;
                case "shipHit":
                    graphics.FillRectangle(shipHitBrush, rectangle);
                    break;
                case "emptyHit":
                    graphics.FillRectangle(emptyHitBrush, rectangle);
                    break;
            }
            graphics.DrawRectangle(borderPen, rectangle);
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            isGameStarted = false;
            isGameFinished = false;
            if (gameThread != null)
                terminateOldThread();
            battleshipBoardPlayer1.resetBoard();
            battleshipBoardPlayer2.resetBoard();
            updateBoards();
        }

        private void buttonApplyChanges_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxTimeBetweenMoves.Text, out timeBetweenMoves);
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            selectStartingPlayer();
            isGameStarted = true;
            if (gameThread != null)
                terminateOldThread();
            gameThread = new Thread(runGame);
            gameThread.Start();
        }

        private void terminateOldThread()
        {
            isGameFinished = true;
            gameThread.Join();
        }

        private void selectStartingPlayer()
        {
            Random random = new Random();
            int number = random.Next(0, 2);
            if (number == 1) isPlayer1Turn = true;
            else isPlayer1Turn = false;
        }

        private BattleshipsBoard getEnemyBattleshipBoard(Player player)
        {
            if (player == player1) return battleshipBoardPlayer2;
            else return battleshipBoardPlayer1;
        }
    }
}
