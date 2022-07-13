using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    public class Product
    {
        public int plakakodu { get; set; }
        public string ilce { get; set; }

        public double nüfus { get; set; }

        public string il { get; set; }


    }

                               
      
    class Program
    {
        public void method(string a) // string veri tipi  girildiğinde bu method çalışır.
        {
            int guvenliknumgiris;
            int guvenliknumarası = 12345;
            Console.WriteLine("Güvenlik numaranız  : 12345 ");
            Console.WriteLine("Size verilen güvenlik numarasını giriniz.");
            guvenliknumgiris = Convert.ToInt32(Console.ReadLine());

            if (guvenliknumgiris == 12345)
            {
                List<Product> listProducts = new List<Product> //  List veri  yapısı
                {
                new Product { plakakodu= 34, il = "Istanbul" },
                new Product { plakakodu= 35, il = "İzmir" },
                new Product { plakakodu= 06, il = "Ankara"}
                };
                Dictionary<int, Product> productsDictionary = listProducts.ToDictionary(x => x.plakakodu); //  dictionary  veri  yapısı ve "to.dictionary" LINQ bileşeni.
                foreach (KeyValuePair<int, Product> kvp in productsDictionary)
                {
                    Console.WriteLine(kvp.Key + " : " + kvp.Value.il);
                }


            }
            else
            {
                Console.WriteLine("Guvenlik Numarasını Yanlış Girdiniz");
                method(a);   // Recursive 
            }



        }
        public void method(int b)  // int veri tipi  girildiğinde bu method çalışır.
        {
            if (b == 34)
            {
                List<Product> listProducts = new List<Product>
                {
                new Product { nüfus= 997.486, ilce = "Esenyurt" },
                new Product { nüfus= 805.930, ilce = "Küçükçekmece" },
                new Product { nüfus= 733.351, ilce = "Bağcılar"}
                };
                Dictionary<double, Product> productsDictionary = listProducts.ToDictionary(x => x.nüfus);
                foreach (KeyValuePair<double, Product> kvp in productsDictionary)
                {
                    Console.WriteLine(kvp.Key + " : " + kvp.Value.ilce);
                }
            }
            else if (b == 35)
            {
                List<Product> listProducts = new List<Product>
                {
                new Product { nüfus= 517.963, ilce = "KARABAĞLAR" },
                new Product { nüfus= 478.788, ilce = "BORNOVA" },
                new Product { nüfus= 452.867, ilce = "KARŞIYAKA"}
                };
                Dictionary<double, Product> productsDictionary = listProducts.ToDictionary(x => x.nüfus);
                foreach (KeyValuePair<double, Product> kvp in productsDictionary)
                {
                    Console.WriteLine(kvp.Key + " : " + kvp.Value.ilce);
                }
            }
            else if (b == 06)
            {
                List<Product> listProducts = new List<Product>
                {
                new Product { nüfus= 949.265, ilce = "ÇANKAYA" },
                new Product { nüfus= 942.884, ilce = "KEÇİÖREN" },
                new Product { nüfus= 703.809, ilce = "YENİMAHALLE"}
                };
                Dictionary<double, Product> productsDictionary = listProducts.ToDictionary(x => x.nüfus);
                foreach (KeyValuePair<double, Product> kvp in productsDictionary)
                {
                    Console.WriteLine(kvp.Key + " : " + kvp.Value.ilce);
                }
            }
        }








        public static void Main(string[] args)
        {
            int x;
            Program p1 = new Program();
            p1.method("Türkiye");  

            Console.WriteLine("İllerin güncel nüfuslarını öğrenmek  için plaka numarası giriniz  : ");
            x = Convert.ToInt32(Console.ReadLine());
            p1.method(x);
            Console.ReadLine();
        }
    }
}
