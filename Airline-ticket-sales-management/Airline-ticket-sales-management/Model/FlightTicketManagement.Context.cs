﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airline_ticket_sales_management.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FlightTicketManagementEntities : DbContext
    {
        public FlightTicketManagementEntities()
            : base("name=FlightTicketManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AIRPORT> AIRPORTs { get; set; }
        public virtual DbSet<FLIGHT> FLIGHTs { get; set; }
        public virtual DbSet<FLIGHTDETAIL> FLIGHTDETAILs { get; set; }
        public virtual DbSet<PLANE> PLANEs { get; set; }
        public virtual DbSet<SEAT> SEATs { get; set; }
        public virtual DbSet<TICKETCLASS> TICKETCLASSes { get; set; }
        public virtual DbSet<REGULATION> REGULATIONS { get; set; }
    }
}