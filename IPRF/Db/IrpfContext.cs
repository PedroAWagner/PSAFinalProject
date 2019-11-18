using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPRF.Db
{
    public class IrpfContext: DbContext
    {
            //public static readonly LoggerFactory FabricaLogger = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });
            public DbSet<User> Users { get; set; }
            public DbSet<Deduction> Deductions { get; set; }
            public DbSet<Declaration> Declarations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseLoggerFactory(FabricaLogger)
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DBIrpf;Trusted_Connection=True;");
            }
    }
}
