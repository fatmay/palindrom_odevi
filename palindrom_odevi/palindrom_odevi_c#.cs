using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace palindrom
    {
    class sınıf
    {
        public string pal(string k)
        {
            string tersi="";
            for (int i = k.Length - 1; i >= 0; i--)
            {
                tersi += k[i];
            }
            Console.WriteLine("\nKelimenin tersi= " + tersi);
            if (tersi == k)
            {
                Console.WriteLine("\nGirilen kelime polindrom bir kelimedir.");
            }
            else
            {
                Console.WriteLine("\nGirilen kelime polindrom bir kelime değildir.");
            }
            return tersi;

        }
    }
    class Program
        {
       
            static void Main(string[] args)
            {
            sınıf n = new sınıf();
                Console.WriteLine("Bir kelime yahut da sayı giriniz: ");
                string kelime = Console.ReadLine();
            n.pal(kelime);
               
                Console.ReadLine();
            }
        }
    }
