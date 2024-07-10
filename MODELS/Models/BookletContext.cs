using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MODELS.Models
{
    public class BookletContext:DbContext
    {

        public BookletContext(DbContextOptions<BookletContext>booklet):base(booklet)
        { 

        }

        public DbSet<Booklet> Booklets { get; set; }
        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Booklet>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Time).IsRequired();
                // ניתן להוסיף הגדרות נוספות כפי הצורך
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.id);
                // ניתן להוסיף הגדרות נוספות כפי הצורך
            });
        }


    }
}
