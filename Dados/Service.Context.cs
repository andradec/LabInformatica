﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dados
{
    using Entidade;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class XarlisDarwinEntities : DbContext
    {
        public XarlisDarwinEntities()
            : base("name=XarlisDarwinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Laboratorio> laboratorios { get; set; }
    }
}