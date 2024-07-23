




































using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Demo
{
    class Program
    {

        public static string HashString(string inputString)
        {
            using (SHA256Managed sha = new SHA256Managed())
            {
                var bytes = Encoding.UTF8.GetBytes(inputString);
                var hash = sha.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        public static double TongHocc(double[] a, double x)
        {
            double result = a[a.Length-1];
            for (int i = a.Length - 2; i >= 0; i--)
            {
                result = result * x + a[i];
            }
            return result;
        }

        public  double TongCoBan(double[] a, double x)
        {
            double result = a[0];
            for (int i = 1;i<a.Length-1;i++)
            {
                result = result + (x + a[i]);
            }
            return result;
        }

    
        public static int UCLNVongLap(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        public static int UCLNDeQuy(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return UCLNDeQuy(b, a % b);
        }
        static void Main(string[] args)
        {
            int c = 9;
            int b = 3;
            int max=UCLNVongLap(c,b);
            int max1=UCLNDeQuy(c,b);
            Console.WriteLine(max+ "" +max1 );
            Console.WriteLine(max1 );


            double[] a = { 1, 2, 3, 4, 5 }; // ví dụ với n = 5
            double x = 5;
            double result = TongHocc(a, x);
            Console.WriteLine($"Tổng vs  x = {x} là {result}.");
            Console.ReadLine();




            
        }
    }
}












