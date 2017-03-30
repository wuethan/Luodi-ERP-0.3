using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 进货单
    /// </summary>
    public class BuyModels
    {
        public int BuyId { get; set; }

        [DisplayName("进货时间")]
        public DateTime ComeDate { get; set; }
    }
}