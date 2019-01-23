namespace HomeWork2
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Hw2Context : DbContext
    {
        public Hw2Context()
            : base("name=Hw2Context")
        {
        }
        
        public DbSet<Gruppa> Gruppas { get; set; }
    }
}