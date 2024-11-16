using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=USER\\SQLEXPRESS;initial Catalog=MyPortfolioDb;integrated Security=true;TrustServerCertificate=True");
        }

        // C#'daki About ile SQL'deki bir tablo ismi olan Abouts "s" takısı ile karışmayacak.
        /* 
         * Bu kısımda veritabanına dahil etmek istediğimiz tüm "Class"ları ekliyoruz.
         * Entities kısmında oluşturulan tüm "tablolar (class)" ve "kolonları (propertyler)" burada classları yazarak tablolarını oluşturmuş oluyoruz.
        */ 
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoListS { get; set; }
    }
}
