namespace Askerlik.Core
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AskerlikDbEntities : DbContext
    {
        
        public AskerlikDbEntities()
            : base("name=AskerlikDbEntities")
        {
        }

       
        public virtual DbSet<Kisla> Kisla{ get; set; }
        public virtual DbSet<Asker> Asker { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}