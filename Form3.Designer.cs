using System.Windows.Forms;
namespace Clue
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
           // this.FormClosing += this.Form3_FormClosing;
            openCards = new Label();
            players = new Label[Game.playerNumber];
            int handedCards = Game.playerNumber * Game.perPlayerCardCount;
            cards = new Label[handedCards];
            openCardsArray = new Label[Game.totalCardCount - handedCards];
            this.SuspendLayout();
            // 
            // Form3
            // 
            if (Game.totalCardCount - handedCards > 0)
            {
                openCards.Visible = true;
                openCards.Text = "Public Cards";
                openCards.AutoSize = true;
                int locX = 44;
                int locY = 120 + (30 * (Game.perPlayerCardCount + 2));
                openCards.Location = new System.Drawing.Point(locX,locY);
                locY += 30;
                for (int i = 0; i < Game.totalCardCount - handedCards; i++)
                {
                    openCardsArray[i] = new Label();
                    openCardsArray[i].Text = Game.openCards[i];
                    openCardsArray[i].AutoSize = true;
                    openCardsArray[i].Location = new System.Drawing.Point(locX, locY);
                    locY += 30;
                }
            }
            int locationX = 44;
            for (int i = 0; i < Game.playerNumber; i++)
            {
                players[i] = new Label();
                players[i].Text = Game.players[i].name;
                players[i].AutoSize = true;
                players[i].Location = new System.Drawing.Point(locationX, 100);
                locationX += 100;
            }
            locationX = 44;
            int locationY = 120;
            int currentPlayer = 0;
            int currentCard = 0;
            for (int i = 0; i < handedCards; i++)
            {
                if (i % Game.perPlayerCardCount == 0 && i  != 0)
                {
                    currentPlayer++;
                    locationY = 120;
                    locationX += 100;
                    currentCard = 0;
                }
                cards[i] = new Label();
                cards[i].Text = Game.players[currentPlayer].Cards[currentCard];
                currentCard++;
                cards[i].Location = new System.Drawing.Point(locationX, locationY);
                locationY += 30;

            }
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 526);
            this.Name = "Form3";
            this.Text = "All Known Cards";
            this.Controls.AddRange(players);
            this.Controls.AddRange(cards);
            this.Controls.AddRange(openCardsArray);
            this.Controls.Add(openCards);
            this.ResumeLayout(false);

        }
       /* private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }*/

        #endregion
        private Label[] players;
        private Label[] cards;
        private Label openCards;
        private Label[] openCardsArray;
    }
}