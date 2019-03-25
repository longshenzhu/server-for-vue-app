using Common;
using DataServer;
using DataServer.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webForVueApp2017.Api
{
    public class ProductController : ApiController
    {
        private List<Product> _productService = ProductTable.AllProducts;

        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IList<Product> GetProducts()
        {
            return _productService;
        }

        /// <summary>
        /// 获取商品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Product GetProduct(Guid id)
        {
            return _productService.SingleOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// 添加商品，产品上架
        /// </summary>
        /// <param name="product">商品信息</param>
        /// <returns></returns>
        [HttpPost]
        public MessageResult AddProduct(Product product)
        {
            //todo 验证
            product.Id = Guid.NewGuid();
            _productService.Add(product);
            return MessageResult.CreateSuccessResult("添加成功", product);
        }

        /// <summary>
        /// 移除商品
        /// </summary>
        /// <param name="productId">商品Id</param>
        /// <returns></returns>
        [HttpPost]
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
