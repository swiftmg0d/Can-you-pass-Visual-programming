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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.btn_goBack = new System.Windows.Forms.Button();
            this.MovmentsTick = new System.Windows.Forms.Timer(this.components);
            this.textLabel = new System.Windows.Forms.Label();
            this.Character = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_goBack
            // 
            this.btn_goBack.Location = new System.Drawing.Point(13, 522);
            this.btn_goBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(112, 35);
            this.btn_goBack.TabIndex = 0;
            this.btn_goBack.Text = "Back";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovmentsTick
            // 
            this.MovmentsTick.Tick += new System.EventHandler(this.MovmentsTick_Tick);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textLabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.textLabel.ForeColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(19, 30);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(770, 248);
            this.textLabel.TabIndex = 8;
            this.textLabel.Text = resources.GetString("textLabel.Text");
            // 
            // Character
            // 
            this.Character.Image = ((System.Drawing.Image)(resources.GetObject("Character.Image")));
            this.Character.Location = new System.Drawing.Point(367, 396);
            this.Character.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(104, 106);
            this.Character.TabIndex = 9;
            this.Character.TabStop = false;
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYPVP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(802, 571);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.btn_goBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpWindow";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HelpWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HelpWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_goBack;
        private System.Windows.Forms.Timer MovmentsTick;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.PictureBox Character;
    }
}