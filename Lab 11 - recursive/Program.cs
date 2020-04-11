using System;
using System.Text;

namespace Lab_11___recursive
{
    class Program
    {
        static int minim = int.MaxValue;
        static int maxim = int.MinValue;
        static int i = 0;
        static int j = 0;
        static int index = 0;
        static int element;
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = new int[] { 23, 45, 12, 29, 133, 400, 134, 260, 300, 101 , 313, 210};
            Console.WriteLine(p.GasireMinim(arr, i));

            i = 0;

            Console.WriteLine(p.GasireMaxim(arr, i));

            for ( i = 0; i < arr.Length ; i++ )
            {
                arr[i] = i;
            }

            i = j = arr.Length - 1;

            string mesaj = $"Introduceti un numar din urmatorul sir [{ String.Join(", ", arr) }]  pentru a-i afla pozitia in sir";

            Console.WriteLine(mesaj.TrimEnd(','));

            element = Convert.ToInt32(Console.ReadLine());

            Console.Write( $"Elementul selectat este la pozitia: { p.GasireIndex(arr) }");

        }

        private int GasireMinim(int[] arr, int m)
        {
            if (arr == null )
            {
                minim = 0;
                return minim;
            }

            if (m == arr.Length)
            {
                return minim;
            }

            if  (arr[m] < minim )
            {
                minim = arr[m];
            }

            return GasireMinim(arr, ++m);
            
            //return minim;
        }

        private int GasireMaxim(int[] arr, int m)
        {
            if (arr == null)
            {
                maxim = 0;
                return maxim;
            } 


            if (m == arr.Length)
            {
                return maxim;
            }

            if (arr[m] > maxim)
            {
                maxim = arr[m];
            }

            return GasireMaxim(arr, ++m);

        }

        public int GasireIndex (int[] arr)
        {

            if (element < arr[j])
            {

                j = j / 2;
                GasireIndex(arr);

            }
            
            if (element == arr[j])
            {

                index = j;

            }


             if (element > arr[j])
            {
                 j += (i - j) / 2;
                 GasireIndex(arr);
            }

            return index + 1;

        }

    }
}
