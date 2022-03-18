using System;

namespace Labday_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mehsulu daxil edin");
            string product = Console.ReadLine();    
            Console.WriteLine("Satis qiymetini daxil edin");
            int saleprice = int.Parse(Console.ReadLine());
            Console.WriteLine("Endirim Faizini qeyd edin");
            int dispercent = int.Parse(Console.ReadLine());

            Book bookprice = new Book(product, saleprice);

            bookprice.GetDiscountedPrice(saleprice, dispercent);

        }
    }
}
