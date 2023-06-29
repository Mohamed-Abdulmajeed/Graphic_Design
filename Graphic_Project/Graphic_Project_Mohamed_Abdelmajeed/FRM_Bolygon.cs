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
    public partial class FRM_Bolygon : Form
    {
        private List<Point> PolygonPoints;
        private List<Point> PolygonPointsFill;

        public FRM_Bolygon()
        {
            InitializeComponent();
            PolygonPoints = new List<Point>();
            PolygonPointsFill = new List<Point>();

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        

        private void FRM_Bolygon_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FRM_Bolygon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try{
            PolygonPoints.Add(new Point(e.X, e.Y));
            PolygonPointsFill.Add(new Point(e.X, e.Y));

            this.CreateGraphics().DrawPolygon(Pens.DarkRed, PolygonPoints.ToArray());
            PolygonPoints.Clear();
            TF = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }
        bool TF = false;
        private void FRM_Bolygon_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (TF)
                    PolygonPointsFill.Clear();
                TF = false;
                PolygonPoints.Add(new Point(e.X, e.Y));
                PolygonPointsFill.Add(new Point(e.X, e.Y));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            try{
            this.CreateGraphics().Clear(Color.White);
            PolygonPoints.Clear();
            PolygonPointsFill.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.CreateGraphics().FillPolygon(Brushes.Red, PolygonPointsFill.ToArray());
                PolygonPointsFill.Clear();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "OOps!!", MessageBoxButtons.OK);

            }
        }

        private void FRM_Bolygon_Load(object sender, EventArgs e)
        {

        }


    }
}
