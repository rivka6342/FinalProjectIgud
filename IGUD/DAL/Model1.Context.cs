﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IgudDBEntities : DbContext
    {
        public IgudDBEntities()
            : base("name=IgudDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Community> Communities { get; set; }
        public virtual DbSet<Guy> Guys { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<sector> sectors { get; set; }
        public virtual DbSet<SignActivity> SignActivities { get; set; }
        public virtual DbSet<SignStudyHour> SignStudyHours { get; set; }
        public virtual DbSet<StudyHour> StudyHours { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Winner> Winners { get; set; }
    }
}
