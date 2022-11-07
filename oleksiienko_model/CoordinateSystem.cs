using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace oleksiienko_model
{
    class CoordinateSystem
    {

        Color color = Color.Black;
        Graphics gr;
        
        PictureBox drawingArea;
        double leftX, rightX, upY, downY;
        int yAxis;
        int xAxis;

        int areaHeight;
        int areaWidth;
        public CoordinateSystem(double rightXInput, double leftXInput, double upYInput, double downYInput, PictureBox pcBox, Color col)
        {

            gr = pcBox.CreateGraphics();

            drawingArea = pcBox;
            color = col;
            rightX = rightXInput;
            upY = upYInput;
            leftX = leftXInput;
            downY = downYInput;
            gr.Clear(pcBox.BackColor);

            yAxis = drawingArea.Width / 2;
            xAxis = drawingArea.Height / 2;

            areaHeight = drawingArea.Height;
            areaWidth = drawingArea.Width;

        }


        public CoordinateSystem(double rightXInput, double leftXInput, double upYInput, double downYInput, PictureBox pcBox)
        {
            gr = pcBox.CreateGraphics();
            drawingArea = pcBox;
            rightX = rightXInput;
            upY = upYInput;
            leftX = leftXInput;
            downY = downYInput;
            gr.Clear(pcBox.BackColor);

            yAxis = drawingArea.Width / 2;
            xAxis = drawingArea.Height / 2;

            areaHeight = drawingArea.Height;
            areaWidth = drawingArea.Width;
        }

        public double xToDec(double x)
        {
            return (x * ( (Math.Abs(leftX) + rightX) / areaWidth)-Math.Abs(leftX));
        }
        public double yToDec(double y)
        {
            return (y * ( (Math.Abs(downY) + upY) / areaHeight ) - Math.Abs(downY));
        }

        public int xToDisp(double x)
        {
            return Convert.ToInt32(((x+Math.Abs(leftX))*(areaWidth/(Math.Abs(leftX)+rightX))));
        }
        public int yToDisp(double y)
        {
            return Convert.ToInt32(((Math.Abs(downY)+y) * (areaHeight/ (Math.Abs(downY) + upY))));
        }
        public Graphics GetGraphics()
        {
            return gr;
        }
       
        public void DrawCoordinateSystem()
        {
            Pen pen = new Pen(color);
            SolidBrush brush = new SolidBrush(color);
            int yAxis = (int)this.xToDisp(0);
            int xAxis = (int)this.yToDisp(0);

            int areaHeight = drawingArea.Height;
            int areaWidth = drawingArea.Width;


            Pen pen_setka = new Pen(Brushes.LightBlue, 1);
            pen_setka.DashStyle = DashStyle.Dash;
            for (int p = (int)leftX; p <= (int)rightX; p++)
            {
                gr.DrawLine(pen_setka, this.xToDisp(p), 0, this.xToDisp(p), areaHeight);
            }
            for (int p = (int)downY; p <= (int)upY; p++)
            {
                gr.DrawLine(pen_setka, 0, this.yToDisp(p), areaWidth, this.yToDisp(p));

            }

            gr.DrawLine(pen, 0, xAxis, areaWidth, xAxis);
            gr.DrawLine(pen, yAxis, 0, yAxis, areaHeight);

            Point[] TriangleX = new Point[] { new Point(areaWidth, xAxis), new Point(areaWidth - areaWidth / 30, xAxis - areaHeight / 50), new Point(areaWidth - areaWidth / 30, xAxis + areaHeight / 50) };
            Point[] TriangleY = new Point[] { new Point(yAxis, 0), new Point(yAxis - areaWidth / 50, areaHeight / 30), new Point(yAxis + areaWidth / 50, areaHeight / 30) };

            gr.FillPolygon(brush, TriangleY); gr.FillPolygon(brush, TriangleX);


            int majorX = (int)(areaWidth / (Math.Abs(leftX) + rightX));
            int minorX = (int)(majorX / 5);

            int majorY = (int)(areaHeight / (Math.Abs(downY) + upY));
            int minorY = (int)(majorY / 5);

            for (int i = 0, j = 0; i < areaWidth || j < areaWidth; i += majorX, j += minorX)
            {
                gr.DrawLine(pen, i, xAxis - 5, i, xAxis + 5);
                gr.DrawLine(pen, j, xAxis - 3, j, xAxis + 3);
                /* if (this.ConvertXToRegularCoordinates(i) == leftX || this.ConvertXToRegularCoordinates(i) == rightX) gr.DrawString(this.ConvertXToRegularCoordinates(i).ToString(), new Font("Times New Roman", 6), brush, new Point(i, xAxis + 10));
                 else gr.DrawString(this.ConvertXToRegularCoordinates(i).ToString(), new Font("Times New Roman", 6), brush, new Point(i - 6, xAxis + 10));
                */
            }
            for (int i = 20, j = 20; i < areaHeight || j < areaHeight; i += majorY, j += minorY)
            {
                gr.DrawLine(pen, yAxis - 5, i, yAxis + 5, i);
                gr.DrawLine(pen, yAxis - 2, i, yAxis + 2, i);
            }

            int majorPlaceX = 0;
            int majorPlaceY = 0;

            for (double i = leftX; i <= rightX; i++)
            {

                gr.DrawString(i.ToString(), new Font("Times New Roman", 6), brush, new Point(majorPlaceX - 6, xAxis + 6));
                majorPlaceX += majorX;

            }
            for (double i = upY; i >= downY; i--)
            {

               if(i != 0) gr.DrawString(i.ToString(), new Font("Times New Roman", 6), brush, new Point(yAxis + 6, majorPlaceY));
                majorPlaceY += majorY;

               

            }



        }
    }
}
