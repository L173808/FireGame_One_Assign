
namespace FireGame_One_Assign
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
            this.start_btn = new System.Windows.Forms.PictureBox();
            this.load_button = new System.Windows.Forms.PictureBox();
            this.spin_button = new System.Windows.Forms.PictureBox();
            this.changing_pictures = new System.Windows.Forms.PictureBox();
            this.shoot_btn = new System.Windows.Forms.Button();
            this.shoot_away_button = new System.Windows.Forms.Button();
            this.play_again_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.start_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changing_pictures)).BeginInit();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Image = global::FireGame_One_Assign.Properties.Resources.start_btn;
            this.start_btn.Location = new System.Drawing.Point(15, 12);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(131, 98);
            this.start_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start_btn.TabIndex = 0;
            this.start_btn.TabStop = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // load_button
            // 
            this.load_button.Image = global::FireGame_One_Assign.Properties.Resources.load_btn;
            this.load_button.Location = new System.Drawing.Point(228, 47);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(147, 74);
            this.load_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.load_button.TabIndex = 1;
            this.load_button.TabStop = false;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // spin_button
            // 
            this.spin_button.Image = global::FireGame_One_Assign.Properties.Resources.spin_btn;
            this.spin_button.Location = new System.Drawing.Point(228, 146);
            this.spin_button.Name = "spin_button";
            this.spin_button.Size = new System.Drawing.Size(147, 74);
            this.spin_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spin_button.TabIndex = 2;
            this.spin_button.TabStop = false;
            this.spin_button.Click += new System.EventHandler(this.spin_button_Click);
            // 
            // changing_pictures
            // 
            this.changing_pictures.Image = global::FireGame_One_Assign.Properties.Resources.fire_game;
            this.changing_pictures.Location = new System.Drawing.Point(476, 2);
            this.changing_pictures.Name = "changing_pictures";
            this.changing_pictures.Size = new System.Drawing.Size(490, 477);
            this.changing_pictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.changing_pictures.TabIndex = 6;
            this.changing_pictures.TabStop = false;
            // 
            // shoot_btn
            // 
            this.shoot_btn.BackColor = System.Drawing.Color.Red;
            this.shoot_btn.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shoot_btn.Location = new System.Drawing.Point(227, 248);
            this.shoot_btn.Name = "shoot_btn";
            this.shoot_btn.Size = new System.Drawing.Size(148, 65);
            this.shoot_btn.TabIndex = 7;
            this.shoot_btn.Text = "Shoot ";
            this.shoot_btn.UseVisualStyleBackColor = false;
            this.shoot_btn.Click += new System.EventHandler(this.shoot_btn_Click);
            // 
            // shoot_away_button
            // 
            this.shoot_away_button.BackColor = System.Drawing.Color.Red;
            this.shoot_away_button.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_away_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shoot_away_button.Location = new System.Drawing.Point(228, 333);
            this.shoot_away_button.Name = "shoot_away_button";
            this.shoot_away_button.Size = new System.Drawing.Size(147, 56);
            this.shoot_away_button.TabIndex = 8;
            this.shoot_away_button.Text = "Shoot Away";
            this.shoot_away_button.UseVisualStyleBackColor = false;
            this.shoot_away_button.Click += new System.EventHandler(this.shoot_away_button_Click);
            // 
            // play_again_button
            // 
            this.play_again_button.BackColor = System.Drawing.Color.Green;
            this.play_again_button.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_again_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.play_again_button.Location = new System.Drawing.Point(12, 414);
            this.play_again_button.Name = "play_again_button";
            this.play_again_button.Size = new System.Drawing.Size(280, 65);
            this.play_again_button.TabIndex = 9;
            this.play_again_button.Text = "Play Agian";
            this.play_again_button.UseVisualStyleBackColor = false;
            this.play_again_button.Click += new System.EventHandler(this.play_again_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(476, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(490, 18);
            this.button3.TabIndex = 10;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FireGame_One_Assign.Properties.Resources.background_;
            this.ClientSize = new System.Drawing.Size(963, 491);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.play_again_button);
            this.Controls.Add(this.shoot_away_button);
            this.Controls.Add(this.shoot_btn);
            this.Controls.Add(this.changing_pictures);
            this.Controls.Add(this.spin_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.start_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changing_pictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox start_btn;
        private System.Windows.Forms.PictureBox load_button;
        private System.Windows.Forms.PictureBox spin_button;
        private System.Windows.Forms.PictureBox changing_pictures;
        private System.Windows.Forms.Button shoot_btn;
        private System.Windows.Forms.Button shoot_away_button;
        private System.Windows.Forms.Button play_again_button;
        private System.Windows.Forms.Button button3;
    }
}

