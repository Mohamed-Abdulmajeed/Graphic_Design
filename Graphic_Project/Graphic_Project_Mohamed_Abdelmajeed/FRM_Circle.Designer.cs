namespace Graphic_Project_Mohamed_Abdelmajeed
{
    partial class FRM_Circle
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
            this.Value = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_xc = new System.Windows.Forms.TextBox();
            this.txt_r = new System.Windows.Forms.TextBox();
            this.txt_yc = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Tran_Neg = new System.Windows.Forms.Button();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Tran_Pos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.btn_Scale = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.process1 = new System.Diagnostics.Process();
            this.Data_G_View = new System.Windows.Forms.DataGridView();
            this.counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_G_View)).BeginInit();
            this.SuspendLayout();
            // 
            // Value
            // 
            this.Value.FormattingEnabled = true;
            this.Value.ItemHeight = 19;
            this.Value.Location = new System.Drawing.Point(662, 236);
            this.Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(202, 460);
            this.Value.TabIndex = 14;
            this.Value.SelectedIndexChanged += new System.EventHandler(this.Value_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_xc);
            this.panel1.Controls.Add(this.txt_r);
            this.panel1.Controls.Add(this.txt_yc);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Location = new System.Drawing.Point(46, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 186);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(41, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Redius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(198, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yc";
            // 
            // txt_xc
            // 
            this.txt_xc.BackColor = System.Drawing.Color.Blue;
            this.txt_xc.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xc.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_xc.Location = new System.Drawing.Point(64, 37);
            this.txt_xc.Multiline = true;
            this.txt_xc.Name = "txt_xc";
            this.txt_xc.Size = new System.Drawing.Size(100, 41);
            this.txt_xc.TabIndex = 5;
            this.txt_xc.Text = "300";
            this.txt_xc.TextChanged += new System.EventHandler(this.txt_xc_TextChanged);
            // 
            // txt_r
            // 
            this.txt_r.BackColor = System.Drawing.Color.Blue;
            this.txt_r.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_r.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_r.Location = new System.Drawing.Point(166, 113);
            this.txt_r.Multiline = true;
            this.txt_r.Name = "txt_r";
            this.txt_r.Size = new System.Drawing.Size(100, 41);
            this.txt_r.TabIndex = 6;
            this.txt_r.Text = "30";
            this.txt_r.TextChanged += new System.EventHandler(this.txt_r_TextChanged);
            // 
            // txt_yc
            // 
            this.txt_yc.BackColor = System.Drawing.Color.Blue;
            this.txt_yc.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yc.ForeColor = System.Drawing.Color.AliceBlue;
            this.txt_yc.Location = new System.Drawing.Point(265, 37);
            this.txt_yc.Multiline = true;
            this.txt_yc.Name = "txt_yc";
            this.txt_yc.Size = new System.Drawing.Size(100, 41);
            this.txt_yc.TabIndex = 8;
            this.txt_yc.Text = "250";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.Crimson;
            this.btn_ok.Location = new System.Drawing.Point(401, 61);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(170, 60);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.btn_Tran_Neg);
            this.panel3.Controls.Add(this.txt_Height);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btn_Tran_Pos);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_Width);
            this.panel3.Location = new System.Drawing.Point(74, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 222);
            this.panel3.TabIndex = 24;
            // 
            // btn_Tran_Neg
            // 
            this.btn_Tran_Neg.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_Tran_Neg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Tran_Neg.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tran_Neg.ForeColor = System.Drawing.Color.OldLace;
            this.btn_Tran_Neg.Location = new System.Drawing.Point(78, 153);
            this.btn_Tran_Neg.Name = "btn_Tran_Neg";
            this.btn_Tran_Neg.Size = new System.Drawing.Size(331, 47);
            this.btn_Tran_Neg.TabIndex = 25;
            this.btn_Tran_Neg.Text = "Translate Negative";
            this.btn_Tran_Neg.UseVisualStyleBackColor = false;
            this.btn_Tran_Neg.Click += new System.EventHandler(this.btn_Tran_Neg_Click);
            // 
            // txt_Height
            // 
            this.txt_Height.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Height.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Height.ForeColor = System.Drawing.Color.Navy;
            this.txt_Height.Location = new System.Drawing.Point(357, 23);
            this.txt_Height.Multiline = true;
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(100, 41);
            this.txt_Height.TabIndex = 19;
            this.txt_Height.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(16, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "Width";
            // 
            // btn_Tran_Pos
            // 
            this.btn_Tran_Pos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Tran_Pos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Tran_Pos.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tran_Pos.ForeColor = System.Drawing.Color.Navy;
            this.btn_Tran_Pos.Location = new System.Drawing.Point(78, 88);
            this.btn_Tran_Pos.Name = "btn_Tran_Pos";
            this.btn_Tran_Pos.Size = new System.Drawing.Size(331, 47);
            this.btn_Tran_Pos.TabIndex = 20;
            this.btn_Tran_Pos.Text = "Translate Positive";
            this.btn_Tran_Pos.UseVisualStyleBackColor = false;
            this.btn_Tran_Pos.Click += new System.EventHandler(this.btn_Tran_Pos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(242, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 34);
            this.label6.TabIndex = 17;
            this.label6.Text = "Height";
            // 
            // txt_Width
            // 
            this.txt_Width.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Width.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Width.ForeColor = System.Drawing.Color.Navy;
            this.txt_Width.Location = new System.Drawing.Point(122, 23);
            this.txt_Width.Multiline = true;
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(100, 41);
            this.txt_Width.TabIndex = 18;
            this.txt_Width.Text = "20";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_X);
            this.panel4.Controls.Add(this.btn_Scale);
            this.panel4.Location = new System.Drawing.Point(58, 556);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(583, 100);
            this.panel4.TabIndex = 26;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 34);
            this.label8.TabIndex = 22;
            this.label8.Text = "How much increase? ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_X
            // 
            this.txt_X.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txt_X.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_X.Location = new System.Drawing.Point(291, 29);
            this.txt_X.Multiline = true;
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(100, 41);
            this.txt_X.TabIndex = 24;
            this.txt_X.Text = "2";
            // 
            // btn_Scale
            // 
            this.btn_Scale.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Scale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Scale.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Scale.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Scale.Location = new System.Drawing.Point(410, 23);
            this.btn_Scale.Name = "btn_Scale";
            this.btn_Scale.Size = new System.Drawing.Size(161, 47);
            this.btn_Scale.TabIndex = 21;
            this.btn_Scale.Text = "Scale";
            this.btn_Scale.UseVisualStyleBackColor = false;
            this.btn_Scale.Click += new System.EventHandler(this.btn_Scale_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Maroon;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Clear.Location = new System.Drawing.Point(703, 721);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(161, 48);
            this.btn_Clear.TabIndex = 27;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(703, 888);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(161, 48);
            this.btn_Back.TabIndex = 28;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.Color.Honeydew;
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.Location = new System.Drawing.Point(888, 12);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(1024, 924);
            this.PicBox.TabIndex = 13;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(703, 807);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 48);
            this.button1.TabIndex = 29;
            this.button1.Text = "Fill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Data_G_View
            // 
            this.Data_G_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_G_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.counter,
            this.PI,
            this.ne,
            this.Y,
            this.P});
            this.Data_G_View.Location = new System.Drawing.Point(58, 677);
            this.Data_G_View.Margin = new System.Windows.Forms.Padding(4);
            this.Data_G_View.Name = "Data_G_View";
            this.Data_G_View.Size = new System.Drawing.Size(583, 287);
            this.Data_G_View.TabIndex = 30;
            // 
            // counter
            // 
            this.counter.HeaderText = "i";
            this.counter.Name = "counter";
            this.counter.Width = 50;
            // 
            // PI
            // 
            this.PI.HeaderText = "Pi";
            this.PI.Name = "PI";
            this.PI.Width = 50;
            // 
            // ne
            // 
            this.ne.HeaderText = "Pi+1";
            this.ne.Name = "ne";
            this.ne.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "Xi+1";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // P
            // 
            this.P.HeaderText = "Yi+1";
            this.P.Name = "P";
            this.P.Width = 50;
            // 
            // FRM_Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.ControlBox = false;
            this.Controls.Add(this.Data_G_View);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.PicBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Circle";
            this.Text = "Circle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Circle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_G_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Value;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_xc;
        private System.Windows.Forms.TextBox txt_r;
        private System.Windows.Forms.TextBox txt_yc;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Tran_Neg;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Tran_Pos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.Button btn_Scale;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.DataGridView Data_G_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
    }
}