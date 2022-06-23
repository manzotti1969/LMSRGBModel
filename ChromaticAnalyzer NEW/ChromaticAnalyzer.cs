using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
//using KTEL.Lib.ImageLib;
using System.Drawing.Imaging;


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
		private System.Windows.Forms.PictureBox SMain;
		private System.Windows.Forms.PictureBox sSecondary;
		private System.Windows.Forms.PictureBox sPalette;
		private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private PictureBox Image2DBox;
        private ProgressBar progressBar;
        private MenuItem ToolImagePolar;
        private MenuItem ToolImageCube;
        private MenuItem menuItem9;
        private MenuItem ToolRadiusSaturation;
        private MenuItem ToolRadiusValue;
        private MenuItem ToolRadiusBoth;
        private MenuItem menuItem10;
        private MenuItem menuItem11;
        private MenuItem menuItem13;
        private MenuItem menuItem14;
        private MenuItem menuItem15;
        private MenuItem menuItem12;
        private MenuItem menuItem3;
        private MenuItem HonHSVImage;
        private MenuItem menuItem16;
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            PolarImage = true;
            HSVImageSize = 512;
            cv = ChromaticValue.saturation;
            kof = KindOfView.fourWindowsLayout;
			HSVIstogram=new double [360];
            //            Image2D = new Bitmap(Image2DBox.Width, Image2DBox.Height, PixelFormat.Format24bppRgb);
            Image2D = new Bitmap(HSVImageSize, HSVImageSize, PixelFormat.Format24bppRgb);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.SMain = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.ToolImagePolar = new System.Windows.Forms.MenuItem();
            this.ToolImageCube = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.ToolRadiusSaturation = new System.Windows.Forms.MenuItem();
            this.ToolRadiusValue = new System.Windows.Forms.MenuItem();
            this.ToolRadiusBoth = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.HonHSVImage = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.sSecondary = new System.Windows.Forms.PictureBox();
            this.sPalette = new System.Windows.Forms.PictureBox();
            this.Image2DBox = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.SMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSecondary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2DBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SMain
            // 
            this.SMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SMain.Location = new System.Drawing.Point(32, 44);
            this.SMain.Name = "SMain";
            this.SMain.Size = new System.Drawing.Size(163, 362);
            this.SMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SMain.TabIndex = 0;
            this.SMain.TabStop = false;
            this.SMain.Paint += new System.Windows.Forms.PaintEventHandler(this.SMain_Paint);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem10,
            this.menuItem7,
            this.menuItem11});
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
            this.menuItem16.Text = "Random Image";
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
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
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem13});
            this.menuItem10.Text = "View";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 0;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem14,
            this.menuItem15});
            this.menuItem13.Text = "Layout";
            this.menuItem13.Popup += new System.EventHandler(this.menuItem13_Popup);
            // 
            // menuItem14
            // 
            this.menuItem14.Checked = true;
            this.menuItem14.Index = 0;
            this.menuItem14.Text = "Image and HSV";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 1;
            this.menuItem15.Text = "Only HSV";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem9,
            this.menuItem3,
            this.HonHSVImage});
            this.menuItem7.Text = "Tool";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ToolImagePolar,
            this.ToolImageCube});
            this.menuItem8.Text = "Image";
            this.menuItem8.Popup += new System.EventHandler(this.menuItem8_Popup);
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // ToolImagePolar
            // 
            this.ToolImagePolar.Checked = true;
            this.ToolImagePolar.Index = 0;
            this.ToolImagePolar.Text = "Hue Polar";
            this.ToolImagePolar.Click += new System.EventHandler(this.ToolImagePolar_Click);
            // 
            // ToolImageCube
            // 
            this.ToolImageCube.Index = 1;
            this.ToolImageCube.Text = "Hue Cube";
            this.ToolImageCube.Click += new System.EventHandler(this.ToolImageCube_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ToolRadiusSaturation,
            this.ToolRadiusValue,
            this.ToolRadiusBoth});
            this.menuItem9.Text = "Radius";
            this.menuItem9.Popup += new System.EventHandler(this.menuItem9_Popup);
            // 
            // ToolRadiusSaturation
            // 
            this.ToolRadiusSaturation.Checked = true;
            this.ToolRadiusSaturation.Index = 0;
            this.ToolRadiusSaturation.Text = "Saturation";
            this.ToolRadiusSaturation.Click += new System.EventHandler(this.ToolRadiusSaturation_Click);
            // 
            // ToolRadiusValue
            // 
            this.ToolRadiusValue.Index = 1;
            this.ToolRadiusValue.Text = "Value";
            this.ToolRadiusValue.Click += new System.EventHandler(this.ToolRadiusValue_Click);
            // 
            // ToolRadiusBoth
            // 
            this.ToolRadiusBoth.Index = 2;
            this.ToolRadiusBoth.Text = "Both";
            this.ToolRadiusBoth.Click += new System.EventHandler(this.ToolRadiusBoth_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // HonHSVImage
            // 
            this.HonHSVImage.Index = 3;
            this.HonHSVImage.Text = "Histogram on HSVImage";
            this.HonHSVImage.Click += new System.EventHandler(this.HonHSVImage_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 3;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12});
            this.menuItem11.Text = "Help";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            this.menuItem12.Text = "About";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // sSecondary
            // 
            this.sSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sSecondary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sSecondary.Location = new System.Drawing.Point(552, 9);
            this.sSecondary.Name = "sSecondary";
            this.sSecondary.Size = new System.Drawing.Size(461, 194);
            this.sSecondary.TabIndex = 1;
            this.sSecondary.TabStop = false;
            this.sSecondary.Paint += new System.Windows.Forms.PaintEventHandler(this.sSecondary_Paint);
            // 
            // sPalette
            // 
            this.sPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sPalette.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sPalette.Location = new System.Drawing.Point(552, 212);
            this.sPalette.Name = "sPalette";
            this.sPalette.Size = new System.Drawing.Size(461, 65);
            this.sPalette.TabIndex = 2;
            this.sPalette.TabStop = false;
            this.sPalette.Paint += new System.Windows.Forms.PaintEventHandler(this.sPalette_Paint);
            // 
            // Image2DBox
            // 
            this.Image2DBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Image2DBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Image2DBox.Location = new System.Drawing.Point(552, 217);
            this.Image2DBox.Name = "Image2DBox";
            this.Image2DBox.Size = new System.Drawing.Size(461, 414);
            this.Image2DBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image2DBox.TabIndex = 3;
            this.Image2DBox.TabStop = false;
            this.Image2DBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Image2DBox_Paint);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(10, 638);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(998, 27);
            this.progressBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1023, 680);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Image2DBox);
            this.Controls.Add(this.sPalette);
            this.Controls.Add(this.sSecondary);
            this.Controls.Add(this.SMain);
            this.Menu = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Chromatic Analyzer 1.0 December 2006";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSecondary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image2DBox)).EndInit();
            this.ResumeLayout(false);

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

		Bitmap CurrentBMP;

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files (*.jpg)|*.jpg|Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
			ofd.FilterIndex = 0 ;
			ofd.RestoreDirectory = true ;

			if(ofd.ShowDialog() == DialogResult.OK)
			{

				CurrentBMP = (Bitmap) Image.FromFile(ofd.FileName);

                RecalcData();
                
				Invalidate(true);
			}
		}

        int HSVImageSize;
        private void RecalcData()
        {
            Image2D = new Bitmap(HSVImageSize, HSVImageSize, PixelFormat.Format24bppRgb);

			ComputeHSVIstogram();
            if (PolarImage)
                ComputeHSVChromaticImage(cv);
            else
                ComputeHVImage();
        }

		double [] HSVIstogram;
        Bitmap Image2D;

        enum ChromaticValue
        { saturation, value, saturationAndValue}

        private void ComputeHSVChromaticImage(ChromaticValue cv)
        {
            double w2 = Image2D.Width / 2 - 0.5;
            double h2 = Image2D.Height / 2 - 0.5;

            double r, g, b;
            double h, s, v;
            int inew, jnew;
            double angle;
            Color nc;

            double radius;

            Random random = new Random();

            if (CurrentBMP != null)
            {
                progressBar.ForeColor = Color.SeaGreen;
                for (int i = 0; i < CurrentBMP.Width; i++)
                {
                    progressBar.Value = (int)(100 * i / CurrentBMP.Width);
                    for (int j = 0; j < CurrentBMP.Height; j++)
                    {
                        Color color;
                        color = CurrentBMP.GetPixel(i, j);
                        r = color.R;
                        g = color.G;
                        b = color.B;

                        /* r = random.Next(255);
                         g = random.Next(255);
                         b = random.Next(255);
                         color = Color.FromArgb((int)r, (int)g, (int)b);*/

                        if (!(r == g && g == b))
                        {
                            RgbToHsv(r, g, b, out h, out s, out v);

                            radius = 0.0;
                            if (s > 0.0 || cv != ChromaticValue.value)
                            {
                                switch (cv)
                                {
                                    case ChromaticValue.saturation:
                                        radius = (double)s;
                                        break;
                                    case ChromaticValue.value:
                                        radius = (double)v;
                                        break;
                                    case ChromaticValue.saturationAndValue:
                                        radius = (double)s * v;
                                        break;
                                }
                                angle = (h + 90) * 2 * Math.PI / 360.0;
                                jnew = (int)(h2 - Math.Sin(angle) * radius * (h2 - 1));
                                inew = (int)(w2 - Math.Cos(angle) * radius * (w2 - 1));

                                //                            inew = (int)(w2 + (w2 / 255.0) * (g - b) * Math.Sqrt(3) / 2);
                                //                            jnew = (int)(h2 - (h2 / 255.0) * (r - (g + b) / 2));

                                Image2D.SetPixel(inew, jnew, color);
                            }
                        }
                    }
                }

                progressBar.ForeColor = Color.Red;
                /// this draws the circle of colours
                /// 
                if (HonHSVImage.Checked)
                {
                    for (h = 0; h < 360.0; h += 0.1)
                    {
                        progressBar.Value = (int)(100 * h / 360.0);

                        s = 1.0;
                        v = 1.0;
                        HsvToRgb(h, s, v, out r, out g, out b);
                        angle = (h + 90) * 2 * Math.PI / 360.0;
                        nc = Color.FromArgb((int)r, (int)g, (int)b);
                        for (int sp = 0; sp < HSVIstogram[(int)h] * 5; sp++)
                        {
                            jnew = (int)(h2 - Math.Sin(angle) * (h2 - sp));
                            inew = (int)(w2 - Math.Cos(angle) * (w2 - sp));
                            Image2D.SetPixel(inew, jnew, nc);
                        }
                    }
                }
                for (h = 0; h < 360.0; h += 0.1)
                {
                    progressBar.Value = (int)(100 * h / 360.0);

                    s = 1.0;
                    v = 1.0;
                    HsvToRgb(h, s, v, out r, out g, out b);
                    angle = (h + 90) * 2 * Math.PI / 360.0;
                    nc = Color.FromArgb((int)r, (int)g, (int)b);
                    for (int sp = 0; sp < 5; sp++)
                    {
                        jnew = (int)(h2 - Math.Sin(angle) * (h2 - sp));
                        inew = (int)(w2 - Math.Cos(angle) * (w2 - sp));
                        Image2D.SetPixel(inew, jnew, nc);
                    }
                }
                progressBar.Value = 0;
            }
        }

        private void ComputeHVImage()
        {
            int width = Image2D.Width;
            int height = Image2D.Height;

            double r, g, b;
            double h, s, v;
            int inew, jnew;

            Random random = new Random();

            if (CurrentBMP != null)
            {
                progressBar.ForeColor = Color.SeaGreen;
                for (int i = 0; i < CurrentBMP.Width; i++)
                {
                    progressBar.Value = (int)(100 * i / CurrentBMP.Width);
                    for (int j = 0; j < CurrentBMP.Height; j++)
                    {
                        Color color;
                        color = CurrentBMP.GetPixel(i, j);
                        r = color.R;
                        g = color.G;
                        b = color.B;

                        if (!(r == g && g == b))
                        {
                            RgbToHsv(r, g, b, out h, out s, out v);

                            inew = 0;
                            jnew = 0;
                            if (s > 0.0 || cv != ChromaticValue.value)
                            {
                                switch (cv)
                                {
                                    case ChromaticValue.saturation:
                                        inew = (int)(h * width  / 360.0);
                                        jnew = (int)(s * height / 1.0);
                                        break;
                                    case ChromaticValue.value:
                                        inew = (int)(h * width / 360.0);
                                        jnew = (int)(v * height / 1.0);
                                        break;
                                    case ChromaticValue.saturationAndValue:
                                        inew = (int)(h * width / 360.0);
                                        jnew = (int)((s*v) * height / 1.0);
                                        break;
                                }
                                Image2D.SetPixel(inew, jnew, color);
                            }
                        }
                    }
                }

                Color nc;
                for (h = 0; h < 360.0; h += 0.1)
                {
                    progressBar.Value = (int)(100 * h / 360.0);

                    s = 1.0;
                    v = 1.0;
                    HsvToRgb(h, s, v, out r, out g, out b);
                    nc = Color.FromArgb((int)r, (int)g, (int)b);
                    for (int sp = 0; sp < 5; sp++)
                    {
                        inew = (int)(h * width / 360.0);
                        jnew = (int)(height - 1 - sp);
                        Image2D.SetPixel(inew, jnew, nc);
                    }
                }
                progressBar.Value = 0;
            }
        }

		private void ComputeHSVIstogram()
		{

			double r,g,b;
			double h,s,v;

			for (int i=0; i<HSVIstogram.GetLength(0); i++)
				HSVIstogram[i]=0;
            if (CurrentBMP != null)
            {
                progressBar.ForeColor = Color.RoyalBlue;
                for (int i = 0; i < CurrentBMP.Width; i++)
                {
                    progressBar.Value = (int)(100 * i / CurrentBMP.Width);

                    for (int j = 0; j < CurrentBMP.Height; j++)
                    {
                        Color color = CurrentBMP.GetPixel(i, j);
                        r = color.R;
                        g = color.G;
                        b = color.B;

                        if (!(r == g && g == b))
                        {
                            RgbToHsv(r, g, b, out h, out s, out v);

                            if (s > 0.2)
                                HSVIstogram[(int)(h)]++;
                        }
                    }
                }

                double[] htmp;
                htmp = new double[HSVIstogram.Length];

                for (int i = 0; i < HSVIstogram.Length; i++)
                {
                    double totx, toty;
                    totx = 0;
                    toty = 0;
                    for (int j = -5; j <= 5; j++)
                    {
                        totx++;
                        toty += HSVIstogram[(i + j + HSVIstogram.Length) % HSVIstogram.Length];
                    }
                    htmp[i] = toty / totx;
                }

                for (int i = 0; i < HSVIstogram.Length; i++)
                {
                    HSVIstogram[i] = htmp[i];
                }

                for (int i = 0; i < HSVIstogram.Length; i++)
                {
                    HSVIstogram[i] = (Math.Pow((double)HSVIstogram[i], 0.3));
                }
            }
		}

		private void sPalette_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen;
			pen=new Pen(System.Drawing.Color.Red);
			for (int i=0; i<sPalette.Width; i++)
			{
				int hint=i*360/sPalette.Width;

				double h=hint;
				double s=1.0;
				double v=1.0;
				double r,g,b;

				HsvToRgb(h,s,v,out r, out g, out b);
				pen.Color=System.Drawing.Color.FromArgb((int)(r),(int)(g),(int)(b));

				e.Graphics.DrawLine(pen,i,0,i,sPalette.Height);
			}
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			this.ComputeHSVIstogram();
			Invalidate(true);
		}

		private void sSecondary_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen;
			pen=new Pen(System.Drawing.Color.Red);

			double hmax=1;
			for (int i=0; i<360;i++)
			{
				if (hmax<HSVIstogram[i])
					hmax=HSVIstogram[i];
			}
			for (int i=0; i<sSecondary.Width; i++)
			{
				int hint=i*360/sSecondary.Width;

				double h=hint;
				double s=1.0;
				double v=1.0;
				double r,g,b;

				HsvToRgb(h,s,v,out r, out g, out b);
				pen.Color=System.Drawing.Color.FromArgb((int)(r),(int)(g),(int)(b));


				e.Graphics.DrawLine(pen,i,(int)(sSecondary.Height-HSVIstogram[hint]*sSecondary.Height/hmax),i,sSecondary.Height);
			}
		}

        private void SMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            if (CurrentBMP != null)
            {
                double rx, ry;
                ry = CurrentBMP.Height / SMain.Height;
                rx = CurrentBMP.Width / SMain.Width;
                e.Graphics.DrawImage(CurrentBMP,0,0,SMain.Width, SMain.Height);             
            }
            string text = "Chromatic Analyzer 1.0 - ";
            if (PolarImage==false)
                text = "Square Image ";
            else
            {
                text = "Polar Image";
                switch (cv)
                {
                    case ChromaticValue.saturation:
                        text+=", saturation based";
                        break;
                    case ChromaticValue.saturationAndValue:
                        text+=", saturation and intensity based";
                        break;
                    case ChromaticValue.value:
                        text += ", intensity based";
                        break;
                }
            }
            Text = text;
        }

        private void Image2DBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            if (Image2D != null)
            {
                e.Graphics.DrawImage(Image2D, 0, 0, Image2DBox.Width, Image2DBox.Height);
            }
        }

        ChromaticValue cv;
        bool PolarImage;
        private void ToolImagePolar_Click(object sender, EventArgs e)
        {
            PolarImage = true;
            RecalcData();
            Invalidate(true);
        }

        private void ToolImageCube_Click(object sender, EventArgs e)
        {
            PolarImage = false;
            RecalcData();
            Invalidate(true);
        }

        private void ToolRadiusSaturation_Click(object sender, EventArgs e)
        {
            cv = ChromaticValue.saturation;
            RecalcData();
            Invalidate(true);
        }

        private void ToolRadiusValue_Click(object sender, EventArgs e)
        {
            cv = ChromaticValue.value;
            RecalcData();
            Invalidate(true);
        }

        private void ToolRadiusBoth_Click(object sender, EventArgs e)
        {
            cv = ChromaticValue.saturationAndValue;
            RecalcData();
            Invalidate(true);
        }

        private void menuItem9_Popup(object sender, EventArgs e)
        {
            ToolRadiusValue.Checked = false;
            ToolRadiusSaturation.Checked = false;
            ToolRadiusBoth.Checked = false;
            switch (cv)
            {
                case ChromaticValue.saturation:
                    ToolRadiusSaturation.Checked = true; 
                    break;
                case ChromaticValue.saturationAndValue:
                    ToolRadiusBoth.Checked = true;
                    break;
                case ChromaticValue.value:
                    ToolRadiusValue.Checked = true;
                    break;
            }
        }

        private void menuItem8_Popup(object sender, EventArgs e)
        {
            ToolImageCube.Checked = false;
            ToolImagePolar.Checked = false;
            switch (PolarImage)
            {
                case false:
                    ToolImageCube.Checked = true;
                    break;
                case true:
                    ToolImagePolar.Checked  = true;
                    break;
            }
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
                Image2D.Save(ofd.FileName);
                Invalidate(true);
            }
        }

        enum KindOfView { fourWindowsLayout, justHue};

        KindOfView kof;
        private void Form1_Resize(object sender, EventArgs e)
        {
            
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
                    SMain.Location=p;
                    SMain.Height = this.ClientSize.Height - bh - 3 * bs;
                    SMain.Width = this.ClientSize.Width - rw - 3 * bs;

                    p.X = bs;
                    p.Y = this.ClientSize.Height - bh - bs;
                    this.progressBar.Location = p;
                    this.progressBar.Width = this.ClientSize.Width - 2 * bs;
                    this.progressBar.Height = bh;

                    // column on the right
                    p.X = SMain.Location.X + SMain.Width + bs;
                    p.Y = bs;    
                    sSecondary.Location = p;
                    sSecondary.Height = 200;
                    sSecondary.Width = this.ClientSize.Width - p.X - bs;

                    p.Y = sSecondary.Height + 2 * bs;
                    sPalette.Location = p;
                    sPalette.Height = sh;
                    sPalette.Width = sSecondary.Width;

                    p.Y = sSecondary.Height + sh + 3 * bs;
                    Image2DBox.Location = p;            
                    dx = sSecondary.Width;
                    dy = this.ClientSize.Height - sSecondary.Height - sPalette.Height - bh - 5 * bs;
                    if (dx > dy)
                    {
                        this.Image2DBox.Width = dy;
                        this.Image2DBox.Height = dy;
                    }
                    else 
                    {
                        this.Image2DBox.Width = dx;
                        this.Image2DBox.Height = dx;
                    }
            break;
            
            case KindOfView.justHue:
                p = new Point();
                dx = this.ClientSize.Width - 2 * bs;
                dy = this.ClientSize.Height - bh - 3 * bs;
                if (dx > dy) d = dy;
                else d = dx;

                p.X = bs + (this.ClientSize.Width - 2 * bs - d) / 2;
                p.Y = bs + (this.ClientSize.Height- 3 * bs - bh - d) / 2;

                Image2DBox.Location = p;
                Image2DBox.Height = d;
                Image2DBox.Width = d;

            break;
            }
            Invalidate(true);
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            kof = KindOfView.justHue;
            //this.Invalidate();
            SMain.Visible = false;
            sSecondary.Visible = false;
            sPalette.Visible = false;
            Size s = this.Size;
            s.Width -= 1;
            this.Size = s;
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.ShowDialog();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            kof = KindOfView.fourWindowsLayout;
            SMain.Visible = true;
            sSecondary.Visible = true;
            sPalette.Visible = true;
            Size s = this.Size;
            s.Width -= 1;
            this.Size = s;
        }

        private void menuItem13_Popup(object sender, EventArgs e)
        {
            menuItem14.Checked = false;
            menuItem15.Checked = false;
            if (kof == KindOfView.fourWindowsLayout)
                menuItem14.Checked = true;
            else
                menuItem15.Checked = true;
        }

        private void HonHSVImage_Click(object sender, EventArgs e)
        {
            HonHSVImage.Checked = !HonHSVImage.Checked;
            RecalcData();
            Invalidate(true);
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            CurrentBMP=new Bitmap(HSVImageSize, HSVImageSize, PixelFormat.Format24bppRgb);
            Random r = new Random();
            for (int i=0; i<CurrentBMP.Width; i++)
                for (int j = 0; j < CurrentBMP.Height; j++)
                {
                    Color nc = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                    CurrentBMP.SetPixel(i, j, nc);
                }
            RecalcData();
            Invalidate(true);
        }
    }
}
