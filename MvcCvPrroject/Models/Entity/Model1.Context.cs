﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCvPrroject.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbEntities : DbContext
    {
        public dbEntities()
            : base("name=dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAdmin> tblAdmin { get; set; }
        public virtual DbSet<tblDeneyimlerim> tblDeneyimlerim { get; set; }
        public virtual DbSet<tblEgitimlerim> tblEgitimlerim { get; set; }
        public virtual DbSet<tblHakkimda> tblHakkimda { get; set; }
        public virtual DbSet<tblHobilerim> tblHobilerim { get; set; }
        public virtual DbSet<tblIletisim> tblIletisim { get; set; }
        public virtual DbSet<tblSertifikalarim> tblSertifikalarim { get; set; }
        public virtual DbSet<tblYeteneklerim> tblYeteneklerim { get; set; }
    }
}
