using Microsoft.EntityFrameworkCore;
using System;

namespace IkProjemCore3dot1.Models
{
    public class PersonelContext : DbContext
    {
        public PersonelContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Personel> Personel41 { get; set; }
        public virtual DbSet<Unvan> Unvan { get; set; }
        public virtual DbSet<Roller> Roller { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<WebItem> WebItem { get; set; } 
        public virtual DbSet<ct_RolePrivilege> ct_RolePrivilege { get; set; }
        public virtual DbSet<ct_UserRole> ct_UserRole { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

        } 
    }
}
