using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 出库单
    /// </summary>
    public class LeaveStockModels
    {
        public int LeaveStockId { get; set; }

        [DisplayName("出库时间")]
        public DateTime LeaveDate { get; set; }

        [DisplayName("所出仓库")]
        public int StoreHouseId { get; set; }
        public virtual StoreHouseModels StoreHouse { get; set; }

    }
}