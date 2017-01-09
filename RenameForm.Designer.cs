using System.Windows.Forms;
namespace Clue
{
    partial class RenameForm
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
            currentNames = new Label[Game.playerNumber];
            newNames = new TextBox[Game.playerNumber];
            submit = new Button();
            warning = new Label();
            int cX = 75;
            int nX = 275;
            int locY = 30;
            for (int i = 0; i < Game.playerNumber; i++)
            {
                currentNames[i] = new Label();
                newNames[i] = new TextBox();
                currentNames[i].Text = Game.players[i].name;
                currentNames[i].AutoSize = true;
                newNames[i].Size = new System.Drawing.Size(75, 23);
                currentNames[i].Location = new System.Drawing.Point(cX, locY);
                newNames[i].Location = new System.Drawing.Point(nX, locY);
                locY += 30;
            }
            //
            //submit
            //
            this.submit.Text = "OK";
            this.submit.Click += new System.EventHandler(this.ok_click);
            this.submit.AutoSize = true;
            this.submit.Location = new System.Drawing.Point(nX, locY);
            //
            //warning
            //
            this.warning.Visible = false;
            this.warning.AutoSize = true;
            this.warning.Location = new System.Drawing.Point(nX, locY + 30);
            this.warning.Text = "No identical names are allowed";
            //
            this.Controls.AddRange(currentNames);
            this.Controls.AddRange(newNames);
            this.Controls.Add(submit);
            this.Controls.Add(warning);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 526);
            this.Text = "Rename Characters";
        }
        #endregion
        private Label[] currentNames;
        private TextBox[] newNames;
        private Button submit;
        private Label warning;
    }
}