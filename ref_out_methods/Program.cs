using System;

namespace ref_out_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2) int tipindən bir array olur
            //içində müsbət və mənfi ədədlər olur
            //elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin
            //və qəbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun
            //daha sonra içindəki mənfi
            //ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın
            int[] nums = { -1, 2, -3, 4, -5 };
            int[] newAr = MassiveElement(ref nums);
            foreach (var item in newAr)
            {
                Console.WriteLine(item);
            }

        }
        static int[] MassiveElement(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < 0)
                {
                    arr[i] = -arr[i];
                }
                
            }
            return arr;
        }
    }
}
