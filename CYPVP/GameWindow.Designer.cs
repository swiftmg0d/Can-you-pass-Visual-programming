namespace CYPVP
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.CharacterMovements = new System.Windows.Forms.Timer(this.components);
            this.SlimeMovements = new System.Windows.Forms.Timer(this.components);
            this.TimeLeft = new System.Windows.Forms.Timer(this.components);
            this.TimeLeftLabel = new System.Windows.Forms.PictureBox();
            this.Slime = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScorePoints = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TimeLeftLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            this.SuspendLayout();
            // 
            // CharacterMovements
            // 
            this.CharacterMovements.Tick += new System.EventHandler(this.Movements_Tick);
            // 
            // SlimeMovements
            // 
            this.SlimeMovements.Tick += new System.EventHandler(this.SlimeMovements_Tick);
            // 
            // TimeLeft
            // 
            this.TimeLeft.Tick += new System.EventHandler(this.TimeLeft_Tick);
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.Image = global::CYPVP.Properties.Resources._1_statusbar;
            this.TimeLeftLabel.Location = new System.Drawing.Point(12, 12);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(156, 39);
            this.TimeLeftLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TimeLeftLabel.TabIndex = 2;
            this.TimeLeftLabel.TabStop = false;
            // 
            // Slime
            // 
            this.Slime.Image = global::CYPVP.Properties.Resources.slime_left;
            this.Slime.Location = new System.Drawing.Point(394, 220);
            this.Slime.Name = "Slime";
            this.Slime.Size = new System.Drawing.Size(59, 60);
            this.Slime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Slime.TabIndex = 1;
            this.Slime.TabStop = false;
            // 
            // Character
            // 
            this.Character.Image = global::CYPVP.Properties.Resources.down_standing;
            this.Character.Location = new System.Drawing.Point(450, 223);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(45, 57);
            this.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Character.TabIndex = 0;
            this.Character.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score: 0";
            // 
            // ScorePoints
            // 
            this.ScorePoints.Tick += new System.EventHandler(this.ScorePoints_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.Slime);
            this.Controls.Add(this.Character);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.Text = "CYPVP";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.TimeLeftLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer CharacterMovements;
        private System.Windows.Forms.Timer SlimeMovements;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.PictureBox Slime;
        private System.Windows.Forms.Timer TimeLeft;
        private System.Windows.Forms.PictureBox TimeLeftLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer ScorePoints;
    }
}