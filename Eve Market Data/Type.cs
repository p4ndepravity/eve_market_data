using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Eve_Market_Data
{
    public class Type
    {
        public int TypeId { get; set; }
        public int TypeIdInGame { get; set; }
        public string TypeName { get; set; }
        public double TypeMargin { get; set; }
    }

    public class TypeContext : DbContext
    {
        public DbSet<Type> Types { get; set; }
    }
}
