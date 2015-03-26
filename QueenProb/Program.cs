using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueenProb
{

    class Program
    {
        static int[,] dizi=new int[8,8];
        static int[,] dizi2 = new int[8, 8];

        static void Main(string[] args)
        {
            create();
            test(dizi);
            cakismalariDuzelt(dizi);
            Console.ReadKey();
        }

        private static void cakismalariDuzelt(int[,] dizi)
        {
            ////for (int i = 0; i < 8; i++)
            ////{
            //    int cak1 = 100;
            //    int cak2 = 0;
            //    //for (int sutun = 0; sutun < 8 ; sutun++)
            //    //{
            //        for (int j = 0; j < 8; j++)
            //        {
            //            for (int k = 0; k < 8; k++)
            //            {
            //                if (dizi[j, k] == 1 )
            //                {
            //                    cak2++;
            //                }
            //            }
            //            Console.WriteLine(k +". sutun " + j + ".satir icin tehtid :" + cak2);
                        
            //            cak2 = 0;
            //    //}
            //        Console.WriteLine();
            //    }
            ////}
        }

        private static void test(int[,] dizi)
        {
            
            int cakisma = 0;
            //1 degerine sahip hucreyi bul
            for (int sutun = 0; sutun < 8; sutun++)
            {
               
                for (int satir = 0; satir < 8; satir++)
                {
                    int i = 0;
                    int sa, su = 0;
                    if (dizi[satir,sutun] == 1)
                    {
                        //yatay cakisma kontrol
                        for (i = 0; i < 8; i++)
                        {
                            if (dizi[satir,i] == 1 && i != sutun)
                            {
                                cakisma++;                                
                            }
                        }

                        //solüstcapraz cakisma kontrol
                        for (i = 0; i < 8; i++)
                        {
                            sa = satir - i - 1;
                            su = sutun - i - 1;

                            if (sinirdismi(sa,su) == false) break;
                            if (dizi[sa, su] == 1) cakisma++;
                        }

                        //sagaltcapraz cakisma kontrol
                        for (i = 0; i < 8; i++)
                        {
                            sa = satir + i +1;
                            su = sutun + i + 1;

                            if (sinirdismi(sa, su) == false) break;
                            if (dizi[sa, su] == 1) cakisma++;
                        }

                        //sagustcapraz cakisma kontrol
                        for (i = 0; i < 8; i++)
                        {
                            sa = satir + i + 1;
                            su = sutun - i - 1;

                            if (sinirdismi(sa, su) == false) break;
                            if (dizi[sa, su] == 1) cakisma++;
                        }

                        //solaltcapraz cakisma kontrol
                        for (i = 0; i < 8; i++)
                        {
                            sa = satir - i - 1;
                            su = sutun + i + 1;

                            if (sinirdismi(sa, su) == false) break;
                            if (dizi[sa, su] == 1) cakisma++;
                        }

                    }
                }
            }
            Console.WriteLine("Toplam cakisma : " + cakisma);
            
        }

        private static bool sinirdismi(int sa, int su)
        {
            //satir ve sutun numaralari 7 den buyuk 0 dan kucuk mu
            if (sa> 7 || su > 7 || sa < 0 || su < 0) return false;
            return true;
        }

       

        //her sutuna 1 vezir gelecek sekilde rastgele diz
        private static void create()
        {
            for (int sutun = 0; sutun < 8; sutun++)
            {
                for (int satir = 0; satir < 8; satir++)
                {
                    dizi[satir, sutun] = 0;
                }
            }

            var j = 0;

            var rnd = new Random();
            for (int i= 0; i < 8; i++)
            {
               
                j= rnd.Next(0, 8);
                dizi[j,i] = 1;

            }

            for (int sutun = 0; sutun < 8; sutun++)
            {
                for (int satir = 0; satir < 8; satir++)
                {
                    
                    Console.Write(" " + dizi[sutun,satir] + " ");
                }
                Console.WriteLine("");
            }


            
        }
    }
}
