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
            this.lb_Points = new System.Windows.Forms.Label();
            this.ScorePoints = new System.Windows.Forms.Timer(this.components);
            this.lb_TimeLeft = new System.Windows.Forms.Label();
            this.StarsSpawn = new System.Windows.Forms.Timer(this.components);
            this.lb_Tips_Heading = new System.Windows.Forms.Label();
            this.lb_Heading_text = new System.Windows.Forms.Label();
            this.TipsTimer = new System.Windows.Forms.Timer(this.components);
            this.StarsFade = new System.Windows.Forms.Timer(this.components);
            this.lb_Paused = new System.Windows.Forms.Label();
            this.lb_Paused1 = new System.Windows.Forms.Label();
            this.SlimeRadiation = new System.Windows.Forms.Timer(this.components);
            this.lb_ChestAnoucment = new System.Windows.Forms.Label();
            this.Hud1 = new System.Windows.Forms.PictureBox();
            this.TimeLeftLabel = new System.Windows.Forms.PictureBox();
            this.Slime = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.Hud = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLeftLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hud)).BeginInit();
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
            // lb_Points
            // 
            this.lb_Points.AutoSize = true;
            this.lb_Points.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Points.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Points.Location = new System.Drawing.Point(396, 22);
            this.lb_Points.Name = "lb_Points";
            this.lb_Points.Size = new System.Drawing.Size(86, 18);
            this.lb_Points.TabIndex = 3;
            this.lb_Points.Text = "Points: 0";
            // 
            // ScorePoints
            // 
            this.ScorePoints.Tick += new System.EventHandler(this.ScorePoints_Tick);
            // 
            // lb_TimeLeft
            // 
            this.lb_TimeLeft.AutoSize = true;
            this.lb_TimeLeft.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimeLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_TimeLeft.Location = new System.Drawing.Point(22, 54);
            this.lb_TimeLeft.Name = "lb_TimeLeft";
            this.lb_TimeLeft.Size = new System.Drawing.Size(119, 18);
            this.lb_TimeLeft.TabIndex = 5;
            this.lb_TimeLeft.Text = "TIME LEFT:  0";
            // 
            // StarsSpawn
            // 
            this.StarsSpawn.Interval = 5000;
            this.StarsSpawn.Tick += new System.EventHandler(this.StarsSpawn_Tick);
            // 
            // lb_Tips_Heading
            // 
            this.lb_Tips_Heading.AutoSize = true;
            this.lb_Tips_Heading.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Tips_Heading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Tips_Heading.Location = new System.Drawing.Point(547, 22);
            this.lb_Tips_Heading.Name = "lb_Tips_Heading";
            this.lb_Tips_Heading.Size = new System.Drawing.Size(39, 15);
            this.lb_Tips_Heading.TabIndex = 7;
            this.lb_Tips_Heading.Text = "TIPS";
            // 
            // lb_Heading_text
            // 
            this.lb_Heading_text.AutoSize = true;
            this.lb_Heading_text.Font = new System.Drawing.Font("Algerian", 9.6F, System.Drawing.FontStyle.Bold);
            this.lb_Heading_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Heading_text.Location = new System.Drawing.Point(592, 22);
            this.lb_Heading_text.MaximumSize = new System.Drawing.Size(190, 0);
            this.lb_Heading_text.Name = "lb_Heading_text";
            this.lb_Heading_text.Size = new System.Drawing.Size(61, 15);
            this.lb_Heading_text.TabIndex = 8;
            this.lb_Heading_text.Text = "label1";
            // 
            // TipsTimer
            // 
            this.TipsTimer.Interval = 10000;
            this.TipsTimer.Tick += new System.EventHandler(this.TipsTimer_Tick);
            // 
            // StarsFade
            // 
            this.StarsFade.Interval = 1200;
            this.StarsFade.Tick += new System.EventHandler(this.StarsFade_Tick);
            // 
            // lb_Paused
            // 
            this.lb_Paused.AutoSize = true;
            this.lb_Paused.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Paused.ForeColor = System.Drawing.Color.White;
            this.lb_Paused.Location = new System.Drawing.Point(530, 108);
            this.lb_Paused.Name = "lb_Paused";
            this.lb_Paused.Size = new System.Drawing.Size(0, 24);
            this.lb_Paused.TabIndex = 9;
            // 
            // lb_Paused1
            // 
            this.lb_Paused1.AutoSize = true;
            this.lb_Paused1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Paused1.ForeColor = System.Drawing.Color.White;
            this.lb_Paused1.Location = new System.Drawing.Point(536, 129);
            this.lb_Paused1.Name = "lb_Paused1";
            this.lb_Paused1.Size = new System.Drawing.Size(0, 24);
            this.lb_Paused1.TabIndex = 10;
            // 
            // SlimeRadiation
            // 
            this.SlimeRadiation.Interval = 2000;
            this.SlimeRadiation.Tick += new System.EventHandler(this.SlimeRadiation_Tick);
            // 
            // lb_ChestAnoucment
            // 
            this.lb_ChestAnoucment.AutoSize = true;
            this.lb_ChestAnoucment.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChestAnoucment.ForeColor = System.Drawing.Color.White;
            this.lb_ChestAnoucment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_ChestAnoucment.Location = new System.Drawing.Point(186, 53);
            this.lb_ChestAnoucment.Name = "lb_ChestAnoucment";
            this.lb_ChestAnoucment.Size = new System.Drawing.Size(0, 19);
            this.lb_ChestAnoucment.TabIndex = 11;
            // 
            // Hud1
            // 
            this.Hud1.Image = global::CYPVP.Properties.Resources.Btn01;
            this.Hud1.Location = new System.Drawing.Point(534, 3);
            this.Hud1.Name = "Hud1";
            this.Hud1.Size = new System.Drawing.Size(308, 93);
            this.Hud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hud1.TabIndex = 6;
            this.Hud1.TabStop = false;
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
            this.Slime.Location = new System.Drawing.Point(534, 226);
            this.Slime.Name = "Slime";
            this.Slime.Size = new System.Drawing.Size(59, 60);
            this.Slime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Slime.TabIndex = 1;
            this.Slime.TabStop = false;
            // 
            // Character
            // 
            this.Character.Image = global::CYPVP.Properties.Resources.left_standing;
            this.Character.Location = new System.Drawing.Point(123, 163);
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
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lb_ChestAnoucment);
            this.Controls.Add(this.lb_Paused1);
            this.Controls.Add(this.lb_Paused);
            this.Controls.Add(this.lb_Heading_text);
            this.Controls.Add(this.lb_Tips_Heading);
            this.Controls.Add(this.Hud1);
            this.Controls.Add(this.lb_TimeLeft);
            this.Controls.Add(this.lb_Points);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.Slime);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Hud);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CYPVP";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Hud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLeftLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hud)).EndInit();
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
        private System.Windows.Forms.Label lb_Points;
        private System.Windows.Forms.Timer ScorePoints;
        private System.Windows.Forms.PictureBox Hud;
        private System.Windows.Forms.Label lb_TimeLeft;
        private System.Windows.Forms.Timer StarsSpawn;
        private System.Windows.Forms.PictureBox Hud1;
        private System.Windows.Forms.Label lb_Tips_Heading;
        private System.Windows.Forms.Label lb_Heading_text;
        private System.Windows.Forms.Timer TipsTimer;
        private System.Windows.Forms.Timer StarsFade;
        private System.Windows.Forms.Label lb_Paused;
        private System.Windows.Forms.Label lb_Paused1;
        private System.Windows.Forms.Timer SlimeRadiation;
        private System.Windows.Forms.Label lb_ChestAnoucment;
    }
}