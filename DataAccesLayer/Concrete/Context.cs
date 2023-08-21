using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context:IdentityDbContext
	{
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server = DESKTOP-NIJ35NE\\SQL2022; database = DbCafeWebSite; integrated security = true; TrustServerCertificate = True");
		}

		public DbSet<About> Abouts { get; set; }
		public DbSet<CategoryMenu> CategoryMenus { get; set; }
		public DbSet<Chef> Chefs { get; set; }
		public DbSet<ContactInfo> ContactInfos { get; set; }
		public DbSet<GalleryItem> GalleryItems { get; set; }

		public DbSet<MenuItem> MenuItems { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<SpecialMealOffer> SpecialMealOffers { get; set; }
      
    }
}
