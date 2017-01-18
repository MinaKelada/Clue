using System.Windows.Forms;
namespace Clue
{
    partial class Form2
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
            Game.renamed -= this.assignPlayerName.OnRename;
            Game.Dispose();
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
            this.locationChecks = new System.Windows.Forms.CheckBox[Game.locationArray.Length];
            this.objectChecks = new System.Windows.Forms.CheckBox[Game.objectsArray.Length];
            this.suspectChecks = new System.Windows.Forms.CheckBox[Game.suspectsArray.Length];
            this.locationLabel = new System.Windows.Forms.Label();
            this.suspectLabel = new System.Windows.Forms.Label();
            this.objectLabel = new System.Windows.Forms.Label();
            this.showAll = new System.Windows.Forms.Button();
            this.assignButton = new Button();
            this.assignCard = new ComboBox();
            this.assignPlayerName = new ModdedComboBox();
            this.rename = new Button();
            this.warning = new Label();
            this.SuspendLayout();
            //
            //showAll
            //
            this.showAll.Text = "Show All Known";
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            this.showAll.Size = new System.Drawing.Size(100, 25);
            //
            //Rename
            //
            this.rename.Text = "Rename";
            this.rename.Click += new System.EventHandler(this.rename_Click);
            this.rename.Size = this.showAll.Size;
            //
            // locationLabel
            //
            this.locationLabel.AutoSize = true;
            this.locationLabel.Text = "Locations";
            this.locationLabel.Location = new System.Drawing.Point(25, 24);
            //
            // suspectLabel
            //
            this.suspectLabel.AutoSize = true;
            this.suspectLabel.Text = "Suspects";
            this.suspectLabel.Location = new System.Drawing.Point(225, 24);
            //
            // objectLabel
            //
            this.objectLabel.AutoSize = true;
            this.objectLabel.Text = "Objects";
            this.objectLabel.Location = new System.Drawing.Point(425, 24);
            // 
            // checkBox1
            // 
            int locationY = 44;
            for (int i = 0; i < Game.locationArray.Length; i++)
            {
                locationChecks[i] = new System.Windows.Forms.CheckBox();
                this.locationChecks[i].AutoSize = true;
                this.locationChecks[i].Location = new System.Drawing.Point(25, locationY);
                locationY += 20;
                this.locationChecks[i].Name = Game.locationArray[i];
                this.locationChecks[i].Size = new System.Drawing.Size(80, 17);
                this.locationChecks[i].TabIndex = 0;
                this.locationChecks[i].Text = Game.locationArray[i];
                this.locationChecks[i].UseVisualStyleBackColor = true;
            }
            this.showAll.Location = new System.Drawing.Point(25, locationY + 20);
            this.rename.Location = new System.Drawing.Point(225, locationY + 20);
            locationY = 44;
            for (int i = 0; i < Game.objectsArray.Length; i++)
            {
                objectChecks[i] = new System.Windows.Forms.CheckBox();
                this.objectChecks[i].AutoSize = true;
                this.objectChecks[i].Location = new System.Drawing.Point(225, locationY);
                locationY += 20;
                this.objectChecks[i].Name = Game.objectsArray[i];
                this.objectChecks[i].Size = new System.Drawing.Size(80, 17);
                this.objectChecks[i].TabIndex = 0;
                this.objectChecks[i].Text = Game.objectsArray[i];
                this.objectChecks[i].UseVisualStyleBackColor = true;
            }
            locationY = 44;
            for (int i = 0; i < Game.suspectsArray.Length; i++)
            {
                suspectChecks[i] = new System.Windows.Forms.CheckBox();
                this.suspectChecks[i].AutoSize = true;
                this.suspectChecks[i].Location = new System.Drawing.Point(425, locationY);
                locationY += 20;
                this.suspectChecks[i].Name = Game.suspectsArray[i];
                this.suspectChecks[i].Size = new System.Drawing.Size(80, 17);
                this.suspectChecks[i].TabIndex = 0;
                this.suspectChecks[i].Text = Game.suspectsArray[i];
                this.suspectChecks[i].UseVisualStyleBackColor = true;
            }
            //
            //assignPlayerName
            //
            //this not showing up yet, work here
            this.assignPlayerName.Size = this.showAll.Size;
            this.assignPlayerName.Location = new System.Drawing.Point(this.showAll.Location.X, this.showAll.Location.Y + 40);
            this.assignPlayerName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.assignPlayerName.Items.AddRange(Game.getAllPlayerNames());
            this.assignPlayerName.FormattingEnabled = true;
            Game.renamed += this.assignPlayerName.OnRename;
            this.assignPlayerName.SelectedIndex = 0;
            //
            //assignCard
            //
            //this not showing up yet, work here
            this.assignCard.Size = this.showAll.Size;
            this.assignCard.Location = new System.Drawing.Point(this.rename.Location.X, this.rename.Location.Y + 40);
            this.assignCard.DropDownStyle = ComboBoxStyle.DropDownList;
            this.assignCard.Items.AddRange(Game.getAllCards());
            this.assignCard.FormattingEnabled = true;
            this.assignCard.SelectedIndex = 0;
            //
            //assignButton
            //
            this.assignButton.Size = this.showAll.Size;
            this.assignButton.Location = new System.Drawing.Point(this.rename.Location.X + (this.rename.Location.X-this.showAll.Location.X), this.rename.Location.Y + 40);
            this.assignButton.Text = "Assign";
            this.assignButton.Click += assign_Click;
            //
            //warning
            //
            this.warning.Location = new System.Drawing.Point(this.showAll.Location.X, 400);
            this.warning.Visible = false;
            this.warning.AutoSize = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 426);
            for (int i = 0; i < Game.locationArray.Length; i++)
            {
                this.Controls.Add(this.locationChecks[i]);
            }
            for (int i = 0; i < Game.objectsArray.Length; i++)
            {
                this.Controls.Add(this.objectChecks[i]);
            }
            for (int i = 0; i < Game.suspectsArray.Length; i++)
            {
                this.Controls.Add(this.suspectChecks[i]);
            }
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.suspectLabel);
            this.Controls.Add(this.objectLabel);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.assignPlayerName);
            this.Controls.Add(this.assignCard);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.warning);
            this.Name = "Form2";
            this.Text = "Clue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox [] locationChecks;
        private System.Windows.Forms.CheckBox[] objectChecks;
        private System.Windows.Forms.CheckBox[] suspectChecks;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label objectLabel;
        private System.Windows.Forms.Label suspectLabel;
        private System.Windows.Forms.Button showAll;
        private Label warning;
        private Button assignButton;
        private ComboBox assignCard;
        private ModdedComboBox assignPlayerName;
        private Button rename;
    }
}