using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProje
{
    class CubukSekli:Sekil
    {
       
        public CubukSekli()
        {
            kareler[0].konumlandır(200, 0);//çubuk oluşacak şekilde konum ayarlaması yapılıyor
            kareler[1].konumlandır(200, 20);
            kareler[2].konumlandır(200, 40);
            kareler[3].konumlandır(200, 60);
        }
        //dön fonksiyonu override edilerek çubuğun 2 hali için durumlar inceleniyor
        public override void don(bool [,] oyunAlani)
        {
            if (durum == 0)
            {
                solaDon(oyunAlani);
            }
            else
            {
                sagaDon(oyunAlani);
            }
        }
        //dönme için ayrı, bu dönmenin gerçekleştirilme imkanını kontrol etmek için ayrı fonksiyonlar yazıldı
        private void solaDon(bool [,]oyunAlani)
        {
            if (kontrolSolaDon(oyunAlani) == false)
                return;
            durum = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    kareler[i].Noktalar[j].X -= 20*(3-i);
                    kareler[i].Noktalar[j].Y += 20 * (3-i);
                    kareler[i].setXY();
                }
            }
           
            
        }
        private bool kontrolSolaDon(bool[,] oyunAlani)
        {
                for (int i = 0; i < 3; i++)
                {
                    
                    if (kareler[i].Noktalar[0].X / 20 +(i-3) < 0)
                        return false;
                    if (kareler[i].Noktalar[0].Y / 20 + (3-i) >= 28)
                        return false;
                   
                }
                    if (oyunAlani[kareler[2].Noktalar[0].X / 20 - 1, kareler[2].Noktalar[0].Y / 20 + 1] == false &&
                        oyunAlani[kareler[1].Noktalar[0].X / 20 - 2, kareler[1].Noktalar[0].Y / 20 + 2] == false &&
                        oyunAlani[kareler[0].Noktalar[0].X / 20 - 3, kareler[0].Noktalar[0].Y / 20 + 3] == false)
                        return true;
                return false;
           
        }
        private void sagaDon(bool[,] oyunAlani)
        {
            if (kontrolSagaDon(oyunAlani) == false)
                return;
                //return false;
            durum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    kareler[i].Noktalar[j].X += 20 * (3 - i);
                    kareler[i].Noktalar[j].Y -= 20 * (3 - i);
                    kareler[i].setXY();
                }
            }
            //return true;
        }
        private bool kontrolSagaDon(bool[,] oyunAlani)
        {
                for (int i = 0; i < 3; i++)
                {

                    if (kareler[i].Noktalar[0].X / 20 + (3-i) < 0)
                        return false;
                    if (kareler[i].Noktalar[0].Y / 20 + (i-3) >= 28)
                        return false;
                   
                }
                if (oyunAlani[kareler[2].Noktalar[0].X / 20 + 1, kareler[2].Noktalar[0].Y / 20 - 1] == false &&
                    oyunAlani[kareler[1].Noktalar[0].X / 20 + 2, kareler[1].Noktalar[0].Y / 20 - 2] == false &&
                    oyunAlani[kareler[0].Noktalar[0].X / 20 + 3, kareler[0].Noktalar[0].Y / 20 - 3] == false)
                    return true;
                return false;   
            
           
        }



       
    }
}
