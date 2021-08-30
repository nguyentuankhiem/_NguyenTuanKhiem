﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TestBlazorNangCao.Data;

namespace TestBlazorNangCao.Pages.Products
{
    public class FavouritedProductBase : ComponentBase
    {
        private List<ProductItem> _products { get; set; } = Inventory.GetData();
        protected List<ProductItem> _favouritedProducts { get; set; } = new List<ProductItem>();

        public string SearchString { get; set; }

        protected IEnumerable<ProductItem> FavouritedProducts => _favouritedProducts.Where(x => string.IsNullOrEmpty(SearchString) || x.Title.ToLower().Contains(SearchString.ToLower()));
    

    protected override void OnInitialized()
        {
            base.OnInitialized();
            foreach(var item in _products)
            {
                if (item.Favourited == true)
                {
                    _favouritedProducts.Add(item);
                }
            }
        }

    }
}
