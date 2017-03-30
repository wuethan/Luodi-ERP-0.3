using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 规格
    /// </summary>
    public class SpecModels
    {
        public int SpecId { get; set; }

        [MaxLength(50)]
        [Required]
        [DisplayName("规格名称")]
        public string SpecName { get; set; }
    }
}