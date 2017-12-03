namespace Yapay
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.point_bet_text = new System.Windows.Forms.TextBox();
            this.random_point_btn = new System.Windows.Forms.Button();
            this.random_bet_track = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.random_bet_track)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Black;
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(550, 420);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(567, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.point_bet_text);
            this.groupBox2.Controls.Add(this.random_point_btn);
            this.groupBox2.Controls.Add(this.random_bet_track);
            this.groupBox2.Location = new System.Drawing.Point(6, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 156);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Point";
            // 
            // point_bet_text
            // 
            this.point_bet_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_bet_text.Location = new System.Drawing.Point(159, 9);
            this.point_bet_text.Multiline = true;
            this.point_bet_text.Name = "point_bet_text";
            this.point_bet_text.Size = new System.Drawing.Size(76, 55);
            this.point_bet_text.TabIndex = 4;
            this.point_bet_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // random_point_btn
            // 
            this.random_point_btn.Location = new System.Drawing.Point(0, 70);
            this.random_point_btn.Name = "random_point_btn";
            this.random_point_btn.Size = new System.Drawing.Size(235, 45);
            this.random_point_btn.TabIndex = 2;
            this.random_point_btn.Text = "Random Point";
            this.random_point_btn.UseVisualStyleBackColor = true;
            this.random_point_btn.Click += new System.EventHandler(this.randomPoint);
            // 
            // random_bet_track
            // 
            this.random_bet_track.Location = new System.Drawing.Point(6, 19);
            this.random_bet_track.Maximum = 1000;
            this.random_bet_track.Minimum = 2;
            this.random_bet_track.Name = "random_bet_track";
            this.random_bet_track.Size = new System.Drawing.Size(147, 45);
            this.random_bet_track.TabIndex = 3;
            this.random_bet_track.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.random_bet_track.Value = 10;
            this.random_bet_track.Scroll += new System.EventHandler(this.random_bet_track_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.random_bet_track)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button random_point_btn;
        private System.Windows.Forms.TrackBar random_bet_track;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox point_bet_text;
    }
}

