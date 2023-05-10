using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TiredWebAPI.Models;

namespace TiredWebAPI.Data
{
    public class TiredWebAPIContext : DbContext
    {
        public TiredWebAPIContext (DbContextOptions<TiredWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<TiredWebAPI.Models.BankAccount> BankAccount { get; set; } = default!;
        public DbSet<TiredWebAPI.Models.Customer> Customer { get; set; } = default!;
    }
}
