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
    public partial class FRM_DDA : Form
    {
        public FRM_DDA()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        void DDA_Line(double Num_x1, double Num_y1, double Mum_x2, double Num_y2)
        {
            try{

                double x = Num_x1, y = Num_y1;
            Bitmap bitmap = new Bitmap(PicBox.Width, PicBox.Height);

            double deleaX = Mum_x2 - Num_x1, deltaY = Num_y2 - Num_y1;
          //  float Mm = deltaY / deleaX;

            double Steps;

            if (Math.Abs(deleaX) > Math.Abs(deltaY))
            {
                Steps = Math.Abs(deleaX);
            }
            else
            {
                Steps = Math.Abs(deltaY);
            }
            Value.Items.Clear();
            for (int i = 0; i <= Steps; i++)
            {
               
                Value.Items.Add("( " + Math.Round(x) + " , " + Math.Round(y) + "  )");
                 x += deleaX / Steps;
                 y += deltaY / Steps;
                bitmap.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.DarkRed);
                
            }

            PicBox.Image = bitmap;

            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            } 
        }



        private void btn_ok_Click(object sender, EventArgs e)
        {
            try{

            float Num_x1 = int.Parse(txt_x1.Text);
            float Num_y1 = int.Parse(txt_y1.Text);
            float Num_x2 = int.Parse(txt_x2.Text);
            float Num_y2 = int.Parse(txt_y2.Text);
            DDA_Line(Num_x1, Num_y1, Num_x2, Num_y2);

            }
            catch (Exception ex)
            {
                button1_Click(null, null);
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DDA_Load(object sender, EventArgs e)
        {

        }
          
        private void btn_rotate_Click(object sender, EventArgs e)
           {
            try{

               double[] arr = new double[4];
               arr = new transformation().Rotatation(double.Parse(txt_x1.Text), double.Parse(txt_y1.Text), double.Parse(txt_x2.Text), double.Parse(txt_y2.Text), double.Parse(txt_Angle.Text));
                  DDA_Line(arr[0],arr[1],arr[2],arr[3]);
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
                DDA_Line(arr[0], arr[1], arr[2], arr[3]);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try{

            int[] arr = new int[4];
            arr = new transformation().translatePositive(int.Parse(txt_x1.Text), int.Parse(txt_y1.Text), int.Parse(txt_x2.Text), int.Parse(txt_y2.Text), int.Parse(txt_Width.Text), int.Parse(txt_Height.Text));
            DDA_Line(arr[0], arr[1], arr[2], arr[3]);
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
            txt_Width.Text = "";
            txt_Height.Text = "";
            txt_Angle.Text = "";
            txt_X.Text = "";
            txt_Y.Text = "";
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
                DDA_Line(arr[0], arr[1], arr[2], arr[3]);
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

        private void txt_X_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_x2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_y2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
