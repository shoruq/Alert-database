using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alertproject.Tables;
using Microsoft.EntityFrameworkCore;

namespace Alertproject
{
    public class AppContext: DbContext
    {


        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Event> Events { get; set; }
        public DbSet<EventProperties> EventProps { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateFields> TemplatesFields { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // relationship between one event and many event properties 
            modelBuilder.Entity<EventProperties>(builder =>
            {
                builder.HasOne<Event>(c => c.Events)

                    .WithMany(c => c.EventsProps)
                    .HasForeignKey(c => c.EventId);

            });


            // relationship between one template and many templateFields
            modelBuilder.Entity<TemplateFields>(builder =>
            {
                builder.HasOne<Template>(c => c.Template)

                    .WithMany(c => c.TemplatesFields)
                    .HasForeignKey(c => c.TemplateId);

            });


            // relationship between one template and many events
            modelBuilder.Entity<Event>(builder =>
            {
                builder.HasOne<Template>(c => c.Templates)

                    .WithMany(c => c.Events)
                    .HasForeignKey(c => c.TemplateId);

            });

            // relationship between one event property one template property 
            modelBuilder.Entity<EventProperties>(builder =>
            {
                builder.HasOne<TemplateFields>(c => c.TempFields)

                    .WithOne(c => c.EventPropers)
                    .HasForeignKey<EventProperties>(c => c.TempfieldId).OnDelete(DeleteBehavior.Restrict);

            });


            base.OnModelCreating(modelBuilder);

        }

    }
}
