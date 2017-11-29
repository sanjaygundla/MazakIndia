using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WcfService
{
    public class ToolContext :DbContext
    {
        public DbSet<Tool_Details> Tool_detail { get; set; }
        public ToolContext(): base("DB_con_str")
        {

        }
    }
}