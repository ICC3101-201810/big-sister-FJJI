using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    delegate void BigSist(string mensaje);

    class BigSis
    {
        List<string> nombres = new List<string>();

        public BigSis()
        {
            nombres.Add("Láminas de Lasaña");
            nombres.Add("Queso Rallado Parmesano");
            nombres.Add("Mantequilla");
            nombres.Add("Carne Molida");
            nombres.Add("Vino Sauvignon Blanc Reserva Botella");
            nombres.Add("Tomates Pelados en lata");
            nombres.Add("Bolsa de Zanahorias");
            nombres.Add("Malla de Cebollas");
            nombres.Add("Aceite de Oliva");
            nombres.Add("Sal Lobos");
            nombres.Add("Pimienta");
            nombres.Add("Harina");
            nombres.Add("Leche Entera");
            nombres.Add("Tomates");

        }
        public void ChequearCarrito (BigSist producto)
        {
            
            producto(" esta en la lista?");
            
        }
        public void RetirarProducto(List<Product> carrito,Product product)
        {
            

            foreach (Product productt in carrito)
            {
                bool error = false;
                foreach (String necesario in this.nombres)
                {
                    error = false;
                    if (necesario != productt.GetName())
                    {
                        error = true;
                        
                    }
                    
                }
                if (error == true)
                {
                    Console.WriteLine("no lo esta, Matias malo :c ");
                    carrito.Remove(productt);

                }
            }
        }

        /*
        market.Add(new Product("Leche Entera", 820, 89, "1L"));
            market.Add(new Product("Gomitas Flipy", 720, 12, "100g"));
            market.Add(new Product("Mantequilla", 850, 12, "125g"));
            market.Add(new Product("Crema para hemorroides", 4990, 7, "300cc"));
            market.Add(new Product("Pimienta", 430, 84, "15g"));
            market.Add(new Product("Vino Sauvignon Blanc Reserva Botella", 4150, 23, "750cc"));
            market.Add(new Product("Sal Lobos", 330, 150, "1kg"));
            market.Add(new Product("Cuaderno Mi Pequeño Pony", 1290, 50, "1un"));
            market.Add(new Product("Láminas de Lasaña", 1250, 85, "400g"));
            market.Add(new Product("Tomate", 1290, 200, "1kg"));
            market.Add(new Product("Harina", 890, 43, "1kg"));
            market.Add(new Product("Audifonos Samsung", 5990, 40, "1un"));
            market.Add(new Product("Pisco Alto del Carmen", 5990, 120, "1L"));
            market.Add(new Product("Carne Molida", 4390, 15, "500g"));
            market.Add(new Product("Aceite de Oliva", 1790, 77, "250g"));
            market.Add(new Product("Sal parrillera", 840, 50, "750g"));
            market.Add(new Product("Cable HDMI 1m", 3990, 25, "1un"));
            market.Add(new Product("Queso Rallado Parmesano", 499, 102, "40g"));
            market.Add(new Product("Vino Blanco Caja", 2790, 84, "2L"));
            market.Add(new Product("Malla de Cebollas", 1090, 91, "1kg"));
            market.Add(new Product("Tomates Pelados en lata", 700, 48, "540g"));
            market.Add(new Product("Queso Parmesano", 3790, 41, "200g"));
            market.Add(new Product("Bolsa de Zanahorias", 890, 74, "1un"));
            */
    }
}
