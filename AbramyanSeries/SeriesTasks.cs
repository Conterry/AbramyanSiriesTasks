using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AbramyanSeries
{
    public class SeriesTasks
    {


        public void Main()
        {
            Series17();
        }


        public double Series1(double[] a)
        {
            double s = 0;

            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }

            return s;
        }

        public double Series3(double[] a)
        {
            double ser = 0;

            for(int i=0; i<a.Length; i++)
            {
                ser += a[i];
            }
            ser /= 10;

            return ser;
        }

        public void Series5()
        {
            int n = 10;
            double[] a = { 1.1, 2.1, 3.2, 4.4, 5.6, 6.5, 7.8, 8.2, 9.1, 1.2};
            double s = 0;

            for(int i=0; i<n; i++)
            {
                Console.WriteLine(Math.Truncate(a[i]));
                s += Math.Truncate(a[i]);
            }

            Console.WriteLine(s);

        }

        public void Series7()
        {
            int n = 10;
            double[] a = { 1.1, 2.1, 3.2, 4.4, 5.6, 6.5, 7.8, 8.2, 9.1, 1.2 };
            int s = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Convert.ToInt32(a[i]));
                s += Convert.ToInt32(a[i]);
            }

            Console.WriteLine(s);
        }

        public void Series9()
        {
            int n = 10;
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int s = 0;

            foreach(int i in a)
            {
                if(a[i] %2 != 0)
                {
                    Console.WriteLine(i);
                    s++;
                }
            }

            Console.WriteLine(s);

        }

        public bool Series11()
        {
            int k = 10, n = 10;
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };

            for(int i=0; i<n; i++)
            {

                if(a[i] < k)
                {
                    return true;
                }

            }

            return false;
        }

        public void Series13()
        {
            int[] a = { 1, 2, -3, 4, 5, -7, 0 };
            int s = 0, i = 0;

            while (a[i] != 0)
            {
                if(a[i] >0 && a[i] %2 == 0)
                {
                    s += a[i];
                }
            }

            Console.WriteLine(s);
        }


        public int Series15(int[] a, int k)
        {

            int i = 0;

            while (a[i] != 0 )
            {
                if(a[i] > k)
                {
                    return i;
                }
                i++;
            }

            return 0;

        }

        public void Series17()
        {
            double b = 3.8;
            int n = 10;
            double[] a = { 1, 3, 4, 6, 8, 10, 12, 12.3, 13.9, 14.9 };

            for(int i=0; i<n; )
            {
                Console.WriteLine(a[i]);
                if (a[i] < b)
                {
                    Console.WriteLine(b);
                }
                i++;
            }
        }

        public void Series19()
        {
            int n = 4, k = 0;
            int[] a = { 4, 1, 8, 3 };

            for (int i = 1; i < n; i++)
            {
                if (a[i] < a[i - 1])
                {
                    Console.WriteLine(a[i]);
                    k++;
                }
            }

            Console.WriteLine(k);

        }


        public bool Series21(int n, double[] a)
        {

            int Count = 0;

            for(int i = 0; i < n-1; i++)
            {
                if (a[i] < a[i + 1])
                {
                    Count++;
                }
            }

            if(Count == n - 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Series23()
        {
            int n = 5;
            double[] a = { 2, 3, 2.1, 4, 7.1 };
            int f = 0, g = 0;

            for(int i=1;i<n-1; i++)
            {
                if((a[i]<a[i-1]) && (a[i] < a[i + 1]) || (a[i] > a[i - 1]) && (a[i] > a[i + 1]))
                {
                    f++;
                }
                else
                {
                    g = i;
                    break;
                }
            }

            if(f == n - 3)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(g);
            }

        }

        public void Series25()
        {
            int n = 6;
            int[] a = { 1, 0, 3, 4, 0, 6 };
            int s = 0, d = 0;

            for(int i=0; i<n; i++)
            {
                if(d == 1)
                {
                    s += a[i];
                }
                if(a[i] == 0)
                {
                    d++;
                }
            }

            Console.WriteLine(s);

        }

        public void Series27()
        {
            int n = 6;
            double[] a = { 1.1, 2.4, 4.6, 7.5, 9.4, 11.1 };

            for(int i=0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(a[i], i));
            }

        }


    }
}
