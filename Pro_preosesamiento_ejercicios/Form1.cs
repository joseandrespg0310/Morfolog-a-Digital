using System.Drawing.Drawing2D;
namespace Pro_preosesamiento_ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics Lienzo;
        //variable
        Bitmap ImagenOriginal;
        int AnchoImagen, AltoImagen;
        int AnchoP = 200, AltoP = 200;
        int x, y;





        private void Form1_Load(object sender, EventArgs e)
        {
            this.p1.Size = new System.Drawing.Size(300, 400);
            this.p2.Size = new System.Drawing.Size(200, 200);
            Lienzo = p2.CreateGraphics();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(ofdAbrir.FileName, FileMode.Open, FileAccess.Read))
                    {
                        ImagenOriginal = (Bitmap)Bitmap.FromStream(fs);
                    }

                    AnchoImagen = ImagenOriginal.Width;
                    AltoImagen = ImagenOriginal.Height;
                    p1.Image = ImagenOriginal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir la imagen: " + ex.Message);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtImg.Text = "x:    " + AnchoImagen.ToString() + "y:  "
                            + AltoImagen.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textpicture.Text = "x:   "
        + p1.Width.ToString() + "y:   " + p1.Height.ToString();
        }



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textoXP.Text = e.X.ToString();
            textoYP.Text = e.Y.ToString();
            if (ImagenOriginal != null)
            {
                //regla de tre
                int imagenX = e.X * ImagenOriginal.Width / p1.Width;
                int imagenY = e.Y * ImagenOriginal.Height / p1.Height;

                x = imagenX;
                y = imagenY;
                ejex.Text = imagenX.ToString();
                ejeY.Text = imagenY.ToString();
            }
            textpicture.Text = "Ancho: " + p1.Width.ToString() + "  Alto: " + p1.Height.ToString();
            Graphics Lienzo2 = p2.CreateGraphics();
            posx = p2.Width / 2;
            posy = p2.Height / 2;
            Color miColor = new Color();

            if (ImagenOriginal != null)
            {
                miColor = ImagenOriginal.GetPixel(x, y);
                Brush miBrocha = new SolidBrush(miColor);
                Lienzo2.FillRectangle(miBrocha, posx, posy, a, a);

                miColor = ImagenOriginal.GetPixel(x, y + 1);
                miBrocha = new SolidBrush(miColor);
                Lienzo2.FillRectangle(miBrocha, posx, posy + a + 5, a, a);

                miColor = ImagenOriginal.GetPixel(x + 1, y);
                miBrocha = new SolidBrush(miColor);
                Lienzo2.FillRectangle(miBrocha, posx + a + 5, posy, a, a);

                miColor = ImagenOriginal.GetPixel(x - 1, y);
                miBrocha = new SolidBrush(miColor);
                Lienzo2.FillRectangle(miBrocha, posx - a - 5, posy, a, a);

                miColor = ImagenOriginal.GetPixel(x, y - 1);
                miBrocha = new SolidBrush(miColor);
                Lienzo2.FillRectangle(miBrocha, posx, posy - a - 5, a, a);

                miColor = ImagenOriginal.GetPixel(x + 1, y + 1);
                miBrocha = new SolidBrush(miColor);
                Lienzo2.FillRectangle(miBrocha, posx + a + 5, posy + a + 5, a, a);

                miColor = ImagenOriginal.GetPixel(x + 1, y - 1);
                miBrocha = new SolidBrush(miColor);
                Lienzo2.FillRectangle(miBrocha, posx + a + 5, posy - a - 5, a, a);

                miColor = ImagenOriginal.GetPixel(x - 1, y + 1);
                miBrocha = new SolidBrush(miColor);
                Lienzo2.FillRectangle(miBrocha, posx - a - 5, posy + a + 5, a, a);

                miColor = ImagenOriginal.GetPixel(x - 1, y - 1);
                miBrocha = new SolidBrush(miColor);
                Lienzo2.FillRectangle(miBrocha, posx - a - 5, posy - a - 5, a, a);
            }

        }

        int posx, posy, a = 20;

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //1 2 3 
            //4 5 6
            //7 8 9
            posx = AnchoP / 2;
            posy = AltoP / 2;
            Color miColor = new Color();
            //pixel 5  
            miColor = ImagenOriginal.GetPixel(x, y);
            Brush miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx, posy, a, a);


            //pixel 6

            miColor = ImagenOriginal.GetPixel(posx + 1, posy);
            miBrocha = new SolidBrush(miColor);
            Lienzo.FillRectangle(miBrocha, posx + a + 5, posy, a, a);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
