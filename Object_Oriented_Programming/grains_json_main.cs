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
        grains_Inventory grains = new grains_Inventory();
        List<grains_Inventory> grains_list = new List<grains_Inventory>();

        public void conversion(string jsonFilePath)
        {
            using (StreamReader reader = new StreamReader(jsonFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<grains_Inventory>>(json);
                Console.WriteLine("Name        Price_per_Kg          Weight          Total_Price");
                foreach(var x in items)
                {
                    double Total_Price = x.price_per_kg * x.weight;
                    Console.WriteLine(x.name + "     ->      " + x.price_per_kg + "      ->      " + x.weight + "        ->      " + Total_Price);
                }

            }
        }
    }
}
