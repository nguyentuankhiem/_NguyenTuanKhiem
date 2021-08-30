using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace TestBlazorNangCao.Data
{
    public class Inventory
    {
        public static void SaveData(List<ProductItem> item)
        {
            using var file = File.CreateText("Data//prd.json");
            var json = new JsonSerializer();
            json.Serialize(file, item);
        }

        public static List<ProductItem> GetData()
        {
            List<ProductItem> itemList = new List<ProductItem>();
            if (File.Exists("Data//prd.json"))
            {
                using var file = File.OpenText("Data//prd.json");
                var json = new JsonSerializer();
                itemList = json.Deserialize(file, typeof(List<ProductItem>)) as List<ProductItem>;
            }
            return itemList.OrderBy(x => x.Title).ToList();
        }
    }
}
