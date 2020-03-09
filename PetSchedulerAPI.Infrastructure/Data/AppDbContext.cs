using System;
using PetSchedulerAPI.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace PetSchedulerAPI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<JobDetails> Activities { get; set; }

        public DbSet<JobType> JobTypes { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../PetSchedulerAPI.Infrastructure/ExerciseLog.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobType>().HasData(
                new JobType { Id = 1, Name = "Running", RecordType = RecordType.DurationAndDistance },
                new JobType { Id = 2, Name = "Weights", RecordType = RecordType.DurationOnly },
                new JobType { Id = 3, Name = "Walking", RecordType = RecordType.DurationAndDistance }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Test User" }
            );

            // configure some seed data in the ExerciseLog table
            modelBuilder.Entity<JobDetails>().HasData(
                new JobDetails { Id = 1, UserId = 1, JobTypeId = 1, Date = new DateTime(2019, 6, 19), Distance = 3, Duration = 30, Notes = "Hot!!!!" }
            );
        }
    }
}
