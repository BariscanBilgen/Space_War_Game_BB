namespace SpaceWarGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_Galaxy = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlayerShip = new System.Windows.Forms.PictureBox();
            this.label_Point = new System.Windows.Forms.Label();
            this.timer_Player = new System.Windows.Forms.Timer(this.components);
            this.timer_BulletThrow = new System.Windows.Forms.Timer(this.components);
            this.timer_ShootEnemy = new System.Windows.Forms.Timer(this.components);
            this.timer_EnemyCreate = new System.Windows.Forms.Timer(this.components);
            this.timer_BulletControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Galaxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Galaxy
            // 
            this.pictureBox_Galaxy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Galaxy.Image = global::SpaceWarGame.Properties.Resources.SpaceBackground;
            this.pictureBox_Galaxy.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Galaxy.Name = "pictureBox_Galaxy";
            this.pictureBox_Galaxy.Size = new System.Drawing.Size(433, 635);
            this.pictureBox_Galaxy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Galaxy.TabIndex = 0;
            this.pictureBox_Galaxy.TabStop = false;
            // 
            // pictureBox_PlayerShip
            // 
            this.pictureBox_PlayerShip.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PlayerShip.Image = global::SpaceWarGame.Properties.Resources.SpaceShip;
            this.pictureBox_PlayerShip.Location = new System.Drawing.Point(152, 453);
            this.pictureBox_PlayerShip.Name = "pictureBox_PlayerShip";
            this.pictureBox_PlayerShip.Size = new System.Drawing.Size(128, 91);
            this.pictureBox_PlayerShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlayerShip.TabIndex = 1;
            this.pictureBox_PlayerShip.TabStop = false;
            // 
            // label_Point
            // 
            this.label_Point.AutoSize = true;
            this.label_Point.BackColor = System.Drawing.Color.Transparent;
            this.label_Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Point.ForeColor = System.Drawing.Color.White;
            this.label_Point.Location = new System.Drawing.Point(33, 30);
            this.label_Point.Name = "label_Point";
            this.label_Point.Size = new System.Drawing.Size(93, 24);
            this.label_Point.TabIndex = 2;
            this.label_Point.Text = "PUAN = 0";
            // 
            // timer_Player
            // 
            this.timer_Player.Interval = 1;
            this.timer_Player.Tick += new System.EventHandler(this.timer_Player_Tick);
            // 
            // timer_BulletThrow
            // 
            this.timer_BulletThrow.Interval = 10;
            this.timer_BulletThrow.Tick += new System.EventHandler(this.timer_BulletThrow_Tick);
            // 
            // timer_ShootEnemy
            // 
            this.timer_ShootEnemy.Interval = 50;
            this.timer_ShootEnemy.Tick += new System.EventHandler(this.timer_ShootEnemy_Tick);
            // 
            // timer_EnemyCreate
            // 
            this.timer_EnemyCreate.Interval = 2000;
            this.timer_EnemyCreate.Tick += new System.EventHandler(this.timer_EnemyCreate_Tick);
            // 
            // timer_BulletControl
            // 
            this.timer_BulletControl.Tick += new System.EventHandler(this.timer_BulletControl_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 635);
            this.Controls.Add(this.label_Point);
            this.Controls.Add(this.pictureBox_PlayerShip);
            this.Controls.Add(this.pictureBox_Galaxy);
            this.Name = "Form1";
            this.Text = "Space War Game BB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Galaxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Galaxy;
        private System.Windows.Forms.PictureBox pictureBox_PlayerShip;
        private System.Windows.Forms.Label label_Point;
        private System.Windows.Forms.Timer timer_Player;
        private System.Windows.Forms.Timer timer_BulletThrow;
        private System.Windows.Forms.Timer timer_ShootEnemy;
        private System.Windows.Forms.Timer timer_EnemyCreate;
        private System.Windows.Forms.Timer timer_BulletControl;
    }
}

