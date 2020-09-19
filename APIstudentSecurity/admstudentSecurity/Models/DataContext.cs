namespace admstudentSecurity.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")    //Constructor
        {

        }

        public System.Data.Entity.DbSet<admstudentSecurity.Models.Student> Students { get; set; }
    }
}