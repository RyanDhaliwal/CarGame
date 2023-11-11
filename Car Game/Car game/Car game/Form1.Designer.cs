namespace Car_game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.scoretext = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.medalImage = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.randCar1 = new System.Windows.Forms.PictureBox();
            this.randCar2 = new System.Windows.Forms.PictureBox();
            this.roadPic2 = new System.Windows.Forms.PictureBox();
            this.roadPic1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.medalImage);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.randCar1);
            this.panel1.Controls.Add(this.randCar2);
            this.panel1.Controls.Add(this.roadPic2);
            this.panel1.Controls.Add(this.roadPic1);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 545);
            this.panel1.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(204, 597);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(154, 46);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.restartGame);
            // 
            // scoretext
            // 
            this.scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(3, 547);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(546, 47);
            this.scoretext.TabIndex = 1;
            this.scoretext.Text = "Score: 0";
            this.scoretext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 659);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 101);
            this.label2.TabIndex = 2;
            this.label2.Text = "Press Right or Left to move the car.\r\n\r\nSurvive as long as you can\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // medalImage
            // 
            this.medalImage.Image = global::Car_game.Properties.Resources.bronze;
            this.medalImage.Location = new System.Drawing.Point(157, 300);
            this.medalImage.Name = "medalImage";
            this.medalImage.Size = new System.Drawing.Size(250, 100);
            this.medalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.medalImage.TabIndex = 4;
            this.medalImage.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Car_game.Properties.Resources.carPink;
            this.player.Location = new System.Drawing.Point(257, 430);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::Car_game.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(257, 318);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 2;
            this.explosion.TabStop = false;
            // 
            // randCar1
            // 
            this.randCar1.Image = global::Car_game.Properties.Resources.carGrey;
            this.randCar1.Location = new System.Drawing.Point(132, 33);
            this.randCar1.Name = "randCar1";
            this.randCar1.Size = new System.Drawing.Size(50, 100);
            this.randCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.randCar1.TabIndex = 3;
            this.randCar1.TabStop = false;
            this.randCar1.Tag = "carLeft";
            // 
            // randCar2
            // 
            this.randCar2.Image = global::Car_game.Properties.Resources.CarRed;
            this.randCar2.Location = new System.Drawing.Point(428, 161);
            this.randCar2.Name = "randCar2";
            this.randCar2.Size = new System.Drawing.Size(50, 100);
            this.randCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.randCar2.TabIndex = 2;
            this.randCar2.TabStop = false;
            this.randCar2.Tag = "carRight";
            // 
            // roadPic2
            // 
            this.roadPic2.Image = ((System.Drawing.Image)(resources.GetObject("roadPic2.Image")));
            this.roadPic2.Location = new System.Drawing.Point(0, 0);
            this.roadPic2.Name = "roadPic2";
            this.roadPic2.Size = new System.Drawing.Size(546, 542);
            this.roadPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadPic2.TabIndex = 1;
            this.roadPic2.TabStop = false;
            // 
            // roadPic1
            // 
            this.roadPic1.Image = ((System.Drawing.Image)(resources.GetObject("roadPic1.Image")));
            this.roadPic1.Location = new System.Drawing.Point(0, -542);
            this.roadPic1.Name = "roadPic1";
            this.roadPic1.Size = new System.Drawing.Size(546, 542);
            this.roadPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadPic1.TabIndex = 0;
            this.roadPic1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 769);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox medalImage;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox randCar1;
        private System.Windows.Forms.PictureBox randCar2;
        private System.Windows.Forms.PictureBox roadPic2;
        private System.Windows.Forms.PictureBox roadPic1;
        private System.Windows.Forms.Timer timer1;
    }
}

