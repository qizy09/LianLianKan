using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lianliankan
{
    class llkfunction
    {
        private int[,] map = new int[def.MAXEDGE, def.MAXEDGE];
        private int[,] move = new int[4, 2];
        private int[] picname = new int[def.MAXPIC + 1];
        private bool gamest;
        private int timest;
        private int score;

        public llkfunction()
        {
            move[0, 0] = 1; move[0, 1] = 0;
            move[1, 0] = 0; move[1, 1] = 1;
            move[2, 0] = -1; move[2, 1] = 0;
            move[3, 0] = 0; move[3, 1] = -1;

            int i;
            for (i = 1; i <= def.MAXPIC; i++)
            {
                picname[i] = i;
            }
            gamest = false;
            timest = 0;
            score = 0;
        }

        public bool create()
        {
            int i, j, x, y, z;
            int rest;
            int[] num = new int[def.MAXPIC];
            int[,] done = new int[def.MAXEDGE, def.MAXEDGE];
            int[,] td = new int[def.MAXEDGE, def.MAXEDGE];
            int[,] tmap = new int[def.MAXEDGE, def.MAXEDGE];

            for (i = 0; i < def.MAXEDGE; i++)
                for (j = 0; j < def.MAXEDGE; j++)
                {
                    done[i, j] = 0;
                    tmap[i, j] = 0;
                }
            rest = def.MAXEDGE * def.MAXEDGE / 2;

            Random pran = new Random();
            
            while (rest > 0)
            {
                for (i = 0; i < def.MAXEDGE; i++)
                    for (j = 0; j < def.MAXEDGE; j++)
                    {
                        td[i, j] = done[i, j];
                    }

                for (i = 0; i < rest; i++)
                {
                    z = pran.Next(def.MAXPIC) + 1;
                    x = pran.Next(def.MAXEDGE);
                    y = pran.Next(def.MAXEDGE);
                    while (td[x, y] != 0)
                    {
                        x = pran.Next(def.MAXEDGE);
                        y = pran.Next(def.MAXEDGE);
                    }
                    tmap[x, y] = z;
                    map[x, y] = z;
                    td[x, y] = 1;
                    while (td[x, y] != 0)
                    {
                        x = pran.Next(def.MAXEDGE);
                        y = pran.Next(def.MAXEDGE);
                    }
                    tmap[x, y] = z;
                    map[x, y] = z;
                    td[x, y] = 1;
                }

                // to delete
                int flag = 1, del, k, l, m;
                def.queue[] que = new def.queue[def.MAXEDGE * def.MAXEDGE * 4];
                def.coordinate c, ac;
                int[,,] mark = new int[def.MAXEDGE, def.MAXEDGE, 4];
                int f, r;

                ac.x = 0; ac.y = 0;

                while (flag == 1)
                {
                    flag = 0;
                    for (i = 0; i < def.MAXEDGE; i++)
                        for (j = 0; j < def.MAXEDGE; j++)
                        {
                            if (done[i, j] == 1) continue;
                            del = 0;
                            // try delete;
                            
                            for (l = 0; l < def.MAXEDGE; l++)
                                for (m = 0; m < def.MAXEDGE; m++)
                                    for (k = 0; k < 4; k++)
                                    {
                                        mark[l, m, k] = 1;
                                    }

                            f = 0; r = 0;
                            for (l = 0; l < 4; l++)
                            {
                                c.x = i + move[l, 0];
                                c.y = j + move[l, 1];
                                if (c.x < 0 || c.y < 0 || c.x >= def.MAXEDGE || c.y >= def.MAXEDGE) continue;
                                if (tmap[c.x, c.y] == tmap[i, j])
                                {
                                    del = 1;
                                    ac = c;
                                    break;
                                }
                                if (tmap[c.x, c.y] != 0) continue;
                                mark[c.x, c.y, l] = 0;
                                que[r].place = c;
                                que[r].direct = l;
                                que[r].turn = 0;
                                r++;
                            }
                            
                            while (del != 1 && f != r)
                            {
                                for (l = 0; l < 4; l++)
                                {
                                    c.x = que[f].place.x + move[l, 0];
                                    c.y = que[f].place.y + move[l, 1];
                                    if (c.x < 0 || c.y < 0 || c.x >= def.MAXEDGE || c.y >= def.MAXEDGE) continue;
                                    if (tmap[c.x, c.y] == tmap[i, j])
                                    {
                                        del = 1;
                                        ac = c;
                                        break;
                                    }
                                    if (mark[c.x, c.y, l] == 0) continue;
                                    if (tmap[c.x, c.y] != 0) continue;
                                    if (que[f].direct != l && que[f].turn == 2) continue;
                                    mark[c.x, c.y, l] = 0;
                                    que[r].place = c;
                                    que[r].direct = l;
                                    que[r].turn = que[f].turn;
                                    if (que[f].direct != l) que[r].turn++;
                                    r++;
                                }
                                f++;
                            }

                            if (del == 1)
                            {
                                flag = 1;
                                rest--;
                                tmap[i, j] = 0;
                                done[i, j] = 1;
                                tmap[ac.x, ac.y] = 0;
                                done[ac.x, ac.y] = 1;
                            }
                        }
                }
            }
            gamest = true;
            System.DateTime now = new System.DateTime();
            now = System.DateTime.Now;
            timest = now.Hour * 3600 + now.Minute * 60 + now.Second;
            return true;
        }

        public bool gameisstart()
        {
            return gamest;
        }

        public int gettimestart()
        {
            return timest;
        }

        public int getscore()
        {
            return score;
        }

        public void addscore()
        {
            score += 10;
        }

        public int getMap(int x, int y)
        {
            return picname[map[x, y]];
        }

        public bool delete(def.coordinate a, def.coordinate b)
        {
            if (map[a.x, a.y] != map[b.x, b.y]) return false;
            
            def.queue[] que = new def.queue[def.MAXEDGE * def.MAXEDGE * 4];
            def.coordinate c;
            int[,,] mark = new int[def.MAXEDGE, def.MAXEDGE, 4];
            int f, r, i, j, k;
            int tmp;

            tmp = map[b.x, b.y];
            map[b.x, b.y] = 0;

            for (i = 0; i < def.MAXEDGE; i++)
                for (j = 0; j < def.MAXEDGE; j++)
                    for (k = 0; k < 4; k++)
                    {
                        mark[i, j, k] = 1;
                    }

            f = 0; r = 0;
            for (i = 0; i < 4; i++)
            {
                c.x = a.x + move[i, 0];
                c.y = a.y + move[i, 1];
                if (c.x < 0 || c.y < 0 || c.x >= def.MAXEDGE || c.y >= def.MAXEDGE) continue;
                if (map[c.x, c.y] != 0) continue;
                mark[c.x, c.y, i] = 0;
                que[r].place = c;
                que[r].direct = i;
                que[r].turn = 0;
                r++;
            }

            while (f != r)
            {
                for (i = 0; i < 4; i++)
                {
                    c.x = que[f].place.x + move[i, 0];
                    c.y = que[f].place.y + move[i, 1];
                    if (c.x < 0 || c.y < 0 || c.x >= def.MAXEDGE || c.y >= def.MAXEDGE) continue;
                    if (mark[c.x, c.y, i] == 0) continue;
                    if (map[c.x, c.y] != 0) continue;
                    if (que[f].direct != i && que[f].turn == 2) continue;
                    mark[c.x, c.y, i] = 0;
                    que[r].place = c;
                    que[r].direct = i;
                    que[r].turn = que[f].turn;
                    if (que[f].direct != i) que[r].turn++;
                    r++;
                }
                f++;
            }

            for (k = 0; k < 4; k++)
                if (mark[b.x, b.y, k] == 0)
                {
                    map[a.x, a.y] = 0;
                    map[b.x, b.y] = 0;
                    return true;
                }
            map[b.x, b.y] = tmp;
            return false;
        }
    }
}
