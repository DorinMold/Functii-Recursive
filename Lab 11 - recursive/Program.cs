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

            //-------------Gasire minim-----------------------

            Console.WriteLine(p.GasireMinim(arr, i));

            //---------------Gasirea Maximului-------------------

            i = 0;

            Console.WriteLine(p.GasireMaxim(arr, i));

            //---------------Gasire index in vector ordonat -----------------------

            for ( i = 0; i < arr.Length ; i++ )
            {
                arr[i] = i;
            }

            i = j = arr.Length - 1;

            string mesaj = $"Introduceti un numar din urmatorul sir [{ String.Join(", ", arr) }]  pentru a-i afla pozitia in sir";

            Console.WriteLine(mesaj.TrimEnd(','));

            element = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( $"Elementul selectat este la pozitia: { p.GasireIndex(arr) }");

            //------------Fibonnaci--------------------
            FibonanaciInvoke(20);

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

        static int[] Fibonnaci;
        public static void FibonanaciInvoke(int n)
        {
            Fibonnaci = new int[n];
            FibCalculation(0);
        }

        public static int FibCalculation(int m)
        {
            if (m == 0)
            {
                Fibonnaci[0] = 0;
            }
            else if (m == 1)
            {
                Fibonnaci[1] = 1;
            }

            else if (m < Fibonnaci.Length)
            {
                Fibonnaci[m] = Fibonnaci[m - 2] + Fibonnaci[m - 1];
            }
            else
            {
                Console.WriteLine(String.Join(", ", Fibonnaci));
                return 0;
            }

            return FibCalculation(m + 1);

        }
    }
}

