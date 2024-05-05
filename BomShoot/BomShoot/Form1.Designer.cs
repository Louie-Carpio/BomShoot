
namespace BomShoot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BGtimer = new System.Windows.Forms.Timer(this.components);
            this.Leftmove = new System.Windows.Forms.Timer(this.components);
            this.Rightmove = new System.Windows.Forms.Timer(this.components);
            this.Upmove = new System.Windows.Forms.Timer(this.components);
            this.Downmove = new System.Windows.Forms.Timer(this.components);
            this.BulleT = new System.Windows.Forms.Timer(this.components);
            this.Enemytimer = new System.Windows.Forms.Timer(this.components);
            this.eBulleT = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rplay = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // BGtimer
            // 
            this.BGtimer.Enabled = true;
            this.BGtimer.Interval = 10;
            this.BGtimer.Tick += new System.EventHandler(this.BGtimer_Tick_1);
            // 
            // Leftmove
            // 
            this.Leftmove.Interval = 5;
            this.Leftmove.Tick += new System.EventHandler(this.Leftmove_Tick_1);
            // 
            // Rightmove
            // 
            this.Rightmove.Interval = 5;
            this.Rightmove.Tick += new System.EventHandler(this.Rightmove_Tick_1);
            // 
            // Upmove
            // 
            this.Upmove.Interval = 5;
            this.Upmove.Tick += new System.EventHandler(this.Upmove_Tick_1);
            // 
            // Downmove
            // 
            this.Downmove.Interval = 5;
            this.Downmove.Tick += new System.EventHandler(this.Downmove_Tick_1);
            // 
            // BulleT
            // 
            this.BulleT.Enabled = true;
            this.BulleT.Interval = 30;
            this.BulleT.Tick += new System.EventHandler(this.BulleT_Tick_1);
            // 
            // Enemytimer
            // 
            this.Enemytimer.Enabled = true;
            this.Enemytimer.Tick += new System.EventHandler(this.Enemytimer_Tick_1);
            // 
            // eBulleT
            // 
            this.eBulleT.Enabled = true;
            this.eBulleT.Interval = 20;
            this.eBulleT.Tick += new System.EventHandler(this.eBulleT_Tick_1);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(315, 481);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 51);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(237, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Rplay
            // 
            this.Rplay.BackColor = System.Drawing.Color.SeaShell;
            this.Rplay.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rplay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Rplay.Location = new System.Drawing.Point(246, 233);
            this.Rplay.Name = "Rplay";
            this.Rplay.Size = new System.Drawing.Size(200, 67);
            this.Rplay.TabIndex = 3;
            this.Rplay.Text = "Replay";
            this.Rplay.UseVisualStyleBackColor = false;
            this.Rplay.Visible = false;
            this.Rplay.Click += new System.EventHandler(this.Rplay_Click_1);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(246, 330);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 70);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(126, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(618, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(26, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "SCORE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(523, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "LEVEL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Rplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form1";
            this.Text = "Bomboclaat Shoot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer BGtimer;
        private System.Windows.Forms.Timer Leftmove;
        private System.Windows.Forms.Timer Rightmove;
        private System.Windows.Forms.Timer Upmove;
        private System.Windows.Forms.Timer Downmove;
        private System.Windows.Forms.Timer BulleT;
        private System.Windows.Forms.Timer Enemytimer;
        private System.Windows.Forms.Timer eBulleT;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Rplay;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

