using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisProje
{
    public partial class Form1 : Form
    {

        Oyun o1;
        public Form1()
        {
            
            InitializeComponent();
           
            //Kare k = new Kare(160, 200);
           o1 = new Oyun();
           o1.yeniSekilOlustur();
            for (int i = 0; i < 4;i++ )
                this.panel1.Controls.Add(o1.AktifSekil.getKare(i).ResimKare);
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!o1.asagiIn())//aşağı inilemiyorsa yeni şekil oluşturulması deneniyor
            {
                if (!o1.yeniSekilOlustur())
                {
                    timer1.Stop();//yeni şekil oluşturulamıyorsa oyun bitiriliyor
                    MessageBox.Show("Game Over");
                    Application.Exit();
                }
                for (int i = 0; i < 4; i++)
                    this.panel1.Controls.Add(o1.AktifSekil.getKare(i).ResimKare);
            }

            //for (int i = 0; i < 4; i++)
            //    this.panel1.Controls.Add(o1.AktifSekil.getKare(i).resimKare);
            // this.pictureBox1.Location = new System.Drawing.Point(this.pictureBox1.Location.X , this.pictureBox1.Location.Y+20);
            //this.pictureBox1 = new System.Windows.Forms.PictureBox();
            //((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            //this.pictureBox1.BackgroundImage = global::TetrisProje.Properties.Resources.sari;
            //this.pictureBox1.Location = new System.Drawing.Point(i, 0);
            //this.pictureBox1.Name = "pictureBox1";
            //this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            //this.pictureBox1.TabIndex = 1;
            //this.pictureBox1.TabStop = false;
            //this.panel1.Controls.Add(this.pictureBox1);
            //((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            //i += 20;
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                o1.solaGit();
            }
            else if (e.KeyCode==Keys.Right)
            {
                o1.sagaGit();

            }
            else if (e.KeyCode==Keys.Down)
            {
                timer1_Tick(this, e);

            }
            else if (e.KeyCode==Keys.Up)
            {
                o1.don();
            }
        }
      
    }
}
