using System;
using System.Security.Cryptography.X509Certificates;

namespace AbramyanSeries
{
    public class SeriesTasks
    {

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

    }
}
