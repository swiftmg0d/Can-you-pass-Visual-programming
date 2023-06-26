namespace CYPVP
{
    partial class CYPVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CYPVP));
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
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
            this.btn_quit.Location = new System.Drawing.Point(495, 289);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(100, 51);
            this.btn_quit.TabIndex = 0;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(495, 165);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 49);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(495, 223);
            this.btn_help.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(100, 57);
            this.btn_help.TabIndex = 2;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(18, 14);
            this.lb_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(298, 72);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Can you pass";
            // 
            // lb_title1
            // 
            this.lb_title1.AutoSize = true;
            this.lb_title1.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title1.ForeColor = System.Drawing.Color.White;
            this.lb_title1.Location = new System.Drawing.Point(96, 85);
            this.lb_title1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_title1.Name = "lb_title1";
            this.lb_title1.Size = new System.Drawing.Size(284, 46);
            this.lb_title1.TabIndex = 4;
            this.lb_title1.Text = "Visaul programming";
            // 
            // pb_menu
            // 
            this.pb_menu.Image = global::CYPVP.Properties.Resources.model1;
            this.pb_menu.Location = new System.Drawing.Point(382, 78);
            this.pb_menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Size = new System.Drawing.Size(60, 54);
            this.pb_menu.TabIndex = 5;
            this.pb_menu.TabStop = false;
            // 
            // pb_muteSound
            // 
            this.pb_muteSound.Image = global::CYPVP.Properties.Resources.unmute1;
            this.pb_muteSound.Location = new System.Drawing.Point(4, 508);
            this.pb_muteSound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_muteSound.Name = "pb_muteSound";
            this.pb_muteSound.Size = new System.Drawing.Size(84, 57);
            this.pb_muteSound.TabIndex = 6;
            this.pb_muteSound.TabStop = false;
            this.pb_muteSound.Click += new System.EventHandler(this.pb_muteSound_Click);
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_version.ForeColor = System.Drawing.Color.White;
            this.lb_version.Location = new System.Drawing.Point(544, 535);
            this.lb_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(50, 30);
            this.lb_version.TabIndex = 7;
            this.lb_version.Text = "v1.0";
            // 
            // CYPVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYPVP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(614, 569);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.pb_muteSound);
            this.Controls.Add(this.pb_menu);
            this.Controls.Add(this.lb_title1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_quit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CYPVP";
            this.Text = "CYPVP";
           // this.Load += new System.EventHandler(this.CYPVP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_muteSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_title1;
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.PictureBox pb_muteSound;
        private System.Windows.Forms.Label lb_version;
    }
}

