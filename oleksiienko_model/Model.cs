using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace oleksiienko_model
{


    public partial class Model : Form
    {
        bool flag = false;
        Graphics gr;
        CoordinateSystem cs;
        GraphicsPath AB1 = new GraphicsPath();
        GraphicsPath AC1 = new GraphicsPath();
        GraphicsPath circle_main = new GraphicsPath();
     //   Point[] input_points = new Point[3] { };
        Pen pen = new Pen(Color.Black);
       
        double leftX, rightX, upY, downY;
        double x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, x7, y7;//Point A, B1, C1, B, C, K, E;
        MouseEventArgs me;

        int click_counter = 0;
         
     
        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            SetCurrentAdvise();

            gr.Clear(pictureBox1.BackColor);
            DetermineCoordinateSystem();

            if (click_counter >=3) drawGraphics();
            SetCurrentAdvise();




        }
        private void SetCurrentAdvise()
        {
            switch (click_counter) { 
                case 0:
                    if (flag)
                    {
                        toolStripStatusLabel1.Text = "Поставьте точку А";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = $"Нажмите: \"Нарисовать систему координат\".";
                    }
                    

                break;
                case 1:
                    toolStripStatusLabel1.Text = "Поставьте точку B1";
                    break;
                case 2:
                    toolStripStatusLabel1.Text = "Поставьте точку C1";
                    break;
                case 3:
                    toolStripStatusLabel1.Text = "Используйте +- для приблежение, и стрелки для передвижение модели";
                    break;



            }




        }
        
            void DetermineCoordinateSystem()
        {
             leftX = double.Parse(textBox_leftX.Text);
             rightX = double.Parse(textBox_rightX.Text);
             upY = double.Parse(textBox_upY.Text);
             downY = double.Parse(textBox_downY.Text);

            cs = new CoordinateSystem(rightX, leftX, upY, downY, pictureBox1, Color.Red);
            cs.DrawCoordinateSystem();
        }

        private void zoomMinus_Click(object sender, EventArgs e)
        {
            leftX--; rightX++; upY++; downY--;
            textBox_leftX.Text = leftX.ToString();
            textBox_rightX.Text = rightX.ToString();
            textBox_upY.Text = upY.ToString();
            textBox_downY.Text = downY.ToString();

            DetermineCoordinateSystem();
            drawGraphics();


        }

        private void pushRight_Click(object sender, EventArgs e)
        {
           

            leftX--;
            rightX--;
            textBox_leftX.Text = leftX.ToString();
            textBox_rightX.Text = rightX.ToString();

            DetermineCoordinateSystem();
            drawGraphics();

        }

        private void pushLeft_Click(object sender, EventArgs e)
        {
          
            rightX++;
            leftX++;
            textBox_leftX.Text = leftX.ToString();
            textBox_rightX.Text = rightX.ToString();
            DetermineCoordinateSystem();
            drawGraphics();


        }

        private void pushUp_Click(object sender, EventArgs e)
        {
            
            upY++;
            downY++;
            textBox_upY.Text = upY.ToString();
            textBox_downY.Text = downY.ToString();

            DetermineCoordinateSystem();
            drawGraphics();

         

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Model_MouseMove(object sender, MouseEventArgs e)
        {
            SetCurrentAdvise();
        }

        private void pushLeft_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Подвинуть влево";
        }

        private void pushRight_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Подвинуть вправо";
        }

        private void pushUp_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Подвинуть вверх";
        }

        private void pushDown_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Подвинуть вниз";
        }

        private void zoomPlus_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Приблизить";
        }

        private void zoomMinus_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Отдалить";
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Начать сначала";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Нарисовать систему координат";
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Сохранить скриншот";
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Титульная страница";
        }

        private void pushDown_Click(object sender, EventArgs e)
        {
           
            downY--;
            upY--;
            textBox_upY.Text = upY.ToString();
            textBox_downY.Text = downY.ToString();

            DetermineCoordinateSystem();
            drawGraphics();

        }

        private void Model_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox_leftX_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_rightX_TextChanged(object sender, EventArgs e)
        {
     
        }
  
        double[] FindTheMatchPoint(double x1, double y1, double x2, double y2, double ratio)
        {
            double x3 = (x1 + x2 * ratio) / (1 + ratio);
            double y3 = (y1 + y2 * ratio) / (1 + ratio);
            return new double[] { x3, y3 };
        }
        double[] FindTheLastPoint(double x1, double y1, double x3, double y3, double ratio)
        {
            double x2 = x3 + (x3 - x1) / ratio;
            double y2 = y3 + (y3 - y1) / ratio;
            return new double[] { x2, y2 };
        }

        /*
        double[] FindTheMatchPoint(double x1, double y1, double x2, double y2, double radius)
        {
            double k = FindK(x1, y1, x2, y2);
            double b = FindB(x1, y1, k);
            if (x1 == x2) return new double[] { x1, y1 + radius };
            if (y1 == y2) return new double[] { x1 + radius, y1 };

            double[] x3y3 = new double[2];

            double delta = 0;
            if (x1 < x2) delta = 0.1;
            else delta = -0.1;

            double changingX = x1;
            double chaningY = y1;
            while (true)
            {
                changingX += delta;
                chaningY = k * changingX + b;
                if (circle_main.IsOutlineVisible(cs.xToDisp(changingX), cs.yToDisp(chaningY),pen)) {
                    x3y3[0] = changingX;
                    x3y3[1] = chaningY;
                    break;
                }
            }
            return x3y3;

        }
        */
        void drawGraphics() {

          
            gr.FillEllipse(new SolidBrush(Color.Red), cs.xToDisp(x1) - 10, cs.yToDisp(y1) - 10, 20, 20);
            gr.DrawString("A", new Font("Times New Roman", 15), new SolidBrush(Color.Black), cs.xToDisp(x1), cs.yToDisp(y1));

         
            gr.FillEllipse(new SolidBrush(Color.Blue), cs.xToDisp(x2) - 10, cs.yToDisp(y2) - 10, 20, 20);
            gr.DrawLine(pen, cs.xToDisp(x1), cs.yToDisp(y1), cs.xToDisp(x2), cs.yToDisp(y2));
            gr.DrawString("B1", new Font("Times New Roman", 15), new SolidBrush(Color.Black), cs.xToDisp(x2), cs.yToDisp(y2));



         
            gr.DrawString("C1", new Font("Times New Roman", 15), new SolidBrush(Color.Black), cs.xToDisp(x3), cs.yToDisp(y3));

            gr.DrawLine(pen, cs.xToDisp(x1), cs.yToDisp(y1), cs.xToDisp(x3), cs.yToDisp(y3));
            gr.FillEllipse(new SolidBrush(Color.Blue), cs.xToDisp(x3) - 10, cs.yToDisp(y3)- 10, 20, 20);

            double AB1_length = Math.Sqrt(Math.Pow(cs.xToDisp(x2) - cs.xToDisp(x1), 2) + Math.Pow(cs.yToDisp(y2) - cs.yToDisp(y1), 2));
            double AC1_length = Math.Sqrt(Math.Pow(cs.xToDisp(x3) - cs.xToDisp(x1), 2) + Math.Pow(cs.yToDisp(y3) - cs.yToDisp(y1), 2));

            double radiusDecard = 0;
            double radius = 0;
            if (AB1_length >= AC1_length)
            {
                radius = (int)AC1_length / 2;
                radiusDecard = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)) / 2;

            }
            else
            {
                radius = (int)AB1_length / 2;
                radiusDecard = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) / 2;
            }
            double extraPart1 = AB1_length - radius;
            double ratio1 = radius / extraPart1;
            double extraPart2 = AC1_length - radius;
            double ratio2 = radius / extraPart2;
         
            gr.DrawEllipse(pen, (float)(cs.xToDisp(x1) - radius), (float)(cs.yToDisp(y1) - radius), (float)radius * 2, (float)radius * 2);

            // double radius = Math.Sqrt(Math.Pow(x1 - x_center, 2) + Math.Pow(y1 - y_center, 2));



            //checking function of conversion
         
           

            /*
            double radius_dec = Convert.ToInt32((Math.Min(AB1_length, AC1_length) / 4));
            double AB1_length_dec = Math.Sqrt(Math.Pow(cs.xToDisp(x2 - x1), 2) + Math.Pow(cs.yToDisp(y2 - y1), 2));
            double AC1_length_dec = Math.Sqrt(Math.Pow(cs.xToDisp(x3 - x1), 2) + Math.Pow(cs.yToDisp(y3 - y1), 2));
            */
            double[] x4y4 = FindTheMatchPoint(x1, y1, x2, y2, ratio1);
            x4 = x4y4[0]; y4 = x4y4[1];
            double[] x5y5 = FindTheMatchPoint(x1, y1, x3, y3, ratio2);
            x5 = x5y5[0]; y5 = x5y5[1];

            gr.DrawString("B", new Font("Times New Roman", 15), new SolidBrush(Color.Black), new Point((int)cs.xToDisp(x4), (int)cs.yToDisp(y4)));
            gr.DrawString("C", new Font("Times New Roman", 15), new SolidBrush(Color.Black), new Point((int)cs.xToDisp(x5), (int)cs.yToDisp(y5)));

            gr.FillEllipse(new SolidBrush(Color.Blue), cs.xToDisp(x4) - 10, cs.yToDisp(y4) - 10, 20, 20);
            gr.FillEllipse(new SolidBrush(Color.Blue), cs.xToDisp(x5) - 10, cs.yToDisp(y5) - 10, 20, 20);

            double BC_Length = Math.Sqrt(Math.Pow(cs.xToDisp(x5) - cs.xToDisp(x4), 2) + Math.Pow(cs.yToDisp(y5) - cs.yToDisp(y4), 2));

            gr.DrawEllipse(pen, (float)((float)cs.xToDisp(x4) - BC_Length), (float)(cs.yToDisp(y4) - BC_Length), (float)BC_Length * 2, (float)BC_Length * 2);
            gr.DrawEllipse(pen, (float)((float)cs.xToDisp(x5) - BC_Length), (float)(cs.yToDisp(y5) - BC_Length), (float)BC_Length * 2, (float)BC_Length * 2);

            x6 = (x5 + x4) / 2;

            y6 = (y4 + y5) / 2;
            gr.FillEllipse(new SolidBrush(Color.Green), cs.xToDisp(x6) - 10, cs.yToDisp(y6) - 10, 20, 20);
            gr.DrawString("K", new Font("Times New Roman", 15), new SolidBrush(Color.Black), new Point((int)cs.xToDisp(x6), (int)cs.yToDisp(y6)));

            //   gr.DrawLine(new Pen(Color.Red), cs.xToDisp(x6), cs.yToDisp(y6), cs.xToDisp(x6), cs.yToDisp(y6)+10);
            double BC_Length_for_xy7 = Math.Sqrt(Math.Pow(x4 - x5, 2) + Math.Pow(y4 - y5, 2));


            double ratio3 = Math.Sqrt(Math.Pow(radiusDecard, 2) - Math.Pow(BC_Length_for_xy7 / 2, 2)) / (BC_Length_for_xy7 * Math.Sqrt(3) / 2);
            double[] x7y7 = FindTheLastPoint(x1, y1, x6, y6, ratio3);

            x7 = x7y7[0]; y7 = x7y7[1];
            gr.DrawString("E", new Font("Times New Roman", 15), new SolidBrush(Color.Black), new Point((int)cs.xToDisp(x7), (int)cs.yToDisp(y7)));
            gr.FillEllipse(new SolidBrush(Color.Bisque), cs.xToDisp(x7) - 10, cs.yToDisp(y7) - 10, 20, 20);
            gr.DrawLine(new Pen(Color.Red), cs.xToDisp(x1), cs.yToDisp(y1), cs.xToDisp(x6), cs.yToDisp(y6));
            gr.DrawLine(new Pen(Color.Red), cs.xToDisp(x1), cs.yToDisp(y1), cs.xToDisp(x7), cs.yToDisp(y7));

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

           
            click_counter++;
            SetCurrentAdvise();
           
            me = (MouseEventArgs)e;

            switch (click_counter)
            {
                case 1:
                    x1 = cs.xToDec(me.X); y1 = cs.xToDec(me.Y);
                    gr.FillEllipse(new SolidBrush(Color.Red), me.X - 10, me.Y - 10, 20, 20);
                    gr.DrawString("A", new Font("Times New Roman", 15), new SolidBrush(Color.Black), me.Location);

                    break;
                case 2:
                    x2 = cs.xToDec(me.X); y2 = cs.xToDec(me.Y);
                    gr.FillEllipse(new SolidBrush(Color.Blue), me.X - 10, me.Y - 10, 20, 20);
                    AB1.AddLine(cs.xToDisp(x1), cs.yToDisp(y1), cs.xToDisp(x2), cs.yToDisp(y2));
                    gr.DrawString("B1", new Font("Times New Roman", 15), new SolidBrush(Color.Black), me.Location);
                    break;
                case 3:
                    x3 = cs.xToDec(me.X); y3 = cs.xToDec(me.Y);
                    gr.DrawString("C1", new Font("Times New Roman", 15), new SolidBrush(Color.Black), me.Location);

                    AC1.AddLine(cs.xToDisp(x1), cs.yToDisp(y1), cs.xToDisp(x3), cs.yToDisp(y3));
                    gr.FillEllipse(new SolidBrush(Color.Blue), me.X - 10, me.Y - 10, 20, 20);

                    double AB1_length = Math.Sqrt(Math.Pow(cs.xToDisp(x2)- cs.xToDisp(x1), 2) + Math.Pow(cs.yToDisp(y2) - cs.yToDisp(y1), 2));
                    double AC1_length = Math.Sqrt(Math.Pow(cs.xToDisp(x3) - cs.xToDisp(x1), 2) + Math.Pow(cs.yToDisp(y3) - cs.yToDisp(y1), 2));
                    /*
                    double x_center;
                    double y_center;
                    if (AB1_length > AC1_length)
                    {
                        x_center = (x1 + x3) / 2;
                        y_center = (y1 + y3) / 2;
                    }
                    else
                    {
                        x_center = (x1 + x2) / 2;
                        y_center = (y1 + y2) / 2;
                    }
                    */
                    //  double radius_disp = Math.Sqrt(Math.Pow(cs.xToDisp(x1 - x_center), 2) + Math.Pow(cs.yToDisp(y1 - y_center), 2));
                    
                    double radiusDecard = 0;
                    double radius = 0;
                    if(AB1_length >= AC1_length)
                    {
                        radius = (int)AC1_length / 2;
                        radiusDecard = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3,2)) /2;

                    }
                    else
                    {
                        radius = (int)AB1_length/2;
                        radiusDecard = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) /2 ;
                    }
                    double extraPart1 = AB1_length - radius;
                    double ratio1 = radius / extraPart1;
                    double extraPart2 = AC1_length - radius;
                    double ratio2 = radius / extraPart2;
                    circle_main.AddEllipse((float)(cs.xToDisp(x1)-radius), (float)(cs.yToDisp(y1)-radius), (float)radius*2, (float)radius*2);

                    // double radius = Math.Sqrt(Math.Pow(x1 - x_center, 2) + Math.Pow(y1 - y_center, 2));
                   


                    gr.DrawPath(pen, AB1);
                    gr.DrawPath(pen,AC1);
                    gr.DrawPath(pen, circle_main);
                    //checking function of conversion
                    /*
                    listBox1.Items.Add(me.Location);
                    listBox1.Items.Add(cs.xToDisp(cs.xToDec(me.X)));
                    listBox1.Items.Add(cs.yToDisp(cs.yToDec(me.Y)));
                    if (cs.xToDisp(cs.xToDec(me.X)) == me.X) listBox1.Items.Add(true);
                    else listBox1.Items.Add(false);

                    if (cs.xToDisp(cs.yToDec(me.Y)) == me.Y) listBox1.Items.Add(true);
                    else listBox1.Items.Add(false);
                    */

                    /*
                    double radius_dec = Convert.ToInt32((Math.Min(AB1_length, AC1_length) / 4));
                    double AB1_length_dec = Math.Sqrt(Math.Pow(cs.xToDisp(x2 - x1), 2) + Math.Pow(cs.yToDisp(y2 - y1), 2));
                    double AC1_length_dec = Math.Sqrt(Math.Pow(cs.xToDisp(x3 - x1), 2) + Math.Pow(cs.yToDisp(y3 - y1), 2));
                    */
                    double[] x4y4 = FindTheMatchPoint(x1, y1, x2, y2, ratio1);
                    x4 = x4y4[0]; y4 = x4y4[1];
                    double[] x5y5 = FindTheMatchPoint(x1, y1, x3, y3, ratio2);
                    x5 = x5y5[0]; y5 = x5y5[1];

                    gr.DrawString("B", new Font("Times New Roman", 15), new SolidBrush(Color.Black), new Point((int)cs.xToDisp(x4),(int)cs.yToDisp(y4)));
                    gr.DrawString("C", new Font("Times New Roman", 15), new SolidBrush(Color.Black), new Point((int)cs.xToDisp(x5), (int)cs.yToDisp(y5)));

                    gr.FillEllipse(new SolidBrush(Color.Blue), cs.xToDisp(x4) - 10, cs.yToDisp(y4) - 10, 20, 20);
                    gr.FillEllipse(new SolidBrush(Color.Blue), cs.xToDisp(x5) - 10, cs.yToDisp(y5) - 10, 20, 20);

                    double BC_Length = Math.Sqrt(Math.Pow(cs.xToDisp(x5) - cs.xToDisp(x4), 2) + Math.Pow(cs.yToDisp(y5) - cs.yToDisp(y4), 2));

                    gr.DrawEllipse(pen, (float)((float)cs.xToDisp(x4) - BC_Length), (float)(cs.yToDisp(y4)- BC_Length), (float)BC_Length*2, (float)BC_Length*2);
                    gr.DrawEllipse(pen, (float)((float)cs.xToDisp(x5) - BC_Length), (float)(cs.yToDisp(y5) - BC_Length), (float)BC_Length*2, (float)BC_Length*2);

                    x6 = (x5 + x4) / 2;

                    y6 = (y4 + y5) / 2;
                    gr.FillEllipse(new SolidBrush(Color.Green), cs.xToDisp(x6) - 10, cs.yToDisp(y6) - 10, 20, 20);
                    gr.DrawString("K", new Font("Times New Roman", 15), new SolidBrush(Color.Black), new Point((int)cs.xToDisp(x6), (int)cs.yToDisp(y6)));

                    //   gr.DrawLine(new Pen(Color.Red), cs.xToDisp(x6), cs.yToDisp(y6), cs.xToDisp(x6), cs.yToDisp(y6)+10);
                    double BC_Length_for_xy7 = Math.Sqrt(Math.Pow(x4-x5, 2) + Math.Pow(y4-y5, 2));
       

                    double ratio3 = Math.Sqrt(Math.Pow(radiusDecard,2)-Math.Pow(BC_Length_for_xy7/2,2))/(BC_Length_for_xy7*Math.Sqrt(3)/2) ;
                    double[] x7y7 = FindTheLastPoint(x1, y1, x6, y6, ratio3);

                    x7 = x7y7[0]; y7 = x7y7[1];
                    gr.DrawString("E", new Font("Times New Roman", 15), new SolidBrush(Color.Black), new Point((int)cs.xToDisp(x7), (int)cs.yToDisp(y7)));
                    gr.FillEllipse(new SolidBrush(Color.Bisque), cs.xToDisp(x7) - 10, cs.yToDisp(y7) - 10, 20, 20);
                    gr.DrawLine(new Pen(Color.Red), cs.xToDisp(x1), cs.yToDisp(y1), cs.xToDisp(x6), cs.yToDisp(y6));
                    gr.DrawLine(new Pen(Color.Red), cs.xToDisp(x1), cs.yToDisp(y1), cs.xToDisp(x7), cs.yToDisp(y7));


                    pushDown.Visible = true;
                    pushLeft.Visible = true;
                    pushRight.Visible = true;
                    pushUp.Visible = true;
                    zoomMinus.Visible = true;
                    zoomPlus.Visible = true;

                    break;

                

            }

            
            
            


        }

        private void textBox_upY_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox_downY_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
           
            this.Hide();
            new Model().Show();
            

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Title().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {/*
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp); *.PNG|*.jpg; *.jpeg; *.gif; *.bmp; *.PNG";
            save.DefaultExt = ".bmp";
            save.AddExtension = true;


            Bitmap targetBitmap = new Bitmap(pictureBox1.ClientSize.Width,
                                     pictureBox1.ClientSize.Height);
            using (Bitmap sourceBitmap = new Bitmap(pictureBox1.Image,
                         pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height))
            {
                using (Graphics g = Graphics.FromImage(targetBitmap))
                {
                    g.DrawImage(sourceBitmap, new Rectangle(0, 0,
                                pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height));


                }
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = targetBitmap;
                targetBitmap.Save("screenshot", ImageFormat.Jpeg);

            }*/

            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save("screen.jpg", ImageFormat.Jpeg);
                MessageBox.Show("Сохранено!");
            }
        }

        public Model()
        {
            InitializeComponent();

        }

        private void Model_Load(object sender, EventArgs e)
        {
     
            gr = pictureBox1.CreateGraphics();

            SetCurrentAdvise();


            pushDown.Visible = false;
            pushLeft.Visible = false;
            pushRight.Visible = false;
            pushUp.Visible = false;
            zoomMinus.Visible = false;
            zoomPlus.Visible = false;


        }

        private void zoomPlus_Click(object sender, EventArgs e)
        {
            leftX++;rightX--;upY--;downY++;
            textBox_leftX.Text = leftX.ToString();
            textBox_rightX.Text = rightX.ToString();
            textBox_upY.Text = upY.ToString();
            textBox_downY.Text = downY.ToString();

            
            DetermineCoordinateSystem();
            drawGraphics();


        }
      
    }
}
