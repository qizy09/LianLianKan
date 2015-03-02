using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace lianliankan
{
    public partial class Form1 : Form
    {
        llkfunction llk;
        def.coordinate nowa, nowb;
        private System.Windows.Forms.Button[] btnMap = new System.Windows.Forms.Button[def.MAXEDGE * def.MAXEDGE];

        public Form1()
        {
            InitializeComponent();
        }

        private bool ShowMap()
        {
            return false;
        }

        private void addbackgroundimage(int k, int p)
        {
            switch (p)
            {
                case 1: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt1;
                    break;
                case 2: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt2;
                    break;
                case 3: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt3;
                    break;
                case 4: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt4;
                    break;
                case 5: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt5;
                    break;
                case 6: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt6;
                    break;
                case 7: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt7;
                    break;
                case 8: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt8;
                    break;
                case 9: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt9;
                    break;
                case 10: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt10;
                    break;
                case 11: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt11;
                    break;
                case 12: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt12;
                    break;
                case 13: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt13;
                    break;
                case 14: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt14;
                    break;
                case 15: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt15;
                    break;
                case 16: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkt16;
                    break;
            }
        }

        private void addblackbackgroundimage(int k, int p)
        {
            switch (p)
            {
                case 1: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh1;
                    break;
                case 2: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh2;
                    break;
                case 3: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh3;
                    break;
                case 4: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh4;
                    break;
                case 5: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh5;
                    break;
                case 6: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh6;
                    break;
                case 7: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh7;
                    break;
                case 8: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh8;
                    break;
                case 9: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh9;
                    break;
                case 10: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh10;
                    break;
                case 11: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh11;
                    break;
                case 12: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh12;
                    break;
                case 13: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh13;
                    break;
                case 14: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh14;
                    break;
                case 15: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh15;
                    break;
                case 16: btnMap[k].BackgroundImage = global::lianliankan.Properties.Resources.llkh16;
                    break;
            }
        }

        private int initialize()
        {
            llk = new llkfunction();
            int i, j;

            if (!llk.create())
            {
                MessageBox.Show("游戏初始化失败...");
                return 0;
            }

            for (i = 0; i < def.MAXEDGE; i++)
                for (j = 0; j < def.MAXEDGE; j++)
                {
                    btnMap[i * def.MAXEDGE + j] = new System.Windows.Forms.Button();
                    btnMap[i * def.MAXEDGE + j].Location = new System.Drawing.Point(1 + 70 * j, 1 + 70 * i);
                    btnMap[i * def.MAXEDGE + j].Name = (i * def.MAXEDGE + j).ToString();
                    btnMap[i * def.MAXEDGE + j].Size = new System.Drawing.Size(70, 70);
                    btnMap[i * def.MAXEDGE + j].TabIndex = 1;
                    btnMap[i * def.MAXEDGE + j].Text = "";
                    btnMap[i * def.MAXEDGE + j].UseVisualStyleBackColor = true;
                    btnMap[i * def.MAXEDGE + j].TabStop = false;
                    btnMap[i * def.MAXEDGE + j].Click += new EventHandler(this.btnMap_Click);
                    btnMap[i * def.MAXEDGE + j].Enabled = true;
                    addbackgroundimage(i * def.MAXEDGE + j, llk.getMap(i, j));
                    this.Controls.Add(btnMap[i * def.MAXEDGE + j]);
                }

            nowa.x = -1; nowa.y = -1;
            nowb.x = -1; nowb.y = -1;

            lblscore.Text = llk.getscore().ToString();

            return 1;
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            btnGameStart.Visible = false;
            initialize();
            timer1.Enabled = true;
        }

        private void test(def.coordinate t)
        {
            if (nowa.x == -1 && nowa.y == -1)
            {
                nowa = t;
                addblackbackgroundimage(t.x * def.MAXEDGE + t.y, llk.getMap(t.x, t.y));
            } else
            if (nowb.x == -1 && nowb.y == -1)
            {
                nowb = t;
                if (llk.delete(nowa, nowb))
                {
                    btnMap[nowa.x * def.MAXEDGE + nowa.y].Visible = false;
                    btnMap[nowb.x * def.MAXEDGE + nowb.y].Visible = false;
                    llk.addscore();
                    lblscore.Text = llk.getscore().ToString();
                    // to add Win;
                    if (llk.getscore() == 320)
                    {
                        timer1.Enabled = false;
                        StreamWriter pass = new StreamWriter("g_llk.dat");
                        pass.Close();
                        MessageBox.Show("你顺利地通过了此关^_^");
                        btnGameStart.Visible = true;
                    }
                }
                btnMap[nowa.x * def.MAXEDGE + nowa.y].Enabled = true;
                btnMap[nowb.x * def.MAXEDGE + nowb.y].Enabled = true;
                addbackgroundimage(nowa.x * def.MAXEDGE + nowa.y, llk.getMap(nowa.x, nowa.y));
                nowa.x = -1;
                nowa.y = -1;
                nowb.x = -1;
                nowb.y = -1;
            }
        }

        private def.coordinate trans(int x)
        {
            def.coordinate t;
            t.x = x / def.MAXEDGE;
            t.y = x % def.MAXEDGE;
            return t;
        }

        private void btnMap_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as Button;

            int x;
            x = System.Convert.ToInt32(btn.Name);
            btnMap[x].Enabled = false;
            def.coordinate now = trans(x);
            test(now);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.DateTime now = new System.DateTime();
            now = System.DateTime.Now;
            int t = now.Hour * 3600 + now.Minute * 60 + now.Second - llk.gettimestart();
            while (t < 0) t += 3600;
            t = def.MAXTIME - t;
            lbltime.Text = t.ToString();
            if (t == 0)
            {
                timer1.Enabled = false;
                int i, j;
                for (i = 0; i < def.MAXEDGE; i++)
                    for (j = 0; j < def.MAXEDGE; j++)
                    {
                        btnMap[i * def.MAXEDGE + j].Enabled = false;
                        this.Controls.Remove(btnMap[i * def.MAXEDGE + j]);
                    }
                MessageBox.Show("超时啦= =要对男生的脸更熟悉一点才行啊！重来吧^_^");
                btnGameStart.Visible = true;
                lblscore.Text = "0";
            }
        }
    }
}
