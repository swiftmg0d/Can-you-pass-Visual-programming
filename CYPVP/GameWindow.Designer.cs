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
            this.label1 = new System.Windows.Forms.Label();
            this.ScorePoints = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.PictureBox();
            this.Slime = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.Hud = new System.Windows.Forms.PictureBox();
            this.Hud1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLeftLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hud1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(411, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Points: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScorePoints
            // 
            this.ScorePoints.Tick += new System.EventHandler(this.ScorePoints_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "TIME LEFT:  0";
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
            this.Slime.Location = new System.Drawing.Point(25, 119);
            this.Slime.Name = "Slime";
            this.Slime.Size = new System.Drawing.Size(59, 60);
            this.Slime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Slime.TabIndex = 1;
            this.Slime.TabStop = false;
            // 
            // Character
            // 
            this.Character.Image = global::CYPVP.Properties.Resources.down_standing;
            this.Character.Location = new System.Drawing.Point(140, 122);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(45, 57);
            this.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Character.TabIndex = 0;
            this.Character.TabStop = false;
            // 
            // Hud
            // 
            this.Hud.Image = global::CYPVP.Properties.Resources.Btn01;
            this.Hud.Location = new System.Drawing.Point(3, 3);
            this.Hud.Name = "Hud";
            this.Hud.Size = new System.Drawing.Size(525, 84);
            this.Hud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hud.TabIndex = 4;
            this.Hud.TabStop = false;
            // 
            // Hud1
            // 
            this.Hud1.Image = global::CYPVP.Properties.Resources.Btn01;
            this.Hud1.Location = new System.Drawing.Point(534, 7);
            this.Hud1.Name = "Hud1";
            this.Hud1.Size = new System.Drawing.Size(308, 65);
            this.Hud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hud1.TabIndex = 6;
            this.Hud1.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Hud1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.Slime);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Hud);
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
            ((System.ComponentModel.ISupportInitialize)(this.Hud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hud1)).EndInit();
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
        private System.Windows.Forms.PictureBox Hud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Hud1;
    }
}