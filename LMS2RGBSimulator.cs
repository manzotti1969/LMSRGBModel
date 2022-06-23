using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace ImageWiz
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.PictureBox sPalette;
        private PictureBox InputSpectrumBoard;
        private MenuItem menuItem16;
        private PictureBox RGBBoard;
        private PictureBox LMSBoard;
        private NumericUpDown RVal;
        private NumericUpDown GVal;
        private NumericUpDown BVal;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown LVal;
        private NumericUpDown MVal;
        private NumericUpDown SVal;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button BLoadSpectrumImage;
        private PictureBox ColorBoard;
        private IContainer components;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // initialize filters adn stimulus
            N = 360;
            L=new double[N];
            M=new double[N];
            S=new double[N];
            R=new double[N];
            G=new double[N];
            B=new double[N];

            InputSpectrum=new double[N];

            RValue = 0.5;
            GValue = 0.2;
            BValue = 0.6;

            RVal.Value = (int)(255 * RValue);
            GVal.Value = (int)(255 * GValue);
            BVal.Value = (int)(255 * BValue);

            RecalcData();
        }

        int N;

        double RValue, GValue, BValue;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.sPalette = new System.Windows.Forms.PictureBox();
            this.InputSpectrumBoard = new System.Windows.Forms.PictureBox();
            this.RGBBoard = new System.Windows.Forms.PictureBox();
            this.LMSBoard = new System.Windows.Forms.PictureBox();
            this.RVal = new System.Windows.Forms.NumericUpDown();
            this.GVal = new System.Windows.Forms.NumericUpDown();
            this.BVal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LVal = new System.Windows.Forms.NumericUpDown();
            this.MVal = new System.Windows.Forms.NumericUpDown();
            this.SVal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BLoadSpectrumImage = new System.Windows.Forms.Button();
            this.ColorBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputSpectrumBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LMSBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem4,
            this.menuItem16,
            this.menuItem6,
            this.menuItem5});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Load";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "Save HSV current image";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 2;
            this.menuItem16.Text = "";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "Exit";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // sPalette
            // 
            this.sPalette.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sPalette.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sPalette.Location = new System.Drawing.Point(0, 304);
            this.sPalette.Name = "sPalette";
            this.sPalette.Size = new System.Drawing.Size(1056, 110);
            this.sPalette.TabIndex = 2;
            this.sPalette.TabStop = false;
            this.sPalette.Paint += new System.Windows.Forms.PaintEventHandler(this.sPalette_Paint);
            // 
            // InputSpectrumBoard
            // 
            this.InputSpectrumBoard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InputSpectrumBoard.BackColor = System.Drawing.Color.White;
            this.InputSpectrumBoard.Location = new System.Drawing.Point(0, 420);
            this.InputSpectrumBoard.Name = "InputSpectrumBoard";
            this.InputSpectrumBoard.Size = new System.Drawing.Size(1056, 240);
            this.InputSpectrumBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InputSpectrumBoard.TabIndex = 3;
            this.InputSpectrumBoard.TabStop = false;
            this.InputSpectrumBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.InputSpectrumBoard_Paint);
            // 
            // RGBBoard
            // 
            this.RGBBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RGBBoard.Location = new System.Drawing.Point(0, 0);
            this.RGBBoard.Name = "RGBBoard";
            this.RGBBoard.Size = new System.Drawing.Size(1056, 298);
            this.RGBBoard.TabIndex = 7;
            this.RGBBoard.TabStop = false;
            this.RGBBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.RGBBoard_Paint);
            // 
            // LMSBoard
            // 
            this.LMSBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LMSBoard.Location = new System.Drawing.Point(0, 666);
            this.LMSBoard.Name = "LMSBoard";
            this.LMSBoard.Size = new System.Drawing.Size(1056, 282);
            this.LMSBoard.TabIndex = 8;
            this.LMSBoard.TabStop = false;
            this.LMSBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.LMSBoard_Paint);
            // 
            // RVal
            // 
            this.RVal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RVal.Location = new System.Drawing.Point(1191, 60);
            this.RVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RVal.Name = "RVal";
            this.RVal.Size = new System.Drawing.Size(120, 31);
            this.RVal.TabIndex = 0;
            this.RVal.ValueChanged += new System.EventHandler(this.RVal_ValueChanged);
            // 
            // GVal
            // 
            this.GVal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.GVal.Location = new System.Drawing.Point(1191, 111);
            this.GVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GVal.Name = "GVal";
            this.GVal.Size = new System.Drawing.Size(120, 31);
            this.GVal.TabIndex = 1;
            this.GVal.ValueChanged += new System.EventHandler(this.GVal_ValueChanged);
            // 
            // BVal
            // 
            this.BVal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BVal.Location = new System.Drawing.Point(1191, 166);
            this.BVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BVal.Name = "BVal";
            this.BVal.Size = new System.Drawing.Size(120, 31);
            this.BVal.TabIndex = 2;
            this.BVal.ValueChanged += new System.EventHandler(this.BVal_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1084, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1084, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1085, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // LVal
            // 
            this.LVal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LVal.Location = new System.Drawing.Point(1191, 707);
            this.LVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LVal.Name = "LVal";
            this.LVal.Size = new System.Drawing.Size(120, 31);
            this.LVal.TabIndex = 6;
            // 
            // MVal
            // 
            this.MVal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MVal.Location = new System.Drawing.Point(1191, 758);
            this.MVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MVal.Name = "MVal";
            this.MVal.Size = new System.Drawing.Size(120, 31);
            this.MVal.TabIndex = 7;
            // 
            // SVal
            // 
            this.SVal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SVal.Location = new System.Drawing.Point(1191, 813);
            this.SVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SVal.Name = "SVal";
            this.SVal.Size = new System.Drawing.Size(120, 31);
            this.SVal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1084, 701);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "L";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1084, 758);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1085, 813);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "S";
            // 
            // BLoadSpectrumImage
            // 
            this.BLoadSpectrumImage.Location = new System.Drawing.Point(1072, 304);
            this.BLoadSpectrumImage.Name = "BLoadSpectrumImage";
            this.BLoadSpectrumImage.Size = new System.Drawing.Size(610, 109);
            this.BLoadSpectrumImage.TabIndex = 12;
            this.BLoadSpectrumImage.Text = "Load Spectrum Image";
            this.BLoadSpectrumImage.UseVisualStyleBackColor = true;
            // 
            // ColorBoard
            // 
            this.ColorBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorBoard.Location = new System.Drawing.Point(1352, 63);
            this.ColorBoard.Name = "ColorBoard";
            this.ColorBoard.Size = new System.Drawing.Size(136, 134);
            this.ColorBoard.TabIndex = 13;
            this.ColorBoard.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(2066, 1000);
            this.Controls.Add(this.ColorBoard);
            this.Controls.Add(this.BLoadSpectrumImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LMSBoard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RGBBoard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SVal);
            this.Controls.Add(this.InputSpectrumBoard);
            this.Controls.Add(this.MVal);
            this.Controls.Add(this.sPalette);
            this.Controls.Add(this.LVal);
            this.Controls.Add(this.RVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BVal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Menu = this.mainMenu;
            this.Name = "Form1";
            this.Text = "LM 2 RGB June 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputSpectrumBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LMSBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void menuItem5_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        double[] L, M, S;
        double[] R, G, B;
        double[] InputSpectrum;
        
        Bitmap CurrentBMP;

        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files (*.jpg)|*.jpg|Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                CurrentBMP = (Bitmap)Image.FromFile(ofd.FileName);

                RecalcData();

                Invalidate(true);
            }
        }

        private void RecalcData()
        {
            for (int i = 0; i < N; i++)
            {
                L[i] = 1.0 * Math.Exp(-((Math.Pow(i - 30, 2) / (2 * 150))));
                M[i] = 1.0 * Math.Exp(-((Math.Pow(i - 180, 2) / (2 * 350))));
                M[i] += 0.3 * Math.Exp(-((Math.Pow(i - 230, 2) / (2 * 350))));
                S[i] = 1.0 * Math.Exp(-((Math.Pow(i - 290, 2) / (2 * 650))));


                R[i] = RValue * Math.Exp(-((Math.Pow(i - 30, 2) / (2 * 150))));
                G[i] = GValue * Math.Exp(-((Math.Pow(i - 180, 2) / (2 * 350))));
                B[i] = BValue * Math.Exp(-((Math.Pow(i - 290, 2) / (2 * 650))));

                InputSpectrum[i] = (R[i] + G[i] + B[i]);
            }


            // convolution

            double tempSumL = 0.0;
            double tempSumM = 0.0;
            double tempSumS = 0.0;

            double totL = 0.0;
            double totM = 0.0;
            double totS = 0.0;
            double totInput = 0.0;
            for (int i = 0; i < N; i++)
            {
                totL += L[i];
                totM += M[i];
                totS += S[i];
                totInput += InputSpectrum[i];

                tempSumL += InputSpectrum[i] * L[i];
                tempSumM += InputSpectrum[i] * M[i];
                tempSumS += InputSpectrum[i] * S[i];
            }

            double LFinal = tempSumL / totL;
            double MFinal = tempSumM / totM;
            double SFinal = tempSumS / totS;

            LVal.Value=  (int)(LFinal * 255);
            MVal.Value = (int)(MFinal * 255);
            SVal.Value = (int)(SFinal * 255);

            ColorBoard.BackColor = Color.FromArgb((byte)RVal.Value, (byte)GVal.Value, (byte)BVal.Value);

            Console.WriteLine(LFinal + "     " + MFinal + "     " + SFinal);
        }


        private void sPalette_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen pen;
            pen = new Pen(System.Drawing.Color.Red);

            double sMax = 0.0;
            for (int i = 0; i < N; i++)
            {
                if (sMax < InputSpectrum[i]) sMax = InputSpectrum[i];
            }
                for (int i = 0; i < sPalette.Width; i++)
            {
                int hint = i * N / sPalette.Width;

                double h = hint;
                double s = 1.0;
                double v = 1.0;
                v = InputSpectrum[hint] * 1.0 / sMax;
                double r, g, b;

                HsvToRgb(h, s, v, out r, out g, out b);
                pen.Color = System.Drawing.Color.FromArgb((int)(r), (int)(g), (int)(b));

                e.Graphics.DrawLine(pen, i, 0, i, sPalette.Height);
            }
        }

        private void RGBBoard_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Pen redpen, greenpen, bluepen;
            redpen = new Pen(System.Drawing.Color.Red);
            greenpen = new Pen(System.Drawing.Color.Green);
            bluepen = new Pen(System.Drawing.Color.Blue);

            int x1, y1, x2, y2;
            int w = RGBBoard.Width;
            int h = RGBBoard.Height;

            for (int i = 0; i < (int)(N -1); i++)
            {
                x1 = (int)(i * w / N);
                y1 = h - (int)(R[i] * h);
                x2 = (int)((i + 1) * w / N);
                y2 = h - (int)(R[i + 1] * h);

                e.Graphics.DrawLine(redpen,x1, y1, x2, y2);

                x1 = (int)(i * w / N);
                y1 = h - (int)(G[i] * h);
                x2 = (int)((i + 1) * w / N);
                y2 = h - (int)(G[i + 1] * h);

                e.Graphics.DrawLine(greenpen, x1, y1, x2, y2);

                x1 = (int)(i * w / N);
                y1 = h - (int)(B[i] * h);
                x2 = (int)((i + 1) * w / N);
                y2 = h - (int)(B[i + 1] * h);

                e.Graphics.DrawLine(bluepen, x1, y1, x2, y2);
            }
        }

        private void LMSBoard_Paint(object sender, PaintEventArgs e)
        {
            Pen redpen, greenpen, bluepen;
            redpen = new Pen(System.Drawing.Color.DarkRed);
            bluepen = new Pen(System.Drawing.Color.DarkBlue);
            greenpen = new Pen(System.Drawing.Color.DarkGreen);

            int x1, y1, x2, y2;
            int w = LMSBoard.Width;
            int h = LMSBoard.Height;

            for (int i = 0; i < (int)(N - 1); i++)
            {
                x1 = (int)(i * w / N);
                y1 = h - (int)(L[i] * h);
                x2 = (int)((i + 1) * w / N);
                y2 = h - (int)(L[i + 1] * h);

                e.Graphics.DrawLine(redpen, x1, y1, x2, y2);

                x1 = (int)(i * w / N);
                y1 = h - (int)(M[i] * h);
                x2 = (int)((i + 1) * w / N);
                y2 = h - (int)(M[i + 1] * h);

                e.Graphics.DrawLine(greenpen, x1, y1, x2, y2);

                x1 = (int)(i * w / N);
                y1 = h - (int)(S[i] * h);
                x2 = (int)((i + 1) * w / N);
                y2 = h - (int)(S[i + 1] * h);

                e.Graphics.DrawLine(bluepen, x1, y1, x2, y2);
            }
        }

        private void InputSpectrumBoard_Paint(object sender, PaintEventArgs e)
        {
            Pen pen;
            pen = new Pen(System.Drawing.Color.Black);
            pen.Width = 2;

            int x1, y1;
            int w = InputSpectrumBoard.Width;
            int h = InputSpectrumBoard.Height;
            Point[] points = new Point[N];

            for (int i = 0; i < (int)(N); i++)
            {
                x1 = (int)(i * w / N);
                y1 = h - (int)(InputSpectrum[i] * h);

                points[i] = new Point(x1, y1);
            }
            e.Graphics.DrawLines(pen, points);
        }


        void RgbToHsv(double r, double g, double b, out double h, out double s, out double v)
        {
            double dx, dy;
            r /= 255.0;
            g /= 255.0;
            b /= 255.0;
            dx = (g - b) * Math.Sqrt(3) / 2;
            dy = r - (g + b) / 2;
            h = (Math.Atan2(dy, dx) * 360.0) / (2 * Math.PI);
            h -= 90;
            h *= -1;
            if (h < 0) h += 360;
            if (h >= 360) h -= 360;

            v = Math.Sqrt((r * r + g * g + b * b) / 3);
            s = Math.Sqrt(Math.Pow(r - (g + b) / 2, 2) + Math.Pow((g - b) * Math.Sqrt(3) / 2, 2));
        }

        void HsvToRgb(double h, double S, double V, out double r, out double g, out double b)
        {
            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        R = G = B = V; // Just pretend its black/white
                        break;
                }
            }
            r = Clamp((R * 255.0));
            g = Clamp((G * 255.0));
            b = Clamp((B * 255.0));
        }

        /// <summary>
        /// Clamp a value to 0-255
        /// </summary>
        double Clamp(double i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();

            ofd.Filter = "Image Files (*.jpg)|*.jpg|Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Invalidate(true);
            }
        }


        private void RVal_ValueChanged(object sender, EventArgs e)
        {
            RValue = ((double)RVal.Value) / 255.0;
            RecalcData();
            Invalidate(true);
        }

        private void GVal_ValueChanged(object sender, EventArgs e)
        {
            GValue = ((double)GVal.Value) / 255.0;
            RecalcData();
            Invalidate(true);
        }

        private void BVal_ValueChanged(object sender, EventArgs e)
        {
            BValue = ((double)BVal.Value) / 255.0;
            RecalcData();
            Invalidate(true);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeMainForm();
        }

        private void ResizeMainForm()
        {
            /*
            int bs; // border size
            int bh; // progress bar height
            int sh; // spectrum bar height
            int rw; // widht of left columns of subwindows
            bs = 5;
            bh = 10;
            sh = 30;
            rw = 400;

            Point p;

            int dx, dy, d;

            switch (kof)
            {
                case KindOfView.fourWindowsLayout:
                    p = new Point(bs, bs);
                    LMSBoard.Location = p;
                    LMSBoard.Height = this.ClientSize.Height - bh - 3 * bs;
                    LMSBoard.Width = this.ClientSize.Width - rw - 3 * bs;

                    p.X = bs;
                    p.Y = this.ClientSize.Height - bh - bs;
                    this.progressBar.Location = p;
                    this.progressBar.Width = this.ClientSize.Width - 2 * bs;
                    this.progressBar.Height = bh;

                    // column on the right
                    p.X = LMSBoard.Location.X + LMSBoard.Width + bs;
                    p.Y = bs;
                    RgbBoard.Location = p;
                    RgbBoard.Height = 200;
                    RgbBoard.Width = this.ClientSize.Width - p.X - bs;

                    p.Y = RgbBoard.Height + 2 * bs;
                    sPalette.Location = p;
                    sPalette.Height = sh;
                    sPalette.Width = RgbBoard.Width;

                    p.Y = RgbBoard.Height + sh + 3 * bs;
                    InputSpectrumBoard.Location = p;
                    dx = RgbBoard.Width;
                    dy = this.ClientSize.Height - RgbBoard.Height - sPalette.Height - bh - 5 * bs;
                    if (dx > dy)
                    {
                        this.InputSpectrumBoard.Width = dy;
                        this.InputSpectrumBoard.Height = dy;
                    }
                    else
                    {
                        this.InputSpectrumBoard.Width = dx;
                        this.InputSpectrumBoard.Height = dx;
                    }
                    break;

                case KindOfView.justHue:
                    p = new Point();
                    dx = this.ClientSize.Width - 2 * bs;
                    dy = this.ClientSize.Height - bh - 3 * bs;
                    if (dx > dy) d = dy;
                    else d = dx;

                    p.X = bs + (this.ClientSize.Width - 2 * bs - d) / 2;
                    p.Y = bs + (this.ClientSize.Height - 3 * bs - bh - d) / 2;

                    InputSpectrumBoard.Location = p;
                    InputSpectrumBoard.Height = d;
                    InputSpectrumBoard.Width = d;

                    break;
            }
            Invalidate(true);*/
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ResizeMainForm();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.ShowDialog();
        }
    }
}
