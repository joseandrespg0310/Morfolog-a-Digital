namespace Pro_preosesamiento_ejercicios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            p1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            ejeY = new TextBox();
            ejex = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtImg = new TextBox();
            btn1 = new Button();
            groupBox2 = new GroupBox();
            textoYP = new TextBox();
            textoXP = new TextBox();
            textpicture = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            ofdAbrir = new OpenFileDialog();
            p2 = new PictureBox();
            label5 = new Label();
            btnLineas = new Button();
            buttonPixel = new Button();
            ((System.ComponentModel.ISupportInitialize)p1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)p2).BeginInit();
            SuspendLayout();
            // 
            // p1
            // 
            p1.BackColor = SystemColors.ActiveCaptionText;
            p1.Location = new Point(16, 77);
            p1.Name = "p1";
            p1.Size = new Size(600, 578);
            p1.SizeMode = PictureBoxSizeMode.StretchImage;
            p1.TabIndex = 0;
            p1.TabStop = false;
            p1.Click += pictureBox1_Click;
            p1.MouseMove += pictureBox1_MouseMove;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1094, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(116, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonPixel);
            groupBox1.Controls.Add(btnLineas);
            groupBox1.Controls.Add(ejeY);
            groupBox1.Controls.Add(ejex);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtImg);
            groupBox1.Controls.Add(btn1);
            groupBox1.Location = new Point(639, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 150);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagen";
            // 
            // ejeY
            // 
            ejeY.Location = new Point(208, 106);
            ejeY.Name = "ejeY";
            ejeY.Size = new Size(56, 23);
            ejeY.TabIndex = 5;
            // 
            // ejex
            // 
            ejex.Location = new Point(63, 103);
            ejex.Name = "ejex";
            ejex.Size = new Size(51, 23);
            ejex.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 106);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "Y:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 103);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "X:";
            // 
            // txtImg
            // 
            txtImg.Location = new Point(208, 36);
            txtImg.Name = "txtImg";
            txtImg.Size = new Size(167, 23);
            txtImg.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(6, 22);
            btn1.Name = "btn1";
            btn1.Size = new Size(131, 48);
            btn1.TabIndex = 0;
            btn1.Text = "Tamaño de la Imagen";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textoYP);
            groupBox2.Controls.Add(textoXP);
            groupBox2.Controls.Add(textpicture);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(639, 236);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 125);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Picture";
            // 
            // textoYP
            // 
            textoYP.Location = new Point(207, 94);
            textoYP.Name = "textoYP";
            textoYP.Size = new Size(56, 23);
            textoYP.TabIndex = 5;
            // 
            // textoXP
            // 
            textoXP.Location = new Point(62, 97);
            textoXP.Name = "textoXP";
            textoXP.Size = new Size(51, 23);
            textoXP.TabIndex = 4;
            // 
            // textpicture
            // 
            textpicture.Location = new Point(208, 37);
            textpicture.Name = "textpicture";
            textpicture.Size = new Size(167, 23);
            textpicture.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 97);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 2;
            label4.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 100);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 1;
            label3.Text = "X:";
            // 
            // button2
            // 
            button2.Location = new Point(15, 37);
            button2.Name = "button2";
            button2.Size = new Size(121, 40);
            button2.TabIndex = 0;
            button2.Text = "Tamañopct";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ofdAbrir
            // 
            ofdAbrir.FileName = "ofdAbrir";
            // 
            // p2
            // 
            p2.BackColor = SystemColors.ActiveCaptionText;
            p2.Location = new Point(639, 367);
            p2.Name = "p2";
            p2.Size = new Size(381, 288);
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            p2.TabIndex = 4;
            p2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F);
            label5.Location = new Point(86, 20);
            label5.Name = "label5";
            label5.Size = new Size(394, 54);
            label5.TabIndex = 5;
            label5.Text = "Examen José Paredes";
            // 
            // btnLineas
            // 
            btnLineas.Location = new Point(306, 99);
            btnLineas.Name = "btnLineas";
            btnLineas.Size = new Size(75, 23);
            btnLineas.TabIndex = 6;
            btnLineas.Text = "Lineas";
            btnLineas.UseVisualStyleBackColor = true;
            // 
            // buttonPixel
            // 
            buttonPixel.Location = new Point(306, 70);
            buttonPixel.Name = "buttonPixel";
            buttonPixel.Size = new Size(75, 23);
            buttonPixel.TabIndex = 7;
            buttonPixel.Text = "Pixel";
            buttonPixel.UseVisualStyleBackColor = true;
            buttonPixel.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 724);
            Controls.Add(label5);
            Controls.Add(p2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(p1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)p1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)p2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox p1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtImg;
        private Button btn1;
        private TextBox ejeY;
        private TextBox ejex;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Button button2;
        private TextBox textoYP;
        private TextBox textoXP;
        private TextBox textpicture;
        private OpenFileDialog ofdAbrir;
        private PictureBox p2;
        private Label label5;
        private Button btnLineas;
        private Button buttonPixel;
    }
}
