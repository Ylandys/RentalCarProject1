//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalCarProject1.Resources
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RentalCarProjectEntities2 : DbContext
    {

        private static RentalCarProjectEntities2 _context;

        public RentalCarProjectEntities2()
            : base("name=RentalCarProjectEntities2")
        {
        }

        public RentalCarProjectEntities2 GetContext()
        { 
            if (_context == null)
            {
                _context = new RentalCarProjectEntities2();
            }
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
