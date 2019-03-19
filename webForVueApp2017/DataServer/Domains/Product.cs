using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer.Domains
{
    public class Product : EntityBase
    {
        /// <summary>
        /// 商品标题,品牌、型号等
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品介绍图片
        /// </summary>
        public IList<string> ImageUrls { get; set; }
        public string ImageUrlsStr { get; set; }
        public float Prize { get; set; }
        /// <summary>
        /// 促销价
        /// </summary>
        public decimal PromotionPrice { get; set; }
        /// <summary>
        /// 详情介绍，材料、颜色选择、尺码等
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 商品或发货地址：福建福州
        /// </summary>
        public string Address { get; set; }
    }
}
