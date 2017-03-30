using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 计量单位
    /// </summary>
    public class UnitModels
    {
        public int UnitId { get; set; }

        [MaxLength(50)]
        [Required]
        [DisplayName("计量单位名称")]
        public string UnitName { get; set; }

        [MaxLength(50)]
        [Required]
        [DisplayName("计量单位中文符号")]
        public string EngLishSymbol { get; set; }

        [MaxLength(50)]
        [Required]
        [DisplayName("计量单位英文符号")]
        public string ChineseSymbol { get; set; }

        [DisplayName("描述")]
        public string Remark { get; set; }
    }
}