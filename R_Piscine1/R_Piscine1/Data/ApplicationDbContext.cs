using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using R_Piscine1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace R_Piscine1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
             public DbSet<Client> clients { get; set; }
        public DbSet<ReservationType> ReservationTypes { get; set; }
        public DbSet<Reservation_Pescine> Reservations { get; set; }
    }

 }
    

