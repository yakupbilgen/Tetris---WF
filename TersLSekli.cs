using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProje
{
    class TersLSekli:Sekil
    {
        public TersLSekli()
        {
            kareler[0].konumlandır(200, 0);//T şekli çıkacak şekilde ayarlandı
            kareler[1].konumlandır(200, 20);
            kareler[2].konumlandır(200, 40);
            kareler[3].konumlandır(180, 40);
            for (int i = 0; i < 4; i++)
            {
                kareler[i].resimDegistir("kirmizi");//karelerin resmi değiştiriliyor (farklı şekiller farklı renklerde gelsin diye)
            }
        }
        private void donus1(bool[,] oyunAlani)
        {
            if (kareler[2].Noktalar[1].X + 40 > 400)
                return;
            if (oyunAlani[kareler[2].Noktalar[1].X / 20, kareler[2].Noktalar[1].Y / 20] == true)
                return;
            if (oyunAlani[kareler[2].Noktalar[1].X / 20+1, kareler[2].Noktalar[1].Y / 20] == true)
                return;

            durum = 1;
            kareler[0].konumlandır(kareler[2].Noktalar[1].X, kareler[2].Noktalar[1].Y);
            kareler[3].konumlandır(kareler[2].Noktalar[1].X+20, kareler[2].Noktalar[1].Y);

        }
        private void donus2(bool[,] oyunAlani)
        {
            if (kareler[1].Noktalar[0].Y - 20 < 0)
                return;
            if (oyunAlani[kareler[1].Noktalar[0].X / 20, kareler[1].Noktalar[0].Y / 20 - 1] == true)
                return;
            if (oyunAlani[kareler[1].Noktalar[0].X / 20+1, kareler[1].Noktalar[0].Y / 20 - 1] == true)
                return;

            durum = 2;
            kareler[0].konumlandır(kareler[1].Noktalar[0].X, kareler[1].Noktalar[0].Y-20);
            kareler[3].konumlandır(kareler[1].Noktalar[0].X+20, kareler[1].Noktalar[0].Y - 20);

        }
        private void donus3(bool[,] oyunAlani)
        {
            if (kareler[1].Noktalar[0].X-40<0)
                return;
            if (oyunAlani[kareler[1].Noktalar[0].X / 20 - 1, kareler[1].Noktalar[0].Y/20] == true)
                return;
            if (oyunAlani[kareler[1].Noktalar[0].X / 20 - 2, kareler[1].Noktalar[0].Y/20] == true)
                return;

            durum = 3;
            kareler[0].konumlandır(kareler[1].Noktalar[0].X - 40, kareler[1].Noktalar[0].Y);
            kareler[3].konumlandır(kareler[1].Noktalar[0].X - 20, kareler[1].Noktalar[0].Y);
        }
        private void donus4(bool[,] oyunAlani)
        {
            if (kareler[1].Noktalar[0].Y - 20 < 0)
                return;
            if (oyunAlani[kareler[1].Noktalar[0].X / 20, kareler[1].Noktalar[0].Y / 20 - 1] == true)
                return;
            if (oyunAlani[kareler[2].Noktalar[0].X / 20 - 1, kareler[2].Noktalar[0].Y / 20] == true)
                return;

            durum = 0;
            kareler[0].konumlandır(kareler[1].Noktalar[0].X, kareler[1].Noktalar[0].Y - 20);
            kareler[3].konumlandır(kareler[2].Noktalar[0].X-20, kareler[2].Noktalar[0].Y );
        }
        public override void don(bool[,] oyunAlani)
        {
            if (durum == 0)
                donus1(oyunAlani);
            else if (durum == 1)
                donus2(oyunAlani);
            else if (durum == 2)
                donus3(oyunAlani);
            else
                donus4(oyunAlani);
        }

       
    }
}
