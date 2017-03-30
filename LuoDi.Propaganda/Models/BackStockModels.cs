using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 退库单表
    /// </summary>
    public class BackStockModels
    {
        public int BackStockId { get; set; }

        [DisplayName("退库时间")]
        public DateTime BackDate { get; set; }

        [DisplayName("所退仓库")]
        public int StoreHouseId { get; set; }
        public virtual StoreHouseModels StoreHouse { get; set; }

        [DisplayName("退库原因")]
        public string Remark { get; set; }
    }
}