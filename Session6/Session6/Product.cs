﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    static class Product
    {
        static int _productId;
        static double _price;
        static Product()
        {
            _productId = 10;
            _price = 156.32;
        }
    }

    public static void Display()
    {
        Console.WriteLine("Product ID: " + _productId);
        Console.WriteLine("Product price: " + _price);
    }
}
