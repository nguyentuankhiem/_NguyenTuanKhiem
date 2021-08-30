using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TestBlazorNangCao.Data;

namespace TestBlazorNangCao.Pages.Products
{
    public class ProductBase : ComponentBase
    {
        private List<ProductItem> _products { get; set; } = Inventory.GetData();
        public string SearchString { get; set; }

        protected IEnumerable<ProductItem> Products => _products.Where(x => string.IsNullOrEmpty(SearchString) || x.Title.ToLower().Contains(SearchString.ToLower()));

        public bool addButton { get; set; }
        public void SaveData() => Inventory.SaveData(_products);

        public void AddNewProduct(ProductItem item)
        {
            _products.Add(item);
            SaveData();
            addButton = false;
        }

        public void StartAdd()
        {
            addButton = true;
        }
        public void CancelAdd()
        {
            addButton = false;
        }


    }
}
