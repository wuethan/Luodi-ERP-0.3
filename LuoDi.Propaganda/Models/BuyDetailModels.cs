using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 进货单明细
    /// BuyOrderId 为 NULL 时, 为现金进货
    /// </summary>
    public class BuyDetailModels
    {
        public int BuyDetailId { get; set; }

        [DisplayName("进货单")]
        public int BuyId { get; set; }
        public virtual BuyModels Buy { get; set; }

        [DisplayName("进货产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("进货合同")]
        public int BuyOrderId { get; set; }
        public virtual BuyOrderModels BuyOrder { get; set; }

        [DisplayName("进货数量")]
        public int Quantity { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("进货价格")]
        public decimal Price { get; set; }
    }
}