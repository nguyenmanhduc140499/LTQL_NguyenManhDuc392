using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LTQL_1721050392.Models
{
    public class DataDBContext : DbContext
    {
        public DataDBContext() : base("DataDBContext")
        {
        }
        public DbSet<LopHoc392> LopHoc392s { get; set; }

        public System.Data.Entity.DbSet<LTQL_1721050392.Models.NMDSinhVien392> NMDSinhVien392 { get; set; }
    }
}