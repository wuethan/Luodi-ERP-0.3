using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 退货单
    /// </summary>
    public class BackSaleModels
    {
        public int BackSaleId { get; set; }

        public DateTime BackDate { get; set; }

        [DisplayName("所退仓库")]
        public int StoreHouseId { get; set; }
        public virtual StoreHouseModels StoreHouse { get; set; }

        [DisplayName("退货原因")]
        public string Remark { get; set; }
    }
}