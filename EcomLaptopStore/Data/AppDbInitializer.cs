using EcomLaptopStore.Data;
using LaptopDirect.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopDirect.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Products
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = " product 1",
                            Description = "This is Description for first product",
                            Price = 6999.99,
                            Specification = "This is specification for first product",
                            ImageURL = "http://dotnethow.net/images/laptops/laptop-1.jpeg",
                            LaptopBrand = LaptopBrand.Acer
                        },
                        new Product()
                        {
                            Name = " product 2",
                            Description = "This is Description for second product",
                            Price = 6999.99,
                            Specification = "This is specification for second product",
                            ImageURL = "http://dotnethow.net/images/laptops/laptop-2.jpeg",
                            LaptopBrand = LaptopBrand.Apple
                        },
                        new Product()
                        {
                            Name = " product 3",
                            Description = "This is Description for 3rd product",
                            Price = 6999.99,
                            Specification = "This is specification for 3rd product",
                            ImageURL = "http://dotnethow.net/images/laptops/laptop-3.jpeg",
                            LaptopBrand = LaptopBrand.Hp
                        },
                        new Product()
                        {
                            Name = " product 4",
                            Description = "This is Description for 4th product",
                            Price = 6999.99,
                            Specification = "This is specification for 4th product",
                            ImageURL = "http://dotnethow.net/images/laptops/laptop-4.jpeg",
                            LaptopBrand = LaptopBrand.Lenovo
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
