using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL_1721050392.Models
{
    public class NMDSinhVien392
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
        public ICollection<LopHoc392> LopHoc392s { get; set; }
    }
}