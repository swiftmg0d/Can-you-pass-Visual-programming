namespace CYPVP
{
    partial class Form1
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
            this.btn_quit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_title1 = new System.Windows.Forms.Label();
            this.pb_menu = new System.Windows.Forms.PictureBox();
            this.pb_muteSound = new System.Windows.Forms.PictureBox();
            this.lb_version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_muteSound)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(330, 188);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(67, 33);
            this.btn_quit.TabIndex = 0;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Options";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(12, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(197, 47);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Can you pass";
            // 
            // lb_title1
            // 
            this.lb_title1.AutoSize = true;
            this.lb_title1.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.ForeColor = System.Drawing.Color.White;
            this.lb_title1.Location = new System.Drawing.Point(64, 55);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(198, 31);
            this.lb_title1.TabIndex = 4;
            this.lb_title1.Text = "Visaul programming";
            // 
            // pb_menu
            // 
            this.pb_menu.Image = global::CYPVP.Properties.Resources.model1;
            this.pb_menu.Location = new System.Drawing.Point(255, 51);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Size = new System.Drawing.Size(40, 35);
            this.pb_menu.TabIndex = 5;
            this.pb_menu.TabStop = false;
            // 
            // pb_muteSound
            // 
            this.pb_muteSound.Image = global::CYPVP.Properties.Resources.unmute1;
            this.pb_muteSound.Location = new System.Drawing.Point(3, 330);
            this.pb_muteSound.Name = "pb_muteSound";
            this.pb_muteSound.Size = new System.Drawing.Size(56, 37);
            this.pb_muteSound.TabIndex = 6;
            this.pb_muteSound.TabStop = false;
            this.pb_muteSound.Click += new System.EventHandler(this.pb_muteSound_Click);
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_version.ForeColor = System.Drawing.Color.White;
            this.lb_version.Location = new System.Drawing.Point(363, 348);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(34, 19);
            this.lb_version.TabIndex = 7;
            this.lb_version.Text = "v1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYPVP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(409, 370);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.pb_muteSound);
            this.Controls.Add(this.pb_menu);
            this.Controls.Add(this.lb_title1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_quit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_muteSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.PictureBox pb_muteSound;
        private System.Windows.Forms.Label lb_version;
    }
}

