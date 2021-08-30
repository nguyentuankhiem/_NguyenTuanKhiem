using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestBlazorNangCao.Data
{
    public class ProductItem
    {
        [Required]
        public string ID { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [Range(1007, 2021, ErrorMessage = "The world's first novel written in the early 11th century, and this year is 2021!")]
        public int PublishedYear { get; set; }
        [Required]
        public string ImgSrc { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "Too long!")]
        public string Description { get; set; }
        [Required]
        [Range(1, 15000, ErrorMessage = "No book with 0 page :D")]
        public int PageNum { get; set; }
        [Required]
        [Range(1, 1000000000, ErrorMessage = "Charity is good but there's a book store :D")]
        public double Price { get; set; }

        public bool Favourited { get; set; }

        public ProductItem(string id, string title, string author, int year, string imgSrc, string des, int pageNum, double price, int qty)
        {
            this.ID = id;
            this.Title = title;
            this.Author = author;
            this.PublishedYear = year;
            this.ImgSrc = imgSrc;
            this.Description = des;
            this.PageNum = pageNum;
            this.Price = price;
        }

        public ProductItem()
        {

        }
    }
}
