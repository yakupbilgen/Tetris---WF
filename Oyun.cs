using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TetrisProje
{
    class Oyun
    {
        private Sekil aktifSekil;
        private Creator k1 = new Creator();
        internal Sekil AktifSekil
        {
            get { return aktifSekil; }

        }
        private bool [,] oyunAlani;
        public Oyun()
        {
            oyunAlani = new bool[20, 28];
           
           
            
        }
        public void don()
        {
            aktifSekil.don(oyunAlani);
        }
        
        public bool asagiIn()
        {

            if (aktifSekil.asagiIn(oyunAlani))
                return true;
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    oyunAlani[aktifSekil.getKare(i).Noktalar[0].X / 20, aktifSekil.getKare(i).Noktalar[0].Y / 20] = true;
                }
                return false;
            }
          

        }
       
        public void solaGit()
        {
            aktifSekil.solaGit(oyunAlani);
        }
        public void sagaGit()
        {
            aktifSekil.sagaGit(oyunAlani);
        }
        public bool yeniSekilOlustur()
        {

            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(0, 7);
            aktifSekil=k1.kontrolEt(aktifSekil, rastgeleSayi);
            return kontrol();
        }
        private bool kontrol()
        {
            if (oyunAlani[aktifSekil.getKare(0).Noktalar[0].X / 20, aktifSekil.getKare(0).Noktalar[0].Y / 20] == true ||
                oyunAlani[aktifSekil.getKare(1).Noktalar[0].X / 20, aktifSekil.getKare(1).Noktalar[0].Y / 20] == true ||
                oyunAlani[aktifSekil.getKare(2).Noktalar[0].X / 20, aktifSekil.getKare(2).Noktalar[0].Y / 20] == true ||
                oyunAlani[aktifSekil.getKare(0).Noktalar[0].X / 20, aktifSekil.getKare(3).Noktalar[0].Y / 20] == true)
                return false;

            return true;
        }
    }
}
