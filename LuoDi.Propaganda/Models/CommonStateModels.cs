using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LuoDi.Propaganda.Models
{
    public class CommonStateModels
    {
        public int CommonStateId { get; set; }

        [DisplayName("状态名")]
        public string StateName { get; set; }
    }
}