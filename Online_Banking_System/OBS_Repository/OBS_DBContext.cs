using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using OBS.DomainLayer.Models;

namespace OBS_Repository
{
    public class OBS_DBContext : DbContext
    {
        public OBS_DBContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Administrator> Administrator { get; set; }
        DbSet<RegistrationDetails> RegistrationDetails { get; set; }
        DbSet<SavingsAccount> SavingsAccount { get; set; }
        DbSet<TermAccount> TermAccount { get; set; }
        DbSet<Transactions> Transactions { get; set; }
        DbSet<UserDetails> UserDetails { get; set; }
        

    }
}

