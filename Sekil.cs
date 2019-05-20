using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProje
{
    abstract class Sekil
    {
        protected Kare []kareler = { new Kare(200,0) ,new Kare(200,20),new Kare(200,40),new Kare(200,60)};
        protected int durum = 0;
        //bool solaDon(bool[,] oyunAlani);
        //bool sagaDon(bool[,] oyunAlani);
        public bool asagiIn(bool [,] oyunAlani)
        {
            for (int i = 0; i < 4; i++)//sınır kontrolü
            {
                if (kareler[i].Noktalar[2].Y / 20 + 1 > 28)
                    return false;
            }
            if (kontrolAsagiIn(oyunAlani) == false)//karelerin altı dolu mu
            {
                return false;
            }
            for (int i = 0; i < 4; i++)//karelerin yeni konumunu ayarlama
            {
                kareler[i].konumlandır(kareler[i].Noktalar[0].X , kareler[i].Noktalar[0].Y+20);
            }
            return true;
        }
        protected bool kontrolAsagiIn(bool[,] oyunAlani)
        {
            for (int i = 0; i < 4; i++)
            {
                if (oyunAlani[kareler[i].Noktalar[3].X / 20, kareler[i].Noktalar[3].Y / 20] == true)
                    return false;
            }
            return true;
        }
        protected bool kontrolSagaGit(bool[,] oyunAlani) 
        {
            for (int i = 0; i < 4; i++)
            {
                if (oyunAlani[kareler[i].Noktalar[1].X / 20, kareler[i].Noktalar[1].Y / 20] == true)
                {
                    return false;
                }
            }
            return true;
        }
        protected bool kontrolSolaGit(bool[,] oyunAlani)
        {
            for (int i = 0; i < 4; i++)
            {
                if (oyunAlani[kareler[i].Noktalar[0].X / 20-1, kareler[i].Noktalar[0].Y / 20] == true)
                {
                    return false;
                }
            }
            return true;
        }
        public void sagaGit(bool[,] oyunAlani)
        {
            for (int i = 0; i < 4; i++)
            {
                if (kareler[i].Noktalar[2].X + 20 > 400)
                    return;
            }
            if (kontrolSagaGit(oyunAlani) == false)
            {
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                kareler[i].konumlandır(kareler[i].Noktalar[0].X + 20, kareler[i].Noktalar[0].Y);
                //for (int j = 0; j < 4; j++)
                //{
                //    kareler[i].noktalar[j].X += 20;
                //    kareler[i].setXY();
                //}
            }
        }
        public void solaGit(bool[,] oyunAlani) 
        {
            for (int i = 0; i < 4; i++)
            {
                if (kareler[i].Noktalar[0].X - 20 < 0)
                    return;
            }
            if (kontrolSolaGit(oyunAlani) == false)
                return;
            for (int i = 0; i < 4; i++)
            {
                kareler[i].konumlandır(kareler[i].Noktalar[0].X - 20, kareler[i].Noktalar[0].Y);
                //for (int j = 0; j < 4; j++)
                //{
                //    kareler[i].noktalar[j].X -= 20;
                //    kareler[i].setXY();
                //}
            }
        }
        public Kare getKare(int indis)
        {
            return kareler[indis];
        }
        public abstract void don(bool[,] oyunAlani);
          
    }
}
