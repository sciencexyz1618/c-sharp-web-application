﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace O_BEBUM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class O_BEBUMEntities : DbContext
    {
        public O_BEBUMEntities()
            : base("name=O_BEBUMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TB_ENDERE> TB_ENDERE { get; set; }
        public DbSet<TB_ITEM> TB_ITEM { get; set; }
        public DbSet<TB_ITEPED> TB_ITEPED { get; set; }
        public DbSet<TB_NOTICI> TB_NOTICI { get; set; }
        public DbSet<TB_PAGAME> TB_PAGAME { get; set; }
        public DbSet<TB_PEDIDO> TB_PEDIDO { get; set; }
        public DbSet<TB_PESSOA> TB_PESSOA { get; set; }
        public DbSet<TB_PLPAGA> TB_PLPAGA { get; set; }
    }
}
