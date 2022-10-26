using Microsoft.Maui.Graphics;
using System;

namespace DigitalClock
{
    public class GraphicsDrawable : IDrawable
    {
        public int distance = 50;

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {

            canvas.StrokeSize = 7;

            Number(canvas, 0, DateTime.Now.Hour / 10);
            Number(canvas, 1, DateTime.Now.Hour % 10);
            canvas.DrawLine(20 + distance * 2, 25, 20 + distance * 2, 35);
            canvas.DrawLine(20 + distance * 2, 45, 20 + distance * 2, 55);
            Number(canvas, 2, DateTime.Now.Minute / 10);
            Number(canvas, 3, DateTime.Now.Minute % 10);
            canvas.DrawLine(20 + distance * 4 + 20, 25, 20 + distance * 4 + 20, 35);
            canvas.DrawLine(20 + distance * 4 + 20, 45, 20 + distance * 4 + 20, 55);
            Number(canvas, 4, DateTime.Now.Second / 10);
            Number(canvas, 5, DateTime.Now.Second % 10);

        }

        public void Number(ICanvas canvas, int n, int number)
        {
            int d = 0;     
            if (n == 2 || n == 3) d = 20;
            if (n == 4 || n == 5) d = 40;

            switch (number)
            {
                case 0:
                    canvas.DrawLine(15 + distance * n + d, 0, 55 + distance * n + d, 0);
                    canvas.DrawLine(55 + distance * n + d, 0, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 70, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 0, 15 + distance * n + d, 70);
                    break;
                case 1:
                    canvas.DrawLine(55 + distance * n + d, 0, 55 + distance * n + d, 70);
                    break;
                case 2:
                    canvas.DrawLine(15 + distance * n + d, 0, 55 + distance * n + d, 0);
                    canvas.DrawLine(55 + distance * n + d, 0, 55 + distance * n + d, 35);
                    canvas.DrawLine(15 + distance * n + d, 35, 55 + distance * n + d, 35);
                    canvas.DrawLine(15 + distance * n + d, 35, 15 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 70, 55 + distance * n + d, 70);
                    break;
                case 3:
                    canvas.DrawLine(15 + distance * n + d, 0, 55 + distance * n + d, 0);
                    canvas.DrawLine(55 + distance * n + d, 0, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 70, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 35, 55 + distance * n + d, 35);
                    break;
                case 4:
                    canvas.DrawLine(55 + distance * n + d, 0, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 35, 55 + distance * n + d, 35);
                    canvas.DrawLine(15 + distance * n + d, 0, 15 + distance * n + d, 35);
                    break;
                case 5:
                    canvas.DrawLine(15 + distance * n + d, 0, 55 + distance * n + d, 0);
                    canvas.DrawLine(15 + distance * n + d, 0, 15 + distance * n + d, 35);
                    canvas.DrawLine(15 + distance * n + d, 35, 55 + distance * n + d, 35);
                    canvas.DrawLine(55 + distance * n + d, 35, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 70, 55 + distance * n + d, 70);
                    break;
                case 6:
                    canvas.DrawLine(15 + distance * n + d, 0, 55 + distance * n + d, 0);
                    canvas.DrawLine(15 + distance * n + d, 0, 15 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 35, 55 + distance * n + d, 35);
                    canvas.DrawLine(55 + distance * n + d, 35, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 70, 55 + distance * n + d, 70);
                    break;
                case 7:
                    canvas.DrawLine(15 + distance * n + d, 0, 55 + distance * n + d, 0);
                    canvas.DrawLine(55 + distance * n + d, 0, 55 + distance * n + d, 72);
                    break;
                case 8:
                    canvas.DrawLine(15 + distance * n + d, 0, 55 + distance * n + d, 0);
                    canvas.DrawLine(55 + distance * n + d, 0, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 70, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 0, 15 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 35, 55 + distance * n + d, 35);
                    break;
                case 9:
                    canvas.DrawLine(15 + distance * n + d, 0, 55 + distance * n + d, 0);
                    canvas.DrawLine(55 + distance * n + d, 0, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 70, 55 + distance * n + d, 70);
                    canvas.DrawLine(15 + distance * n + d, 0, 15 + distance * n + d, 35);
                    canvas.DrawLine(15 + distance * n + d, 35, 55 + distance * n + d, 35);
                    break;
            }
        }
    }
}