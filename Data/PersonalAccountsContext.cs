using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalAccounts.Models;

namespace PersonalAccounts.Data
{
    public class PersonalAccountsContext : DbContext
    {
        public PersonalAccountsContext (DbContextOptions<PersonalAccountsContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalAccounts.Models.Category> Category { get; set; }

        public DbSet<PersonalAccounts.Models.Transaction> Transaction { get; set; }
    }
}
