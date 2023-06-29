using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic_Project_Mohamed_Abdelmajeed
{
    class transformation
    {
        public double[] Scale(double Num_x1, double Num_y1, double Num_x2, double Num_y2, double sx, double sy)
        {
            double[,] Scall ={
                              {sx , 0 , 0},
                              {0  , sy, 0},
                              {0  , 0 , 1}
                             };

            double[,] Matrix1_Zero0 = trasform_to_Zero( (Num_x1 + Num_x2) / 2, (Num_y1 + Num_y2) / 2);

            double[,] Come_Back = trasform_to_Zero((Num_x1 + Num_x2) / -2, (Num_y1 + Num_y2) / -2);

            double[,] Test = matrix_3_3__Mult__matrix_3_3(Come_Back, Scall);

            double[,] Result = matrix_3_3__Mult__matrix_3_3(Test, Matrix1_Zero0);

            double[] Point_1_Before = { Num_x1, Num_y1, 1 };
            double[] Point_2_Before = { Num_x2, Num_y2, 1 };

            double[] Point_1_After_Scall = Matrix_3_3__Mult__Matrix_3_1(Result, Point_1_Before);
            double[] Point_2_After_Scall = Matrix_3_3__Mult__Matrix_3_1(Result, Point_2_Before);

            double[] arr = new double[4];
            arr[0] = Point_1_After_Scall[0];
            arr[1] = Point_1_After_Scall[1];
            arr[2] = Point_2_After_Scall[0];
            arr[3] = Point_2_After_Scall[1];
            return arr;
        }

        public double[] Circle_translatePositive(double Num_xc, double Num_yc, double transX, double transY)
        {

            Num_xc += transX;
            Num_yc += transY;
            double[] arr = new double[2];
            arr[0] = Num_xc;
            arr[1] = Num_yc;
            
            return arr;
        }
        public double[] Circle_translateNegative(double Num_xc, double Num_yc, double transX, double transY)
        {

            Num_xc -= transX;
            Num_yc -= transY;
            double[] arr = new double[2];
            arr[0] = Num_xc;
            arr[1] = Num_yc;

            return arr;
        }
        public double[] translatePositive(double Num_x1, double Num_y1, double Num_x2, double Num_y2, double transX, double transY)
        {

            Num_x1 += transX;
            Num_x2 += transX;
            Num_y1 += transY;
            Num_y2 += transY;
            double[] arr = new double[4];
            arr[0] = Num_x1;
            arr[1] = Num_y1;
            arr[2] = Num_x2;
            arr[3] = Num_y2;
            return arr;
        }

        public double[] translateNegative(double Num_x1, double Num_y1, double Num_x2, double Num_y2, double transX, double transY)
        {

            Num_x1 -= transX;
            Num_x2 -= transX;
            Num_y1 -= transY;
            Num_y2 -= transY;
            double[] arr = new double[4];
            arr[0] = Num_x1;
            arr[1] = Num_y1;
            arr[2] = Num_x2;
            arr[3] = Num_y2;
            return arr;
        }

        public double[] Rotatation(double Num_x1, double Num_y1, double Num_x2, double Num_y2, double Angle)
        {


            Angle = Angle * Math.PI / 180;
            
            double[,] rotatation ={
                                   {Math.Cos(Angle)       ,  Math.Sin(Angle) *(-1) ,  0},
                                   {Math.Sin(Angle)       ,  Math.Cos(Angle)       ,  0},
                                   {0                     ,  0                     ,  1}
                                  };

            double[,] matrix1_Zero0 = trasform_to_Zero((Num_x1 + Num_x2) / 2, (Num_y1 + Num_y2) / 2);

            double[,] Come_Back = trasform_to_Zero((Num_x1 + Num_x2) / -2, (Num_y1 + Num_y2) / -2);

            double[,] Test = matrix_3_3__Mult__matrix_3_3(Come_Back, rotatation);

            double[,] Result = matrix_3_3__Mult__matrix_3_3(Test, matrix1_Zero0);

            double[] Point_1_Before = { Num_x1, Num_y1, 1 };
            double[] Point_2_Before = { Num_x2, Num_y2, 1 };

            double[] Point_1_After_Rotate = Matrix_3_3__Mult__Matrix_3_1(Result, Point_1_Before);
            double[] Point_2_After_Rotate = Matrix_3_3__Mult__Matrix_3_1(Result, Point_2_Before);
            double[] arr = new double[4];
            arr[0]= Point_1_After_Rotate[0];
            arr[1]= Point_1_After_Rotate[1];
            arr[2]= Point_2_After_Rotate[0];
            arr[3]= Point_2_After_Rotate[1];
            return arr;

        }


        double[,] trasform_to_Zero(double NUMx, double NUMy)
        {
            double[,] Trans_to_Zero ={
                                 {1 , 0 , -1*NUMx},
                                 {0 , 1 , -1*NUMy},
                                 {0 , 0 ,  1     }
                                 };
            return Trans_to_Zero;

        }


        double[] Matrix_3_3__Mult__Matrix_3_1(double[,] arr1, double[] arr2)
        {
            double[] Result = new double[3];

            for (int i = 0; i < 9; i++)
            {
                Result[i / 3] += arr1[i / 3, i % 3] * arr2[i % 3];
            }

            return Result;
        }


        double[,] matrix_3_3__Mult__matrix_3_3(double[,] arr1, double[,] arr2)
        {
            double[,] Result = new double[3, 3];

            for (int i = 0; i < 9; i++)
            {

                for (int col = 0; col < 3; col++)
                {
                    Result[i / 3, i % 3] += arr1[i / 3, col] * arr2[col, i % 3];
                }

            }

            return Result;
        }

    }
}
