using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabPOO
    {
        static class Serializacion
        {
            public static List<Product> Cargar()
            //Si bien, se activa cuando esta vacio, nos entregara el carrito vacio igualmente
            {
            List<Product> carrito = new List<Product>();
            try
                {
                    using (Stream stream = File.Open("data.bin", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();

                        var CompraAnterior = (List<Product>)bin.Deserialize(stream);

                    foreach (Product salida in CompraAnterior)
                    {
                        carrito.Add(salida);
                    }

                    }
                }
                catch (Exception e)
                {

                }
            // datos agregados a intancia actual
            return carrito;
            }

            public static void Guardar(List<Product> entrada)
            {
                // serializacion para guardado de datos 
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {

                    BinaryFormatter bin = new BinaryFormatter();

                    bin.Serialize(stream, entrada);
                    stream.Close();
                }
                //datos guardados 
            }
        }
    }