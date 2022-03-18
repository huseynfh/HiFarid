using System;
using System.Collections.Generic;
using System.Text;

namespace Labday_4_2
{
    class Book:Product
    {
        public Book(string productname,int saledprice):base(productname,saledprice)
        {

        }
        public void GetDiscountedPrice(int saleprice,int discountpercent)
        {
            int result = saleprice - (saleprice * discountpercent / 100);
            Console.WriteLine(result);
        }

    }
}
