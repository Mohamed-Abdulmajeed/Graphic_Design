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
    public partial class FRM_Ellips : Form
    {
        public FRM_Ellips()
        {
            InitializeComponent();
        }
        public int round(double x)
        {
            return (int)(x + 0.5);
        }
        public void Ellips(int xCenter, int yCenter, int rx, int ry)
        {
            try{
            Bitmap bitmap = new Bitmap(PicBox.Width, PicBox.Height);
            int x = 0;
            int y = ry;
            Value.Items.Clear();

/*
            dataGridView1.Columns.Remove(ii);
            dataGridView1.Columns.Remove(iii);
            dataGridView1.Columns.Remove(iiii);
            dataGridView1.Columns.Remove(iiiii);
            dataGridView1.Columns.Remove(iiiiii);
            dataGridView2.Columns.Remove(jj);
            dataGridView2.Columns.Remove(jjj);
            dataGridView2.Columns.Remove(jjjj);
            dataGridView2.Columns.Remove(jjjjj);
            dataGridView2.Columns.Remove(jjjjjj);
           */


            ArrayList FirstQ1 = new ArrayList();
            ArrayList SecQ1 = new ArrayList();
            ArrayList ThirdQ1 = new ArrayList();
            ArrayList FourthQ1 = new ArrayList();
            ArrayList FirstQ2 = new ArrayList();
            ArrayList SecQ2 = new ArrayList();
            ArrayList ThirdQ2 = new ArrayList();
            ArrayList FourthQ2 = new ArrayList();
            int index1 = 0;
            int index2 = 0;
            int indx = 0;
            double Pk = round((ry * ry) - (rx * rx * ry) + (0.25 * rx * rx));

            while ((2 * x * Math.Pow(ry, 2)) < (2 * y * Math.Pow(rx, 2)))
            {
                DataGridViewRow rw = new DataGridViewRow();
                rw.CreateCells(dataGridView1);
                rw.Cells[0].Value = index1;
                rw.Cells[1].Value = Pk;

                FirstQ1.Add(" ( " + ((int)xCenter + x) + " , " + ((int)yCenter - y) + "  )");
                SecQ1.Add(" ( " + ((int)xCenter - x) + " , " + ((int)yCenter - y) + "  )");
                ThirdQ2.Add(" ( " + ((int)xCenter - x) + " , " + ((int)yCenter + y) + "  )");
                FourthQ2.Add(" ( " + ((int)xCenter + x) + " , " + ((int)yCenter + y) + "  )");

                index1++;

                bitmap.SetPixel((int)xCenter + x, (int)yCenter - y, Color.Black);
                bitmap.SetPixel((int)xCenter - x, (int)yCenter - y, Color.Black);
                bitmap.SetPixel((int)xCenter - x, (int)yCenter + y, Color.Black);
                bitmap.SetPixel((int)xCenter + x, (int)yCenter + y, Color.Black);

                x++;
                if (Pk < 0)
                {
                    Pk += (2 * x * ry * ry) + (ry * ry);
                }
                else
                {
                    y--;
                    Pk += (2 * x * ry * ry) - (2 * y * rx * rx) + (ry * ry);
                }
                rw.Cells[2].Value = "(" + x + "," + y + ")";
                rw.Cells[3].Value = 2 * ry * ry * x;
                rw.Cells[4].Value = 2 * rx * rx * y;
                dataGridView1.Rows.Add(rw);

            }

            int Pk2 = (int)(Math.Pow(ry, 2) * Math.Pow(x, 2) + (Math.Pow(ry, 2) * x) + (Math.Pow(ry, 2) / 4) + (Math.Pow(rx, 2) * Math.Pow(y, 2)) - (2 * Math.Pow(rx, 2) * y) - (Math.Pow(rx, 2)) - (Math.Pow(rx, 2) * Math.Pow(ry, 2)));
            indx = index1;
            while (y >= 0)
            {
                DataGridViewRow rw2 = new DataGridViewRow();
                rw2.CreateCells(dataGridView2);
                rw2.Cells[1].Value = Pk2;
                if (Pk2 >= 0)
                {
                    y--;
                    Pk2 -=  (int)((2 * y * Math.Pow(rx, 2)) + Math.Pow(rx, 2));

                }
                else
                {
                    y--;
                    x++;
                    Pk2 +=  (int)((2 * x * Math.Pow(ry, 2)) - (2 * y * Math.Pow(rx, 2)) + Math.Pow(rx, 2));
                }

                bitmap.SetPixel((int)xCenter + x, (int)yCenter - y, Color.Black);
                bitmap.SetPixel((int)xCenter - x, (int)yCenter - y, Color.Black);
                bitmap.SetPixel((int)xCenter - x, (int)yCenter + y, Color.Black);
                bitmap.SetPixel((int)xCenter + x, (int)yCenter + y, Color.Black);

                FirstQ2.Add(" ( " + ((int)xCenter + x) + " , " + ((int)yCenter - y) + "  )");
                SecQ2.Add(" ( " + ((int)xCenter - x) + " , " + ((int)yCenter - y) + "  )");
                ThirdQ1.Add(" ( " + ((int)xCenter - x) + " , " + ((int)yCenter + y) + "  )");
                FourthQ1.Add(" ( " + ((int)xCenter + x) + " , " + ((int)yCenter + y) + "  )");

                rw2.Cells[0].Value = indx;
                rw2.Cells[2].Value = "(" + x + "," + y + ")";
                rw2.Cells[3].Value = 2 * ry * ry * x;
                rw2.Cells[4].Value = 2 * rx * rx * y;

                dataGridView2.Rows.Add(rw2);
                index2++;
                indx++;
            }
            PicBox.Image = bitmap;

Value.Items.Add("First Quarter");
            Value.Items.Add("");

            for (int i = 0; i < index1; i++)
                Value.Items.Add(FirstQ1[i]);
            for (int i = 0; i < index2; i++)
                Value.Items.Add(FirstQ2[i]);
            Value.Items.Add("");

            Value.Items.Add("Second Quarter");
            Value.Items.Add("");

            for (int i = 0; i < index1; i++)
                Value.Items.Add(SecQ1[i]);
            for (int i = 0; i < index2; i++)
                Value.Items.Add(SecQ2[i]);
            Value.Items.Add("");

            Value.Items.Add("Third Quarter");
            Value.Items.Add("");

            for (int i = 0; i < index1; i++)
                Value.Items.Add(ThirdQ2[i]);
            for (int i = 0; i < index2; i++)
                Value.Items.Add(ThirdQ1[i]);
            
            Value.Items.Add("");

            Value.Items.Add("Fourth Quarter");
            Value.Items.Add("");

           
            for (int i = 0; i < index1; i++)
            Value.Items.Add(FourthQ2[i]);
            for (int i = 0; i < index2; i++)
                Value.Items.Add(FourthQ1[i]);
            
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
            int rx = int.Parse(txt_rx.Text);
            int ry = int.Parse(txt_ry.Text);
            Ellips(xc, yc, rx, ry);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            try
            {

                txt_xc.Text = "";
                txt_yc.Text = "";
                txt_rx.Text = "";
                txt_ry.Text = "";

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

        private void txt_rx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Tran_Pos_Click(object sender, EventArgs e)
        {
            try
            {

                int[] arr = new int[2];
                arr = new transformation().Circle_translatePositive(int.Parse(txt_xc.Text), int.Parse(txt_yc.Text), int.Parse(txt_Width.Text), int.Parse(txt_Height.Text));

                Ellips(arr[0], arr[1], int.Parse(txt_rx.Text), int.Parse(txt_ry.Text));
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
            try
            {

                int[] arr = new int[2];
                arr = new transformation().Circle_translateNegative (int.Parse(txt_xc.Text), int.Parse(txt_yc.Text), int.Parse(txt_Width.Text), int.Parse(txt_Height.Text));

                Ellips(arr[0], arr[1], int.Parse(txt_rx.Text), int.Parse(txt_ry.Text));
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
            try
            {

                int xc = int.Parse(txt_xc.Text);
                int yc = int.Parse(txt_yc.Text);
                float X = float.Parse(txt_X.Text) * int.Parse(txt_rx.Text);
                float Y = float.Parse(txt_X.Text) * int.Parse(txt_ry.Text);

                Ellips(xc, yc, (int)X,(int)Y);
                txt_rx.Text = Convert.ToString(X);
                txt_ry.Text = Convert.ToString(Y);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            PicBox.CreateGraphics().FillEllipse(Brushes.Red, int.Parse(txt_xc.Text) - int.Parse(txt_rx.Text), int.Parse(txt_yc.Text) - int.Parse(txt_ry.Text), 2 * int.Parse(txt_rx.Text), 2 * int.Parse(txt_ry.Text));
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void FRM_Ellips_Load(object sender, EventArgs e)
        {

        }
    }
}
