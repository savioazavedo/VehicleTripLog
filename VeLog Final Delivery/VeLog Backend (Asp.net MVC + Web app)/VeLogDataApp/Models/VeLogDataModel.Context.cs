﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeLogDataApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VelogDataContext : DbContext
    {
        public VelogDataContext()
            : base("name=VelogDataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<VeLogData> VeLogDatas { get; set; }
        public virtual DbSet<tblvelogUser> tblvelogUsers { get; set; }
        public virtual DbSet<tblvelogCampu> tblvelogCampus { get; set; }
        public virtual DbSet<tblvelogCours> tblvelogCourses { get; set; }
        public virtual DbSet<tblvelogDivision> tblvelogDivisions { get; set; }
        public virtual DbSet<tblVelogCar> tblVelogCars { get; set; }
    }
}
