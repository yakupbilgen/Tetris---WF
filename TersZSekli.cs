using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProje
{
    class TersZSekli:Sekil
    {
         public TersZSekli()
        {
            kareler[0].konumlandır(240, 0);//Ters Z şekli çıkacak şekilde ayarlandı
            kareler[1].konumlandır(220, 0);
            kareler[2].konumlandır(220, 20);
            kareler[3].konumlandır(200, 20);
            for (int i = 0; i < 4; i++)
            {
                kareler[i].resimDegistir("sari");//karelerin resmi değiştiriliyor (farklı şekiller farklı renklerde gelsin diye)
            }
        }
        private void donus1(bool[,] oyunAlani)
        {
            if (kareler[2].Noktalar[2].Y / 20 + 1 >= 28)
                return;
            if (oyunAlani[kareler[2].Noktalar[1].X/20, kareler[2].Noktalar[1].Y/20] == true)
                return;
            if (oyunAlani[kareler[2].Noktalar[2].X / 20, kareler[2].Noktalar[2].Y / 20] == true)
                return;
          
            kareler[0].konumlandır(kareler[0].Noktalar[0].X, kareler[0].Noktalar[0].Y + 20);
            kareler[3].konumlandır(kareler[0].Noktalar[0].X,kareler[0].Noktalar[0].Y + 20);
            durum = 1;
        }
        private void donus2(bool[,] oyunAlani)
        {
            if (kareler[2].Noktalar[0].X / 20 - 1 < 0)
                return;
            if (oyunAlani[kareler[1].Noktalar[1].X / 20, kareler[1].Noktalar[1].Y / 20] == true)
                return;
            if (oyunAlani[kareler[2].Noktalar[0].X / 20-1, kareler[2].Noktalar[0].Y / 20] == true)
                return;


            kareler[0].konumlandır(kareler[0].Noktalar[0].X, kareler[0].Noktalar[0].Y-20);
            kareler[3].konumlandır(kareler[2].Noktalar[0].X - 20, kareler[2].Noktalar[0].Y);
           
            durum = 0;
        }
      
        //dönüş ihtimalleri hesaplandı. 4 durum için ayrı ayrı fonksiyonlar yazıldı
        public override void don(bool[,] oyunAlani)
        { 
            if (durum == 0)
            {
                donus1(oyunAlani);
            }
            else
            {
                donus2(oyunAlani);
            }
            
        }

       
    }
    }

