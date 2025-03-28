﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GrowEasy_API.Models;

namespace GrowEasy_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems{ get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Category>().HasData(new Category
				{
				CategoryId = 1,
				Description = "Relacionamentos"
				});

			modelBuilder.Entity<MenuItem>().HasData(new MenuItem
				{
				Id = 1,
				Name = "Como Fazer amigos e influenciar pessoas",
				Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
				Image = "https://redmangoimages.blob.core.windows.net/redmango/spring roll.jpg",
				Nota = 7.99,
				CategoryId = 1,
				IsFavorite = false
				}, new MenuItem
					{
					Id = 2,
					Name = "Idli",
					Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
					Image = "https://redmangoimages.blob.core.windows.net/redmango/idli.jpg",
					Nota = 8.99,
					CategoryId = 1,
					IsFavorite = true
					});
			}
    }
}
