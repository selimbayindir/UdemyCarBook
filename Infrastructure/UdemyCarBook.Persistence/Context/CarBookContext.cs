using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Persistence.Context
{
    public class CarBookContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SELIMBAYINDIR\\SUPERHERO;Database=CarBookStoreApp12;User Id=dw;Password=PerUpdate28;TrustServerCertificate=True");
            /*
             * ,
             "MssqlMy": "Server=SELIM\\BYNDR;Database=NZWaLKS;User Id=sa;Password=Perkon123456;Trusted_Connection=True;TrustServerCertificate=True"
             */
        }
        DbSet<About> Abouts { get; set; }
        DbSet<Banner> Banners{ get; set; }
        DbSet<Brand>  Brands { get; set; }
        DbSet<Car> Cars { get; set; }
        DbSet<CarDescription> CarDescriptions { get; set; }
        DbSet<CarFeature> cAR { get; set; }
        DbSet<CarPricing> CarPricings { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<FooterAddress>  FooterAddresses { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Pricing> Pricings { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<SocialMedia> SocialMedias { get; set; }
        DbSet<Testimonial> Testimonials { get; set; }

    }
}
