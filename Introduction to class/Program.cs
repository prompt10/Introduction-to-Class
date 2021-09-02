using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace Introduction_to_class
{
    class Program
    {
        class T_shirt
        {
            public string size;
            public string color;
            public float price;
            public string image; 
        }

        class User
        {
            public string name;
            public string email;
            public Array ShoppingCart;
        }

        class Address
        {
            public string street;
            public string city;
            public string zipCode;
        }

        static void Main(string[] args)
        {
            T_shirt Lred500 = new T_shirt();
            Lred500.size = "L";
            Lred500.color = "red";
            Lred500.price = 500;
            Lred500.image = "Lred500.jpg";

            T_shirt Mblack750 = new T_shirt();
            Mblack750.size = "M";
            Mblack750.color = "black";
            Mblack750.price = 750;
            Mblack750.image = "Mblack750.jpg";

            T_shirt Spink625 = new T_shirt();
            Spink625.size = "S";
            Spink625.color = "pinl";
            Spink625.price = 625;
            Spink625.image = "Spink625";

            Address jameAdress = new Address();
            jameAdress.street = "131/75, ถนนพุทธมณฑล";
            jameAdress.city = "นครปฐม";
            jameAdress.zipCode = "10180";

            float[] orderTshirt_shirts = new float[3] { Lred500.price, Mblack750.price, Spink625.price };
            string[] orderTshirt_Adress = new string[3] { jameAdress.street, jameAdress.city,jameAdress.zipCode };

            string[][] orderThirt = new string[3][];
                orderThirt[0] = new string[] { Convert.ToString(Lred500.price), Convert.ToString(Mblack750.price), Convert.ToString(Spink625.price) };
                orderThirt[1] = new string[] { jameAdress.street, jameAdress.city, jameAdress.zipCode };
            

            User JameWatson = new User();
            JameWatson.name = "jame watsom";
            JameWatson.email = "jame@gmail.com";
            JameWatson.ShoppingCart = orderThirt;


            Console.WriteLine("Price: ");

                     

            foreach (var itemP in orderThirt[0])
            {
                Console.Write(itemP);
                Console.Write(", ");
            }

            double sum = 0;
            List<double> TshirtPrice = new List<double>();


                for (int i = 0; i < orderThirt[0].Length; i++)
                {
                    TshirtPrice.Add(Convert.ToDouble(orderThirt[0][i]));

                    sum = sum + TshirtPrice[i];
                }
                
            

            Console.WriteLine("Total price: {0}", sum );

            Console.Write("Address: ");
            
            foreach (var itemA in orderThirt[1])
            {
                Console.Write(itemA);
            }



        }
    }
}
