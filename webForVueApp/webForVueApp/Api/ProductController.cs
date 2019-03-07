using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using Common;
using DataServer;
using DataServer.Domains;

namespace webForVueApp.Api
{
    public class ProductController : ApiController
    {
        private List<Product> _productService = ProductTable.AllProducts;
        public IList<Product> GetProducts()
        {
            return _productService;
        }

        //添加商品，产品上架
        public MessageResult AddProduct(Product product)
        {
            //todo 验证

            _productService.Add(product);
            return MessageResult.CreateSuccessResult("添加成功", product);
        }
        //移除商品
        public MessageResult RemoveProduct(Guid productId)
        {
            var product = _productService.SingleOrDefault(x => x.Id == productId);
            if (product == null)
            {
                return MessageResult.CreateFailResult("未找到该商品");
            }
            _productService.Remove(product);
            return MessageResult.CreateSuccessResult("产品下架成功");
        }

    }
}
