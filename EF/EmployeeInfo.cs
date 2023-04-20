using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testexportfile.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeInfo")]
    public partial class EmployeeInfo
    {
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(150)]
        public string EmployeeName { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int Exprience { get; set; }
    }
}