﻿namespace Yapay
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
            this.operation_list = new System.Windows.Forms.ListBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.random_bet_track = new System.Windows.Forms.TrackBar();
            this.random_point_btn = new System.Windows.Forms.Button();
            this.point_bet_text = new System.Windows.Forms.TextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.manual_center = new System.Windows.Forms.Button();
            this.claassCountNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.result_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.attirubute_count = new System.Windows.Forms.NumericUpDown();
            this.asset_count = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.get_info_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.random_bet_track)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claassCountNum)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attirubute_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asset_count)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // operation_list
            // 
            this.operation_list.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operation_list.FormattingEnabled = true;
            this.operation_list.Location = new System.Drawing.Point(0, 445);
            this.operation_list.Name = "operation_list";
            this.operation_list.ScrollAlwaysVisible = true;
            this.operation_list.Size = new System.Drawing.Size(823, 277);
            this.operation_list.TabIndex = 2;
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
            this.picture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Controls.Add(this.point_bet_text);
            this.groupBox2.Controls.Add(this.random_point_btn);
            this.groupBox2.Controls.Add(this.random_bet_track);
            this.groupBox2.Location = new System.Drawing.Point(6, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Point";
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
            // random_point_btn
            // 
            this.random_point_btn.Location = new System.Drawing.Point(6, 70);
            this.random_point_btn.Name = "random_point_btn";
            this.random_point_btn.Size = new System.Drawing.Size(229, 45);
            this.random_point_btn.TabIndex = 2;
            this.random_point_btn.Text = "Random Point";
            this.random_point_btn.UseVisualStyleBackColor = true;
            this.random_point_btn.Click += new System.EventHandler(this.randomPoint);
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
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(6, 121);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(229, 34);
            this.clear_btn.TabIndex = 5;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.result_btn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.claassCountNum);
            this.groupBox3.Controls.Add(this.manual_center);
            this.groupBox3.Location = new System.Drawing.Point(13, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 146);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual Control";
            // 
            // manual_center
            // 
            this.manual_center.Location = new System.Drawing.Point(3, 58);
            this.manual_center.Name = "manual_center";
            this.manual_center.Size = new System.Drawing.Size(225, 38);
            this.manual_center.TabIndex = 6;
            this.manual_center.Text = "Manual center points";
            this.manual_center.UseVisualStyleBackColor = true;
            this.manual_center.Click += new System.EventHandler(this.manual_center_Click);
            // 
            // claassCountNum
            // 
            this.claassCountNum.Location = new System.Drawing.Point(3, 32);
            this.claassCountNum.Name = "claassCountNum";
            this.claassCountNum.Size = new System.Drawing.Size(225, 20);
            this.claassCountNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Claass Count";
            // 
            // result_btn
            // 
            this.result_btn.Location = new System.Drawing.Point(3, 103);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(225, 32);
            this.result_btn.TabIndex = 9;
            this.result_btn.Text = "Result";
            this.result_btn.UseVisualStyleBackColor = true;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.get_info_btn);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.asset_count);
            this.groupBox4.Controls.Add(this.attirubute_count);
            this.groupBox4.Location = new System.Drawing.Point(7, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 69);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receptron";
            // 
            // attirubute_count
            // 
            this.attirubute_count.Location = new System.Drawing.Point(172, 10);
            this.attirubute_count.Name = "attirubute_count";
            this.attirubute_count.Size = new System.Drawing.Size(56, 20);
            this.attirubute_count.TabIndex = 0;
            // 
            // asset_count
            // 
            this.asset_count.Location = new System.Drawing.Point(172, 36);
            this.asset_count.Name = "asset_count";
            this.asset_count.Size = new System.Drawing.Size(56, 20);
            this.asset_count.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "VC";
            // 
            // get_info_btn
            // 
            this.get_info_btn.Location = new System.Drawing.Point(9, 20);
            this.get_info_btn.Name = "get_info_btn";
            this.get_info_btn.Size = new System.Drawing.Size(130, 31);
            this.get_info_btn.TabIndex = 2;
            this.get_info_btn.Text = "Get";
            this.get_info_btn.UseVisualStyleBackColor = true;
            this.get_info_btn.Click += new System.EventHandler(this.get_info_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(567, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 722);
            this.Controls.Add(this.operation_list);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.random_bet_track)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claassCountNum)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attirubute_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asset_count)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox operation_list;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox point_bet_text;
        private System.Windows.Forms.Button random_point_btn;
        private System.Windows.Forms.TrackBar random_bet_track;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button result_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown claassCountNum;
        private System.Windows.Forms.Button manual_center;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button get_info_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown asset_count;
        private System.Windows.Forms.NumericUpDown attirubute_count;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

