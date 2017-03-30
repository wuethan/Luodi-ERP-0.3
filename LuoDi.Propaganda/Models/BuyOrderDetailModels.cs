using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 进货合同明细
    /// </summary>
    public class BuyOrderDetailModels
    {
        public int BuyOrderDetailId { get; set; }

        [DisplayName("合同")]
        public int BuyOrderId { get; set; }
        public virtual BuyOrderModels BuyOrder { get; set; }

        [DisplayName("所进产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("商品数量")]
        public int Quantity { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("商品进价")]
        public decimal Price { get; set; }
    }
}