﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskTool.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
        using System.ComponentModel.DataAnnotations.Schema;
    public partial class TaskDbEntities1 : DbContext
    {
        public TaskDbEntities1()
            : base("name=TaskDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>().Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tasks> Tasks { get; set; }
    }
}