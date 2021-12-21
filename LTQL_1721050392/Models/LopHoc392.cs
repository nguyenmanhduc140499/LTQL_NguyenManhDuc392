using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL_1721050392.Models
{
    public class LopHoc392
    {
        [Key]
        public int MaLop { get; set; }
        public string TenLop { get; set; }
    }
}