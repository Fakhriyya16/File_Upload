using Fiorello_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<SliderInfo>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Expert>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Product>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Title = "Flower Power",
                    Description = "Class aptent taciti sociosqu ad litora torquent per conubia\r\n                                    nostra, per",
                    Image = "blog-feature-img-1.jpg",
                    CreatedDate = DateTime.Now
                },
                new Blog
                {
                    Id = 2,
                    Title = "Local Florists",
                    Description = "Class aptent taciti sociosqu ad litora torquent per conubia\r\n                                    nostra, per",
                    Image = "blog-feature-img-3.jpg",
                    CreatedDate = DateTime.Now
                },
                new Blog
                {
                    Id = 3,
                    Title = "Flower Beauty",
                    Description = "Class aptent taciti sociosqu ad litora torquent per conubia\r\n                                    nostra, per",
                    Image = "blog-feature-img-4.jpg",
                    CreatedDate = DateTime.Now
                }
            );
        }

    }
}
