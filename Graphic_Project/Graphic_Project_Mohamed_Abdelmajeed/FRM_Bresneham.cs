using System;
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
    public partial class FRM_Bresneham : Form
    {
        public FRM_Bresneham()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void FRM_Bresneham_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int[] arr = new int[4];
                arr = new transformation().translatePositive(int.Parse(txt_x1.Text), int.Parse(txt_y1.Text), int.Parse(txt_x2.Text), int.Parse(txt_y2.Text), int.Parse(txt_Width.Text), int.Parse(txt_Height.Text));
                Bersenham_Line(arr[0], arr[1], arr[2], arr[3]);
                txt_x1.Text = Convert.ToString(arr[0]);
                txt_y1.Text = Convert.ToString(arr[1]);
                txt_x2.Text = Convert.ToString(arr[2]);
                txt_y2.Text = Convert.ToString(arr[3]);
            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }
        public void Bersenham_Line(double Num_x1, double Num_y1, double Num_x2, double Num_y2)
        {
            try{

                double deltaX, dDeltaY, x, y, p0, Sign1, Sign2; bool Change;


            x = Num_x1;
            y = Num_y1;

            Sign1 = Math.Sign(Num_x2 - Num_x1);
            Sign2 = Math.Sign(Num_y2 - Num_y1);

            deltaX = Math.Abs(Num_x2 - Num_x1);
            dDeltaY = Math.Abs(Num_y2 - Num_y1);
            p0 = 2 * dDeltaY - deltaX;
            if (dDeltaY > deltaX)
            {
                swap(ref deltaX, ref dDeltaY);
                Change = true;
            }
            else
            {
                Change = false;
            }

            PicBox.Image = new Bitmap(PicBox.Width, PicBox.Height);
            String s = "";
            Value.Items.Clear();
            for (int i = 0; i < deltaX; i++)
            {
                if (i < 10) s = "    ";
                else if (i < 100) s = "  ";
                else s = "";

                ((Bitmap)PicBox.Image).SetPixel((int)x, (int)y, Color.Navy);
                
                Value.Items.Add(i+s+"  |  "+" ( " + (int)x + " , " + (int)y + "  )  |  "+p0);
                if (p0 > 0)
                {
                    if (Change)
                    {
                        x += Sign1;
                    }
                    else
                    {
                        y += Sign2;
                    }
                    p0 = p0 + 2 * (dDeltaY - deltaX);
                }
                else
                {
                    p0 = p0 + 2 * dDeltaY;
                }

                if (Change)
                {
                    y += Sign2;
                }
                else
                {
                    x += Sign1;
                }

            }

            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }
        public static void swap(ref double Number1, ref double Number2)
        {

            double TEMP;

            TEMP = Number1;
            Number1 = Number2;
            Number2 = TEMP;

        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            try{
           int Num_x1 = int.Parse(txt_x1.Text);
           int Num_y1 = int.Parse(txt_y1.Text);
           int Num_x2 = int.Parse(txt_x2.Text);
           int Num_y2 = int.Parse(txt_y2.Text);
            Bersenham_Line(Num_x1,Num_y1,Num_x2,Num_y2);
            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }

        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            try{

            double[] arr = new double[4];
            arr = new transformation().Rotatation(double.Parse(txt_x1.Text), double.Parse(txt_y1.Text), double.Parse(txt_x2.Text), double.Parse(txt_y2.Text), double.Parse(txt_Angle.Text));
            Bersenham_Line(arr[0], arr[1], arr[2], arr[3]);
            txt_x1.Text = Convert.ToString(arr[0]);
            txt_y1.Text = Convert.ToString(arr[1]);
            txt_x2.Text = Convert.ToString(arr[2]);
            txt_y2.Text = Convert.ToString(arr[3]);

            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                int[] arr = new int[4];
                arr = new transformation().Scale(int.Parse(txt_x1.Text), int.Parse(txt_y1.Text), int.Parse(txt_x2.Text), int.Parse(txt_y2.Text), int.Parse(txt_X.Text), int.Parse(txt_Y.Text));
                Bersenham_Line(arr[0], arr[1], arr[2], arr[3]);
                txt_x1.Text = Convert.ToString(arr[0]);
                txt_y1.Text = Convert.ToString(arr[1]);
                txt_x2.Text = Convert.ToString(arr[2]);
                txt_y2.Text = Convert.ToString(arr[3]);
            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try{

            txt_x1.Text = "";
            txt_x2.Text = "";
            txt_y1.Text = "";
            txt_y2.Text = "";
            txt_X.Text = "";
            txt_Y.Text = "";
            txt_Angle.Text = "";
            txt_Width.Text = "";
            txt_Height.Text = "";
            Value.Items.Clear();
            PicBox.Image = null;
            PicBox.Invalidate();

            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                int[] arr = new int[4];
                arr = new transformation().translateNegative(int.Parse(txt_x1.Text), int.Parse(txt_y1.Text), int.Parse(txt_x2.Text), int.Parse(txt_y2.Text), int.Parse(txt_Width.Text), int.Parse(txt_Height.Text));
                Bersenham_Line(arr[0], arr[1], arr[2], arr[3]);
                txt_x1.Text = Convert.ToString(arr[0]);
                txt_y1.Text = Convert.ToString(arr[1]);
                txt_x2.Text = Convert.ToString(arr[2]);
                txt_y2.Text = Convert.ToString(arr[3]);
            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
