using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Арканоид : Form
    {
        Blocks[,] block;
        public int direction;
        double sx=2, sy=2,bx,by;
        int countx, county;

        private void panel1_Paint(object sender, PaintEventArgs e)//Отрисовка блоков
        {
            for (int x = 0; x < countx; x++)
                for (int y = 0; y < county; y++)
                {
                    block[x, y].Draw(e.Graphics);
                }
        }

        public Арканоид()
        {
            InitializeComponent();
            countx = 20;
            county = 10;
            int bw = 30, bh = 12;//размер блока
            int counter = 1;
            block = new Blocks[countx,county];
            for (int x=0;x<countx;x++)
                for (int y = 0; y < county; y++)
                {
                    block[x,y] = new Blocks();
                    block[x, y].Left = x * bw + (panel1.Width - bw * countx) / 2;
                    block[x, y].Top = (y + 2) * bh;
                    block[x, y].Width = bw - 2;
                    block[x, y].Height = bh - 2;
                    if (counter == 1)//Присваиваю блокам цвета радуги
                        block[x, y].MyColor = Color.Red;
                    if (counter == 2)
                        block[x, y].MyColor = Color.Orange;
                    if (counter == 3)
                        block[x, y].MyColor = Color.Yellow;
                    if (counter == 4)
                        block[x, y].MyColor = Color.Green;
                    if (counter == 5)
                        block[x, y].MyColor = Color.LightBlue;
                    if (counter == 6)
                        block[x, y].MyColor = Color.Blue;
                    if (counter == 7)
                    {
                        block[x, y].MyColor = Color.Violet;
                        counter = 0;
                    }
                       
                    counter++;
                }
            direction = 0;
            bx = ball.Left;
            by = ball.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)//Полет мяча и движение платформы
        {
            for (int x = 0; x < countx; x++)
                for (int y = 0; y < county; y++)
                {
                   if (block[x, y].Hit(ball.Left, ball.Top, ball.Width, ball.Height))
                    {
                        if (block[x, y].Hit_type == "X") sx = -sx;
                        if (block[x, y].Hit_type == "Y") sy = -sy;
                        panel1.Invalidate();
                    }
                }
            platform.Left += direction;
            bx += sx;
            by += sy;
            ball.Left = (int)bx;
            ball.Top = (int)by;
            if(platform.Left < 0)//Платформа доходит до левой стороны окна и останавливается
            {
                platform.Left = 0;
                direction = 0;
            }
            if (platform.Left > panel1.Width- platform.Width)//Платформа доходит до правой стороны окна и останавливается
            {
                direction = 0;
            }
            if(ball.Top <= 0)//Толчек мяча от верхней стороны окна
            {
                sy = -sy;
                ball.Top++;
            }
            if (ball.Left <= 0)////Изменгение траектории полета мяча при ударе о левую стенку
            {
                sx = -sx;
            }
            if (ball.Left > panel1.Width - ball.Width)//Изменгение траектории полета мяча при ударе о правую стенку
            {
                sx = -sx;
            }
            if ((platform.Left - ball.Width) < ball.Left && //Толчек мяча от платформы 
                (platform.Left + platform.Width) > ball.Left &&
                (ball.Top+ball.Height) >= 220)
            {
                sy = -sy;
                ball.Top--;
            }  
        }

        private void Арканоид_KeyDown(object sender, KeyEventArgs e)//Управление платформой
        {
            if(e.KeyCode == Keys.Left)
            {
                direction = -5;
            }
            if (e.KeyCode == Keys.Right)
            {
                direction = 5;
            }
            
        }
    }
    class Blocks//Создаю блоки и делаю их невидимыми при ударе с мячом
    {
        public int Top, Left, Width, Height;
        public Color MyColor;
        public bool visible= true;
        public string Hit_type;
        public void Draw(Graphics g)
        {
            if (!visible) return;
            SolidBrush b = new SolidBrush(MyColor);
            Pen p = new Pen(Color.Black);
            g.DrawRectangle(p, Left, Top, Width, Height);
            g.FillRectangle(b, Left, Top, Width, Height);
        }
        public Boolean Hit(int xb, int yb, int w, int h)
        {
            if(!visible) return false;

            int xb1 = xb + w;
            int yb1 = yb + h;
            int x = Left;
            int y = Top;
            int x1 = x + Width;
            int y1 = y + Height;
            bool ht=false;
            if (xb1 >= x && xb1 <= x1 &&((y>yb&&y<yb1)||(y1>yb&&y1<yb1)))//Удар справа
            {
                ht = true;
                Hit_type = "X";
            }
            else if (xb >= x && xb <= x1 && ((y > yb && y < yb1) || (y1 > yb && y1 < yb1)))//Удар слева
            {
                ht = true;
                Hit_type = "X";
            }
            else if (yb >= y && yb <= y1 && ((x > xb && x < xb1) || (x1 > xb && x1 < xb1)))//Удар сверху
            {
                ht = true;
                Hit_type = "Y";
            }
            else if (yb1 >= y && yb1 <= y1 && ((x > xb && x < xb1) || (x1 > xb && x1 < xb1)))//Удар снизу
            {
                ht = true;
                Hit_type = "Y";
            }
            if (ht)
            {
                visible = false;
                return true;
            }
            return false;
        }
    }
}
