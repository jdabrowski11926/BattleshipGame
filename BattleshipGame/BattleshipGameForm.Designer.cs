
namespace BattleshipGame
{
    partial class BattleshipGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.labelTimeBetweenMoves = new System.Windows.Forms.Label();
            this.textBoxTimeBetweenMoves = new System.Windows.Forms.TextBox();
            this.buttonApplyChanges = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.player1BoardPanel = new System.Windows.Forms.Panel();
            this.player2BoardPanel = new System.Windows.Forms.Panel();
            this.player1shipTilesLabel = new System.Windows.Forms.Label();
            this.player2shipTilesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(12, 12);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(179, 39);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // labelTimeBetweenMoves
            // 
            this.labelTimeBetweenMoves.AutoSize = true;
            this.labelTimeBetweenMoves.Location = new System.Drawing.Point(12, 81);
            this.labelTimeBetweenMoves.Name = "labelTimeBetweenMoves";
            this.labelTimeBetweenMoves.Size = new System.Drawing.Size(119, 15);
            this.labelTimeBetweenMoves.TabIndex = 1;
            this.labelTimeBetweenMoves.Text = "Time between moves";
            // 
            // textBoxTimeBetweenMoves
            // 
            this.textBoxTimeBetweenMoves.Location = new System.Drawing.Point(12, 99);
            this.textBoxTimeBetweenMoves.Name = "textBoxTimeBetweenMoves";
            this.textBoxTimeBetweenMoves.Size = new System.Drawing.Size(179, 23);
            this.textBoxTimeBetweenMoves.TabIndex = 2;
            this.textBoxTimeBetweenMoves.Text = "500";
            // 
            // buttonApplyChanges
            // 
            this.buttonApplyChanges.Location = new System.Drawing.Point(12, 128);
            this.buttonApplyChanges.Name = "buttonApplyChanges";
            this.buttonApplyChanges.Size = new System.Drawing.Size(179, 37);
            this.buttonApplyChanges.TabIndex = 3;
            this.buttonApplyChanges.Text = "Apply changes";
            this.buttonApplyChanges.UseVisualStyleBackColor = true;
            this.buttonApplyChanges.Click += new System.EventHandler(this.buttonApplyChanges_Click);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(12, 192);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(179, 44);
            this.buttonStartGame.TabIndex = 4;
            this.buttonStartGame.Text = "Start game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // player1BoardPanel
            // 
            this.player1BoardPanel.Location = new System.Drawing.Point(223, 12);
            this.player1BoardPanel.Name = "player1BoardPanel";
            this.player1BoardPanel.Size = new System.Drawing.Size(394, 363);
            this.player1BoardPanel.TabIndex = 5;
            // 
            // player2BoardPanel
            // 
            this.player2BoardPanel.Location = new System.Drawing.Point(642, 12);
            this.player2BoardPanel.Name = "player2BoardPanel";
            this.player2BoardPanel.Size = new System.Drawing.Size(456, 363);
            this.player2BoardPanel.TabIndex = 6;
            // 
            // player1shipTilesLabel
            // 
            this.player1shipTilesLabel.AutoSize = true;
            this.player1shipTilesLabel.Location = new System.Drawing.Point(223, 378);
            this.player1shipTilesLabel.Name = "player1shipTilesLabel";
            this.player1shipTilesLabel.Size = new System.Drawing.Size(0, 15);
            this.player1shipTilesLabel.TabIndex = 8;
            // 
            // player2shipTilesLabel
            // 
            this.player2shipTilesLabel.AutoSize = true;
            this.player2shipTilesLabel.Location = new System.Drawing.Point(642, 382);
            this.player2shipTilesLabel.Name = "player2shipTilesLabel";
            this.player2shipTilesLabel.Size = new System.Drawing.Size(0, 15);
            this.player2shipTilesLabel.TabIndex = 9;
            // 
            // BattleshipGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 709);
            this.Controls.Add(this.player2shipTilesLabel);
            this.Controls.Add(this.player1shipTilesLabel);
            this.Controls.Add(this.player2BoardPanel);
            this.Controls.Add(this.player1BoardPanel);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.buttonApplyChanges);
            this.Controls.Add(this.textBoxTimeBetweenMoves);
            this.Controls.Add(this.labelTimeBetweenMoves);
            this.Controls.Add(this.buttonNewGame);
            this.Name = "BattleshipGameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label labelTimeBetweenMoves;
        private System.Windows.Forms.TextBox textBoxTimeBetweenMoves;
        private System.Windows.Forms.Button buttonApplyChanges;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Panel player1BoardPanel;
        private System.Windows.Forms.Panel player2BoardPanel;
        private System.Windows.Forms.Label player1shipTilesLabel;
        private System.Windows.Forms.Label player2shipTilesLabel;
    }
}

