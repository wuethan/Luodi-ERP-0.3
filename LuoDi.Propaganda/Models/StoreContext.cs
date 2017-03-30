using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LuoDi.Propaganda.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<CommonInfoModels> InfoModels { get; set; }

        public DbSet<CommonColumnModels> ColumnModels { get; set; }

        public DbSet<CommonMenuModels> MenuModels { get; set; }
    }
}