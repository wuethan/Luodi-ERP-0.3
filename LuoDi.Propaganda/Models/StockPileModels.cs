    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 库存
    /// LastLeaveDate 为NULL 时,此种商品从来没有 卖过
    /// </summary>
    public class StockPileModels
    {
        public int StockPileId { get; set; }

        [DisplayName("所在仓库")]
        public int StoreHouseId { get; set; }
        public virtual StoreHouseModels StoreHouse { get; set; }

        [DisplayName("产品")]
        public int ProductId { get; set; }
        public virtual ProductModels Product { get; set; }

        [DisplayName("此种商品第一次入库时间")]
        public DateTime FirstEnterDate { get; set; }

        [DisplayName("此种商品最后一次出库时间")]
        public DateTime LastLeaveDate { get; set; }

        [DisplayName("所存数量")]
        public int Quantity { get; set; }

        [Column(TypeName = "MONEY")]
        [DisplayName("加权价")]
        public decimal Price { get; set; }

    }
}