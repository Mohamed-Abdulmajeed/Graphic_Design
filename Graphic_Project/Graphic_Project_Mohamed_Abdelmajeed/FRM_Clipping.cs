using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Project_Mohamed_Abdelmajeed
{
    public partial class FRM_Clipping : Form
    {
        private List<Point> PolygonPoints;
        private ArrayList AllPoint ;

        private int Num_Line, num, Name_Line;
        

        public FRM_Clipping()
        {
            InitializeComponent();
            PolygonPoints = new List<Point>();
            AllPoint = new ArrayList();
            Num_Line = 0;
            Name_Line = 0;
            num = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.White);

            PolygonPoints.Clear();
            AllPoint.Clear();
            Num_Line = 0;
            Name_Line = 0;
            num = 0;
        }

        private void FRM_Clipping_MouseDown(object sender, MouseEventArgs e)
        {
            try{
            Num_Line+=2;
            num++;
            PolygonPoints.Add(new Point(e.X, e.Y));
            AllPoint.Add(e.X);
            AllPoint.Add(e.Y);

            Font myfont =new Font("tahoma",14,FontStyle.Bold);
            if (num %2==0)
            {
                Name_Line++;
            this.CreateGraphics().DrawPolygon(Pens.DarkRed, PolygonPoints.ToArray());
            this.CreateGraphics().DrawString("L" + Name_Line, myfont, Brushes.DarkBlue, PolygonPoints[0]);
            PolygonPoints.Clear();
            }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try{
            int minx = int.Parse(txt_x1.Text);
            int miny = int.Parse(txt_y1.Text);
            int maxx = int.Parse(txt_x2.Text);
            int maxy = int.Parse(txt_y2.Text);
            this.CreateGraphics().DrawLine(Pens.DarkGreen, minx, miny, maxx, miny);
            this.CreateGraphics().DrawLine(Pens.DarkGreen, minx, miny, minx, maxy);
            this.CreateGraphics().DrawLine(Pens.DarkGreen, minx, maxy, maxx, maxy);
            this.CreateGraphics().DrawLine(Pens.DarkGreen, maxx, miny, maxx, maxy);
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
       
        private void button1_Click(object sender, EventArgs e)
        {
            try{
            Font myfont = new Font("tahoma", 14, FontStyle.Bold);

            this.CreateGraphics().Clear(Color.White);

            int minxWind = int.Parse(txt_x1.Text);
            int minyWind = int.Parse(txt_y1.Text);
            int maxxWind = int.Parse(txt_x2.Text);
            int maxyWind = int.Parse(txt_y2.Text);

            this.CreateGraphics().DrawLine(Pens.DarkGreen, minxWind, minyWind, maxxWind, minyWind);
            this.CreateGraphics().DrawLine(Pens.DarkGreen, minxWind, minyWind, minxWind, maxyWind);
            this.CreateGraphics().DrawLine(Pens.DarkGreen, minxWind, maxyWind, maxxWind, maxyWind);
            this.CreateGraphics().DrawLine(Pens.DarkGreen, maxxWind, minyWind, maxxWind, maxyWind);

            int nameLine = 0;

            for (int i = 0; i < Num_Line; i += 4)

            {
                nameLine++;

                int x1 = (int)AllPoint[i];
                int y1 = (int)AllPoint[i + 1];
                int x2 = (int)AllPoint[i + 2];
                int y2 = (int)AllPoint[i + 3];

                String code1, code2;

                code1 = getcode(minxWind, minyWind, maxxWind, maxyWind, x1, y1);
                code2 = getcode(minxWind, minyWind, maxxWind, maxyWind, x2, y2);
                char[] cod1 = code1.ToArray();
                char[] cod2 = code2.ToArray();
                bool TruFalse = false;
            
                for (int j = 0; j < 4; j++)
                { 
                if (cod1[j].Equals(cod2[j]).Equals("1"))
                    TruFalse = true;

                if (cod1.Equals(cod2))
                {
                    if (cod1.Equals("0000"))
                    { }
                    else
                        TruFalse = true;

                }
                }

                    if (TruFalse)
                    {
                    }
                    else if (code1.Equals("0000") && code2.Equals("0000"))
                    {
                        this.CreateGraphics().DrawLine(Pens.DarkRed, x1, y1, x2, y2);
                        Point point = new Point(x1, y1);
                        this.CreateGraphics().DrawString("L" + nameLine, myfont, Brushes.DarkBlue, point);

                    }
                    else
                    {
                        float m = (float)(y2 - y1) / (float)(x2 - x1);
                        int[] p1 = new int[2];
                        int[] p2 = new int[2];
                        if (code1.Equals("0000"))
                        {
                            p1[0] = x1;
                            p1[1] = y1;
                        }
                        else
                            p1 = check_And_Rrturn_New_Point(m, code1, minxWind, maxxWind, minyWind, maxyWind, x1, y1);
                        if (code2.Equals("0000"))
                        {
                            p2[0] = x2;
                            p2[1] = y2;
                        }
                        else
                            p2 = check_And_Rrturn_New_Point(m, code2, minxWind, maxxWind, minyWind, maxyWind, x2, y2);

                        Point point = new Point(p1[0], p1[1]);
                        String cod = getcode(minxWind, minyWind, maxxWind, maxyWind, p1[0], p1[1]);
                        if (cod.Equals("0000"))
                        {
                            if (((p1[0] == p2[0]) && (p1[0] == minxWind || p1[0] == maxxWind)) || ((p1[1] == p2[1]) && (p1[1] == minyWind || p1[1] == maxyWind)))
                            { 
                            }
                            else
                            {
                                this.CreateGraphics().DrawLine(Pens.DarkRed, p1[0], p1[1], p2[0], p2[1]);
                                this.CreateGraphics().DrawString("L" + nameLine, myfont, Brushes.DarkBlue, point);
                            }
                        }
                    }

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        
        ///////////////////////////////////////////////////////////////////////////////////
     

        public String getcode(int minx, int miny, int maxx, int maxy, int x1, int y1)
        {
            String code1 = "0";

            if (x1 >= minx && x1 <= maxx && y1 <= maxy && y1 >= miny)
                return code1 = "0000";

            else if (x1 >= minx && x1 <= maxx && y1 < maxy && y1 < miny)
                return code1 = "0100";

            else if (x1 >= minx && x1 >= maxx && y1 < maxy && y1 < miny)
                return code1 = "0110";

            else if (x1 <= minx && x1 <= maxx && y1 < maxy && y1 < miny)
                return code1 = "0101";

            else if (x1 > minx && x1 > maxx && y1 <= maxy && y1 >= miny)
                return code1 = "0010";

            else if (x1 >= minx && x1 >= maxx && y1 > maxy && y1 > miny)
                return code1 = "1010";

            else if (x1 >= minx && x1 <= maxx && y1 > maxy && y1 > miny)
                return code1 = "1000";

            else if (x1 <= minx && x1 <= maxx && y1 > maxy && y1 > miny)
                return code1 = "1001";

            else if (x1 < minx && x1 < maxx && y1 <= maxy && y1 >= miny)
                return code1 = "0001";

            else return code1;
        }
        
        //////////////////////////////////////////////////////////////////////////////////
     
        public int[] check_And_Rrturn_New_Point(float m, String code, int minx, int maxx, int miny, int maxy, int x, int y)
        {
            int xnew = 0, ynew = 0;

            if (code.Equals("0100"))
            {
                ynew = miny;
                xnew = Math.Abs((int)(x + ((ynew - y) / m)));
                int[] arr = { xnew, ynew };
                return arr;
            }
            else if (code.Equals("1000"))
            {
                ynew = maxy;
                xnew = Math.Abs((int)(x + ((ynew - y) / m)));
                int[] arr = { xnew, ynew };
                return arr;
            }
            else if (code.Equals("0010"))
            {
                xnew = maxx;
                ynew = Math.Abs((int)(y + (m * (xnew - x))));
                int[] arr = { xnew, ynew };
                return arr;
            }
            else if (code.Equals("0001"))
            {
                xnew = minx;
                ynew = Math.Abs((int)(y + (m * (xnew - x))));
                int[] arr = { xnew, ynew };
                return arr;
            }
            else if (code.Equals("0110"))
            {
                xnew = maxx;
                ynew = Math.Abs((int)(y + (m * (xnew - x))));

                String cod = getcode(minx, miny, maxx, maxy, xnew, ynew);
                if (cod.Equals("0000"))
                {
                    int[] arr = { xnew, ynew };
                    return arr;
                }
                else
                {
                    ynew = miny;
                    xnew = Math.Abs((int)(x + ((ynew - y) / m)));

                    int[] arr = { xnew, ynew };
                    return arr;
                }

            }
            else if (code.Equals("0101"))
            {
                xnew = minx;
                ynew = Math.Abs((int)(y + (m * (xnew - x))));
                String cod = getcode(minx, miny, maxx, maxy, xnew, ynew);
                if (cod.Equals("0000"))
                {
                    int[] arr = { xnew, ynew };
                    return arr;
                }
                else
                {
                    ynew = miny;
                    xnew = Math.Abs((int)(x + ((ynew - y) / m)));

                    int[] arr = { xnew, ynew };
                    return arr;
                }
            }
            else if (code.Equals("1010"))
            {
                xnew = maxx;
                ynew = Math.Abs((int)(y + (m * (xnew - x))));
                String cod = getcode(minx, miny, maxx, maxy, xnew, ynew);
                if (cod.Equals("0000"))
                {
                    int[] arr = { xnew, ynew };
                    return arr;
                }
                else
                {
                    ynew = maxy;
                    xnew = Math.Abs((int)(x + ((ynew - y) / m)));

                    int[] arr = { xnew, ynew };
                    return arr;
                }
            }
            else if (code.Equals("1001"))
            {
                xnew = minx;
                ynew = Math.Abs((int)(y + (m * (xnew - x))));
                String cod = getcode(minx, miny, maxx, maxy, xnew, ynew);
                if (cod.Equals("0000"))
                {
                    int[] arr = { xnew, ynew };
                    return arr;
                }
                else
                {
                    ynew = maxy;
                    xnew = Math.Abs((int)(x + ((ynew - y) / m)));

                    int[] arr = { xnew, ynew };
                    return arr;
                }
            }

            else
            {
                int[] arr = { xnew, ynew };
                return arr;
            }

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////
       
        private void txt_x2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_Clipping_Load(object sender, EventArgs e)
        {

        }
    }
}
