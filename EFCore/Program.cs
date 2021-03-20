using EFCore.Models;
using System;

namespace EFCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UpdateProduct(2);

            //DeleteProduct(2);
            //InsertProduct();
            //GetProducts();
        }

        public static void InsertProduct()
        {
            using (EFContext db = new EFContext())
            {
                Product product = new Product();
                product.Name = "Pen Drive4";
                db.Add(product);
                db.SaveChanges();

                Product product2 = new Product();
                product2.Name = "Pen Drive5";
                db.Add(product2);
                db.SaveChanges();
            }
        }

        public static void GetProducts()
        {
            using var db = new EFContext();
            var products = db.Products;
            foreach (var product in products)
            {
                Console.WriteLine(product.Id + " " + product.Name);
            }
        }

        public static void UpdateProduct(int id)
        {
            using (var db = new EFContext())
            {
                var product = db.Products.Find(id);
                db.Update(product).Entity.Name = "updated2";
                db.SaveChanges();
            }
        }

        public static void DeleteProduct(int id)
        {
            using (var db = new EFContext())
            {
                var product = db.Products.Find(id);
                db.Remove(product);
                db.SaveChanges();
            }
        }
    }
}