using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAPI.Domain.Interfaces;
using webAPI.Domain.Models;
using webAPI.Infra.Data.Context;

namespace webAPI.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private CompanyDBContext _ctx;
        public ProductRepository(CompanyDBContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _ctx.products;
        }

        public IEnumerable<ProductOrderCategory> GetProductsOrderCategory()
        {
            var prpducts = _ctx.products.AsQueryable();
            var orders =_ctx.orders.AsQueryable();
            var categories=_ctx.categories.AsQueryable();
            var result = from p in prpducts
                         join o in orders
                         on p.Id equals o.Product_Id

                        
                         select new ProductOrderCategory()
                         {
                             Product_Quantity = orders.Where(x => x.Product_Id == p.Id).Select(x => x.Product_Quantity).Sum(),
                             Id = p.Id,
                             Name = p.Name
                             ,
                             
                             Category = categories.Where(x => (x.Id.ToString()) ==p.Category_Id ).Select(x => x.Category).First()
                         };
            return result;

                             //            var cnn = (SqlConnection)_ctx.Database.GetDbConnection();
                             //            cnn.Open();
                             //            var cmd = new SqlCommand(@"

                         //select p.Id,p.Name,c.Category ,sum(o.Product_Quantity) over (partition by p.Id)
                         //from products as p
                         //join orders as o on p.Id=o.Product_Id
                         //join categories as c on c.Id=p.Category_Id

                         //order by sum(o.Product_Quantity) over (partition by p.Id) desc

                         //", cnn);
                         //            var rdr = cmd.ExecuteReader(CommandBehavior.Default);
                         //            IEnumerable<ProductOrderCategory> productOrderCategories = new List<ProductOrderCategory>();
                         //            while (rdr.HasRows)
                         //            {
                         //                productOrderCategories.Append(new ProductOrderCategory() { Id = (int)rdr[0], Name = (string)rdr[1], Category = (string)rdr[2], Product_Quantity = (int)rdr[3] });
                         //            }
                         //  return productOrderCategories;
        }
    }
}
