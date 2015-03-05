namespace lianliankan
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            this.lblscore = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnGameStart = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(560, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(12, 600);
            label3.TabIndex = 3;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("华文楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblscore.Location = new System.Drawing.Point(640, 121);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(34, 39);
            this.lblscore.TabIndex = 2;
            this.lblscore.Text = "0";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("华文楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltime.Location = new System.Drawing.Point(640, 277);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(68, 39);
            this.lbltime.TabIndex = 5;
            this.lbltime.Text = "120";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(609, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "              作者：Weeks\r\n清华大学软件学院九字班";
            // 
            // label4
            // 
            label4.Image = global::lianliankan.Properties.Resources.lbtime;
            label4.Location = new System.Drawing.Point(600, 194);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(146, 53);
            label4.TabIndex = 4;
            // 
            // label1
            // 
            label1.Image = global::lianliankan.Properties.Resources.lbscore;
            label1.Location = new System.Drawing.Point(600, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 53);
            label1.TabIndex = 1;
            // 
            // btnGameStart
            // 
            this.btnGameStart.BackgroundImage = global::lianliankan.Properties.Resources.btnst;
            this.btnGameStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGameStart.Location = new System.Drawing.Point(578, 426);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(194, 60);
            this.btnGameStart.TabIndex = 0;
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::lianliankan.Properties.Resources.bgr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnGameStart);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.Text = "连连看 - 女生节特别版";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

