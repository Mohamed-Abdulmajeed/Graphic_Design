namespace Graphic_Project_Mohamed_Abdelmajeed
{
    partial class FRM_Bresneham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Scale = new System.Windows.Forms.Button();
            this.btn_Tran_Pos = new System.Windows.Forms.Button();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.txt_Angle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.ListBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.txt_y2 = new System.Windows.Forms.TextBox();
            this.txt_y1 = new System.Windows.Forms.TextBox();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Tran_Neg = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Scale
            // 
            this.btn_Scale.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Scale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Scale.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Scale.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Scale.Location = new System.Drawing.Point(379, 41);
            this.btn_Scale.Name = "btn_Scale";
            this.btn_Scale.Size = new System.Drawing.Size(161, 47);
            this.btn_Scale.TabIndex = 42;
            this.btn_Scale.Text = "Scale";
            this.btn_Scale.UseVisualStyleBackColor = false;
            this.btn_Scale.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Tran_Pos
            // 
            this.btn_Tran_Pos.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Tran_Pos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Tran_Pos.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tran_Pos.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Tran_Pos.Location = new System.Drawing.Point(85, 88);
            this.btn_Tran_Pos.Name = "btn_Tran_Pos";
            this.btn_Tran_Pos.Size = new System.Drawing.Size(331, 47);
            this.btn_Tran_Pos.TabIndex = 41;
            this.btn_Tran_Pos.Text = "Translate Positive";
            this.btn_Tran_Pos.UseVisualStyleBackColor = false;
            this.btn_Tran_Pos.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Height
            // 
            this.txt_Height.BackColor = System.Drawing.Color.Aqua;
            this.txt_Height.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Height.Location = new System.Drawing.Point(379, 27);
            this.txt_Height.Multiline = true;
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(100, 41);
            this.txt_Height.TabIndex = 40;
            this.txt_Height.Text = "15";
            // 
            // txt_Width
            // 
            this.txt_Width.BackColor = System.Drawing.Color.Aqua;
            this.txt_Width.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Width.Location = new System.Drawing.Point(120, 30);
            this.txt_Width.Multiline = true;
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(100, 41);
            this.txt_Width.TabIndex = 39;
            this.txt_Width.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(238, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 34);
            this.label6.TabIndex = 38;
            this.label6.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(14, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 34);
            this.label7.TabIndex = 37;
            this.label7.Text = "Width";
            // 
            // btn_rotate
            // 
            this.btn_rotate.BackColor = System.Drawing.Color.Magenta;
            this.btn_rotate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rotate.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rotate.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_rotate.Location = new System.Drawing.Point(348, 36);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(161, 47);
            this.btn_rotate.TabIndex = 36;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = false;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // txt_Angle
            // 
            this.txt_Angle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Angle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Angle.Location = new System.Drawing.Point(140, 36);
            this.txt_Angle.Multiline = true;
            this.txt_Angle.Name = "txt_Angle";
            this.txt_Angle.Size = new System.Drawing.Size(100, 41);
            this.txt_Angle.TabIndex = 35;
            this.txt_Angle.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(24, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 34);
            this.label5.TabIndex = 34;
            this.label5.Text = "Angle";
            // 
            // Value
            // 
            this.Value.FormattingEnabled = true;
            this.Value.ItemHeight = 19;
            this.Value.Items.AddRange(new object[] {
            " | i\t| X \t | Y\t| p",
            "-------------------------------------------------"});
            this.Value.Location = new System.Drawing.Point(565, 236);
            this.Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(305, 460);
            this.Value.TabIndex = 33;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Coral;
            this.btn_Back.Location = new System.Drawing.Point(62, 882);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(161, 48);
            this.btn_Back.TabIndex = 32;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_ok.Location = new System.Drawing.Point(407, 56);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(170, 60);
            this.btn_ok.TabIndex = 31;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_x2
            // 
            this.txt_x2.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_x2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x2.Location = new System.Drawing.Point(273, 35);
            this.txt_x2.Multiline = true;
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.Size = new System.Drawing.Size(100, 41);
            this.txt_x2.TabIndex = 30;
            this.txt_x2.Text = "340";
            // 
            // txt_y2
            // 
            this.txt_y2.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_y2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_y2.Location = new System.Drawing.Point(273, 105);
            this.txt_y2.Multiline = true;
            this.txt_y2.Name = "txt_y2";
            this.txt_y2.Size = new System.Drawing.Size(100, 41);
            this.txt_y2.TabIndex = 29;
            this.txt_y2.Text = "200";
            // 
            // txt_y1
            // 
            this.txt_y1.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_y1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_y1.Location = new System.Drawing.Point(72, 105);
            this.txt_y1.Multiline = true;
            this.txt_y1.Name = "txt_y1";
            this.txt_y1.Size = new System.Drawing.Size(100, 41);
            this.txt_y1.TabIndex = 28;
            this.txt_y1.Text = "330";
            // 
            // txt_x1
            // 
            this.txt_x1.BackColor = System.Drawing.Color.YellowGreen;
            this.txt_x1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x1.Location = new System.Drawing.Point(72, 35);
            this.txt_x1.Multiline = true;
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(100, 41);
            this.txt_x1.TabIndex = 27;
            this.txt_x1.Text = "250";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 34);
            this.label4.TabIndex = 26;
            this.label4.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "Y1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Y2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "X1";
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.Color.Yellow;
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.Location = new System.Drawing.Point(876, 12);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(1036, 918);
            this.PicBox.TabIndex = 22;
            this.PicBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txt_Height);
            this.panel1.Controls.Add(this.btn_Tran_Neg);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Width);
            this.panel1.Controls.Add(this.btn_Tran_Pos);
            this.panel1.Location = new System.Drawing.Point(32, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 210);
            this.panel1.TabIndex = 43;
            // 
            // btn_Tran_Neg
            // 
            this.btn_Tran_Neg.BackColor = System.Drawing.Color.Ivory;
            this.btn_Tran_Neg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Tran_Neg.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tran_Neg.Location = new System.Drawing.Point(85, 148);
            this.btn_Tran_Neg.Name = "btn_Tran_Neg";
            this.btn_Tran_Neg.Size = new System.Drawing.Size(331, 47);
            this.btn_Tran_Neg.TabIndex = 47;
            this.btn_Tran_Neg.Text = "Translate Negative";
            this.btn_Tran_Neg.UseVisualStyleBackColor = false;
            this.btn_Tran_Neg.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_Angle);
            this.panel2.Controls.Add(this.btn_rotate);
            this.panel2.Location = new System.Drawing.Point(32, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 100);
            this.panel2.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.txt_y2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_x1);
            this.panel3.Controls.Add(this.txt_y1);
            this.panel3.Controls.Add(this.btn_ok);
            this.panel3.Controls.Add(this.txt_x2);
            this.panel3.Location = new System.Drawing.Point(12, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 180);
            this.panel3.TabIndex = 45;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Maroon;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Clear.Location = new System.Drawing.Point(674, 737);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(161, 48);
            this.btn_Clear.TabIndex = 46;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Controls.Add(this.txt_Y);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txt_X);
            this.panel4.Controls.Add(this.btn_Scale);
            this.panel4.Location = new System.Drawing.Point(32, 707);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 100);
            this.panel4.TabIndex = 48;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txt_Y
            // 
            this.txt_Y.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Y.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Y.Location = new System.Drawing.Point(232, 27);
            this.txt_Y.Multiline = true;
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(100, 41);
            this.txt_Y.TabIndex = 46;
            this.txt_Y.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 34);
            this.label8.TabIndex = 43;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(187, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 34);
            this.label9.TabIndex = 44;
            this.label9.Text = "Y";
            // 
            // txt_X
            // 
            this.txt_X.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_X.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_X.Location = new System.Drawing.Point(45, 27);
            this.txt_X.Multiline = true;
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(100, 41);
            this.txt_X.TabIndex = 45;
            this.txt_X.Text = "2";
            // 
            // FRM_Bresneham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1924, 982);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.PicBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Bresneham";
            this.Text = "FRM_Bresneham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Bresneham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Scale;
        private System.Windows.Forms.Button btn_Tran_Pos;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.TextBox txt_Angle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Value;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.TextBox txt_y2;
        private System.Windows.Forms.TextBox txt_y1;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Tran_Neg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_X;
    }
}