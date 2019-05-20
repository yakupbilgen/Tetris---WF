using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisProje
{
    class Kare
    {
        private Nokta[] noktalar = { new Nokta(), new Nokta(), new Nokta(), new Nokta() };

        internal Nokta[] Noktalar
        {
            get { return noktalar; }
            set { noktalar = value; }
        }
        public void konumlandır(int x,int y)
        {
            noktalar[0].X = x;
            noktalar[0].Y = y;

            noktalar[1].X = x + 20;
            noktalar[1].Y = y;

            noktalar[2].X = x + 20;
            noktalar[2].Y = y + 20;

            noktalar[3].X = x;
            noktalar[3].Y = y + 20;
            setXY();
            
        }
        private PictureBox resimKare;

        public PictureBox ResimKare
        {
            get { return resimKare; }
        }
        
        public void resimDegistir(string resimAdi)
        {
            if (resimAdi.Equals("mavi"))
            {
                this.resimKare.BackgroundImage = global::TetrisProje.Properties.Resources.mavi;
            }
            else if (resimAdi.Equals("yesil"))
            {
                this.resimKare.BackgroundImage = global::TetrisProje.Properties.Resources.yesil;
            }
            else if (resimAdi.Equals("sari"))
            {
                this.resimKare.BackgroundImage = global::TetrisProje.Properties.Resources.sari;
            }
            else if (resimAdi.Equals("pembe"))
            {
                this.resimKare.BackgroundImage = global::TetrisProje.Properties.Resources.pembe;
            }
            else if (resimAdi.Equals("kirmizi"))
            {
                this.resimKare.BackgroundImage = global::TetrisProje.Properties.Resources.kirmizi;
            }
            
        }
        public void setXY()
        {
            resimKare.Location = new System.Drawing.Point(noktalar[0].X, noktalar[0].Y);
        }
        public Kare(int x,int y)
        {
            
            noktalar[0].X = x;
            noktalar[0].Y = y;

            noktalar[1].X = x+20;
            noktalar[1].Y = y;

            noktalar[2].X = x + 20;
            noktalar[2].Y = y+20;

            noktalar[3].X = x;
            noktalar[3].Y = y+20;

            this.resimKare = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resimKare)).BeginInit();
            this.resimKare.BackgroundImage = global::TetrisProje.Properties.Resources.mavi;
            this.resimKare.Location = new System.Drawing.Point(noktalar[0].X, noktalar[0].Y);
            this.resimKare.Name = "pictureBox1";
            this.resimKare.Size = new System.Drawing.Size(20, 20);
            this.resimKare.TabIndex = 1;
            this.resimKare.TabStop = false;
            

        }
    }
}
