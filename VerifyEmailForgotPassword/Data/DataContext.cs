﻿namespace VerifyEmailForgotPassword.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Server=.;Database=userdb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<User> Users => Set<User>();
    }
}
