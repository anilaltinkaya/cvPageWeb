using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cvPageWeb.Models.Entity
{
    public class db_context : DbContext
    {
        public DbSet<TBL_SINGULAR_INFO> TBL_SINGULAR_INFO { get; set; }
        public DbSet<TBL_MEMBERS> TBL_MEMBERS { get; set; }
    }
}