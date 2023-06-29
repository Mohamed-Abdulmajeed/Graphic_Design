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
    public partial class FRM_Circle : Form
    {
        public FRM_Circle()
        {
            InitializeComponent();
        }

        private void PicBox_Click(object sender, EventArgs e)
        {

        }

        private void Value_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
        public void circle(int xCenter, int yCenter, int radius)
        {
            try{

            Bitmap bitmap = new Bitmap(PicBox.Width, PicBox.Height);

            int x = 0;
            int y = radius;
            int Pk = 1 - y;
            Value.Items.Clear();
            ArrayList FirstQ1 = new ArrayList();
            ArrayList SecQ1 = new ArrayList();
            ArrayList ThirdQ1 = new ArrayList();
            ArrayList FourthQ1 = new ArrayList();
            ArrayList FirstQ2 = new ArrayList();
            ArrayList SecQ2 = new ArrayList();
            ArrayList ThirdQ2 = new ArrayList();
            ArrayList FourthQ2 = new ArrayList();
            int index = 0;

            while (x < y)
            {
                DataGridViewRow Row = new DataGridViewRow();
                Row.CreateCells(Data_G_View);
                Row.Cells[0].Value = index;
                Row.Cells[1].Value = Pk;
                 if (Pk < 0)
                  {
                    Pk += 2 * x + 1;
                  }

                  else
                  {
                    Pk += 2 * (x - y) + 1;
                    y--;
                  }
            x++;
            Row.Cells[2].Value = Pk;
            Row.Cells[3].Value = x;
            Row.Cells[4].Value = y;
            bitmap.SetPixel((int)xCenter + x, (int)yCenter - y, Color.Black);
            bitmap.SetPixel((int)xCenter + y, (int)yCenter - x, Color.Black);

            bitmap.SetPixel((int)xCenter - x, (int)yCenter - y, Color.Black);
            bitmap.SetPixel((int)xCenter - y, (int)yCenter - x, Color.Black);

            bitmap.SetPixel((int)xCenter - y, (int)yCenter + x, Color.Black);
            bitmap.SetPixel((int)xCenter - x, (int)yCenter + y, Color.Black);

            bitmap.SetPixel((int)xCenter + y, (int)yCenter + x, Color.Black);
            bitmap.SetPixel((int)xCenter + x, (int)yCenter + y, Color.Black);

                PicBox.Image = bitmap;

                FirstQ1.Add(" ( " + ((int)xCenter + x) + " , " + ((int)yCenter - y) + "  )");
                FirstQ2.Add(" ( " + ((int)xCenter + y) + " , " + ((int)yCenter - x) + "  )");

                SecQ1.Add(" ( " + ((int)xCenter - x) + " , " + ((int)yCenter - y) + "  )");
                SecQ2.Add(" ( " + ((int)xCenter - y) + " , " + ((int)yCenter - x) + "  )");

                ThirdQ1.Add(" ( " + ((int)xCenter - y) + " , " + ((int)yCenter + x) + "  )");
                ThirdQ2.Add(" ( " + ((int)xCenter - x) + " , " + ((int)yCenter + y) + "  )");

                FourthQ1.Add(" ( " + ((int)xCenter + y) + " , " + ((int)yCenter + x) + "  )");
                FourthQ2.Add(" ( " + ((int)xCenter + x) + " , " + ((int)yCenter + y) + "  )");
                
                index++;
                Data_G_View.Rows.Add(Row);

            }
            Value.Items.Add("First Quarter");
            Value.Items.Add("");

            for (int i = 0; i < index; i++)
                Value.Items.Add(FirstQ1[i]);
            for (int i = index-1; i >=0 ; i--)
                Value.Items.Add(FirstQ2[i]);
            Value.Items.Add("");

            Value.Items.Add("Second Quarter");
            Value.Items.Add("");

            for (int i = 0; i < index; i++)
                Value.Items.Add(SecQ1[i]);
            for (int i = index - 1; i >= 0; i--)
                Value.Items.Add(SecQ2[i]);
            Value.Items.Add("");

            Value.Items.Add("Third Quarter");
            Value.Items.Add("");

            for (int i = 0; i < index; i++)
                Value.Items.Add(ThirdQ1[i]);
            for (int i = index - 1; i >= 0; i--)
                Value.Items.Add(ThirdQ2[i]);
            Value.Items.Add("");

            Value.Items.Add("Fourth Quarter");
            Value.Items.Add("");

            for (int i = 0; i < index; i++)
            Value.Items.Add(FourthQ1[i]);
            for (int i = index - 1; i >= 0; i--)
            Value.Items.Add(FourthQ2[i]);
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            try{

            int xc = int.Parse(txt_xc.Text);
            int yc = int.Parse(txt_yc.Text);
            int radius = int.Parse(txt_r.Text);
            circle(xc, yc, radius);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void txt_xc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Tran_Pos_Click(object sender, EventArgs e)
        {
            try{

            int[] arr = new int[2];
            arr = new transformation().Circle_translatePositive(int.Parse(txt_xc.Text), int.Parse(txt_yc.Text), int.Parse(txt_Width.Text), int.Parse(txt_Height.Text));

            circle(arr[0], arr[1], int.Parse(txt_r.Text));
            txt_xc.Text = Convert.ToString(arr[0]);
            txt_yc.Text = Convert.ToString(arr[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void btn_Tran_Neg_Click(object sender, EventArgs e)
        {
            try{

            int[] arr = new int[2];
            arr = new transformation().Circle_translateNegative(int.Parse(txt_xc.Text), int.Parse(txt_yc.Text), int.Parse(txt_Width.Text), int.Parse(txt_Height.Text));

            circle(arr[0], arr[1], int.Parse(txt_r.Text));
            txt_xc.Text = Convert.ToString(arr[0]);
            txt_yc.Text = Convert.ToString(arr[1]);
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void btn_Scale_Click(object sender, EventArgs e)
        { 
            try{

            int xc = int.Parse(txt_xc.Text);
            int yc = int.Parse(txt_yc.Text);
            int X = int.Parse(txt_X.Text) * int.Parse(txt_r.Text);

            circle(xc, yc,X);
            txt_r.Text = Convert.ToString(X);
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

            try
            {

                txt_xc.Text = "";
                txt_yc.Text = "";
                txt_r.Text = "";
                txt_Width.Text = "";
                txt_Height.Text = "";
                txt_X.Text = "";
                Value.Items.Clear();
                PicBox.Image = null;
                PicBox.Invalidate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void txt_r_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            PicBox.CreateGraphics().FillEllipse(Brushes.Red, int.Parse(txt_xc.Text) - int.Parse(txt_r.Text), int.Parse(txt_yc.Text) - int.Parse(txt_r.Text), 2*int.Parse(txt_r.Text),2* int.Parse(txt_r.Text));
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_Circle_Load(object sender, EventArgs e)
        {

        }
    }
}
