using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04Exercises02
{
    internal class Program
    {
        class Vehicle
        {
            private string strModel;
            private float fltPrice;
            public Vehicle(string strModel, float fltPrice)
            {
                this.strModel = strModel;
                this.fltPrice = fltPrice;
            } 
            public float GetPrice(float coe)
            {
                return fltPrice + coe;
            }
            public float GetPrice(string cat)
            {
                if (cat == "A")
                {
                    fltPrice = fltPrice+ 30000f;
                }
                else if (cat == "B")
                {
                    fltPrice = fltPrice + 39000f;
                }
                else if (cat == "C")
                {
                    fltPrice = fltPrice + 31000f;
                }    
                return fltPrice;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enther the model: ");
            string model = Console.ReadLine();
            Console.Write("Enther the price: ");
            float price= float.Parse(Console.ReadLine());
            Vehicle v1Obj= new Vehicle(model, price);
            Console.Write("Enther the coe: ");
            float coe = float.Parse(Console.ReadLine());
            Console.WriteLine("The price is: " + v1Obj.GetPrice(coe).ToString());
            Console.Write("Enther the model: ");
            string model2 = Console.ReadLine();
            Console.Write("Enther the price: ");
            float price2 = float.Parse(Console.ReadLine());
            Vehicle v2Obj= new Vehicle(model2, price2);
            Console.Write("Enther the cat: ");
            string cat = Console.ReadLine();
            Console.WriteLine("The new price is: " + v1Obj.GetPrice(cat).ToString());
            Console.ReadKey();
        }
    }
}
