using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Drawing;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
          {
             new Product
             {
                Id =1,
                Name = "Camera",
                Price=2000,
                Count=50,
                Image="product-1.jpg",
                Descriptions="New,useful and in black color"
             },
              new Product
             {
                Id =2,
                Name = "Shirt",
                Price=500,
                Count=30,
                Image="product-2.jpg",
                Descriptions="New,in blue color and warm"

             },
              new Product
             {
                Id =3,
                Name = "Shoes",
                Price=600,
                Count=70,
                Image="product-4.jpg",
                Descriptions="New,in black color and comfortable"

             },
               new Product
             {
                Id =4,
                Name = "Watch",
                Price=800,
                Count=70,
                Image="product-6.jpg",
                Descriptions="New,in white color ,expensive and brand model "

             },
                new Product
             {
                Id =5,
                Name = "Cream",
                Price=300,
                Count=70,
                Image="product-8.jpg",
                Descriptions="protective from the sun"

             },

              
            new Product { Id = 1, Name = "Camera", Image = "product-1", Price =2000, Count = 50 },
            new Product { Id = 2, Name = "Shirt", Image = "product-1", Price=500,Count = 50 },
            new Product { Id = 3, Name = "Shoes", Image = "product-1",Price=600, Count = 50 },
            new Product { Id = 4, Name = "watch", Image = "product-1",Price=800, Count = 50 },
            new Product { Id = 5, Name = "Cream", Image = "product-8", Price=300,Count = 50 },
            
        };
            
          List<Catagory>Catagories=new List<Catagory>


            return View(products);
        }
        public IActionResult Shop()
        {
            return View();  
        }
		public IActionResult Detail()
		{
			return View();
		}
	}
    
}
