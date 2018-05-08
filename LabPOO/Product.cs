﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace LabPOO
{
    [Serializable()]
    class Product
    {
        private string name;
        private int stock;
        private int price; //Price for one unit of the product
        private string unit;

        public Product(string name, int price, int stock, string unit)
        {
            this.name = name;
            this.stock = stock;
            this.price = price;
            this.unit = unit;
        }

        public bool Agregar(List<Product> carrito)
        {
            if (stock > 0)
            {
                carrito.Add(this);
                stock--;
                return true;
            }
            return false;
        }

        public string Name { get => name; }
        public int Stock { get => stock; }
        public int Price { get => price; }
        public string Unit { get => unit; }

        public string GetName()
        {
            return this.name;
        }
        public void aa(string mensaje)
        {
            string nombre = this.GetName();
            Console.WriteLine("Matias, el producto " +nombre + mensaje);

            
        }
    }
}
