using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProje
{
    class KareSekli:Sekil
    {
         public KareSekli()
        {
            kareler[0].konumlandır(200, 0);//Kare şekli çıkacak şekilde ayarlandı.
            kareler[1].konumlandır(220, 0);
            kareler[2].konumlandır(220, 20);
            kareler[3].konumlandır(200, 20);
            for (int i = 0; i < 4; i++)
            {
                kareler[i].resimDegistir("pembe");//karelerin resmi değiştiriliyor (farklı şekiller farklı renklerde gelsin diye)
            }
        }
         //private void donus1(bool[,] oyunAlani)
         //{
         //    durum = 1;
         //    return;
         //}
         //private void donus2(bool[,] oyunAlani)
         //{
         //    durum = 2;
         //    return;
         //}
         //private void donus3(bool[,] oyunAlani)
         //{
         //    durum = 3;
         //    return;
         //}
         //private void donus4(bool[,] oyunAlani)
         //{
         //    durum = 1;
         //    return;
         //}
         //dönüş ihtimalleri hesaplandı. 4 durum için ayrı ayrı fonksiyonlar yazıldı
         public override void don(bool[,] oyunAlani)
         {
             //if (durum == 0)
             //{
             //    donus1(oyunAlani);

             //}
             //else if (durum == 1)
             //{
             //    donus2(oyunAlani);
             //}
             //else if (durum == 2)
             //{
             //    donus3(oyunAlani);
             //}
             //else
             //{
             //    donus4(oyunAlani);
             //}
         }



         
    }
    }
