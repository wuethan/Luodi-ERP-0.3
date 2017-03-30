using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    /// <summary>
    /// 标签
    /// </summary>
    public class TagModels
    {
        public int TagId { get; set; }

        [MaxLength(20)]
        [Required]
        [DisplayName("标签名")]
        public string TagName { get; set; }
    }
}