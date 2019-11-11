using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ViewsRenderingAnalysis.DataAccess;
using ViewsRenderingAnalysis.Models;

namespace ViewsRenderingAnalysis.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> model;
            using (var context = new ProductsContext())
            {
                model = context.Products.ToList();   
            }
            return View(model);
        }

        // GET: Products/Details/5
        public ActionResult Details(Guid id)
        {
            Product currentProduct;
            using (var context = new ProductsContext())
            {
                currentProduct = context.Products.Where(product => product.Id == id).ToList()[0];
            }
            return View(currentProduct);
        }

        // GET: Products/Create
        public async Task<ActionResult> Create(FormCollection values)
        {
            using (var context = new ProductsContext())
            {
                Product product = new Product
                {
                    Name = values["Name"]
                };

                double price, weight;
                double.TryParse(values["Price"], out price);
                double.TryParse(values["Weight"], out weight);

                product.Price = price;
                product.Weight = weight;

                context.Products.Add(product);

                await context.SaveChangesAsync();
            }
            return View();
        }

        // GET: Products/Delete/5
        public ActionResult Delete(Guid id)
        {
            Product currentProduct;
            using (var context = new ProductsContext())
            {
                currentProduct = context.Products.Where(product => product.Id == id).ToList()[0];
                
            }
            return View(currentProduct);
        }

        public async Task<ActionResult> ReallyDelete(Guid id)
        {
            Product currentProduct;
            List<Product> products;
            using (var context = new ProductsContext())
            {
                currentProduct = context.Products.Where(product => product.Id == id).ToList()[0];
                context.Products.Remove(currentProduct);
                await context.SaveChangesAsync();
                products = context.Products.ToList();
            }
            return View("Index", products);
        }
    }
}
