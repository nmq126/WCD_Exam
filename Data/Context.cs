using ExamWCD.Models;
using System.Data.Entity;

namespace ExamWCD.Data
{
    public class Context: DbContext
    {
        public Context() : base("ExamWCD")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}