using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LuoDi.Propaganda.Models
{
    public class CommonColumnModels
    {
        public int ColumnId { get; set; }

        [MaxLength(100)]
        [Required]
        [DisplayName("栏目名称")]
        public string ColumnName { get; set; }
    }
}