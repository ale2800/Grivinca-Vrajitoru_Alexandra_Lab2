using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grivinca_Vrajitoru_Alexandra_Lab2.Models;

namespace Grivinca_Vrajitoru_Alexandra_Lab2.Data
{
    public class Grivinca_Vrajitoru_Alexandra_Lab2Context : DbContext
    {
        public Grivinca_Vrajitoru_Alexandra_Lab2Context (DbContextOptions<Grivinca_Vrajitoru_Alexandra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Grivinca_Vrajitoru_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Grivinca_Vrajitoru_Alexandra_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Grivinca_Vrajitoru_Alexandra_Lab2.Models.Author> Author { get; set; }

        public DbSet<Grivinca_Vrajitoru_Alexandra_Lab2.Models.Category> Category { get; set; }

        public DbSet<Grivinca_Vrajitoru_Alexandra_Lab2.Models.Member> Member { get; set; }

        public DbSet<Grivinca_Vrajitoru_Alexandra_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
