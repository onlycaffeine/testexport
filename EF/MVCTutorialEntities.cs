using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace testexportfile.EF
{
    public partial class MVCTutorialEntities : DbContext
    {
        public MVCTutorialEntities()
            : base("name=MVCTutorialEntities")
        {
        }

        public virtual DbSet<EmployeeInfo> EmployeeInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
