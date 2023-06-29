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
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Graphics_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_DDA dda= new FRM_DDA ();
            dda.Show();
        }

        private void btn_Bres_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Bresneham bres = new FRM_Bresneham();
            bres.Show();
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Circle circle = new FRM_Circle();
            circle.Show();
        }

        private void btn_Ellipse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Ellips Ellips = new FRM_Ellips();
            Ellips.Show();
        }

        private void btn_Bolgen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Bolygon Bolygon = new FRM_Bolygon();
            Bolygon.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FRM_Clipping Clipping = new FRM_Clipping();
            Clipping.Show();
        }

        private void btn_DDA_MouseMove(object sender, MouseEventArgs e)
        {
            btn_DDA.BackColor = Color.Red;
        }

        private void btn_DDA_MouseLeave(object sender, EventArgs e)
        {
            btn_DDA.BackColor = Color.Brown;
        }

        private void btn_Circle_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Circle.BackColor = Color.Red;

        }

        private void btn_Circle_MouseLeave(object sender, EventArgs e)
        {
            btn_Circle.BackColor = Color.Brown;

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Clippe.BackColor = Color.Red;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btn_Clippe.BackColor = Color.Brown;

        }

        private void btn_Bres_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Bres.BackColor = Color.Red;

        }

        private void btn_Bres_MouseLeave(object sender, EventArgs e)
        {
            btn_Bres.BackColor = Color.Brown;

        }

        private void btn_Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Ellipse.BackColor = Color.Red;

        }

        private void btn_Ellipse_MouseLeave(object sender, EventArgs e)
        {
            btn_Ellipse.BackColor = Color.Brown;

        }

        private void btn_Bolgen_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Bolgen.BackColor = Color.Red;

        }

        private void btn_Bolgen_MouseLeave(object sender, EventArgs e)
        {
            btn_Bolgen.BackColor = Color.Brown;

        }

        private void btn_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Exit.BackColor = Color.Lime;

        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.Green;

        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.LawnGreen;
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.LawnGreen;
        }
    }
}
