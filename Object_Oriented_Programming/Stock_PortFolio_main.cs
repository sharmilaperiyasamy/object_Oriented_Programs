using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Object_Oriented_Programming
{
    internal class Stock_PortFolio_main
    {
        Stock stock = new Stock();
        List<Stock> share_list = new List<Stock>();

        public void conversion(string jsonFilePath)
        {
            using (StreamReader reader = new StreamReader(jsonFilePath))
            {
                var json = reader.ReadToEnd();
                var shares = JsonConvert.DeserializeObject<List<Stock>>(json);
                Console.WriteLine("StockName\t->\tnumberOfShares\t->\tSharePrice\t->\tTotalSharePrice");
                double Total_Price = 0;
                foreach(var share in shares)
                {
                    double tTotalSharePrice = share.numberOfShares * share.SharePrice;
                    Total_Price = Total_Price + tTotalSharePrice;
                    Console.WriteLine(share.StockName + "     ->     " + share.numberOfShares + "     ->     " + share.SharePrice + "     ->     " + tTotalSharePrice);
                }
                Console.WriteLine("Sum of all Stocks : " + Total_Price);
            }
        }
    }
}
