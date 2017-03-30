using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 退库单明细
    /// </summary>
    public class BackStockDetailModels
    {
        public int BackStockDetailId { get; set; }

        [DisplayName("退库单")]
        public int BackStockId { get; set; }
        public virtual BackStockModels BackStock { get; set; }

        [DisplayName("退库商品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("退入数量")]
        public int Quantity { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("参考价格")]
        public decimal Price { get; set; }
    }
}