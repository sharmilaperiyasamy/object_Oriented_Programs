using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Object_Oriented_Programming
{
    internal class grains_json_main
    {
        public void conversion(string jsonFilePath)
        {
            Factory_Model factory = new Factory_Model();
            List<grains_Inventory> Rice;
            List<grains_Inventory> Pulses;
            List<grains_Inventory> Wheat;

            using (StreamReader reader = new StreamReader(jsonFilePath))
            {
                var json = reader.ReadToEnd();
                Factory_Model items = JsonConvert.DeserializeObject<Factory_Model>(json);
                Rice = items.Rice;
                Pulses = items.Pulses;
                Wheat = items.Wheat;
                Console.WriteLine("Which grain item you want to check : \n1.Rice\t\t2.Pulses\t\t3.Wheat");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name\t->\tPrice_Per_Kg\t->\tWeight\t->\tTotal_Price");
                switch (option)
                {
                    case 1:
                        foreach (var x in Rice)
                        {
                            double Total_Price = x.price_per_kg * x.weight;
                            Console.WriteLine(x.name + "\t->\t" + x.price_per_kg + "\t->\t" + x.weight + "\t->\t" + Total_Price);
                        }
                        break;
                    case 2:
                        foreach (var x in Pulses)
                        {
                            double Total_Price = x.price_per_kg * x.weight;
                            Console.WriteLine(x.name + "\t->\t" + x.price_per_kg + "\t->\t" + x.weight + "\t->\t" + Total_Price);
                        }
                        break;
                    case 3:
                        foreach (var x in Wheat)
                        {
                            double Total_Price = x.price_per_kg * x.weight;
                            Console.WriteLine(x.name + "\t->\t" + x.price_per_kg + "\t->\t" + x.weight + "\t->\t" + Total_Price);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
               
            }
        }
    }
}
