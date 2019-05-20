using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProje
{
    class Creator
    {
       
        public Sekil kontrolEt(Sekil aktifSekil,int rastgeleSayi)
        { 
            switch (rastgeleSayi)
            { 
                case 0:
                    aktifSekil = new LSekli();
                    break;   
                case 1: 
                    aktifSekil = new CubukSekli();
                    break;
                case 2:
                    aktifSekil = new TSekli();
                    break;
                case 3:
                   aktifSekil = new TersLSekli();
                    break;
                case 4: 
                    aktifSekil = new KareSekli();
                    break;
                case 5:
                    aktifSekil = new ZSekli();
                    break;
                default:
                    aktifSekil = new TersZSekli();
                    break;
            }
            return aktifSekil;
        }
        //        private bool kontrolEtL(bool[,] oyunAlani)
        //{
        //    if (oyunAlani[10, 0] == true || oyunAlani[10, 1] == true || oyunAlani[10, 2] == true || oyunAlani[11, 2] == true)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        // private bool kontrolEtCubuk(bool[,] oyunAlani)
        //{
        //    if (oyunAlani[10, 0] == true || oyunAlani[10, 1] == true || oyunAlani[10, 2] == true || oyunAlani[10, 3] == true)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        // private bool kontrolEtT(bool[,] oyunAlani)
        //{
        //    if (oyunAlani[10, 0] == true || oyunAlani[11, 0] == true || oyunAlani[12, 2] == true || oyunAlani[11, 1] == true)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        // private bool kontrolEtTersL(bool[,] oyunAlani)
        //{
        //    if (oyunAlani[10, 0] == true || oyunAlani[10, 1] == true || oyunAlani[10, 2] == true || oyunAlani[9, 2] == true)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        // private bool kontrolEtZ(bool[,] oyunAlani)
        //{
        //    if (oyunAlani[10, 0] == true || oyunAlani[11, 0] == true || oyunAlani[11, 1] == true || oyunAlani[12, 1] == true)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        // private bool kontrolEtTersZ(bool[,] oyunAlani)
        //{
        //    if (oyunAlani[12, 0] == true || oyunAlani[11, 0] == true || oyunAlani[11, 1] == true || oyunAlani[10, 1] == true)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        // private bool kontrolEtKare(bool[,] oyunAlani)
        // {
        //     if (oyunAlani[10, 0] == true || oyunAlani[10, 1] == true || oyunAlani[11, 0] == true || oyunAlani[11, 1] == true)
        //     {
        //         return false;
        //     }
        //     return true;
        // }
        
        }
    }

