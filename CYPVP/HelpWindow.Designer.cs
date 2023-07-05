namespace CYPVP
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.lbl_heading = new System.Windows.Forms.Label();
            this.Character = new System.Windows.Forms.PictureBox();
            this.lbl_control = new System.Windows.Forms.Label();
            this.lbl_instruction = new System.Windows.Forms.Label();
            this.lbl_instruction1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_heading.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_heading.ForeColor = System.Drawing.Color.White;
            this.lbl_heading.Location = new System.Drawing.Point(41, 9);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(393, 42);
            this.lbl_heading.TabIndex = 8;
            this.lbl_heading.Text = "\"Welcome to the game! To control your character\'s movement,\r\n use the following k" +
    "eyboard keys:";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Character
            // 
            this.Character.Image = global::CYPVP.Properties.Resources.down_standing;
            this.Character.Location = new System.Drawing.Point(29, 147);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(69, 70);
            this.Character.TabIndex = 9;
            this.Character.TabStop = false;
            // 
            // lbl_control
            // 
            this.lbl_control.AutoSize = true;
            this.lbl_control.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_control.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_control.Location = new System.Drawing.Point(115, 172);
            this.lbl_control.Name = "lbl_control";
            this.lbl_control.Size = new System.Drawing.Size(242, 21);
            this.lbl_control.TabIndex = 10;
            this.lbl_control.Text = "Press W,A,S,D to move the character ";
            // 
            // lbl_instruction
            // 
            this.lbl_instruction.AutoSize = true;
            this.lbl_instruction.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_instruction.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_instruction.Location = new System.Drawing.Point(12, 321);
            this.lbl_instruction.Name = "lbl_instruction";
            this.lbl_instruction.Size = new System.Drawing.Size(338, 21);
            this.lbl_instruction.TabIndex = 11;
            this.lbl_instruction.Text = "Be careful of the slime and reach the goal of the game";
            // 
            // lbl_instruction1
            // 
            this.lbl_instruction1.AutoSize = true;
            this.lbl_instruction1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_instruction1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_instruction1.Location = new System.Drawing.Point(25, 341);
            this.lbl_instruction1.Name = "lbl_instruction1";
            this.lbl_instruction1.Size = new System.Drawing.Size(355, 21);
            this.lbl_instruction1.TabIndex = 12;
            this.lbl_instruction1.Text = "....and also don\'t forget to open the chests ;) . Good luck!";
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYPVP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(474, 369);
            this.Controls.Add(this.lbl_instruction1);
            this.Controls.Add(this.lbl_instruction);
            this.Controls.Add(this.lbl_control);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.lbl_heading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HelpWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HelpWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.Label lbl_control;
        private System.Windows.Forms.Label lbl_instruction;
        private System.Windows.Forms.Label lbl_instruction1;
    }
}