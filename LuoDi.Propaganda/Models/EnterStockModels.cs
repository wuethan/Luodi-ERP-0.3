using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 入库单表
    /// </summary>
    public class EnterStockModels
    {
        public int EnterStockId { get; set; }

        [DisplayName("入库时间")]
        public DateTime EnterDate { get; set; }

        [DisplayName("所入仓库")]
        public int StoreHouseId { get; set; }
        public virtual StoreHouseModels StoreHouse { get; set; } 
    }
}