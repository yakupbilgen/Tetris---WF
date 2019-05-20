using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProje
{
    class TSekli:Sekil
    {
        public TSekli()
        {
            kareler[0].konumlandır(200, 0);//T şekli çıkacak şekilde ayarlandı
            kareler[1].konumlandır(220, 0);
            kareler[2].konumlandır(240, 0);
            kareler[3].konumlandır(220, 20);
            for (int i = 0; i < 4; i++)
            {
                kareler[i].resimDegistir("yesil");//karelerin resmi değiştiriliyor (farklı şekiller farklı renklerde gelsin diye)
            }
        }
        private void donus1(bool[,] oyunAlani)
        {
            if (kareler[1].Noktalar[0].Y / 20 - 1 < 0)
                return;
            if (oyunAlani[kareler[1].Noktalar[0].X/20, kareler[1].Noktalar[0].Y/20-1] == true)
                return;
            //for(int i=0;i<4;i++)
            //{
            //    kareler[2].noktalar[i].X -= 20;
            //    kareler[2].noktalar[i].Y -= 20;

            //}
            //kareler[2].setXY();
            kareler[2].konumlandır(kareler[2].Noktalar[0].X - 20, kareler[2].Noktalar[0].Y - 20);
            durum = 1;
        }
        private void donus2(bool[,] oyunAlani)
        {
            if (kareler[3].Noktalar[1].X / 20 + 1 > 20)
                return;
            if (oyunAlani[kareler[0].Noktalar[3].X / 20, kareler[0].Noktalar[3].Y / 20] == true)
                return;
            if (oyunAlani[kareler[3].Noktalar[1].X / 20, kareler[3].Noktalar[1].Y / 20] == true)
                return;
           

            kareler[0].konumlandır(kareler[0].Noktalar[0].X, kareler[0].Noktalar[0].Y + 20);
            kareler[2].konumlandır(kareler[2].Noktalar[0].X+20, kareler[2].Noktalar[0].Y + 40);
            //for (int i = 0; i < 4; i++)
            //{
            //    kareler[0].noktalar[i].Y += 20;
            //    kareler[2].noktalar[i].X += 20;
            //    kareler[2].noktalar[i].Y += 40;
            //}
            //kareler[0].setXY();
            //kareler[2].setXY();
            durum = 2;
        }
        private void donus3(bool[,] oyunAlani)
        {
            if (kareler[0].Noktalar[0].Y - 40 < 0)
                return;
            if (oyunAlani[kareler[1].Noktalar[0].X / 20, kareler[1].Noktalar[0].Y / 20-1] == true )
                return;
            if ( oyunAlani[kareler[1].Noktalar[1].X / 20, kareler[1].Noktalar[1].Y / 20] == true)
                return;

            durum = 3;
            kareler[0].konumlandır(kareler[0].Noktalar[0].X + 20, kareler[0].Noktalar[0].Y - 40);
            kareler[2].konumlandır(kareler[2].Noktalar[0].X,kareler[2].Noktalar[0].Y - 20); 
            //for (int i = 0; i < 4; i++)
            //{
            //    kareler[0].noktalar[i].X += 20;
            //    kareler[0].noktalar[i].Y -= 40;
            //    kareler[2].noktalar[i].Y -= 20;
            
            //}
            //kareler[0].setXY();
            //kareler[2].setXY();
        }
        private void donus4(bool[,] oyunAlani)
        {
            if (kareler[1].Noktalar[0].X / 20 - 1 < 0)
                return;
            if (oyunAlani[kareler[1].Noktalar[0].X / 20-1, kareler[1].Noktalar[0].Y / 20] == true )
                return;
            

            durum = 0;
            kareler[0].konumlandır(kareler[0].Noktalar[0].X - 20, kareler[0].Noktalar[0].Y + 20);
            //for (int i = 0; i < 4; i++)
            //{
            //    kareler[0].noktalar[i].X -= 20;
            //    kareler[0].noktalar[i].Y += 20;
            //}
            //kareler[0].setXY();
        }
        //dönüş ihtimalleri hesaplandı. 4 durum için ayrı ayrı fonksiyonlar yazıldı
        public override void don(bool[,] oyunAlani)
        { 
            if (durum == 0)
            {
                donus1(oyunAlani);

            }
            else if (durum == 1)
            {
                donus2(oyunAlani);
            }
            else if (durum == 2)
            {
                donus3(oyunAlani);
            }
            else
            {
                donus4(oyunAlani);  
            }
        }


    }
}
