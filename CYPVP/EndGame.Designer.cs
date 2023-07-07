namespace CYPVP
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.lb_GameOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Points = new System.Windows.Forms.Label();
            this.lb_Grade = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_GameOver
            // 
            this.lb_GameOver.AutoSize = true;
            this.lb_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.lb_GameOver.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GameOver.ForeColor = System.Drawing.Color.White;
            this.lb_GameOver.Location = new System.Drawing.Point(34, 9);
            this.lb_GameOver.Name = "lb_GameOver";
            this.lb_GameOver.Size = new System.Drawing.Size(303, 71);
            this.lb_GameOver.TabIndex = 0;
            this.lb_GameOver.Text = "GAME OVER!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "GRADE:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Points
            // 
            this.lb_Points.AutoSize = true;
            this.lb_Points.BackColor = System.Drawing.Color.Transparent;
            this.lb_Points.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Points.ForeColor = System.Drawing.Color.White;
            this.lb_Points.Location = new System.Drawing.Point(265, 121);
            this.lb_Points.Name = "lb_Points";
            this.lb_Points.Size = new System.Drawing.Size(80, 33);
            this.lb_Points.TabIndex = 3;
            this.lb_Points.Text = "Points:";
            this.lb_Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Grade
            // 
            this.lb_Grade.AutoSize = true;
            this.lb_Grade.BackColor = System.Drawing.Color.Transparent;
            this.lb_Grade.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Grade.ForeColor = System.Drawing.Color.White;
            this.lb_Grade.Location = new System.Drawing.Point(278, 80);
            this.lb_Grade.Name = "lb_Grade";
            this.lb_Grade.Size = new System.Drawing.Size(80, 33);
            this.lb_Grade.TabIndex = 4;
            this.lb_Grade.Text = "Points:";
            this.lb_Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sorry you failed Visual Programming";
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYPVP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(372, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_Grade);
            this.Controls.Add(this.lb_Points);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_GameOver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CYPVP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_GameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Points;
        private System.Windows.Forms.Label lb_Grade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}