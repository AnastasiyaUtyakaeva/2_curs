﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace telCom_2._1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class telComEntities : DbContext
    {
        public telComEntities()
            : base("name=telComEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Balance1> Balance1 { get; set; }
        public virtual DbSet<Call1> Call1 { get; set; }
        public virtual DbSet<City1> City1 { get; set; }
        public virtual DbSet<Client1> Client1 { get; set; }
        public virtual DbSet<ElementsTariff1> ElementsTariff1 { get; set; }
        public virtual DbSet<HistoryTariff1> HistoryTariff1 { get; set; }
        public virtual DbSet<LegalEntity1> LegalEntity1 { get; set; }
        public virtual DbSet<Person1> Person1 { get; set; }
        public virtual DbSet<Tariff1> Tariff1 { get; set; }
        public virtual DbSet<Worker1> Worker1 { get; set; }
    }
}
