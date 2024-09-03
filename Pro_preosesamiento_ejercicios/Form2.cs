using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Pro_preosesamiento_ejercicios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Graphics Lienzo;
        //variable
        Bitmap ImagenOriginal;
        int AnchoImagen, AltoImagen;
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                ImagenOriginal = (Bitmap)(Bitmap.FromFile(ofdAbrir.FileName));
                AnchoImagen = ImagenOriginal.Width;
                AltoImagen = ImagenOriginal.Height;
                pictureBox1.Image = ImagenOriginal;
            }
        }
    }
}
