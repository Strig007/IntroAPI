using IntroAPI.Models.EF;
using IntroAPI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace IntroAPI.Controllers
{
    public class ProductController : ApiController
    {
        public List<ProductModel> Get()
        {
            EcommerceEntities db = new EcommerceEntities();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);

            var data = mapper.Map<List<ProductModel>>(db.Products.ToList());
            return data;

            /*var data = new List<ProductModel>();

            foreach(var s in db.Products)
            {
                ProductModel p = new ProductModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Price = s.Price
                };

                data.Add(p);
            }

            return data;*/
        }

        [Route("api/product/names")]
        [HttpGet]
        public List<string> ProductNames()
        {
            EcommerceEntities db = new EcommerceEntities();

            var data = (from d in db.Products
                        select d.Name).ToList();
            return data;
        }


        [Route("api/product/names/{id}")]
        [HttpGet]
        public string ProductNames(int id)
        {
            EcommerceEntities db = new EcommerceEntities();

            var data = (from d in db.Products
                        where d.Id == id
                        select d.Name).FirstOrDefault();
            return data;
        }

        public void Post(ProductModel p)
        {
            EcommerceEntities db = new EcommerceEntities();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, Product>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Product>(p);

            db.Products.Add(data);
            db.SaveChanges();
        }
    }
}
