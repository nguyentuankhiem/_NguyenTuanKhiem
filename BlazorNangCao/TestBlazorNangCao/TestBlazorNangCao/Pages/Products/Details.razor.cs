using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using TestBlazorNangCao.Data;
using Microsoft.AspNetCore.Components;

namespace TestBlazorNangCao.Pages.Products
{
    public class DetailsBase : ComponentBase
    {
        [Parameter]
        public string IDPath { get; set; }

        protected List<ProductItem> _products { get; set; } = Inventory.GetData();

        protected ProductItem CurrentProd { get; set; } = new ProductItem();

        public bool EditMode { get; set; }

        public string DeleteButtonString { get; set; }

        public string DeleteButtonStyle { get; set; }

        public void FavouritedButtonClicked()
        {
            if (CurrentProd.Favourited)
            {
                DeleteButtonString = "Favourited";
                DeleteButtonStyle = "btn-danger";
            }
            else
            {
                DeleteButtonString = "Add to favourite";
                DeleteButtonStyle = "btn-outline-danger";
            }
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            CurrentProd = _products.Find(x => x.ID == this.IDPath);
            FavouritedButtonClicked();
        }
        public void _save() => Inventory.SaveData(_products);

        public void SaveData()
        {
            CurrentProd.Favourited = !CurrentProd.Favourited;
            _save();
            FavouritedButtonClicked();
        }

        public void ToggleEdit()
        {
            EditMode = !EditMode;
        }

        public void CancelEdit()
        {
            EditMode = false;
        }

        public void UpdateEdit(ProductItem item)
        {
            EditMode = false;
            CurrentProd = item;
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].ID == item.ID)
                {
                    _products[i] = item;
                }
            }
            SaveData();
        }
    }
}
